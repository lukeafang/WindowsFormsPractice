using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string textInput)
        {
            double convertedNumber;
            if (!double.TryParse(textInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
            return convertedNumber;
        }
    }
}
