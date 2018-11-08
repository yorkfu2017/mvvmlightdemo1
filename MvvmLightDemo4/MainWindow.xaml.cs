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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MvvmLightDemo4.View;
using MvvmLightDemo4.AModelBinding.Model;
using MvvmLightDemo4.AModelBinding.View;
using MvvmLightDemo4.AFormValidation.View;

namespace MvvmLightDemo4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            View.WelcomeView welcomeWindow = new WelcomeView();
            welcomeWindow.Show();
        }

        private void button1_BothWayBingding(object sender, RoutedEventArgs e)
        {
            BothWayBindingView bothWayBindingView = new BothWayBindingView();
            bothWayBindingView.Show();
        }

        private void button1_FormValidation(object sender, RoutedEventArgs e)
        {
            FormValidate formvalidate = new FormValidate();
            formvalidate.Show();
        }
    }
}
