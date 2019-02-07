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

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
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
            message = $" name:{name}\n ageRange:{ageRange}\n gender:{gender}\n skills:{skills}\n date:{submitDate}\n";
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
            DBConnect dbConnect = new DBConnect();

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
            DBConnect dbConnect = new DBConnect();
            string queryString = "";
            //queryString = $"create table if not exists menu (id INTEGER AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), type VARCHAR(20), price VARCHAR(10), modifiedDate datetime);";
            queryString = $"create table menu (id INTEGER AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), type VARCHAR(20), price VARCHAR(10), modifiedDate datetime);";
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
            DBConnect dbConnect = new DBConnect();
            string queryString = "";
            //queryString = $"drop table if exists menu;";
            queryString = $"drop table menu;";
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
            DBConnect dbConnect = new DBConnect();
            string queryString = "";
            queryString = $"INSERT INTO menu (name, type, price, modifiedDate) VALUES('Beef Noodle', 'Noodle', '8.99', NOW());";
            dbConnect.executeQuery(queryString);
            if (dbConnect.IsSuccess())
            {
                MessageBox.Show("Inserted first record");
            }
            else
            {
                MessageBox.Show(dbConnect.getErrorString());
                return;
            }

            queryString = $"INSERT INTO menu(name, type, price, modifiedDate) VALUES('Fired Chicken Rice', 'Rice', '7.99', NOW());";
            dbConnect.executeQuery(queryString);
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
            DBConnect dbConnect = new DBConnect();
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
                            textBoxSheet4LoadFile.AppendText(s+"\n");
                        }

                        int nLines = lineList.Count;
                        MessageBox.Show($"{nLines} line read.");
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
                        if(line.Length == 0) { continue; }
                        sr.WriteLine(line);
                    }
                    sr.Close();
                }

                MessageBox.Show("Saved");


            }
        }
    }
}
