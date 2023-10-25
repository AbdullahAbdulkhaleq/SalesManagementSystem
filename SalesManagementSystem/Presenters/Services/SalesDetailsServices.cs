using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    public class SalesDetailsServices
    {
        public static int Insert(SalesDetailsModel model)
        {
            return DB.GetDate("", "", () => Insert(model, DB.Command));
        }
        private static void Insert(SalesDetailsModel model, SqlCommand command)
        {

        }
    }
}
