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
    /// Interaction logic for VehicleWindow.xaml
    /// </summary>
    public partial class VehicleWindow : Window
    {
        public VehicleWindow()
        {
            InitializeComponent();
        }

        //Variables
        string make = "N/A";
        string model = "N/A";
        double vehiclePurchasePrice = 0;
        double vehicleTotalDeposit = 0;
        double vehicleInterestRate = 0;
        double vehicleInsurance = 0;
        double vehicleRepaymentAmount = 0;
        double vehicleTotalAmountDue = 0;

        //Vehicle class object
        Vehicle myCar = new Vehicle();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtMake.Text != "" || txtModel.Text != "")
            {
                //Storing the make and model
                make = txtMake.Text;
                model = txtModel.Text;

                //Display to the label
                lblMakeModel.Content = make + " - " + model;
            }
            else
            {
                MessageBox.Show("Please enter the make and model");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Check the input from the user and store it in the local variable
            try
            {
                //Storing 
                vehiclePurchasePrice = double.Parse(txtVehiclePurchasePrice.Text);

                //Show it on the label
                lblVehiclePurchasePrice.Content = "R" + vehiclePurchasePrice;
                lblVehiclePurchasePrice.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch (Exception)
            {
                //Display to the label that the value is invalid
                lblVehiclePurchasePrice.Content = "INVALID";
                lblVehiclePurchasePrice.Foreground = new SolidColorBrush(Colors.Red);
            }

            //Check the input from the user and store it in the local variable
            try
            {
                //Storing 
                vehicleTotalDeposit = double.Parse(txtVehicleDeposit.Text);

                //Show it on the label
                lblVehicleDeposit.Content = "R" + vehicleTotalDeposit;
                lblVehicleDeposit.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch (Exception)
            {
                //Display to the label that the value is invalid
                lblVehicleDeposit.Content = "INVALID";
                lblVehicleDeposit.Foreground = new SolidColorBrush(Colors.Red);
            }

            //Check the input from the user and store it in the local variable
            try
            {
                //Storing 
                vehicleInterestRate = double.Parse(txtVehicleInsurance.Text);

                //Show it on the label
                lblVehicleInterestRate.Content = "R" + vehicleInterestRate;
                lblVehicleInterestRate.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch (Exception)
            {
                //Display to the label that the value is invalid
                lblVehicleInterestRate.Content = "INVALID";
                lblVehicleInterestRate.Foreground = new SolidColorBrush(Colors.Red);
            }

            //Check the input from the user and store it in the local variable
            try
            {
                //Storing 
                vehicleInsurance = double.Parse(txtVehicleInsurance.Text);

                //Show it on the label
                lblVehicleInsurance.Content = "R" + vehicleInsurance;
                lblVehicleInsurance.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch (Exception)
            {
                //Display to the label that the value is invalid
                lblVehicleInsurance.Content = "INVALID";
                lblVehicleInsurance.Foreground = new SolidColorBrush(Colors.Red);
            }

        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Storing the values from the textboxes in the variables
            vehiclePurchasePrice = double.Parse(txtVehiclePurchasePrice.Text);
            vehicleTotalDeposit = double.Parse(txtVehicleDeposit.Text);
            vehicleInterestRate = double.Parse(txtVehicleInterestRate.Text);
            vehicleInsurance = double.Parse(txtVehicleInsurance.Text);

            //Calculate monthly repayment
            vehicleTotalAmountDue = vehiclePurchasePrice * (1 + (vehicleInterestRate / 100) * (5));

            //Monthly Repayment
            vehicleRepaymentAmount = vehicleTotalAmountDue / 60;

            //Display to the user using the label
            //Repayment
            lblMonthlyRepayment.Content = "R" + vehicleRepaymentAmount;
            //Purchase Price
            lblVehiclePurchasePrice.Content = "R" + vehiclePurchasePrice;
            //Total Deposit
            lblVehicleDeposit.Content = "R" + vehicleTotalDeposit;
            //Interest Rate
            lblVehicleInterestRate.Content = vehicleInterestRate + "%";
            //Insurance
            lblVehicleInsurance.Content = "R" + vehicleInsurance;

            

            //Store it in the list
            myCar.addExpensedouble(vehicleRepaymentAmount + vehicleInsurance);

            //Making the button active again
            btnProcced.IsEnabled = true;

        }

        private void TxtProcced_Click(object sender, RoutedEventArgs e)
        {
            //Object of the savings window
            SavingsWindow mySavings = new SavingsWindow();

            //Displaying the savings window
            mySavings.Show();

            //Hiding the current window
            this.Hide();
        }
    }
}
