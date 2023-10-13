using System.Data;
using System.Data.SqlClient;
using System;
namespace SalesManagementSystemServer.DB
{
    public static class DBServices
    {
        //نبداء بعمل متغير من هذه النواع علشان نخزن المتغيرات 
        public static SqlCommand Command = null;

        //دالة ترجع نص الاتصال 
        private static SqlConnection GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource =Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DataBaseName;
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }

        //هذه الدالة تقةم بادخال وتعديل والحذف من جميع الجداول 
        public static bool Execute(string ProcedureName, Action action)
        {

            using (SqlConnection connection = GetConnectionString())
            {
                try
                {
                    //نبدا بتهئة المتغير وارسال الية اسم التخزين مع نص الاتصال
                    Command = new SqlCommand(ProcedureName, connection);
                    //حددنا نواع ال تنفيذ انها اجراء مخزن
                    Command.CommandText = ProcedureName;
                    //هناء بيتم تنفيذ الدالة المرسلة علشان نحدد اسماء المتغيرات لهذه الاجراء المخزن
                    action.Invoke();
                    //فتحنا اللاتصال
                    connection.Open();
                    //نفذناء الطلب الى قاعدة البيانات
                    Command.ExecuteNonQuery();
                    return true;

                }
                catch
                {
                    return false;
                }
                finally
                {
                    //بعد الانتهاء من تنفيذ الدالة نقوم بتحرير الكائن واغلاق الاتصال مع قاعدة البيانات 
                    Command = null;
                    connection.Close();
                }

            }
        }

        //هذه الداله تقوم بارجعال البيانات من جميع جداول قواعد البيانات الى جميع الشاشات
        public static DataTable GetDate(string ProcedureName, Action tran)
        {
            DataTable Table = new DataTable();
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
                    tran.Invoke();
                    Connection.Open();
                    Table.Load(Command.ExecuteReader());

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
        public static int GetDate(string ProcedureName, string ParameterName, Action action)
        {
            using (SqlConnection Connection = GetConnectionString())
            {
                try
                {
                    Command = new SqlCommand(ProcedureName, Connection);
                    Command.CommandType = CommandType.StoredProcedure;
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
