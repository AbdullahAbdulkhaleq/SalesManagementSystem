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
    public class ProductPresenter
    {
        ProductModel productModel;
        IProduct iproduct;
        public ProductPresenter(IProduct iproduct)
        {
            this.productModel = new ProductModel();
            this.iproduct = iproduct;
        }
        private void connectedInterfaceAndModel()
        {
            this.productModel.ProductId =this.iproduct.ProductId;
            this.productModel.ProductName = this.iproduct.ProductName;
            this.productModel.ProductPrice =this.iproduct.ProductPrice;
            this.productModel.UnitId =this.iproduct.UnitId;
            this.productModel.StoreId =this.iproduct.StoreId;
            this.productModel.ProductCategoryId =this.iproduct.ProductCategoryId;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return ProductServices.Insert(this.productModel);
        }
        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return ProductServices.Select(this.productModel);
        }
    }
}
