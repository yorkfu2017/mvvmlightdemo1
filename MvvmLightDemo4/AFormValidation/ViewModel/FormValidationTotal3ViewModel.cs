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
    public class FormValidationTotal3ViewModel : ViewModelBase
    {

        private FormValidationTotal3Model vformValidationTotal3Model;
        public FormValidationTotal3Model VformValidationTotal3Model
        {
            get { return vformValidationTotal3Model; }
            set
            {
                vformValidationTotal3Model = value;
                RaisePropertyChanged(() => VformValidationTotal3Model);
                //if (string.IsNullOrEmpty(vformValidationTotal3Model.Name))
                //{
                //    throw new ApplicationException("该字段不能为空");
                //}
            }
        }

//==================================================================================================================================================
        //private String userNameEx;
        ///// <summary>
        ///// 用户名称（不为空）
        ///// </summary>
        //public string UserNameEx
        //{
        //    get
        //    {
        //        return userNameEx;
        //    }
        //    set
        //    {
        //        userNameEx = value;
        //        RaisePropertyChanged(() => UserNameEx);
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new ApplicationException("该字段不能为空！");
        //        }
        //    }
        //}
//==================================================================================================================================================


        public FormValidationTotal3ViewModel()
        {
            VformValidationTotal3Model = new FormValidationTotal3Model();
        }

    }
}
