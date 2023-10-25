﻿using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    public class UnitServices
    {
        public static int Insert(UnitModel model)
        {
            return DB.GetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(UnitModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.UnitCode;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.UnitDesc;
        }
        public static DataTable Select(UnitModel customer)
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }
    }
}
