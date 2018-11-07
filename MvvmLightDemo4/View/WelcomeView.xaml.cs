using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MvvmLightDemo4.ViewModel;

namespace MvvmLightDemo4.View
{
    /// <summary>
    /// WelcomeView.xaml 的交互逻辑
    /// </summary>
    public partial class WelcomeView : Window
    {
        public WelcomeView()
        {
            InitializeComponent();
            //this.DataContext = new WelcomeViewModel();
            //   DataContext = "{ Binding Source ={StaticResource Locator},Path=welcomeviewmodel } 
           
        }
    }
}
