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
using System.IO;

namespace StandaloneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //calling the class
        Buy buy = new Buy();

        //calls the class
        Declarations Alex = new Declarations();

        //textbox pass from rent class to mainwindow class
        Rent R = new Rent();

        //textbox value passes from homeloan form
        HomeLoan loan = new HomeLoan();

        //textbox value passes from BuyAVehicle form to main form
        BuyAVehicle BuyAVehicle = new BuyAVehicle();

        //savings value passes from savings form to main form
        Savings Savings = new Savings();
        public MainWindow()
        {
            InitializeComponent();
           
           
           


        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
              {
           
           
            

               
            Alex.Income = Convert.ToDouble(txtSalary.Text);
            Alex.Tax = Convert.ToDouble(txtTax.Text);
            Alex.Groceries = Convert.ToDouble(txtGroceries.Text);
            Alex.Water = Convert.ToDouble(txtWater.Text);
            Alex.Travelling = Convert.ToDouble(txtTravel.Text);
            Alex.Cell_phone = Convert.ToDouble(txtCell.Text);
            Alex.Other = Convert.ToDouble(txtOther.Text);

            Alex.Ta = Alex.Income / 100 * Alex.Tax; //calculations that calculate Tax deduction
            Alex.Cal = Alex.Income - Alex.Ta; //calculations that subract tax from income entered by user
            Alex.Groce = Alex.Cal - Alex.Groceries;
            Alex.Light = Alex.Groce - Alex.Water;
            Alex.Travel = Alex.Light - Alex.Travelling;
            Alex.Cell = Alex.Travel - Alex.Cell_phone;
            Alex.Other_ex = Alex.Cell - Alex.Other;
            //Rental pass from Rent class
            //textbox value from user input {Rent form} will be displayed on the main form
            Alex.Rental = R.Rentals;
            Alex.Rent = Alex.Other_ex - Alex.Rental;


            //the following calculates the home loan
            Alex.Purchase_prop = loan.Purchase;
            Alex.Total_dep = loan.Deposit;
            Alex.Price = Alex.Purchase_prop - Alex.Total_dep;

            //purchase price * interest rate * years/months
            Alex.Interest_rate = loan.Interest;
            Alex.Rate = Alex.Interest_rate / 100;
            Alex.Loan = Alex.Price * Alex.Rate * 20;
            Alex.Months_repay = loan.Repayment;
            Alex.Months = Alex.Loan / Alex.Months_repay;

            Alex.Repay = Alex.Other_ex - Alex.Months;

            //calling vehicle class
           
           
            //values passed from buy a vehicle form and assigned to delcarations class variables
            buy.Make = BuyAVehicle.Make;
            buy.Model = BuyAVehicle.Model;
            buy.Purchase_Price = BuyAVehicle.Price;
            buy.Total_deposit = BuyAVehicle.Deposit;
            buy.Interest_rate = BuyAVehicle.Rate;
            buy.Insurance = BuyAVehicle.Insurance;

           

            //declaring variables
         
            double Del = Alex.Income / 100 * 75;


            if (btnRental.IsChecked == true && btnVehicle.IsEnabled == true)
            {

                    buy.calculations = Alex.Ta + Alex.Groceries + Alex.Water + Alex.Travelling + Alex.Cell_phone + Alex.Other + Alex.Rental + buy.insurance_premium;
                    buy.Car_Cal = buy.Purchase_Price - buy.Total_deposit;//calculations to extract deposit from the purchase price
                    buy.Loan = buy.Car_Cal / 100 * buy.Interest_rate; //interest calculated from the amount where deposit was extracted
                    buy.Cost = buy.Loan + buy.Car_Cal; // amount after the deposit amount was extracted plus interest amount added
                    buy.Monthly_cost = buy.Cost / 60; //car purchase price devided by 60 months
                    buy.insurance_premium = buy.Monthly_cost + buy.Insurance; //insurance premium added on monthly cost of the car
                    buy.Remainder = Alex.Rent - buy.insurance_premium; //the remainder of the salary

                    //outputs rental captured details and vehicle details 
                    MessageBox.Show("\nYour monthly income is R " + Alex.Income +
                            "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                            "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                            "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                            "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                            "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                            "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                            "\nAfter your Rental Amount this is the remainder of your salary R " + Alex.Rent +

                   "\nThe Model of your car is " + buy.Model + "\n" +
                   "The Make of your car is " + buy.Make + "\n" +
                   "The purchase price of the car is  R " + buy.Purchase_Price + "\n" +
                   "The deposit needed for the car is R " + buy.Total_deposit + "\n" +
                   "This is the amount after paying for the deposit  R " + buy.Car_Cal +
                   "\nThis is the total amount plus interest added R " + buy.Cost + "\n" +
                   "Here is the amount you will pay on monthly basics for the Car Plus the insurance premium R " + buy.insurance_premium + "\n" +
                   "You will pay for your car for about 60 months\n" +
                   "This is the remainder of your salary after the Monthly installment R " + buy.Remainder);

                  

                }

             if (btnHomeLoan.IsChecked == true && btnVehicle.IsEnabled == true)
            {
                    buy.calculations = Alex.Ta + Alex.Groceries + Alex.Water + Alex.Travelling + Alex.Cell_phone + Alex.Other + Alex.Repay + buy.insurance_premium;
                    buy.Car_Cal = buy.Purchase_Price - buy.Total_deposit;//calculations to extract deposit from the purchase price
                    buy.Loan = buy.Car_Cal / 100 * buy.Interest_rate; //interest calculated from the amount where deposit was extracted
                    buy.Cost = buy.Loan + buy.Car_Cal; // amount after the deposit amount was extracted plus interest amount added
                    buy.Monthly_cost = buy.Cost / 60; //car purchase price devided by 60 months
                    buy.insurance_premium = buy.Monthly_cost + buy.Insurance; //insurance premium added on monthly cost of the car
                    buy.Remainder = Alex.Repay - buy.insurance_premium;



                    //outputs homeloan and vehicle
                    MessageBox.Show("\nYour monthly income is R " + Alex.Income +
                       "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                       "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                       "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                       "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                       "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                       "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                       "\nProperty price is R " + Alex.Purchase_prop +
                       "\nDeposit of the property is R " + Alex.Total_dep + "" +
                       "\nYou will repay your home loan for a period of " + Alex.Months_repay + " \nThe monthly amount will be R " + Alex.Months +
                       "\nIf you would pay the monthly amount stated, the remainder of your salary after month repayments will be R " + Alex.Repay +
              "\nThe Model of your car is " + buy.Model + "\n" +
                            "The Make of your car is " + buy.Make + "\n" +
                            "The purchase price of the car is  R " + buy.Purchase_Price + "\n" +
                            "The deposit needed for the car is R " + buy.Total_deposit + "\n" +
                            "This is the amount after paying for the deposit  R " + buy.Car_Cal +
                            "\nThis is the total amount plus interest added R " + buy.Cost + "\n" +
                            "Here is the amount you will pay on monthly basics for the Car Plus the insurance premium R " + buy.insurance_premium + "\n" +
                            "You will pay for your car for about 60 months\n" +
                            "This is the remainder of your salary after the Monthly car installment R " + buy.Remainder);
                  


                }


                if (btnRental.IsChecked == true && btnHomeLoan.IsChecked ==false && btnVehicle.IsEnabled == false)
            {
                MessageBox.Show("\nYour monthly income is R " + Alex.Income +
                               "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                               "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                               "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                               "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                               "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                               "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                               "\nAfter your Rental Amount this is the remainder of your salary R " + Alex.Rent);
            }
            if (btnHomeLoan.IsChecked == true && btnRental.IsChecked ==false && btnVehicle.IsEnabled ==false)
            {
                MessageBox.Show("\nYour monthly income is R " + Alex.Income +
                    "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                    "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                    "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                    "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                    "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                    "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                    "\nProperty price is R " + Alex.Purchase_prop +
                    "\nDeposit of the property is R " + Alex.Total_dep + "" +
                    "\nYou will repay your home loan for a period of " + Alex.Months_repay + " \nThe monthly amount will be R " + Alex.Months +
                    "\nIf you would pay the monthly amount stated, the remainder of your salary after month repayments will be R " + Alex.Repay);
                   

                }
            else
                {
                    MessageBox.Show("Choose either Rental Accomodation or Homeloan \nNot both!!", "Error!!! \a");
                }

        
    
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
            
              

        }

        //radio button
        private void BtnRental_Checked(object sender, RoutedEventArgs e)
        {
            btnRental.IsChecked = true;
            btnHomeLoan.IsChecked = false;
            //it opens rental form
            R.Show();
           
          
          
           
        }

        //radio Button
        private void BtnHomeLoan_Checked(object sender, RoutedEventArgs e)
        {

            btnRental.IsChecked = false;
            btnHomeLoan.IsChecked = true;
            //opeing the HomeLoan form
            loan.Show();
        
        }

        private void BtnCar_Checked(object sender, RoutedEventArgs e)
        {
           
           
        }

        //button
        private void BtnVehicle_Click(object sender, RoutedEventArgs e)
        {
            //opens vehicle form
            BuyAVehicle.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void BtnSavings_Click(object sender, RoutedEventArgs e)
        {
            //calls savings form
            Savings.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //calls feature variables
            feature saving = new feature();
            //textbox pass from Savings form to main form
            saving.Months = Savings.months;
            saving.Amount = Savings.amount;
            saving.Description = Savings.description;
            saving.Rate = Savings.rate;
            


            MessageBox.Show("");
            

        }
    }
}
