using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System.Data;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class SupplierPresenter
    {
        ISupplier isupplier;
        SupplierModel supplierModel;
        public SupplierPresenter(ISupplier isupplier)
        {
            this.isupplier = isupplier;
            this.supplierModel = new SupplierModel();
        }
        private void connectedInterfaceAndModel()
        {
            this.supplierModel.SupplierId = isupplier.SupplierId;
            this.supplierModel.SupplierName = isupplier.SupplierName;
            this.supplierModel.SupplierType = isupplier.SupplierType;
            this.supplierModel.SupplierPhone = isupplier.SupplierPhone;
            this.supplierModel.SupplierEmail = isupplier.SupplierEmail;
            this.supplierModel.SupplierBrand = isupplier.SupplierBrand;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return SupplierServices.Insert(this.supplierModel);
        }
        public DataTable Select()
        {
            return SupplierServices.Select();
        }

    }
}
