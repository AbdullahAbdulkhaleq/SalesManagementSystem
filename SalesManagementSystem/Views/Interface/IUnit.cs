using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface IUnit
    {
        int UnitId { get; set; }
        string UnitCode { get; set; }
        string UnitDesc { get; set; }
    }
}
