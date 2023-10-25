using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Designer
{
    public partial class UCChild : UCParent
    {
        public UCChild()
        {
            InitializeComponent();
        }
        #region
        public event EventHandler Print;
        public event EventHandler Refrech;
        #endregion

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {

            if (Print != null)
                Print.Invoke(this, e);
        }

        private void BtnResearch_Click(object sender, EventArgs e)
        {

            if (Refrech != null)
                Print.Invoke(this, e);
        }
    }
}
