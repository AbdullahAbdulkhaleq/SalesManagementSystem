using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Models;

namespace SalesManagementSystem.Presenters.Services
{
    public static class SupplierServices
    {

        public static int Insert(SupplierModel model)
        {
            return DB.SetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(SupplierModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Supplier";
            command.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = model.SupplierName;
            command.Parameters.Add("@SupplierEmail", SqlDbType.NVarChar).Value = model.SupplierEmail;
            command.Parameters.Add("@SupplierType", SqlDbType.NVarChar).Value = model.SupplierType;
            command.Parameters.Add("SupplierPhone", SqlDbType.NVarChar).Value = model.SupplierPhone;
            command.Parameters.Add("@SupplierBrand", SqlDbType.NVarChar).Value = model.SupplierBrand;
        }
        public static DataTable Select()
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Supplier";
        }

    }
}
