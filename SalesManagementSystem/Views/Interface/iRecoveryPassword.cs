using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Views.Interface
{
    public interface iRecoveryPassword
    {
        int RecoveryId { get; set; }
        int UserId { get; set; }
        string WhatsYourFavoriteAnimal { get; set; }
        string WhatsIsayourBestCity { get; set; }
        string WhatsYourFavoriteHobby { get; set; }
    }
}
