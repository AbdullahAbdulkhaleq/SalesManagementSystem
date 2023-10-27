using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Services
{
    public class PurchasingModel
    {
        public int PurchasingId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime PurchasingDate { get; set; }
        public decimal PurchasingTotal { get; set; }
    }
}
