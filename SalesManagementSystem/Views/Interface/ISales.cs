using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface ISales
    {
        int PurchasingId { get; set; }
        DateTime PurchasingDate { get; set; }
        decimal PurchasingTotal { get; set; }
        int SupplierId { get; set; }
        int UserId { get; set; }
        int StoreId { get; set; }
    }
}
