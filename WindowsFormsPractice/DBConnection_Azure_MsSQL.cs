using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsPractice
{
    class DBConnection_Azure_MsSQL : DBConnection
    {
        private bool bError;
        private string errorMsg;

        SqlConnectionStringBuilder builder;
        SqlConnection connection;

        public DBConnection_Azure_MsSQL()
        {
            initial();
        }

        private void initial()
        {
            bError = false;
            errorMsg = "";

            // Build connection string
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = "datasource.database.windows.net";
            builder.UserID = "practiceuser";
            builder.Password = "P@55w0rd";
            builder.InitialCatalog = "DemoDatabase";

            connection = new SqlConnection(builder.ConnectionString);

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
                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                connection.Open();
                Console.WriteLine("Done.");
                return true;
            }
            catch (SqlException e)
            {
                bError = true;
                errorMsg = e.ToString();
                Console.WriteLine(e.ToString());
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
            catch (SqlException e)
            {
                bError = true;
                errorMsg = e.Message;
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
                    //StringBuilder sb = new StringBuilder();
                    //sb.Append(query);
                    String sql = query;


                    //create command and assign the query and connection from the constructor
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //Execute command
                        command.ExecuteNonQuery();
                        //int rowsAffected = command.ExecuteNonQuery();
                        //Console.WriteLine(rowsAffected + " row(s) inserted");
                    }

                    //close connection
                    this.Disconnect();
                }
                catch (SqlException ex)
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
            //Create a list to store the result
            List<string> results = new List<string>();

            if (this.Connect() == true)
            {
                try
                {
                    //read data
                    Console.WriteLine("Reading data from table");
                    string sql = "SELECT * FROM menu";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                //Console.WriteLine("{0} {1} {2}", dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
                                string tempStr = "";
                                tempStr = String.Format("id: {0}, name: {1}, type: {2}, price: {3}, Date: {4}.\n", dataReader["id"], dataReader["name"], dataReader["type"], dataReader["price"], dataReader["modifiedDate"]);
                                results.Add(tempStr);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    bError = true;
                    errorMsg = ex.Message;
                    connection.Close();
                }
            }
            
            return results;
        }
    }
}
