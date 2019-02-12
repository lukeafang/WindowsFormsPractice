using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    class DemoIndexer
    {
        public int size;
        private string[] arr;

        //define indexer
        public string this[int i]
        {
            get
            {
                if( i >= 0 && i < size )
                {
                    return arr[i];
                }
                else
                {
                    return "out of range";
                }
                
            }
            set
            {
                if (i >= 0 && i < size)
                {
                    arr[i] = value;
                }
            }
        }

        public DemoIndexer()
        {
            size = 10;
            arr = new string[size];
        }
    }
}
