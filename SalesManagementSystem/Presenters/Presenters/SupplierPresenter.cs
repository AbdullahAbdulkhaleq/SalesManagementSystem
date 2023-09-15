using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.DB;
using SalesManagementSystem.Views.Interface;
using System;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class SupplierPresenter
    {
         ISupplier isupplier ;
         SupplierModel suppliermodel = new SupplierModel();

        public SupplierPresenter(ISupplier isupplier)
        {
            this.isupplier = isupplier;
        }
        private void ConnecdeBetweenModelInterface()
        {
            suppliermodel.SupplierId = isupplier.SupplierId;
            suppliermodel.SupplierName = isupplier.SupplierName;
        }
        public bool insert()
        {
            ConnecdeBetweenModelInterface();
            return SupplierDB.SupplierParameterInsert(suppliermodel.SupplierId, suppliermodel.SupplierName);
        }
    }
}
