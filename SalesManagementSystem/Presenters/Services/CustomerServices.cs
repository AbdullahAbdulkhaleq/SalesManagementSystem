using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SalesManagementSystem.Presenters.Services
{
    static class CustomerServices
    {
        public static int Insert(CustomerModel model)
        {
            return DB.SetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(CustomerModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.CustomerName;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.CustomerEmail;
            command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = model.CustomerType;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = model.CustomerPhone;
        }
        public static DataTable Select()
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }

    }
}
