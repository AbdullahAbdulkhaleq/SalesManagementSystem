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

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FError : FDMain
    {
        public FError(string Message)
        {
            InitializeComponent();
            LabMessage.Text = Message;
        }
    }
}
