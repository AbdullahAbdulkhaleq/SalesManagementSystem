using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IStore
    {
        int StoreId { get; set; }
        string StoreName { get; set; }
        string StoreAddress { get; set; }
        string StorePhone { get; set; }
    }
}
