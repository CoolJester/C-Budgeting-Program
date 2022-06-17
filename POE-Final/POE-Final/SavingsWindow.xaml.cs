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
    /// Interaction logic for SavingsWindow.xaml
    /// </summary>
    public partial class SavingsWindow : Window
    {
        public SavingsWindow()
        {
            InitializeComponent();
        }

        //Variables for storing the data
        string reason = "";
        double amount = 0;
        double interest = 0;
        double duration = 0;
        double totalAmountDue = 0;
        double monthlySaving = 0;

        //Object relating to the expenses
        Expense myObject = new HomeLoan();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Get the data from the text boxes
            amount = double.Parse(txtTotalAmount.Text);
            interest = double.Parse(txtInterest.Text);
            duration = double.Parse(txtDuration.Text);
            reason = Convert.ToString(txtReasonForSaving.Text);

            //Calculating the total due
            totalAmountDue = amount * (1 + (interest / 100) * (duration));

            //Monthly Savings amount
            monthlySaving = totalAmountDue / (duration * 12);

            //Display to the label
            lblSavingsAmount.Content = "R" + monthlySaving;

            //Store the expense in the list
            myObject.addExpensedouble(monthlySaving);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Check if the data is valid
            if (txtTotalAmount.Text != "" && txtDuration.Text != "" && txtInterest.Text != "")
            {
                //Object of the report window
                ReportWindow myReport = new ReportWindow();

                //Display the report window
                myReport.Show();

                //Hide the current window 
                this.Hide();
            }
        }
    }
}
