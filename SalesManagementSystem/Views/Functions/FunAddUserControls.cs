
using SalesManagementSystem.Views.Enum;
using SalesManagementSystem.Views.UI.Human;
using SalesManagementSystem.Views.UI.Inventory;
using SalesManagementSystem.Views.UI.Inventory_FUnit_FStore_FProduct;
using SalesManagementSystem.Views.UI.Purchasing;
using SalesManagementSystem.Views.UI.Sales;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.Functions
{
    public class FunAddUserControls
    {

        public  static UserControl SetControl(string UserCont)
        {
            return (SetControl(GetControl(UserCont)));
        }
        /*        public static Panel SetControlToPanel(string UserCont)
        {
            Panel p = new Panel();
            UserControl con = (SetControl(GetControl(UserCont)));
            con.Dock = DockStyle.Fill;
            p.Controls.Add(con);
           return p ;
        }*/
        private static UserControl SetControl(EUserControl U)
        {
            switch (U)
            {
                case EUserControl.UCCustomer:
                    return new UCCustomer();

                case EUserControl.UCSupplier:
                    return new UCSupplier();

                case EUserControl.UCUser:
                    return new UCUser();

                case EUserControl.UCProduct:
                    return new UCProduct();

                case EUserControl.UCGategory:
                    return new UCGategory();

                case EUserControl.UCUnit:
                    return new UCUnit();

                case EUserControl.UCStore:
                    return new UCStore();

                case EUserControl.UCSales:
                    return new UCSales();

                case EUserControl.UCPurchasing:
                    return new UCPurchasing();

                default: return new UserControl();
            }
        }

        private static EUserControl GetControl(string userControlName)
        {
            switch (userControlName)
            {
                case "BtnMenuCustomer":
                    return EUserControl.UCCustomer;

                case "BtnMenuSupplier":
                    return EUserControl.UCSupplier;

                case "BtnMenuUser":
                    return EUserControl.UCUser;

                case "BtnMenuProduct":
                    return EUserControl.UCProduct;

                case "BtnMenuGategory":
                    return EUserControl.UCGategory;

                case "BtnMenuUnit":
                    return EUserControl.UCUnit;

                case "BtnMenuStore":
                    return EUserControl.UCStore;

                case "BtnMenuPurchasing":
                    return EUserControl.UCPurchasing;

                case "BtnMenuSales":
                    return EUserControl.UCSales;

                case "1":
                    return EUserControl.UCCustomer;

                case "10":
                    return EUserControl.UCCustomer;

                case "11":
                    return EUserControl.UCCustomer;

                case "12":
                    return EUserControl.UCCustomer;

                case "13":
                    return EUserControl.UCCustomer;

                case "14":
                    return EUserControl.UCCustomer;

                default: return EUserControl.UCUser;

            }
        }
    }
}
