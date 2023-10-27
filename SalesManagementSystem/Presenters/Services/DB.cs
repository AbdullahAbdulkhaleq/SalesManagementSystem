using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;

namespace SalesManagementSystem.Presenters.Services
{
    internal static class DB
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
        //هذه  الداله تستقبل اسم لاجراء والمتغيرات الخاصة بهذه الاجراءو ترجع قيمة  من الجراءت المخزنة
        public static int SetDate(string ProcedureName, string ParameterName, Action action)
        {
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
                    action.Invoke();

                    SqlParameter ParameterNameout = new SqlParameter();
                    ParameterNameout.ParameterName = ParameterName;
                    ParameterNameout.SqlDbType = SqlDbType.Int;
                    ParameterNameout.Direction = ParameterDirection.Output;
                    Command.Parameters.Add(ParameterNameout);

                    Connection.Open();
                    Command.ExecuteReader();
                    return int.Parse(ParameterNameout.Value.ToString());


                }
                catch
                {
                    return 0;
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
        //هذه الدالة تقوم بعمليات الادخال والحذف والتعديل لجميع جداول البرنامج من جميع الشاشات
        public static bool SetDate(string ProcedureName, Action tran)
        {
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
                    tran.Invoke();
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
        //هذه الداله تقوم بارجعال البيانات من جميع جداول قواعد البيانات الى جميع الشاشات
        public static DataTable GetDate(string ProcedureName, Action tran)
        {
            DataTable Table = new DataTable();
            using(SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType= CommandType.StoredProcedure;
                    tran.Invoke();
                    SqlParameter ParameterNameout = new SqlParameter();
                    ParameterNameout.ParameterName = "@Sccessfully";
                    ParameterNameout.SqlDbType = SqlDbType.Bit;
                    ParameterNameout.Direction = ParameterDirection.Output;
                    Command.Parameters.Add(ParameterNameout);
                    Connection.Open();
                    Table.Load( Command.ExecuteReader());

                }
                catch
                {
                    /*Table.AddHandler("",);*/
                }
                finally
                {
                    Connection.Close();
                }
            }

            return Table;
        }
    }
}
