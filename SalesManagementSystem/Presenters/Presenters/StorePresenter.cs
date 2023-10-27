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
    public class StorePresenter
    {
        StoreModel storeModel;
        IStore istore;
        public StorePresenter(IStore istore)
        {
            this.storeModel = new StoreModel();
            this.istore = istore;
        }
        private void connectedInterfaceAndModel()
        {
            this.storeModel.StoreId = this.istore.StoreId;
            this.storeModel.StoreName = this.istore.StoreName;
            this.storeModel.StorePhone = this.istore.StorePhone;
            this.storeModel.StoreAddress = this.istore.StoreAddress;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return StoreServices.Insert(this.storeModel);
        }
        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return StoreServices.Select();
        }
        public int Delete()
        {
            connectedInterfaceAndModel();
            return StoreServices.Delete(this.storeModel);
        }
        public int Update()
        {
            connectedInterfaceAndModel();
            return StoreServices.Update(this.storeModel);
        }
    }
}
