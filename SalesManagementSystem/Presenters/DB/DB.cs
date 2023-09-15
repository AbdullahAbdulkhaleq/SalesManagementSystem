using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Presenters.DB
{
    public static class DB
    {
        public static SqlCommand Command;
        public static SqlConnection GetConnectionString()
        {
            SqlConnectionStringBuilder ConnectionString = new SqlConnectionStringBuilder();
            ConnectionString.DataSource = Properties.Settings.Default.ServerName;
            ConnectionString.InitialCatalog = Properties.Settings.Default.DatabaseName;
            ConnectionString.IntegratedSecurity = true;
            return new SqlConnection(ConnectionString.ConnectionString);
        }
        public static bool Ex(string sql, Action tran)
        {
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(sql, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
                    tran.Invoke();
                    Connection.Open();
                    Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
        public static void Insert()
        {
            Command.Parameters.Add("");
        }
    }
}
