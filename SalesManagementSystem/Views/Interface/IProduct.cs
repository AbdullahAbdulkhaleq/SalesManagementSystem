using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        decimal ProductPrice { get; set; }
        int StoreId { get; set; }
        int UnitId { get; set; }
        int ProductCategoryId { get; set; }
    }
}
