using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Models
{
    public class RecoveryPasswordModel
    {
        public int RecoveryId { get; set; }
        public int UserId { get; set; }
        public string WhatsYourFavoriteAnimal { get; set; }
        public string WhatsIsayourBestCity { get; set; }
        public string WhatsYourFavoriteHobby { get; set; }
    }
}
