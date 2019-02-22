
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    interface DBConnection
    {
        //open connection to database
        bool Connect();

        //Close connection
        bool Disconnect();

        string getErrorString();

        bool IsSuccess();

        void executeQuery(string query);

        //execute select statement
        List<string> SelectTest();
    }




}
