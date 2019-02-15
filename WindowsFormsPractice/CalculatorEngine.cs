using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    public class CalculatorEngine
    {
        public double Calcualte(string argOperation, double number1, double number2)
        {
            double result;
            switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = number1 + number2;
                    break;
                case "subtract":
                case "-":
                    result = number1 - number2;
                    break;
                default:
                    throw new InvalidOperationException("Operation is not recognized.");
            }
            return result;
        }

        public void getIntValue(out int x)
        {
            int temp = 11;
            x = 11;
        }
    }
}
