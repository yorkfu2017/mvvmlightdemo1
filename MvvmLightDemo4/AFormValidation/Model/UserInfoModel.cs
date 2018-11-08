using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft;
using GalaSoft.MvvmLight;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MVVMLightDemo4.AfromValidation.Common;



namespace MvvmLightDemo4.AFormValidation.Model
{
  public  class UserInfoModel : ValidateModelBase
    { 
        private string userName;
        [@RequiredAttribute]
        //[Required]
       
        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName);   }
        }
        private Int64 userPhone;

        public Int64 UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; RaisePropertyChanged(() => userPhone); }
        }
        private Int32 userSex;

        public Int32 UserSex
        {
            get { return userSex; }
            set { userSex = value; RaisePropertyChanged(() => UserSex); }
        }

        private string userAdd;

        public string UserAdd
        {
            get { return userAdd; }
            set { userAdd = value; RaisePropertyChanged(() => UserAdd); }
        }

       
    }
}
