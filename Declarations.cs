using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StandaloneApp
{
    //main class will inherit the abstract class ever since calling the abstract class will result in an error 
    class Declarations : Expense //base class (parent)
    {
        //constructor
        public Declarations()
        {

        }
        //declaration for user input
        public double Income { get; set; }
        public double Tax { get; set; }

        //delarations for the expenditures 
        public double Groceries { get; set; }
        public double Water { get; set; }
        public double Travelling { get; set; }
        public double Cell_phone { get; set; }
        public double Other { get; set; }

        //stores expenses into array
        public double[] Store = new double[8];
        //stores all the lists 
        public List<double> Vehicle = new List<double>();

        // option for condition on rental and buying a property
        public int Option { get; set; }
        public double Rent { get; set; }
        public int Choose { get; set; }
    }
    //buy a vehicle class
    class Buy
    {
        //constructor
        public Buy()
        {

        }
        //buy a vehicle declarations
        public string Model { get; set; }//the car model i.e G wagon or A class AMG
        public string Make { get; set; } //The car name 
        public double Purchase_Price { get; set; }//purchase price of the car / value
        public double Total_deposit { get; set; }//deposit of the car
        public double Interest_rate { get; set; } //percentage
        public double Insurance { get; set; } //declarations to calculate insurance premium
        public double calculations { get; set; }//declaration to calculate all the expenses
        public double Car_Cal { get; set; } // it will be used to calculate car deposit
        public double Loan { get; set; }//to calculate loan
        public double Cost { get; set; }//calculations
        public double Monthly_cost { get; set; } //to calculare the monthly amount for the car / repayment months
        public double insurance_premium { get; set; } //to calculate the insurance premium
        public double Remainder { get; set; } //calculates the remainder of the salary after monlthy installment from salary
    }

    //delegate class
    public class TestDelegate
    {
        //Creating delegation with no parameters and no return type.
        public delegate void Delegate();
        public void Greater()
        {
           MessageBox.Show("\nYour Expenses are greater than 75% of your Income!!!!!!!!! \a");
        }
    }

    abstract class Expense //derived class (child)
    {
        //constructor
        public Expense()
        {

        }
        //abstract peroperties

        // declaration for the rental amount 
        public double Rental { get; set; }

        //declaration for buying a propery
        public double Purchase_prop { get; set; }
        public double Total_dep { get; set; }
        public double Interest_rate { get; set; }
        public double Months_repay { get; set; }


        //Declaration to calculate tax
        public double Ta { get; set; }
        public double Cal { get; set; }

        //declaration to subtract from income 
        public double Groce { get; set; }
        public double Light { get; set; }
        public double Travel { get; set; }
        public double Cell { get; set; }
        public double Other_ex { get; set; }


        //declaration to calculate home loan
        public double Price { get; set; }
        public double Dep { get; set; }
        public double Rate { get; set; }
        public double Loan { get; set; }
        public double Repay { get; set; }
        public double Months { get; set; }
        public double Tot { get; set; }
 }
    //new feature class
   public class feature
    {
        public double Months;
        public double Amount;
        public string Description;
        public double Rate;

        //savings calculations 
        public double M;
        public double A;
        public string D;
        public double R;

    }

}
