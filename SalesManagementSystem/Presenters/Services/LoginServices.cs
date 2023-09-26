using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    static class LoginServices
    {
        public static bool Login(string UserName, string UserPassword)
        {
            //أسم الاجراء واسم المتغير المخرج منه مع اسماء جميع المتغيرات الازمة لتنفيذ هذه الاجراء
            //اذا كانت القيمة المرجعة ==1  اذا يوجد مستخدم بنفس اللسم وكلمة السر

            if (DB.GetDate("PLogin", "exist", () => Login(UserName, UserPassword, DB.Command)) == 1) 
            {
                return true;
            }
            else
                return false;

        }
        private static void Login(string UserName, string UserPassword, SqlCommand command)
        {
            command.Parameters.Add("@UserName",SqlDbType.NVarChar).Value = UserName;
            command.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = UserPassword;
        }
    }
}
