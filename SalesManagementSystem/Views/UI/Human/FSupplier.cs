using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Human
{
    public partial class FSupplier : FDMain, ISupplier
    {
        SupplierPresenter supplierPresenter;
        public int SupplierId { get => int.Parse(TSupplierId.Text); set => TSupplierId.Text = value.ToString(); }
        public string SupplierName { get => TSupplierName.Text; set => TSupplierName.Text = value; }
        public FSupplier()
        {
            InitializeComponent();
            supplierPresenter = new SupplierPresenter(this);
        }
    }
}
