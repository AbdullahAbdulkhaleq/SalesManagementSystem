using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
    }
}
