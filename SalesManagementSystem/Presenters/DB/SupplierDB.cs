using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.DB
{
    public static class SupplierDB
    {
        public static bool SupplierParameterInsert(int id, string name)
        {
            //Arro function
            return DB.Ex("", () => SupplierInsert(id, name, DB.Command));
        }
        private static void SupplierInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = id;
            command.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = name;
        }
        public static bool SupplierParameterSelect(int id)
        {
            return DB.Ex("", () => SupplierSelect(id, DB.Command));
        }
        private static void SupplierSelect(int id, SqlCommand command)
        {
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = id;
        }
        public static bool SupplierParameterDelete(int id)
        {
            return DB.Ex("", () => SupplierDelete(id,DB.Command));
        }
        private static void SupplierDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = id;
        }

    }
}
