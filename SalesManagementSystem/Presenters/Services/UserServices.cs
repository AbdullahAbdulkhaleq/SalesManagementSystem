using SalesManagementSystem.Models;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagementSystem.Presenters.Services
{
    //هذه الكلاس بيكون ينفذ جميع اومر قواعد البيانات الخاصة للمستخدمين
    public static class UserServices
    {
        public static  int Insert(UserModle user)
        {
            return DB.SetDate("P_User_Insert","@Sccessfully", () => Insert(user, DB.Command));
        }
        private static void Insert(UserModle user, SqlCommand command)
        {
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.UserPassword;
            command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = user.DepartmentId;
            command.Parameters.Add("@UserStatus", SqlDbType.Int).Value = user.UserStatus;
        }
        public static DataTable Select()
        {
            return DB.GetDate("P_Select_All", ()=>Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "User_";
        }
    }
}
