using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Hotel_Reservation_Overhaul
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        // DESCRIPTION: Initializes connection values
        private void Initialize()
        {
            server = "localhost";
            database = "dbo";
            uid = "root";
            password = "hotelmgmt";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //DESCRIPTION: Opens connection to database
        private bool OpenConnection()
        {
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                   switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        // DESCRIPTION: Executes non-query (INSERT, UPDATE, DELETE)
        public void NonQuery(MySqlCommand cmd)
        {
            if (OpenConnection() == true)
            {
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        //public List<string>[] Select()
        //{
        //}
        
        // DESCRIPTION: Runs COUNT command 
        public int Count(MySqlCommand cmd)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                cmd.Connection = connection;
                Count = int.Parse(cmd.ExecuteScalar() + "");    //ExecuteScalar will return one value
                this.CloseConnection();                       //close Connection
                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
