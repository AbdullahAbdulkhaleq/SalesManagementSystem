using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class SalesDetailsPresenter
    {
        ISalesDetails isalesDetails;
        SalesDetailsModel salesDetailsModel;
        public SalesDetailsPresenter(ISalesDetails isalesDetails)
        {
            this.salesDetailsModel = new SalesDetailsModel();
            this.isalesDetails = isalesDetails;
        }
        private void connectedInterfaceAndModel()
        {

        }
    }
}
