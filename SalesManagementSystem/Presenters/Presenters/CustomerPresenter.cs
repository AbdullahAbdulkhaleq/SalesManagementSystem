using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool Insert()
        {
            connectedInterfaceAndModel();
            return CustomerServices.CustomerInsert(this.customermodel.CustomerName,
                                                   this.customermodel.CustomerEmail, 
                                                   this.customermodel.CustomerType, 
                                                   this.customermodel.CustomerPhone);
        }
        public bool Delete()
        {connectedInterfaceAndModel();
            return CustomerServices.CustomerDelete(this.customermodel.CustomerId);
        }
        public bool DeleteAll()
        {
            connectedInterfaceAndModel();
            return CustomerServices.CustomerDeleteAll();
        }
        public bool Update()
        {
            connectedInterfaceAndModel();
            return CustomerServices.CustomerUpdate(this.customermodel.CustomerId,
                                                   this.customermodel.CustomerName,
                                                   this.customermodel.CustomerEmail,
                                                   this.customermodel.CustomerType,
                                                   this.customermodel.CustomerPhone);
        }
        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return CustomerServices.CustomerSelect(this.customermodel.CustomerId);
        }
    }
}
