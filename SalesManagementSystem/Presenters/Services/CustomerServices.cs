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

        public static bool CustomerInsert(CustomerModel customer)
        {
            return DB.SetDate("P_Insert", () => CustomerInsert(customer, DB.Command));
        }
        private static void CustomerInsert(CustomerModel customer, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "";
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.CustomerName;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.CustomerEmail;
            command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = customer.CustomerType;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.CustomerPhone;
        }
        public static bool CustomerDeleteAll()
        {
            return DB.SetDate("", () => CustomerDeleteAll("", DB.Command));
        }
        private static void CustomerDeleteAll(string UserNaem, SqlCommand command)
        {
            command.Parameters.Add("@UserNaem", SqlDbType.NVarChar).Value = UserNaem;
        }
        public static bool CustomerDelete(CustomerModel customer)
        {
            return DB.SetDate("", () => CustomerDelete(customer, DB.Command));
        }
        private static void CustomerDelete(CustomerModel customer, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customer.CustomerId;
        }
        public static bool CustomerUpdate(CustomerModel customer)
        {
            return DB.SetDate("P_Update", () => CustomerUpdate(customer, DB.Command));
        }
        private static void CustomerUpdate(CustomerModel customer, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customer.CustomerId;
            command.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = customer.CustomerName;
            command.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar).Value = customer.CustomerEmail;
            command.Parameters.Add("@CustomerType", SqlDbType.NVarChar).Value = customer.CustomerType;
            command.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar).Value = customer.CustomerPhone;
        }
        public static DataTable CustomerSelect(CustomerModel customer)
        {
            return DB.GetDate("a", () => CustomerSelect(customer, DB.Command));
        }
        private static void CustomerSelect(CustomerModel customer, SqlCommand command)
        {
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customer.CustomerId;
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
