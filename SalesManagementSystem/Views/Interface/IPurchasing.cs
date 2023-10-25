using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IPurchasing
    {
        int PurchasingId { get; set; }
        int SupplierId { get; set; }
        int UserId { get; set; }
        int StoreId { get; set; }
        DateTime PurchasingDate { get; set; }
        decimal PurchasingTotal { get; set; }
    }
}
