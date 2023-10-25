using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    public class SalesServices
    {
        public static  int Insert(SalesModel model)
        {
            return DB.GetDate("", "", () => Insert(model, DB.Command));
        }
        private static void Insert(SalesModel model, SqlCommand command)
        {

        }
    }
}
