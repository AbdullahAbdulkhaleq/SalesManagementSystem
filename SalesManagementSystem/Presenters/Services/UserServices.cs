using SalesManagementSystem.Models;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagementSystem.Presenters.Services
{
    //هذه الكلاس بيكون ينفذ جميع اومر قواعد البيانات الخاصة للمستخدمين
    public static class UserServices
    {
        public static  int Insert(UserModle modle)
        {
            return DB.SetDate("P_User_Insert","@Sccessfully", () => Insert(modle, DB.Command));
        }
        private static void Insert(UserModle modle, SqlCommand command)
        {
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = modle.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = modle.UserPassword;
            command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = modle.DepartmentId;
            command.Parameters.Add("@UserStatus", SqlDbType.Int).Value = modle.UserStatus;
        }
        public static DataTable Select()
        {
            return DB.GetDate("P_Select_All", ()=>Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "User_";
        }
        public static int Delete(UserModle modle)
        {
            return DB.SetDate("","",()=>Delete(modle,DB.Command));
        }
        private static void Delete(UserModle modle ,SqlCommand command)
        {
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = modle.UserId;
        }
        public static int Update(UserModle modle)
        {
            return DB.SetDate("", "", () => Update(modle, DB.Command));
        }
        private static void Update(UserModle modle,SqlCommand command)
        {
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = modle.UserId;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = modle.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = modle.UserPassword;
            command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = modle.DepartmentId;
            command.Parameters.Add("@UserStatus", SqlDbType.Int).Value = modle.UserStatus;
        }
    }
 }
