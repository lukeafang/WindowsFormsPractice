using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsPractice
{
    class DBConnection_MySQL : DBConnection
    {
        private string server;
        private string database;
        private string port;
        private string uid;
        private string password;

        private MySqlConnection connection;
        private string connectionString;

        private bool bError;
        private string errorMsg;

        public DBConnection_MySQL()
        {
            initial();
        }

        private void initial()
        {
            server = "localhost";
            database = "demodb";
            uid = "test";
            password = "test";
            port = "3306";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "port=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            bError = false;
            this.errorMsg = "";
        }

        public string getErrorString()
        {
            return this.errorMsg;
        }

        public bool IsSuccess()
        {
            return !bError;
        }

        //open connection to database
        public bool Connect()
        {
            bError = false;
            errorMsg = "";

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                bError = true;
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        errorMsg = "Cannot connect to server.  Contact administrator";
                        break;

                    case 1045:
                        errorMsg = "Invalid username/password, please try again";
                        break;
                    default:
                        errorMsg = ex.Message;
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool Disconnect()
        {
            bError = false;
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                bError = true;
                errorMsg = ex.Message;
                return false;
            }
        }

        public void executeQuery(string query)
        {
            if (query.Length <= 0) { return; }

            bError = false;

            //open connection
            if (this.Connect() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.Disconnect();
                }
                catch (MySqlException ex)
                {
                    bError = true;
                    errorMsg = ex.Message;
                    connection.Close();
                }
            }
        }

        //execute select statement
        public List<string> SelectTest()
        {
            string query = "SELECT * FROM menu";

            //Create a list to store the result
            List<string> results = new List<string>();

            //Open connection
            if (this.Connect() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        string tempStr = "";
                        tempStr = String.Format("id: {0}, name: {1}, type: {2}, price: {3}, Date: {4}.\n", dataReader["id"], dataReader["name"], dataReader["type"], dataReader["price"], dataReader["modifiedDate"]);
                        results.Add(tempStr);
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.Disconnect();

                    //return list to be displayed
                    return results;
                }
                catch (MySqlException ex)
                {
                    bError = true;
                    errorMsg = ex.Message;
                    connection.Close();
                    return results;
                }
            }
            else
            {
                return results;
            }
        }
    }
}
