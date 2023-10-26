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
    public class ProductServices
    {
        public static int Insert(ProductModel model)
        {
            return DB.SetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(ProductModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Product";
            command.Parameters.Add("@Name", SqlDbType.Int).Value = model.ProductName;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = model.ProductPrice;
            command.Parameters.Add("@UnitId", SqlDbType.Int).Value = model.UnitId;
            command.Parameters.Add("@StoreId", SqlDbType.Int).Value = model.StoreId;
            command.Parameters.Add("@ProductCategoryId", SqlDbType.Int).Value = model.ProductCategoryId;
        }
        public static DataTable Select()
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Product";
        }
    }
}
