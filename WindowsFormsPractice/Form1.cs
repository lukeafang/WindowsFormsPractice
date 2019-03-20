using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        //define delegate 
        public delegate void MyDelegate(string name);

        public delegate void SendValueDelegate(string pValue);
        public event SendValueDelegate SendValueCallback;

        public Form1()
        {
            InitializeComponent();

            //initial UI value
            InitialUI();
        }

        private void InitialUI()
        {
            //tab1 
            //sheet1
            txtSheet1Name.Text = "Tom";
            radioSheet1Male.Checked = true;
            cbSheet1AgeRange.SelectedIndex = 1;
            chkSheet1CPlus.Checked = true;
            chkSheet1CSharp.Checked = true;
            dateTimePickerSheet1.Value = DateTime.Today;

            //tab2
            radioButtonDatabaseMySql.Checked = true;
        }

        private void btnSheet1Submit_Click(object sender, EventArgs e)
        {
            //get value from items
            //name
            string name = txtSheet1Name.Text;
            //age
            string ageRange = "";
            ageRange = cbSheet1AgeRange.SelectedItem.ToString();
            //gender
            string gender = "Male";
            if (radioSheet1Female.Checked)
            {
                gender = "Female";
            }
            string skills = "";
            if (chkSheet1CPlus.Checked) { skills += "C++, "; }
            if (chkSheet1CSharp.Checked) { skills += "C#, "; }
            if (chkSheet1Java.Checked) { skills += "Java, "; }

            string submitDate = "";
            submitDate = dateTimePickerSheet1.Value.ToString();

            string message = "";
            message = String.Format(" name:{0}\n ageRange:{1}\n gender:{2}\n skills:{3}\n date:{4}\n",name,ageRange,gender,skills,submitDate);
            MessageBox.Show(message);

        }

        private void btnSheet2Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Load Image File";
            theDialog.Filter = "PNG files|*.png";
            //theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = theDialog.FileName.ToString();
                pictureBoxSheet2.Image = Image.FromFile(filePath);
                pictureBoxSheet2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void listBoxSheet3Fruit_DoubleClick(object sender, EventArgs e)
        {
            string text = listBoxSheet3Fruit.GetItemText(listBoxSheet3Fruit.SelectedItem);
            MessageBox.Show(text);
        }

        private void dbConnectBtn_Click(object sender, EventArgs e)
        {
            DBConnection dbConnect;
            if (radioButtonDatabaseMySql.Checked)
            {
                dbConnect = new DBConnection_MySQL();
            }
            else
            {
                dbConnect = new DBConnection_Azure_MsSQL();
            }

            //test connection
            if (dbConnect.Connect())
            {
                //disconnect
                if (dbConnect.Disconnect())
                {
                    MessageBox.Show("Connect Test Success.");
                }
                else
                {
                    MessageBox.Show(dbConnect.getErrorString());
                }
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
            }

        }

        private void dbConnectCreateTableBtn_Click(object sender, EventArgs e)
        {
            //test create table "menu"
            DBConnection dbConnect;
            string queryString = "";
            if (radioButtonDatabaseMySql.Checked)
            {
                dbConnect = new DBConnection_MySQL();
                queryString = String.Format("create table menu (id INTEGER AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), type VARCHAR(20), price VARCHAR(10), modifiedDate datetime);");
            }
            else
            {
                dbConnect = new DBConnection_Azure_MsSQL();
                queryString = String.Format("create table menu (id INT IDENTITY(1,1) PRIMARY KEY, name VARCHAR(30), type VARCHAR(20), price VARCHAR(10), modifiedDate datetime);");
            }


            //queryString = $"create table if not exists menu (id INTEGER AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), type VARCHAR(20), price VARCHAR(10), modifiedDate datetime);";

            dbConnect.executeQuery(queryString);
            if (dbConnect.IsSuccess())
            {
                MessageBox.Show("Table Created");
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
            }
        }

        private void dbConnectDropTableBtn_Click(object sender, EventArgs e)
        {
            //test drop table "menu"
            DBConnection dbConnect;
            if (radioButtonDatabaseMySql.Checked)
            {
                dbConnect = new DBConnection_MySQL();
            }
            else
            {
                dbConnect = new DBConnection_Azure_MsSQL();
            }


            string queryString = "";
            //queryString = $"drop table if exists menu;";
            queryString = "drop table menu;";
            dbConnect.executeQuery(queryString);
            if (dbConnect.IsSuccess())
            {
                MessageBox.Show("Table Droped");
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
            }
        }

        private void dbConnectInsertBtn_Click(object sender, EventArgs e)
        {
            //test insert data into table "menu"
            DBConnection dbConnect;
            string queryString1 = "";
            string queryString2 = "";
            if (radioButtonDatabaseMySql.Checked)
            {
                dbConnect = new DBConnection_MySQL();
                queryString1 = "INSERT INTO menu (name, type, price, modifiedDate) VALUES('Beef Noodle', 'Noodle', '8.99', NOW());";
                queryString2 = "INSERT INTO menu(name, type, price, modifiedDate) VALUES('Fired Chicken Rice', 'Rice', '7.99', NOW());";
            }
            else
            {
                dbConnect = new DBConnection_Azure_MsSQL();
                queryString1 = "INSERT INTO menu (name, type, price, modifiedDate) VALUES('Beef Noodle', 'Noodle', '8.99', GETDATE());";
                queryString2 = "INSERT INTO menu(name, type, price, modifiedDate) VALUES('Fired Chicken Rice', 'Rice', '7.99', GETDATE());";
            }


            dbConnect.executeQuery(queryString1);
            if (dbConnect.IsSuccess())
            {
                MessageBox.Show("Inserted first record");
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
                return;
            }

            dbConnect.executeQuery(queryString2);
            if (dbConnect.IsSuccess())
            {
                MessageBox.Show("Inserted second record");
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
                return;
            }

        }

        private void dbConnectSelectBtn_Click(object sender, EventArgs e)
        {
            DBConnection dbConnect;
            if (radioButtonDatabaseMySql.Checked)
            {
                dbConnect = new DBConnection_MySQL();
            }
            else
            {
                dbConnect = new DBConnection_Azure_MsSQL();
            }


            List<string> resultList = dbConnect.SelectTest();

            string finalResult = "";
            foreach (string result in resultList)
            {
                finalResult += result + '\n';
            }
            MessageBox.Show(finalResult);
        }

        private void btnSheet4LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Txt File";
            theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = theDialog.FileName.ToString();
                if (File.Exists(filePath))
                {
                    textBoxSheet4LoadFile.Text = "";

                    String lines;
                    lines = File.ReadAllText(filePath);
                    textBoxSheet4LoadFile.AppendText(lines);
                    /*
                    //load file context
                    String[] lines = File.ReadAllLines(filePath);

                    foreach(string line in lines)
                    {
                        textBoxSheet4LoadFile.AppendText(line);
                        textBoxSheet4LoadFile.AppendText("\r\n");
                    }*/
                }
                else
                {
                    MessageBox.Show("File not exist.");
                }
            }
        }

        private void btnSheet4SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Txt File|*.txt";
            saveFileDialog1.Title = "Save an txt File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName.ToString();
                if (File.Exists(filePath))
                {
                    // MessageBox.Show("File exist. Overwrite it.");
                }
                string context = textBoxSheet4LoadFile.Text;
                MessageBox.Show(context);
                File.WriteAllText(filePath, context);

            }
        }

        private void btnSheet4LoadFileStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Txt File";
            theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = theDialog.FileName.ToString();
                if (File.Exists(filePath))
                {
                    textBoxSheet4LoadFile.Text = "";
                    //using stream
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        ArrayList lineList = new ArrayList();
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            lineList.Add(s);
                            textBoxSheet4LoadFile.AppendText(s + "\n");
                        }

                        int nLines = lineList.Count;
                        MessageBox.Show(String.Format("{0} line read.",nLines));
                    }
                }
                else
                {
                    MessageBox.Show("File not exist.");
                }
            }
        }

        private void btnSheet4SaveFileStream_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Txt File|*.txt";
            saveFileDialog1.Title = "Save an txt File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName.ToString();
                if (File.Exists(filePath))
                {
                    // MessageBox.Show("File exist. Overwrite it.");
                }
                //using (StreamWriter sr = File.AppendText(filePath))
                using (StreamWriter sr = new StreamWriter(filePath, false))//overwrite
                {
                    String context = textBoxSheet4LoadFile.Text;
                    string[] lines = context.Split('\n');
                    foreach (string line in lines)
                    {
                        if (line.Length == 0) { continue; }
                        sr.WriteLine(line);
                    }
                    sr.Close();
                }

                MessageBox.Show("Saved");


            }
        }

        private void btnSheet5SaveObject_Click(object sender, EventArgs e)
        {
            //get working path.
            string workPath = Application.StartupPath;
            string filePath = workPath + @"\test.obj";

            User obj = new User(666, "testUser");

            //create the file stream
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //serizlize the object
            formatter.Serialize(stream, obj);
            stream.Close();

            //
            MessageBox.Show("User Object saved.");
        }

        private void btnSheet5LoadObject_Click(object sender, EventArgs e)
        {
            //get working path.
            string workPath = Application.StartupPath;
            string filePath = workPath + @"\test.obj";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            User objnew = (User)formatter.Deserialize(stream);

            string finalStr = "";
            finalStr = String.Format("ID: {0}, Name: {1}.",objnew.ID, objnew.Name);
            MessageBox.Show(finalStr);

        }

        private void btnSheet6TestNullableValue_Click(object sender, EventArgs e)
        {
            //define a nullable value
            //Nullable<int> someNullValue = null;
            int? someNullValue = null;

            //check value is null or not
            if (someNullValue.HasValue)
            {
                MessageBox.Show("value is not null");
            }

            if (someNullValue == null)
            {
                MessageBox.Show("Value is null.");
            }

            //assign a nullable to variable, if nullable value is null, assign value as 666
            int someIntValue = someNullValue ?? 666;
            MessageBox.Show("Assigned value is: " + someIntValue);


        }

        private void btnSheet6CreateArray_Click(object sender, EventArgs e)
        {
            //generate array with repeat value   
            // creates bool array of size 10 with default value "true"
            bool[] boolArray = Enumerable.Repeat(true, 10).ToArray();
            Console.WriteLine(boolArray[0]);

            // creates int array of size 10 with default value "555"
            int[] intArray = Enumerable.Repeat(555, 10).ToArray();
            Console.WriteLine(intArray[0]);

            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            Console.WriteLine(marks[3]);
        }

        private void btnSheet6IsAsCompare_Click(object sender, EventArgs e)
        {
            //is test
            Person o1 = new Person();
            User o2 = new User();

            bool bValue = false;
            bValue = o1 is Object;
            Console.WriteLine("o1 is Object: " + bValue);

            bValue = o1 is User;
            Console.WriteLine("o1 is User: " + bValue);

            bValue = o2 is Person;
            Console.WriteLine("o2 is Person: " + bValue);

            bValue = o2 is User;
            Console.WriteLine("o2 is User: " + bValue);

            //as test
            Object[] o = new object[4];

            o[0] = new Person();
            o[1] = new User();
            o[2] = "Hello";
            o[3] = 555;

            for (int i = 0; i < o.Length; i++)
            {
                //using as operator
                Person p1 = o[i] as Person;
                Console.WriteLine("{0}", i);

                //as operator success
                if (p1 != null)
                {
                    Console.WriteLine("It's a person.");
                }
                else
                {
                    Console.WriteLine("It's not a person");
                }
            }


        }

        private void btnDelegateTest_Click(object sender, EventArgs e)
        {
            //create a delegate object
            MyDelegate delegateObject_1 = new MyDelegate(customShow1);
            delegateObject_1("hello");

            //create other delegate object
            MyDelegate delegateOBject_2 = customShow1;

            //add new method into delegate object
            delegateOBject_2 += new MyDelegate(customShow2);

            //either way to call function
            //delegateOBject_2.Invoke("Yo. Invoke.");
            delegateOBject_2("Bye");

            //Anonymous method
            MyDelegate delegateObject_3 = delegate (string m)
            {
                Console.WriteLine("Show function 3: {0}", m);
            };
            delegateObject_3("anonymous method");

            //try callback
            Console.WriteLine("Try callback function");
            DelCallbackTest t1 = new DelCallbackTest();

            //try lambda
            Console.WriteLine("Try Lambda");
            MyDelegate del_lambda = (string s) =>
            {
                Console.WriteLine("Lambda: " + s);
            };
            del_lambda("Hello!");
        }

        public static void customShow1(string value)
        {
            Console.WriteLine("Custom Show 1 : {0}", value);
        }

        public static void customShow2(string value)
        {
            Console.WriteLine("Custom Show 2 : {0}", value);
        }



        private void btnSheet7OpenWindow_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //send value to new window even
            this.SendValueCallback += new SendValueDelegate(f2.ReceiveValueCallbackFunc);
            //invoke function
            this.SendValueCallback(txtSheet7ID.Text);

            //get value from new window event
            f2.ReturnValueCallback += new Form2.ReturnValueDelegate(this.updateUIValueSheet7);
            f2.ShowDialog();
        }

        private void updateUIValueSheet7(string name, string password)
        {
            txtSheet7Name.Text = name;
            txtSheet7Password.Text = password;
        }

        private void btnSheet6Indexer_Click(object sender, EventArgs e)
        {
            DemoIndexer d = new DemoIndexer();
            for (int i = 0; i < 10; i++)
            {
                d[i] = String.Format("Name_{0}", i);
            }

            Console.WriteLine(d[2]);
            Console.WriteLine(d[3]);
            Console.WriteLine(d[13]);

        }

        private void btnSheet8SingletonTest_Click(object sender, EventArgs e)
        {
            Singleton.Instance.WriteNumber();

            int countNumber = Singleton.Instance.GetNumber();
            MessageBox.Show("Count Number : " + countNumber);
        }

        private void btnSheet8OutTest_Click(object sender, EventArgs e)
        {
            CalculatorEngine calculator = new CalculatorEngine();
            int x = 1;
            Console.WriteLine("Before run method. x = " + x);
            calculator.getIntValue(out x);
            Console.WriteLine("After run method. x = " + x);

        }

        private void btnSheet8RefTest_Click(object sender, EventArgs e)
        {
            CalculatorEngine calculator = new CalculatorEngine();
            int x = 1, y = 2;
            Console.WriteLine(String.Format("(swap Without Ref) Before run method. x = {0}, y = {1}", x, y));
            calculator.swapWithoutRef(x, y);
            Console.WriteLine(String.Format("(swap Without Ref) After run method. x = {0}, y = {1}", x, y));

            x = 1;
            y = 2;
            Console.WriteLine(String.Format("(swap With Ref) Before run method. x = {0}, y = {1}", x, y));
            calculator.swapWithRef(ref x, ref y);
            Console.WriteLine(String.Format("(swap With Ref) After run method. x = {0}, y = {1}", x, y));
        }

        private void btnSheet8ParamTest_Click(object sender, EventArgs e)
        {
            CalculatorEngine calculator = new CalculatorEngine();
            int sum = calculator.AddElements(512, 720, 250, 567, 889);
            MessageBox.Show("Sum = " + sum);
        }

        private void btnOperatorTest_Click(object sender, EventArgs e)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();

            double volume = 0.0;

            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            //Box2.setLength(12.0);
            //Box2.setBreadth(13.0);
            //Box2.setHeight(10.0);

            Box2.setLength(6.0);
            Box2.setBreadth(7.0);
            Box2.setHeight(5.0);

            Console.WriteLine("Box1： {0}", Box1.ToString());
            Console.WriteLine("Box2： {0}", Box2.ToString());

            //add operator
            Box3 = Box1 + Box2;
            Console.WriteLine("Box3： {0}", Box3.ToString());

            //compare operator
            if (Box1 == Box2) Console.WriteLine("Box1 == Box2");
            else Console.WriteLine("Box1 != Box2");

            string input = "1851 1999 1950 1905 2003";
            string pattern = @"(?<=19)\d{2}\b";

            foreach (Match match in Regex.Matches(input, pattern))
                Console.WriteLine(match.Value);
        }

        private void getRowDataFromExcel(int rowIndex, Excel.Range range, out string name, out string type, out string price, out string date)
        {
            name = "";
            type = "";
            price = "";
            date = "";

            int index = 1;
            if (range.Cells[rowIndex, index] != null)
            {
                name = Convert.ToString(range.Cells[rowIndex, index++].Value2);
            }
            if (range.Cells[rowIndex, index] != null)
            {
                type = Convert.ToString(range.Cells[rowIndex, index++].Value2);
            }
            if (range.Cells[rowIndex, index] != null)
            {
                price = Convert.ToString(range.Cells[rowIndex, index++].Value2);
            }
            if (range.Cells[rowIndex, index] != null)
            {
                date = Convert.ToString(range.Cells[rowIndex, index++].Value2);
            }

        }

        private void btnExcelLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Load Excel File";
            theDialog.Filter = "xlsx files|*.xlsx";
            //theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = theDialog.FileName.ToString();


                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);//get first sheet

                range = xlWorkSheet.UsedRange;

                int n_row = range.Rows.Count;
                int n_col = range.Columns.Count;

                DataTable dt = (DataTable)dataGridViewExcelSheet.DataSource;
                string name, type, price, date;
                for (int i = 2; i <= n_row; i++)
                {
                    getRowDataFromExcel(i, range, out name, out type, out price, out date);
                    //string outputString = $"name:{name}, type:{type}, price:{price}, date:{date}";
                    //MessageBox.Show(outputString);
                    dt.Rows.Add(name, type, price, date);
                   
                }

                xlWorkBook.Close(true, null, null);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Enter");

            //dataGridViewExcelSheet.Columns.Clear();
            //dataGridViewExcelSheet.Refresh();

            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[4] { new DataColumn("name", typeof(string)), new DataColumn("type", typeof(string)), new DataColumn("price", typeof(string)), new DataColumn("ModifiedDate", typeof(string)) });
            dataGridViewExcelSheet.DataSource = dataTable;
         
        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            //save file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Load Excel File";
            saveFileDialog1.Filter = "xlsx files|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName.ToString();

                //get data from datagrid
                DataTable dt = (DataTable)dataGridViewExcelSheet.DataSource;

                int nRow = dt.Rows.Count;
                int nCol = dt.Columns.Count;

                //get column names
                string[] columnNameList = new string[nCol];
                for(int i = 0; i < nCol; i++)
                {
                    columnNameList[i] = dataGridViewExcelSheet.Columns[i].Name;
                }

                //get data from each row
                for(int i = 0; i < nRow; i++)
                {
                    string value = dataGridViewExcelSheet.Rows[i].Cells[0].Value.ToString();

                }

                //create new excel file

                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }
                //disable display alert.
                xlApp.DisplayAlerts = false;

                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //write columnd
                int rowIndex = 1;
                int colIndex = 1;
                for(int j=0; j< nCol; j++)
                {
                    colIndex = j + 1;
                    xlWorkSheet.Cells[1, colIndex] = dataGridViewExcelSheet.Columns[j].Name;
                }

                //write each row
                for(int i = 0; i < nRow; i++)
                {
                    rowIndex = i + 2;//skip column name
                    for (int j = 0; j < nCol; j++)
                    {
                        colIndex = j + 1;
                        string value = dataGridViewExcelSheet.Rows[i].Cells[j].Value.ToString();
                        xlWorkSheet.Cells[rowIndex, colIndex] = value;
                    }
                    
                }

                xlWorkBook.SaveAs(filePath, misValue, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Excel file saved");
            }
        }
    }
}
