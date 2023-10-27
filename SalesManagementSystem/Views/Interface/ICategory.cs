using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface ICategory
    {
        int ProductCategoryId { get; set; }
        string ProductCategoryName { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
