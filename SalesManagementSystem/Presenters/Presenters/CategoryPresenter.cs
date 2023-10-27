using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Presenters.Services;
using System.Data;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class CategoryPresenter
    {
        CategoryModel categoryModel;
        ICategory icategory; 

        public CategoryPresenter(ICategory icategory)
        {
            this.categoryModel = new CategoryModel();
            this.icategory = icategory;
        }
        private void connectedInterfaceAndModel()
        {
            this.categoryModel.ProductCategoryId = this.icategory.ProductCategoryId;
            this.categoryModel.ProductCategoryName = this.icategory.ProductCategoryName;
            this.categoryModel.ModifiedDate = this.icategory.ModifiedDate;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return CategoryServices.Insert(this.categoryModel);
        }
        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return CategoryServices.Select();
        }
    }
}
