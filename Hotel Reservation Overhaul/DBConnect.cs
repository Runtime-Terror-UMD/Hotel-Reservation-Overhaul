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

        //DESCRIPTION: Closea connection to database
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

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
                da.Fill(ds, "result");
                return ds;
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
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = connection.BeginTransaction();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        // DESCRIPTION: Runs COUNT command 
        public int Count(MySqlCommand cmd)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                cmd.Connection = connection;
                
                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");    
                this.CloseConnection();                       
                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
