using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft;
using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace MvvmLightDemo4.Model
{
  public  class WelcomeModel:ObservableObject 
    {
# region 我们如果是继承原始类的时候,往往如下实现  这个应该是wpf的底层机制，就是和binding对应的绑定有关，后台数据修改了，保证前端数据同步
        //我们如果是继承原始类的时候，往往如下实现
      /*  public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private string FirstName;

        public string _FirstName
        {
            get { return FirstName; }
            set
            {
                if (value == FirstName) { return; }
                FirstName = value;
                OnPropertyRaised("_FirstName");

            }

        }
        */
        #endregion


        private string introduction;
        public string Introduction
        {

            get { return introduction; }
            set { introduction = value;
                RaisePropertyChanged(() => Introduction); }
        }
    }
}
