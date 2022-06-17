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
    /// Interaction logic for PropertyWindow.xaml
    /// </summary>
    public partial class PropertyWindow : Window
    {
        public PropertyWindow()
        {
            InitializeComponent();
        }

        //Object homeloan
        HomeLoan myObject = new HomeLoan();

        //Variables used for storing the rental amount
        double rentalAmount = 0;

        //Variables used for storing the Property amounts
        double propertyPurchasePriceAmount = 0;
        double propertyTotalDepositAmount = 0;
        double propertyInterestRate = 0;
        int propertyNumberOfMonths = 0;
        double totalAmountDue = 0;
        double monthlyRepaymentAmount = 0;

        //Control variable to check what the user choose
        string propertyOption = "none";

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void BtnRent_Click(object sender, RoutedEventArgs e)
        {
            //Change the control variable 
            propertyOption = "rent";

            //Making the rental items visible
            lblRentAmount.Visibility = Visibility.Visible;
            txtRentalAmount.Visibility = Visibility.Visible;

            //Making the buying items invisible
            lblPropertyPriceAmount.Visibility = Visibility.Hidden;
            lblPropertyDepositAmount.Visibility = Visibility.Hidden;
            lblPropertyInterestRate.Visibility = Visibility.Hidden;
            lblPropertyNumberOfMonths.Visibility = Visibility.Hidden;

            txtPropertyPriceAmount.Visibility = Visibility.Hidden;
            txtPropertyDepositAmount.Visibility = Visibility.Hidden;
            txtPropertyInterestRate.Visibility = Visibility.Hidden;
            txtPropertyNumberOfMonths.Visibility = Visibility.Hidden;

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            //Change the control 
            propertyOption = "buy";

            //Making the rental items invisible
            lblRentAmount.Visibility = Visibility.Hidden;
            txtRentalAmount.Visibility = Visibility.Hidden;

            //Making the buying items visible
            lblPropertyPriceAmount.Visibility = Visibility.Visible;
            lblPropertyDepositAmount.Visibility = Visibility.Visible;
            lblPropertyInterestRate.Visibility = Visibility.Visible;
            lblPropertyNumberOfMonths.Visibility = Visibility.Visible;

            txtPropertyPriceAmount.Visibility = Visibility.Visible;
            txtPropertyDepositAmount.Visibility = Visibility.Visible;
            txtPropertyInterestRate.Visibility = Visibility.Visible;
            txtPropertyNumberOfMonths.Visibility = Visibility.Visible;
        }

        private void TxtRentalAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code when the textbox is not empty
            if (txtRentalAmount.Text != "")
            {
                //Data validation that the input is valid
                try
                {
                    //Storing the rental amount variable
                    rentalAmount = double.Parse(txtRentalAmount.Text);

                    //Making the error message invisible 
                    lblErrorLabel.Visibility = Visibility.Hidden;
                }
                catch (Exception)
                {
                    //Showing to the user that they entered an invalid value
                    lblErrorLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void TxtPropertyPriceAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code when the textbox is not empty
            if (txtPropertyPriceAmount.Text != "")
            {
                //Data validation that the input is valid
                try
                {
                    //Storing the Purchase Price amount variable
                    propertyPurchasePriceAmount = double.Parse(txtPropertyPriceAmount.Text);

                    //Making the error message invisible 
                    lblErrorLabel.Visibility = Visibility.Hidden;
                }
                catch (Exception)
                {
                    //Showing to the user that they entered an invalid value
                    lblErrorLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void TxtPropertyDepositAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code when the textbox is not empty
            if (txtPropertyDepositAmount.Text != "")
            {
                //Data validation that the input is valid
                try
                {
                    //Storing the Total Deposit amount variable
                    propertyTotalDepositAmount = double.Parse(txtPropertyDepositAmount.Text);

                    //Making the error message invisible 
                    lblErrorLabel.Visibility = Visibility.Hidden;
                }
                catch (Exception)
                {
                    //Showing to the user that they entered an invalid value
                    lblErrorLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void TxtPropertyInterestRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code when the textbox is not empty
            if (txtPropertyInterestRate.Text != "")
            {
                //Data validation that the input is valid
                try
                {
                    //Storing the Interest Rate amount variable
                    propertyInterestRate = double.Parse(txtPropertyInterestRate.Text);                    

                    //Cheking if the interest rate is between 0 and 100
                    if (propertyInterestRate >= 0 && propertyInterestRate <= 100)
                    {
                        //Making the error message invisible 
                        lblErrorLabel.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        //Error Message for the user
                        MessageBox.Show("Please insert a value that ranges between 0 and 100");
                        txtPropertyInterestRate.Text = "";
                    }

                }
                catch (Exception)
                {
                    //Showing to the user that they entered an invalid value
                    lblErrorLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void TxtPropertyNumberOfMonths_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code when the textbox is not empty
            if (txtPropertyNumberOfMonths.Text != "")
            {
                //Data validation that the input is valid
                try
                {
                    //Storing the Number of Months amount variable
                    propertyNumberOfMonths = int.Parse(txtPropertyNumberOfMonths.Text);

                    //Validating that the number of months is 240-360
                    if (propertyNumberOfMonths >= 240 && propertyNumberOfMonths <= 360)
                    {
                        //Making the error message invisible 
                        lblErrorLabel.Visibility = Visibility.Hidden;

                        //Changing the label to black
                        lblPropertyNumberOfMonths.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    else
                    {                        

                        //Changing the label to red
                        lblPropertyNumberOfMonths.Foreground = new SolidColorBrush(Colors.Red);

                        //Showing to the user that they entered an invalid value
                        lblErrorLabel.Visibility = Visibility.Visible;
                    }


                    
                }
                catch (Exception)
                {
                    //Showing to the user that they entered an invalid value
                    lblErrorLabel.Visibility = Visibility.Visible;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (propertyOption == "none")
            {
                MessageBox.Show("Please pick between rent or buy");
            }
            else if(propertyOption == "rent")
            {
                //Add the expense to the list
                myObject.addExpensedouble(rentalAmount);

                //Vehicle window object
                VehicleSelectionWindow vehicleSelection = new VehicleSelectionWindow();

                //Display the window
                vehicleSelection.Show();

                //Hide the Property window
                this.Hide();
            }
            else
            {
                //Calculate the monthly repayment
                //A = P * (1 + (interest) * (duration));
                propertyPurchasePriceAmount = propertyPurchasePriceAmount - propertyTotalDepositAmount;

                //Calculating the total due
                totalAmountDue = propertyPurchasePriceAmount * (1 + (propertyInterestRate / 100) * (propertyNumberOfMonths));

                //Calculate the monthly amount due
                monthlyRepaymentAmount = totalAmountDue / propertyNumberOfMonths;

                //Store it in the list
                myObject.addExpensedouble(monthlyRepaymentAmount);

                //Vehicle window object
                VehicleSelectionWindow vehicleSelection = new VehicleSelectionWindow();

                //Display the window
                vehicleSelection.Show();

                //Hide the Property window
                this.Hide();
            }
        }
    }
}
