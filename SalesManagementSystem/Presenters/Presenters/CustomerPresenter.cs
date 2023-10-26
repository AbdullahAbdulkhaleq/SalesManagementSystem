using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System.Data;

namespace SalesManagementSystem.Presenters.Presenters
{
    class CustomerPresenter
    {
        ICustomer icustomer;
        CustomerModel customermodel;

        public CustomerPresenter(ICustomer icustomer)
        {
            customermodel = new CustomerModel();
            this.icustomer = icustomer;
        }
        private void connectedInterfaceAndModel()
        {
            this.customermodel.CustomerId = this.icustomer.CustomerId;
            this.customermodel.CustomerName = this.icustomer.CustomerName;
            this.customermodel.CustomerEmail = this.icustomer.CustomerEmail;
            this.customermodel.CustomerType = this.icustomer.CustomerType;
            this.customermodel.CustomerPhone = this.icustomer.CustomerPhone;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return CustomerServices.Insert(this.customermodel);
        }

        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return CustomerServices.Select();
        }
    }
}
