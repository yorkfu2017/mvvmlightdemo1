using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using MvvmLightDemo4.Model;
using System.Threading.Tasks;

namespace MvvmLightDemo4.ViewModel
{
   public class WelcomeViewModel:ViewModelBase
    {
        public WelcomeViewModel()

        {
             Welcome = new WelcomeModel() { Introduction = "Hello  " };
        }
        #region 属性 
        private WelcomeModel welcome;
        public WelcomeModel Welcome
        {
            get { return welcome; }
            set { welcome = value;RaisePropertyChanged(()=>Welcome); }
        }
        #endregion
    }
}
