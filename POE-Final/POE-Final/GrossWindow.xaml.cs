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
    /// Interaction logic for GrossWindow.xaml
    /// </summary>
    public partial class GrossWindow : Window
    {
        public GrossWindow()
        {
            InitializeComponent();
        }

        //Grossincome variable
        double grossIncome = 0;

        //Object of the salary
        Salary mySalary = new Salary();

        //Method that executes when the text in the textbox is changed
        private void TxtGrossIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Executing the code if the textbox is not empty
            if (txtGrossIncome.Text != "")
            {
                //Handling a invalid input
                try
                {
                    grossIncome = double.Parse(txtGrossIncome.Text);

                    mySalary.setGrossSalary(grossIncome);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please ENTER a numeric value");
                    txtGrossIncome.Text = "";
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Object of the window we want to go to
            ExpensesWindow expenses = new ExpensesWindow();

            //Displaying the window 
            expenses.Show();

            //Hiding the current window
            this.Hide();
        }
    }
}
