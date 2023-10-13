using System.Windows;
using SalesManagementSystem.Views.Enum;

namespace SalesManagementSystem.Views.Functions
{
    public class FMessage
    {
        public static void Print(string Message ="")
        {
            MessageBox.Show($"Place Enter {Message}");
        }
        public static void Print(int ErrorNumber, string Message = "")
        {
            EErrorMessage Error = GetError(ErrorNumber);
            switch (Error)
            {
                case EErrorMessage.ThereAreNoErrors:
                    MessageBox.Show($"Wolcom {Message}"," Wolcom ", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorNotInsert:
                    MessageBox.Show("ErrorNotFound", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorNotAvailableQuantity:
                    MessageBox.Show("ErrorNotPresent", $"Error {Message}  !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorNotFound:
                    MessageBox.Show("ErrorInvalid", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorNotDeleted:
                    MessageBox.Show("ErrorInvalidValue!", $"Error {Message} ", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorNotUpdated:
                    MessageBox.Show("ErrorInvalidType", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorInvalidValueType:
                    MessageBox.Show("ErrorInvalidValueType", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
/*                case EErrorMessage.ErrorBlockUser:
                    MessageBox.Show("ErrorBlockUser", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
                case EErrorMessage.ErrorBlockGroup:
                    MessageBox.Show("ErrorBlockUser", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;*/

                default: 
                    MessageBox.Show("UnknownError", $"Error {Message} !", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;


            }
        }

        private static EErrorMessage GetError(int ErrorNumber)
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
