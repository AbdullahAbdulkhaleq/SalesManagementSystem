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
        //هذه  الداله تستقبل اسم لاجراء والمتغيرات الخاصة بهذه الاجراءو ترجع قيمة  من الجراءت المخزنة
        public static int GetDate(string ProcedureName, string ParameterName, Action action )
        {
            using(SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command  = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType =CommandType.StoredProcedure;
                    action.Invoke();
                    SqlParameter ifexists = new SqlParameter();
                    ifexists.ParameterName = ParameterName;
                    ifexists.SqlDbType = SqlDbType.Int;
                    ifexists.Direction = ParameterDirection.Output;
                    Command.Parameters.Add(ifexists);
                    Connection.Open();
                    Command.ExecuteReader();
                    return int.Parse(ifexists.Value.ToString());


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
        //هذه الدالة ترجع قيمة من  الاجراء النخزن
        public static T GetDate<T>(string ProcedureName, string ParameterName)
        {
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
                    SqlParameter OutPutParameter = new SqlParameter();
                    OutPutParameter.ParameterName = ParameterName;
                    OutPutParameter.SqlDbType = SqlDbType.Int;
                    OutPutParameter.Direction = ParameterDirection.Output;
                    Command.Parameters.Add(OutPutParameter);
                    Connection.Open();
                    Command.ExecuteReader();

                    return (T)OutPutParameter.Value;


                }
                catch
                {
                    return default;
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
    }
}
