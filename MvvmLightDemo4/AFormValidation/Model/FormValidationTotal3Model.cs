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
    public class FormValidationTotal3Model : ObservableObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                
                name = value; RaisePropertyChanged(() => Name);
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("该字段不能为空");
                }
            }
        }

        private string name1;

        public string Name1
        {
            get { return name1; }
            set
            {

                name1 = value; RaisePropertyChanged(() => Name1);
             
            }
        }
        private Int64 phone;

        public Int64 Phone
        {
            get { return phone; }
            set { phone = value; RaisePropertyChanged(() => phone); }
        }
        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; RaisePropertyChanged(() => age); }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; RaisePropertyChanged(() => address); }
        }


    }
}
