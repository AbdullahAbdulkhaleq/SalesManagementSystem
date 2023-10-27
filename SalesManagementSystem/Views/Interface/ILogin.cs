using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface ILogin
    {
        string UserName { get; set; }
        string UserPassword { get; set; }
    }
}
