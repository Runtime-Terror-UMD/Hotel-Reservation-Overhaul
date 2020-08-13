using System;
using System.Collections.Generic;
using System.Data;
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
        public static string connectionString;

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
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        
        }

        //DESCRIPTION: Opens connection to database
        public bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        //DESCRIPTION: Closes connection to database
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                connection.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataSet ExecuteDataSet(MySqlCommand cmd)
        {
            try
            {
                this.OpenConnection();
                DataSet ds = new DataSet();
                cmd.Connection = connection;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable ExecuteDataTable(MySqlCommand cmd)
        {
            try
            {
                this.OpenConnection();
                DataTable dt = new DataTable();
                cmd.Connection = connection;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        // DESCRIPTION: Executes SELECT statements
        public MySqlDataReader ExecuteReader(MySqlCommand cmd)
        {
            this.OpenConnection();
            if (this.OpenConnection() == true)
            {
                try
                { 
                    MySqlDataReader reader;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return null;
            }
            return null;
        }

        //DESCRIPTION: Executes Non-Queries (INSERT, DELETE, UPDATE)
        public int NonQuery(MySqlCommand cmd)
        {
            try
            {
                int affected;
                connection = new MySqlConnection(connectionString);
                this.OpenConnection();
                cmd.Connection = connection;
                MySqlTransaction mytransaction = connection.BeginTransaction();
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                this.CloseConnection();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        // DESCRIPTION: Executes scalar query of type integer
        public int intScalar(MySqlCommand cmd)
        {
            this.OpenConnection();
            int returnInt = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                cmd.Connection = connection;

                //ExecuteScalar will return one value
                returnInt = int.Parse(cmd.ExecuteScalar() + "");    
                this.CloseConnection();                       
                return returnInt;
            }
            else
            {
                return returnInt;
            }
        }

        // DESCRIPTION: Executes scalar query of type string
        public string stringScalar(MySqlCommand cmd)
        {
            string returnString = null;
            this.OpenConnection();
            if (this.OpenConnection() == true)
            {
                cmd.Connection = connection;

                returnString = cmd.ExecuteScalar().ToString();
                this.CloseConnection();
                return returnString;
            }
            else
            {
                return returnString;
            }
        }
    }
}
