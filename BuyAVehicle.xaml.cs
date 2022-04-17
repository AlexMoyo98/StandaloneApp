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
    /// Interaction logic for BuyAVehicle.xaml
    /// </summary>
    public partial class BuyAVehicle : Window
    {
        public string Make;
        public string Model;
        public double Price;
        public double Deposit;
        public double Rate;
        public double Insurance;
        public BuyAVehicle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          Make =Convert.ToString(txtCarMake.Text);
           Model =Convert.ToString(txtCarModel.Text);
           Price = Convert.ToDouble(txtCarPrice.Text);
           Deposit = Convert.ToDouble(txtCarDeposit.Text);
           Rate = Convert.ToDouble(txtCarRate.Text);
           Insurance = Convert.ToDouble(txtInsurance.Text);
            MessageBox.Show("Your Buy A Vehicle details have been captured /a");
            this.Close();
        }
    }
}
