using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IUser
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
        int UserStatus { get; set; }
        int DepartmentId { get; set; }
    }
}
