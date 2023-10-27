using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class SalesModel
    {
        public int PSalesId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal SalesTotal { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
    }
}
