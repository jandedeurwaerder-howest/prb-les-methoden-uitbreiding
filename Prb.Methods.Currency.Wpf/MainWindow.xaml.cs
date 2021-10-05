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

namespace Prb.Methods.Currency.Wpf
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            tblEuro.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text);
            tblDollar.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text, txtExchange.Text, "Dollar");

            string x = GenerateReport(txtNetEuro.Text, txtVAT.Text, "1", "BF");
        
        }
        private string GenerateReport(string netInText, string vatInText,
            string exhangeRateInText = "1", string currency = "Euro")
        {
            decimal net = decimal.Parse(netInText);
            decimal vat = decimal.Parse(vatInText);
            decimal exchangeRate = decimal.Parse(exhangeRateInText);

            net = net * exchangeRate;
            decimal vatTotal = net * (vat / 100);
            decimal totalAmount = net + vatTotal;

            string report;
            //report = "Netto bedrag = " + net.ToString("#,##0.00") + "\n";
            report = $"Netto bedrag = {net.ToString("#,##0.00")} {currency}\n";
            report += $"BTW {vat.ToString("#,##0.00")}% = {vatTotal.ToString("#,##0.00")} {currency}\n";
            report += $"Totaal bedrag = {totalAmount.ToString("#,##0.00")} {currency}";
            return report;
        }
    }
}
