using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Presenters.Services;

namespace SalesManagementSystem.Presenters.Helper
{
    public static class SupplierServices
    {
        public static bool SupplierInsert(string Name, string Email, string Type, string Phone, string Brand)
        {
            return DB.SetDate("P_Supplier_Insert", () => SupplierSetData( Name, Email, Type, Phone, Brand, DB.Command));
        }
        private static void SupplierSetData(string Name, string Email, string Type, string Phone, string Brand, SqlCommand Command)
        {
            Command.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = Name;
            Command.Parameters.Add("@SupplierEmail", SqlDbType.NVarChar).Value = Email;
            Command.Parameters.Add("@SupplierType",SqlDbType.NVarChar).Value = Type;
            Command.Parameters.Add("SupplierPhone",SqlDbType.NVarChar).Value = Phone;
            Command.Parameters.Add("@SupplierBrand",SqlDbType.NVarChar).Value = Brand;
        } 
        public static bool SupplierDelete(int Id)
        {
            return DB.SetDate("", () => SupplierDelete(Id, DB.Command));
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
