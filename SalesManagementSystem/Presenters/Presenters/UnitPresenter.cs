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
    public class UnitPresenter
    {
        IUnit iunit;
        UnitModel unitModel;
        
        public UnitPresenter(IUnit iunit)
        {
            this.unitModel = new UnitModel();
            this.iunit = iunit;
        }
        private void connectedInterfaceAndModel()
        {
            this.unitModel.UnitId = this.iunit.UnitId;
            this.unitModel.UnitCode = this.iunit.UnitCode;
            this.unitModel.UnitDesc = this.iunit.UnitDesc;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return UnitServices.Insert(this.unitModel);
        }
        public DataTable Select()
        {
            connectedInterfaceAndModel();
            return UnitServices.Select(this.unitModel);
        }
    }
}
