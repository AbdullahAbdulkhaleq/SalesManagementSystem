using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SalesManagementSystem.Models;

namespace SalesManagementSystem.Presenters.Services
{
    public class DepartmentModel
    {
        public static int Insert(DepartmentModel department)
        {
            return DB.GetDate("", "", ()=> Insert(department, DB.Command));
        }
        private static void Insert(DepartmentModel department,SqlCommand command)
        {
            /*command.Parameters.Add("",SqlDbType.Int).Value =department;*/
        }

        public static DataTable CustomerSelect(CustomerModel customer)
        {
            return DB.GetDate("P_Select_All", () => CustomerSelect(DB.Command));
        }
        private static void CustomerSelect(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }
    }
}
