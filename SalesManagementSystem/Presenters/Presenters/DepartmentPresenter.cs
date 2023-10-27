using SalesManagementSystem.Models;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class DepartmentPresenter
    {
        IDepartment idepartment;
        DepartmentModel departmentModel;
        public DepartmentPresenter(IDepartment idepartment)
        {
            departmentModel = new DepartmentModel();
           this.idepartment = idepartment;
        }
        private void connectedInterfaceAndModel()
        {
            this.departmentModel.DepartmentId = this.idepartment.DepartmentId;
            this.departmentModel.DepartmentName = this.idepartment.DepartmentName;
        }

 /*       public int Insert()
        {
            *//*return DepartmentServices*//*
        }*/
    }
}
