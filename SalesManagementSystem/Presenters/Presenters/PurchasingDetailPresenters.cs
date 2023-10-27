using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class PurchasingDetailPresenters
    {
        IPurchasingDetails ipurchasingDetails;
        PurchasingDetailsModel purchasingDetailsModel;
        public PurchasingDetailPresenters(IPurchasingDetails ipurchasingDetails)
        {
            this.purchasingDetailsModel = new PurchasingDetailsModel();
            this.ipurchasingDetails = ipurchasingDetails;
        }
        private void connectedInterfaceAndModel()
        {

        }
    }
}
