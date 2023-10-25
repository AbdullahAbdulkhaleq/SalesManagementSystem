using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    internal class PurchasingPresenter
    {
        IPurchasing ipurchasing;
        PurchasingModel purchasingModel;
        public PurchasingPresenter(IPurchasing ipurchasing)
        {
            this.purchasingModel = new PurchasingModel();
            this.ipurchasing = ipurchasing;
        }
        private void connectedInterfaceAndModel()
        {
            
        }
    }
}
