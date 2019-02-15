using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        //overloading operator
        //overloading + operator
        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        //overloading compare == operator
        public static bool operator == (Box b, Box c)
        {
            bool status = false;
            if(b.length == c.length && b.breadth == c.breadth && b.height == c.height)
            {
                status = true;
            }
            return status;
        }

        //overloading compare != operator
        public static bool operator !=(Box b, Box c)
        {
            bool status = false;
            if (b.length != c.length || b.breadth != c.breadth || b.height != c.height)
            {
                status = true;
            }
            return status;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }
}
