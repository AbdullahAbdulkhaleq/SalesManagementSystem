using System.Windows;
using SalesManagementSystem.Views.Enum;
using SalesManagementSystem.Views.UI.Designer;

namespace SalesManagementSystem.Views.Functions
{
    public class FunMessage
    {
        private static FMessage Messages = null;
        public static void Print()
        {
            Print(false, "يرجاء أضافة جميع البيانات");

        }
        public static void Print(int ErrorNumber, string Message = "")
        {
            Messages = new FMessage();
            EErrorMessage Error = GetMessageType(ErrorNumber);
            switch (Error)
            {
                case EErrorMessage.ThereAreNoErrors:
                    Messages.show($"Wolcom {Message}", $"Wolcom!", Properties.Resources.Info);
                    break;
                case EErrorMessage.ErrorNotInsert:
                    Messages.show($"Error NotInsert", $"Error {Message} !", Properties.Resources.Close);
                    break;
                case EErrorMessage.ErrorNotAvailableQuantity:
                    Messages.show($"ErrorNotPresent", $"Error {Message} !", Properties.Resources.Close);
                    break;
                case EErrorMessage.ErrorNotFound:
                    Messages.show($"ErrorInvalid", $"Error {Message} !", Properties.Resources.Close);
                    break;
                case EErrorMessage.ErrorNotDeleted:
                    Messages.show($"ErrorInvalidValue", $"Error {Message} !", Properties.Resources.Close);
                    break;
                case EErrorMessage.ErrorNotUpdated:
                    Messages.show($"ErrorInvalidType", $"Error {Message} !", Properties.Resources.Close);
                    break;
                case EErrorMessage.ErrorInvalidValueType:
                    Messages.show($"ErrorInvalidValueType", $"Error {Message} !", Properties.Resources.Close);
                    break;
                /*                case EErrorMessage.ErrorBlockUser:
                                    MessageBox.Show("ErrorBlockUser", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                                    break;
                                case EErrorMessage.ErrorBlockGroup:
                                    MessageBox.Show("ErrorBlockUser", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                                    break;*/

                default:
                    Messages.show($"UnknownError", $"Error {Message} !", Properties.Resources.Close);
                    break;

            }
            Messages.Show();
        }

        public static void Print(bool Status, string Message)
        {
            Messages = new FMessage();
            if (Status)
            {
                Messages.show(Message);
            }
            else
            {
                Messages.show($" {Message}", "Error", Properties.Resources.Close);
            }

            Messages.Show();
        }
        public static void Print(string Message, string Caption, bool status = true)
        {

            Print(false, "يرجاء أضافة جميع البيانات");

        }

        public static EErrorMessage GetMessageType(int ErrorNumber)
        {
            switch(ErrorNumber)
            {
                case 1:
                    return EErrorMessage.ThereAreNoErrors;

                case 2:
                    return EErrorMessage.ErrorNotInsert;


                case 3:
                    return EErrorMessage.ErrorNotAvailableQuantity;

                    
                case 4:
                    return EErrorMessage.ErrorNotFound;


                case 5:
                    return EErrorMessage.ErrorNotDeleted;
    

                case 6:
                    return EErrorMessage.ErrorNotUpdated;
      

                case 7:
                    return EErrorMessage.ErrorInvalidValueType;
      

 /*               case 8:
                    return EErrorMessage.ErrorBlockUser;
    

                case 9:
                    return EErrorMessage.ErrorBlockGroup;*/
    

                default:
                    return EErrorMessage.UnknownError;
            }
        }
    }
}
