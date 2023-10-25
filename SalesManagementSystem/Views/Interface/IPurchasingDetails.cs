using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IPurchasingDetails
    {
        int PurchasingDetailsId { get; set; }
        int PurchasingId { get; set; }
        int ProductId { get; set; }
        int Quantity { get; set; }
        decimal UnitPrice { get; set; }
    }
}
