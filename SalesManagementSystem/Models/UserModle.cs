using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class UserModle
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserStatus { get; set; }
        public int DepartmentId { get; set; }
    }
}
