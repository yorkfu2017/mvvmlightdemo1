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
   public class FormValidationTotal3ViewModel:ViewModelBase
    {
       
        private FormValidationTotal3Model vformValidationTotal3Model;
        public FormValidationTotal3Model VformValidationTotal3Model
        {
            get { return vformValidationTotal3Model; }
            set { vformValidationTotal3Model = value; RaisePropertyChanged(() => VformValidationTotal3Model); }
        }
        public FormValidationTotal3ViewModel()
        {
            VformValidationTotal3Model = new FormValidationTotal3Model();
        }

    }
}
