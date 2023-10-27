using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class SalesPresenter
    {
        ISales isales;
        SalesModel salesModel;
        public SalesPresenter(ISales isales)
        {
            this.salesModel = new SalesModel();
            this.isales = isales;
        }
        private void connectedInterfaceAndModel()
        {
            this.salesModel.StoreId = this.isales.StoreId;

        }
    }
}
