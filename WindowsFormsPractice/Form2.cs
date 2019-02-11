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
    public partial class Form2 : Form
    {
        public delegate void ReturnValueDelegate(string pValue);
        public event ReturnValueDelegate ReturnValueCallback;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnNewWindowSubmit_Click(object sender, EventArgs e)
        {
            ReturnValueCallback(txtNewWindowName.Text);
            this.Close();
        }

        public void ReceiveValueCallbackFunc(string pValue)
        {
            txtNewWindowID.Text = pValue;
        }

    }
}
