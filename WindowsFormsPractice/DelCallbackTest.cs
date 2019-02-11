using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    public delegate string MyDel();

    class DelCallbackTest
    {
        private string _name = "A";

        //method for delegate
        public string showInfo()
        {
            return this._name;
        }

        public DelCallbackTest()
        {
            //create delegate class
            DelDriver driver = new DelDriver();
            MyDel d1 = showInfo;
            driver.delDriver(d1);
        }


    }

    class DelDriver
    {
        public void delDriver(MyDel del)
        {
            Console.WriteLine(del());
        }
    }
}
