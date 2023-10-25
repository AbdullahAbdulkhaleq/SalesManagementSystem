using SalesManagementSystem.Views.Enum;
using SalesManagementSystem.Views.UI;
using SalesManagementSystem.Views.UI.Access;
using SalesManagementSystem.Views.UI.Designer;
using SalesManagementSystem.Views.UI.Purchasing;
using SalesManagementSystem.Views.UI.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.Functions
{
    public class FunLogin
    {
        public static FDMain Login(int Login)
        {
            return  FormsLogin(LoginType(Login));
        }
        //هذه الدالة بتحدد نواع المستخدم ان وجد على حسب المتغير الراجع من قاعدة البيانات 
        private static  ELogin LoginType(int Login)
        {
            switch (Login)
            {
                case 0:
                    return ELogin.LoginError;

                case 1:
                    return ELogin.LoginAdmin;

                case 2:
                    return ELogin.LoginSales;

                case 3:
                    return ELogin.LoginPurchasing;

                case 4:
                    return ELogin.LoginInventory;

                case 5:
                    return ELogin.LoginBlock;

                case 40404:
                    return ELogin.LoginErrorInLog;

                default:
                    return ELogin.LoginNotFound;
            }
        }
        //هذه الدالة سترجع فورم المطلوب على حسب نواع التسجبل ام ادمن او مبيعات او الخ...
        private static FDMain FormsLogin(ELogin Login)
        {
            switch(Login)
            {
                case ELogin.LoginError:
                    return null;

                case ELogin.LoginAdmin:
                    return new FHomeAdmin();

                case ELogin.LoginSales:
                    return new FHomeSales();

                case ELogin.LoginPurchasing:
                    return new FHomePurchasing();

                case ELogin.LoginInventory:
                    return new FHomeInventory();

                case ELogin.LoginBlock:
                    return new FError("المعذرة هذه المستخدم محظور");

                case ELogin.LoginErrorInLog:
                    return new FError("يوجد خطاء في تسجيل الدخول يرجاء  التأكد من الاتصال ");

                default:
                    return null;
            }
        }
    }
}