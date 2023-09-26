using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Helper;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;

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
        public bool Insert()
        {
            connectedInterfaceAndModel();
            return SupplierServices.SupplierInsert(
                                                    this.supplierModel.SupplierName,
                                                    this.supplierModel.SupplierEmail,
                                                    this.supplierModel.SupplierType,
                                                    this.supplierModel.SupplierPhone,
                                                    this.supplierModel.SupplierBrand);
        }
        public bool Delete()
        {
            /*return SupplierServices.*/
            return false;
        }
        
    }
}
