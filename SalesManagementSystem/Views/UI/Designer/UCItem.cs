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
    public partial class UCItem : UserControl
    {
        public UCItem()
        {
            InitializeComponent();
        }

        #region
        int _Id;
        string _Name = String.Empty;
        String _Three = String.Empty;
        String _Four = String.Empty;
        String _Five = String.Empty;
        String _Six = String.Empty;
        [Category("Items")]
        [Description("هذه الحدث لنقر على هذه العنصر")]
        public event EventHandler ItemClick;

        [Category("Items")]
        [Description("لتعبئة الخانةالاولى")]
        public int One
        {
            get { return _Id; }
            set { LabOne.Text = value.ToString(); _Id = value; }
        }

        [Category("Items")]
        [Description("لتعبئة العمود الثاني")]
        public string Tow
        {
            get { return _Name; }
            set { LabTow.Text = value; _Name = value; SetSize(How()); }
        }

        [Category("Items")]
        [Description("لتعبئة العمود الثالث")]
        public string Three
        {
            get { return _Three; }
            set { LabThree.Text = value; _Three = value; SetSize(How()); }
        }

        [Category("Items")]
        [Description("لتعبئة العمود الرابع")]
        public string Fore
        {
            get { return _Four; }
            set { LabFore.Text = value; _Four = value; SetSize(How()); }
        }

        [Category("Items")]
        [Description("لتعبئة العمود الخامس")]
        public string Five
        {
            get { return _Five; }
            set { LabFive.Text = value; _Five = value; SetSize(How()); }
        }

        [Category("Items")]
        [Description("لتعبئة العمود السادس")]
        public string Six
        {
            get { return _Six; }
            set { LabSix.Text = value; _Six = value;SetSize(How());}
        }

        #endregion

        private void UCItem_Click(object sender, EventArgs e)
        {
            if (ItemClick != null)
                ItemClick.Invoke(this, e);
        }

        private void SetSize(EUCItemType How)
        {
            LabOne.MinimumSize = new Size(100, 45);
            switch (How)
            {
                case EUCItemType.Tow:
                    LabTow.Size = new Size(858, 45);
                    break;
                case EUCItemType.Three:
                    LabTow.MinimumSize = new Size(429, 45);
                    LabThree.MinimumSize = new Size(429, 45);
                    break;
                case EUCItemType.Fore:
                    LabTow.MinimumSize = new Size(286, 45);
                    LabThree.MinimumSize = new Size(286, 45);
                    LabFore.MinimumSize = new Size(286, 45);
                    break;
                case EUCItemType.Fiev:
                    LabTow.MinimumSize = new Size(214, 45);
                    LabThree.MinimumSize = new Size(214, 45);
                    LabFore.MinimumSize = new Size(214, 45);
                    LabFive.MinimumSize = new Size(214, 45);
                    break;
                case EUCItemType.Six:
                    LabTow.MinimumSize = new Size(171, 45);
                    LabThree.MinimumSize = new Size(171, 45);
                    LabFore.MinimumSize = new Size(171, 45);
                    LabFive.MinimumSize = new Size(171, 45);
                    LabSix.MinimumSize = new Size(171, 45);
                    break;
            }
        }
        private EUCItemType How()
        {
            if (_Name != string.Empty && _Three != String.Empty && _Four != String.Empty && _Five != String.Empty && _Six != String.Empty)
            {
                return EUCItemType.Six;
            }
            else if (_Three != String.Empty && _Four != String.Empty && _Five != String.Empty)
            {
                return EUCItemType.Fiev;
            }
            else if (_Three != String.Empty && _Four != String.Empty)
            {
                return EUCItemType.Fore;
            }
            else if (_Three != String.Empty)
            {
                return EUCItemType.Three;
            }
            else
            {
                return EUCItemType.Tow;
            }
        }



        private void LabSix_Click(object sender, EventArgs e)
        {

        }

        private void LabFive_Click(object sender, EventArgs e)
        {

        }

        private void LabFore_Click(object sender, EventArgs e)
        {

        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
    enum EUCItemType
    {
        Tow = 2,
        Three = 3,
        Fore = 4,
        Fiev = 5,
        Six = 6
    }
}
