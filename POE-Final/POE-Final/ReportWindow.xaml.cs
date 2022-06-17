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

namespace POE_Final
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        //Object that relates to Expenses class
        HomeLoan myObject = new HomeLoan();

        //Object containing the salary
        Salary mySalary = new Salary();

        //Object from vehicle
        Vehicle myCar = new Vehicle();
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Gross
            lblGrossIncome.Content = "R" + mySalary.getGrossSalary();

            //Tax Deductions
            lblTaxDeductions.Content = "R" + myObject.getNewExpense(0);

            //Groceries
            lblGroceries.Content = "R" + myObject.getNewExpense(1);

            //Water and Lights
            lblWaterAndElectricity.Content = "R" + myObject.getNewExpense(2);            

            //Cellphone and telephone
            lblCellphone.Content = "R" + myObject.getNewExpense(3);

            //Transport
            lblTransport.Content = "R" + myObject.getNewExpense(4);

            //Other Expenses
            lblOtherExpenses.Content = "R" + myObject.getNewExpense(5);

            //Property
            lblPropertyAmount.Content = "R" + myObject.getNewExpense(6);

            //Vehicle
            if (myCar.getBuying())
            {
                //Label
                lblVehicleMessage.Content = "Monthly repayment due for vehicle";

                //Display the amount
                lblVehicleAmount.Content = "R" + Convert.ToString(myCar.getNewExpense(7));
            }
            else
            {
                lblVehicleMessage.Content = "User is not buying a car";
                lblVehicleAmount.Content = "N/A";
            }

            //Savings
            if (myCar.getBuying())
            {
                lblSavingsAmount.Content = "R" + myCar.getNewExpense(8);
            }
            else
            {
                lblSavingsAmount.Content = "R" + myCar.getNewExpense(7);
            }

            //Net Salary
            lblNetSalary.Content = "R" + (mySalary.getGrossSalary() - myCar.getTotalExpense());


        }
    }
}
