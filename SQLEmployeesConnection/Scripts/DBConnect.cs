using SQLEmployeesConnection.Scripts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SQLEmployeesConnection
{
    internal class DBConnect
    {
        private readonly string connectionString =
            "Data Source=85.208.21.117,54321;" +
            "Initial Catalog=DavidSanzEmployees;" +
            "User ID=sa;" +
            "Password=Sql#123456789";

        public SqlConnection Connection { get; private set; }

        public DBConnect()
        {
            Connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(connectionString);

                if(Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
