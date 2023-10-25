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
    public class CategoryServices
    {

        public static int Insert(CategoryModel model)
        {
            return DB.GetDate("P_Insert", "@Sccessfully", ()=>Insert(model,DB.Command));
        }
        private static void Insert(CategoryModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.ProductCategoryName;
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = model.ModifiedDate;
        }

        public static DataTable Select(CategoryModel customer)
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }
    }
}
