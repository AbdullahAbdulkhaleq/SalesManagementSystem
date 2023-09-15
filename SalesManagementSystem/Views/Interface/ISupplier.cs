using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface ISupplier
    {
        int SupplierId { get; set; }
        string SupplierName { get; set; }
    }
}
