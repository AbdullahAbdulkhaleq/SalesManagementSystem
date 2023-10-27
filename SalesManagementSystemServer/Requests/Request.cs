using SalesManagementSystemServer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystemServer.Requests
{
    //الطلب
    internal class Request
    {
        public ERequestType Type { get; set; }
        public object Data { get; set; }
    }
}
