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

namespace Prb.Methods.Vat.Wpf
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbVAT.Items.Add(6);
            cmbVAT.Items.Add(12);
            cmbVAT.Items.Add(21);
            cmbVAT.SelectedIndex = 2;
        }


        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(txtPriceExcl.Text, out decimal netAmount);
            float vat = float.Parse( cmbVAT.SelectedItem.ToString());
            tbkCalculation.Text = MakeReport(netAmount, vat);
        }
        /// <summary>
        /// Berekent het BTW bedrag
        /// </summary>
        /// <param name="netAmount"></param>
        /// <param name="vatTarif"></param>
        /// <returns>Het berekende BTW bedrag</returns>
        decimal CalculateVATAmount(decimal netAmount, float vatTarif)
        {
            decimal vatAmount = netAmount * (decimal)vatTarif / 100;
            return vatAmount;
        }

        decimal CalculateTotalAmount(decimal netAmount, float vatTarif)
        {
            decimal totalAmount = 
                netAmount + CalculateVATAmount(netAmount, vatTarif);
            return totalAmount;
        }
        string MakeReport(decimal netAmount, float vatTarif)
        {
            string report = $"BTW excl.\t€ {netAmount.ToString("#,##0.00")}\n";
            report += $"BTW tarief \t{vatTarif} %\n";
            decimal vatAmount = CalculateVATAmount(netAmount, vatTarif);
            report += $"BTW bedrag \t€ {vatAmount.ToString("#,##0.00")}\n";
            decimal totalAmount = CalculateTotalAmount(netAmount, vatTarif);
            report += $"BTW incl.\t€{totalAmount.ToString("#,##00.00")}";
            return report;
        }

        private void cmbVAT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbkCalculation.Text = "";
        }
    }
}
