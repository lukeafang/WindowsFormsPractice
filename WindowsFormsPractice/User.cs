using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    [Serializable]
    class User : Person
    {
        public int ID;
        

        public User()
        {
            ID = 1;
            Name = "User1";
        }

        public User(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
