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
        public static int SupplierInsert(SupplierModel supplier)
        {
            return DB.SetDate("P_Supplier_Insert", "@Sccessfully", () => SupplierSetData(supplier, DB.Command));
        }
        private static void SupplierSetData(SupplierModel supplier, SqlCommand Command)
        {
            Command.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = supplier.SupplierName;
            Command.Parameters.Add("@SupplierEmail", SqlDbType.NVarChar).Value = supplier.SupplierEmail;
            Command.Parameters.Add("@SupplierType",SqlDbType.NVarChar).Value = supplier.SupplierType;
            Command.Parameters.Add("SupplierPhone",SqlDbType.NVarChar).Value = supplier.SupplierPhone;
            Command.Parameters.Add("@SupplierBrand",SqlDbType.NVarChar).Value = supplier.SupplierBrand;
        } 
        public static int SupplierDelete(int Id)
        {
            return DB.SetDate("", "@Sccessfully", () => SupplierDelete(Id, DB.Command));
        }
        private static void SupplierDelete(int Id ,SqlCommand command)
        {
            command.Parameters.Add("@SupplierId",SqlDbType.Int).Value = Id;
        }
        public static bool SupplierDeleteAll()
        {
            return DB.SetDate("", () => SupplierDeleteAll(DB.Command));
        }
        private static void SupplierDeleteAll(SqlCommand command)
        {

        }
        public static  int GetSupplierId()
        {
            return DB.GetDate("P_Get_Next_Id", "@NextId", () => GetSupplierId("Supplier", DB.Command));
        }
        private static void GetSupplierId(string ParameterName, SqlCommand command) 
        {
            command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value = ParameterName;
        }
    }
}
