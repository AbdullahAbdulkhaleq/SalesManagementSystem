using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class RecoveryPasswordPresenter
    {
        iRecoveryPassword iRecoveryPassword;
        RecoveryPasswordModel recoveryPasswordModel;
        public RecoveryPasswordPresenter(iRecoveryPassword iRecoveryPassword)
        {
            this.recoveryPasswordModel = new RecoveryPasswordModel();
            this.iRecoveryPassword = iRecoveryPassword;
        }
        private void connectedInterfaceAndModel()
        {
            this.recoveryPasswordModel.RecoveryId = this.iRecoveryPassword.RecoveryId;
            this.recoveryPasswordModel.WhatsYourFavoriteAnimal = this.iRecoveryPassword.WhatsYourFavoriteAnimal;
            this.recoveryPasswordModel.WhatsYourFavoriteHobby = this.iRecoveryPassword.WhatsYourFavoriteHobby;
            this.recoveryPasswordModel.WhatsIsayourBestCity = this.iRecoveryPassword.WhatsIsayourBestCity;
        }
        public int Insert()
        {
            connectedInterfaceAndModel();
            return RecoveryPasswordServices.Insert(this.recoveryPasswordModel);
        }

    }
}
