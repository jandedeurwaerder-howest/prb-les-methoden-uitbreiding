using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.Methods.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ShowCountry();
        }
        private void BtnShowCountry_Click(object sender, RoutedEventArgs e)
        {
            string country = "Canada";
            ShowCountry(country);
        }



        private void ShowCountry(string country)
        {
            MessageBox.Show("Het land is " + country);
        }
    }
}
