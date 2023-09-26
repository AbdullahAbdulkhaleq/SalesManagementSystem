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

        public static bool CustomerInsert( string Name, string Email, string Type, string Phone)
        {
            return DB.SetDate("P_Customer_Insert", () => CustomerInsert( Name, Email, Type, Phone, DB.Command));
        }
        private static void CustomerInsert( string Name, string Email, string Type, string Phone, SqlCommand command)
        {
            command.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar).Value = Email;
            command.Parameters.Add("@CustomerType", SqlDbType.NVarChar).Value = Type;
            command.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar).Value = Phone;
        }
        public static bool CustomerDeleteAll()
        {
            return DB.SetDate("", () => CustomerDeleteAll("", DB.Command));
        }
        private static void CustomerDeleteAll(string UserNaem, SqlCommand command)
        {
            command.Parameters.Add("@UserNaem", SqlDbType.NVarChar).Value = UserNaem;
        }
        public static bool CustomerDelete(int id)
        {
            return DB.SetDate("", () => CustomerDelete(id, DB.Command));
        }
        private static void CustomerDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = id;
        }
        public static bool CustomerUpdate(int Id, string Name, string Email, string Type, string Phone)
        {
            return DB.SetDate("P_Customer_Update", () => CustomerUpdate(Id, Name, Email, Type, Phone, DB.Command));
        }
        private static void CustomerUpdate(int Id, string Name, string Email, string Type, string Phone, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar).Value = Email;
            command.Parameters.Add("@CustomerType", SqlDbType.NVarChar).Value = Type;
            command.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar).Value = Phone;
        }
        public static DataTable CustomerSelect(int Id = -1)
        {
            return DB.GetDate("a", () => CustomerSelect(Id, DB.Command));
        }
        private static void CustomerSelect(int Id, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Id;
        }
        public static int GetCustomerId()
        {
            return DB.GetDate("P_Get_Next_Id", "@NextId",()=> GetCustomerId("Customer",DB.Command));
        }
        private static void GetCustomerId (string ParameterName, SqlCommand command)
        {
            command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value=ParameterName;
        }
    }
}
