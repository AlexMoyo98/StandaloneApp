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
using System.Windows.Shapes;

namespace StandaloneApp
{
    /// <summary>
    /// Interaction logic for HomeLoan.xaml
    /// </summary>
    public partial class HomeLoan : Window
    {
        public double Purchase;
        public double Deposit;
        public double Interest;
        public double Repayment;
        public HomeLoan()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
         Purchase = Convert.ToDouble(txtPurPrice.Text);
         Deposit = Convert.ToDouble(txtDepositHome.Text);
           Interest = Convert.ToDouble(txtInterestRate.Text);
           Repayment = Convert.ToDouble(txtRepay.Text);
            MessageBox.Show("HomeLoan details saved \a");
            this.Close();
        }
    }
}
