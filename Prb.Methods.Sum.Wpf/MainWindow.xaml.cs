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

namespace Prb.Methods.Sum.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int sum;


        int CalculateSum(int numberOne, int numberTwo)
        {
            sum = numberOne + numberTwo;
            return sum;
        }
        int CalculateSum(string numberOneText, string numberTwoText)
        {
            int numberOne = int.Parse(numberOneText);
            int numberTwo = int.Parse(numberTwoText);
            sum = numberOne + numberTwo;
            return sum;
        }
        int CulculateSum(int een, string twee)
        {
            return een + int.Parse(twee);
        }

        void ScopeTest()
        {
            MessageBox.Show("De som was : " + sum);
            
        }
        private void btnCalculateSum_Click(object sender, RoutedEventArgs e)
        {
            string leftNumber = txtLeftNumber.Text;
            string rightNumber = txtRightNumber.Text;

            //sum = CalculateSum(txtLeftNumber.Text, txtRightNumber.Text);

            sum = CalculateSum(leftNumber, rightNumber);
            MessageBox.Show("De som van " 
                + leftNumber 
                + " en " 
                + rightNumber 
                + " is " 
                + sum, 
                "Som berekenen");

        }
    }
}
