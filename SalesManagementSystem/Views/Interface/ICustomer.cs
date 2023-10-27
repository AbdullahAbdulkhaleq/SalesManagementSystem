using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    internal interface ICustomer
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerEmail { get; set; }
        string CustomerType { get; set; }
        string CustomerPhone { get; set; }

    }
}
