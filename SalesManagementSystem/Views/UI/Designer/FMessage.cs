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
    public partial class FMessage : Form
    {

        public FMessage()
        {
            InitializeComponent();
            this.Show();
        }
        public void show(string _Message, string _Captions = "", Image _Icon = null)
        {
            Message.Text = _Message;
            Captions.Text = _Captions;
            if (Icon != null)
                this.Icon.Image = _Icon;
            else
                this.Icon.Image = Properties.Resources.Info;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
