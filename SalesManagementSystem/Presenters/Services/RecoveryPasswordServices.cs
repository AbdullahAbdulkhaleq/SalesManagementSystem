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
    public class RecoveryPasswordServices
    {
        public static int Insert(RecoveryPasswordModel model)
        {
            return DB.GetDate("P_Insert", "@Sccessfully", () => Insert(model, DB.Command));
        }
        private static void Insert(RecoveryPasswordModel model, SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
            command.Parameters.Add("@Name", SqlDbType.Int).Value = model.UserId;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.WhatsYourFavoriteAnimal;
            command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = model.WhatsYourFavoriteAnimal;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = model.WhatsIsayourBestCity;
        }

        public static DataTable Select(RecoveryPasswordModel customer)
        {
            return DB.GetDate("P_Select_All", () => Select(DB.Command));
        }
        private static void Select(SqlCommand command)
        {
            command.Parameters.Add("@TableName", SqlDbType.NVarChar).Value = "Customer";
        }
    }
}
