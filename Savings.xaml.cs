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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        //savings declarations
        public double months;
        public double amount;
        public string description;
        public double rate;

        public Savings()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            months = Convert.ToDouble(txtMonths.Text);
            amount = Convert.ToDouble(txtSavings.Text);
            description = Convert.ToString(txtDescription.Text);
            rate = Convert.ToDouble(txtInterest.Text);
            MessageBox.Show("Your Savings have been saved");
            this.Close();
        }
    }
}
