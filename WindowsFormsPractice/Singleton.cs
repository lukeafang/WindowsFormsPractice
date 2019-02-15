using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private int currentNumber = 0;

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void WriteNumber()
        {
            currentNumber++;
            Console.WriteLine(currentNumber);
        }

        public int GetNumber()
        {
            return currentNumber;
        }
    }
}
