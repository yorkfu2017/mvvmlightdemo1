using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using MvvmLightDemo4.Model;
using System.Threading.Tasks;
using MvvmLightDemo4.AFormValidation.Model;
namespace MvvmLightDemo4.AFormValidation.ViewModel
{
    
    public class FormValidateViewModel : ViewModelBase
    {
        #region 属性
        private UserInfoModel userInfo;
        public UserInfoModel UserInfo
        {
            get { return userInfo; }
            set { userInfo = value;RaisePropertyChanged(()=>UserInfo); }

        }
        #endregion
        public FormValidateViewModel()

        {
            UserInfo = new UserInfoModel();
            //UserInfo.UserName = "york";
        }

    }
}
