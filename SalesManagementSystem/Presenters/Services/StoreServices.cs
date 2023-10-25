using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    public class StoreServices
    {
        public static int Insert(StoreModel model)
        {
            return DB.GetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(StoreModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.StoreName;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = model.StorePhone;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = model.StoreAddress;
        }

        public static DataTable Select(StoreModel customer)
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }
    }
}
