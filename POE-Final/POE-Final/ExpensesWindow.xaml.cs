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
    /// Interaction logic for ExpensesWindow.xaml
    /// </summary>
    public partial class ExpensesWindow : Window
    {
        public ExpensesWindow()
        {
            InitializeComponent();
        }

        //Object salary
        Salary mySalary = new Salary();

        //Object HomeLoan
        HomeLoan myObject = new HomeLoan();

        //Variables for storing the basic expenses
        double Groceries = 0;
        double waterAndLights = 0;
        double Transport = 0;
        double cellphoneCosts = 0;
        double otherExpenses = 0;

        //Boolean values for checking if the data is correct
        bool boolGroceries = false;
        bool boolWaterAndLights = false;
        bool boolTransport = false;
        bool boolCellphone = false;
        bool boolOtherExpenses = false;

        private void TxtGroceries_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtGroceries.Text != "")
            {
                //Handle the error
                try
                {
                    //Storing the value in the variable
                    Groceries = double.Parse(txtGroceries.Text);

                    //showing that the valid has been set successfully
                        //The color
                        lblGroceries.Foreground = new SolidColorBrush(Colors.Green);
                        //The text
                        lblGroceries.Content = "R" + Groceries;

                    //Storing that this expense is valid
                    boolGroceries = true;

                    
                }
                catch (Exception)
                {
                    //showing on the right that the value entered is invalid
                    lblGroceries.Foreground = new SolidColorBrush(Colors.Red);
                    lblGroceries.Content = "INVALID";

                    //Storing that this expense is invalid
                    boolGroceries = false;
                }
            }
        }

        private void TxtWaterAndLights_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtWaterAndLights.Text != "")
            {
                //Handle the error
                try
                {
                    //Storing the value in the variable
                    waterAndLights = double.Parse(txtWaterAndLights.Text);

                    //showing that the valid has been set successfully
                    //The color
                    lblWaterAndElectricity.Foreground = new SolidColorBrush(Colors.Green);
                    //The text
                    lblWaterAndElectricity.Content = "R" + waterAndLights;

                    //Storing that this expense is valid
                    boolWaterAndLights = true;

                    

                }
                catch (Exception)
                {
                    //showing on the right that the value entered is invalid
                    lblWaterAndElectricity.Foreground = new SolidColorBrush(Colors.Red);
                    lblWaterAndElectricity.Content = "INVALID";

                    //Storing that this expense is invalid
                    boolWaterAndLights = false;
                }
            }
        }

        private void TxtCellphone_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtCellphone.Text != "")
            {
                //Handle the error
                try
                {
                    //Storing the value in the variable
                    cellphoneCosts = double.Parse(txtCellphone.Text);

                    //showing that the valid has been set successfully
                    //The color
                    lblCellphone.Foreground = new SolidColorBrush(Colors.Green);
                    //The text
                    lblCellphone.Content = "R" + cellphoneCosts;

                    //Storing that this expense is valid
                    boolCellphone = true;

                    
                }
                catch (Exception)
                {
                    //showing on the right that the value entered is invalid
                    lblCellphone.Foreground = new SolidColorBrush(Colors.Red);
                    lblCellphone.Content = "INVALID";

                    //Storing that this expense is invalid
                    boolCellphone = false;
                }
            }
        }

        private void TxtOtherExpenses_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtOtherExpenses.Text != "")
            {
                //Handle the error
                try
                {
                    //Storing the value in the variable
                    otherExpenses = double.Parse(txtOtherExpenses.Text);

                    //showing that the valid has been set successfully
                    //The color
                    lblOtherExpenses.Foreground = new SolidColorBrush(Colors.Green);
                    //The text
                    lblOtherExpenses.Content = "R" + otherExpenses;

                    //Storing that this expense is valid
                    boolOtherExpenses = true;

                    

                }
                catch (Exception)
                {
                    //showing on the right that the value entered is invalid
                    lblOtherExpenses.Foreground = new SolidColorBrush(Colors.Red);
                    lblOtherExpenses.Content = "INVALID";

                    //Storing that this expense is invalid
                    boolOtherExpenses = false;
                }
            }
        }

        private void TxtTransport_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtTransport.Text != "")
            {
                //Handle the error
                try
                {
                    //Storing the value in the variable
                    Transport = double.Parse(txtTransport.Text);

                    //showing that the valid has been set successfully
                    //The color
                    lblTransport.Foreground = new SolidColorBrush(Colors.Green);
                    //The text
                    lblTransport.Content = "R" + Transport;

                    //Storing that this expense is valid
                    boolTransport = true;

                    

                }
                catch (Exception)
                {
                    //showing on the right that the value entered is invalid
                    lblTransport.Foreground = new SolidColorBrush(Colors.Red);
                    lblTransport.Content = "INVALID";

                    //Storing that this expense is invalid
                    boolTransport = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Object for the next window(Property)
            PropertyWindow property = new PropertyWindow();

            //Check if everything is valid
            if (boolGroceries && boolCellphone && boolTransport && boolOtherExpenses && boolWaterAndLights)
            {
                //Adding the expenses to the list
                //Store in the list using the object
                myObject.addExpensedouble(Groceries);

                //Store in the list using the object
                myObject.addExpensedouble(waterAndLights);

                //Store in the list using the object
                myObject.addExpensedouble(cellphoneCosts);

                //Store in the list using the object
                myObject.addExpensedouble(Transport);

                //Store in the list using the object
                myObject.addExpensedouble(otherExpenses);

                //Opening the property window
                property.Show();

                //Hiding the current window
                this.Hide();
            }
            else
            {
                MessageBox.Show("The system has detected INVALID values!!!\n\n" + ((boolGroceries) ? "Groceries - OK" : "Groceries - NOT OK (Please insert a numeic value)") + "\n" + ((boolWaterAndLights) ? "Water and Lights - OK" : "Water and Lights - NOT OK (Please insert a numeric value)") + "\n" + ((boolTransport) ? "Transport - OK" : "Transport - NOT OK (Please insert a numeric value)") + "\n" + ((boolCellphone) ? "Cell/Telephone - OK" : "Cell/Telephone - NOT OK (Please insert a numeric value)") + "\n" + ((boolOtherExpenses) ? "Other Expenses - OK" : "Other Expenses - NOT OK (Please insert a numeric value)"));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Changing the tax deducttion label
            lblTax.Content = (mySalary.getGrossSalary() * 0.15);

            //Storing in the list using the object
            myObject.addExpensedouble((mySalary.getGrossSalary() * 0.15));
        }
    }
}
