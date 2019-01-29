using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


    }
}
