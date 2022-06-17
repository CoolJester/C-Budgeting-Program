using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Student Number : 19342975
 *  Student Name : Ntsako
 *  Student Surname : Baloyi
 *  Group Number : 2
 *  Last Date of Edit : 06/06/2021
 *  Contact Number : 073 526 3367
 */


namespace POE_Final
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Variables used in the running of the application
            //Incomes
            double grossSalary;
            double netSalary;
            //LineBreaker
            string hr = "---------------------------------------------------";
            //Basic Expense Names
            List<string> expNames = new List<string>() { 
                "Groceries per month.",
                "Water and Lights.",
                "transport with fuel.",
                "Cell/Telephone Costs"
            };
            
            start:
            //Getting Gross Salary
            Console.WriteLine("Please enter your gross salary, this is the amount before deductions.");
            try
            {
                //Trying to record the gross salary in a variable
                grossSalary = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                //When a invalid value is enetered
                Console.WriteLine("Please enter a number (Press Enter to Continue)");
                Console.ReadKey();
                //Retrying to get the value
                goto start;
            }

            //Expenses Object
            HomeLoan hl = new HomeLoan();

            //Vehicle
            Vehicle myCar = new Vehicle();

            /*---------------Getting the expenses----------------*/
            //Getting Monthly Tax
            Console.WriteLine("Your monthly tax is: " + (grossSalary * 0.15) + "\n-----------------Press Enter to Continue------------------");
            //Adding the tax amount to the List 
            hl.addExpensedouble((grossSalary * 0.15));
            Console.ReadKey();

            //Adding the expenses to the order object
            hl.addRecord("Monthly Tax Amount", (grossSalary * 0.15));

            //Getting the basic expenses from the user using a loop
            foreach (var x in expNames)
            {
                expensesStart:
                Console.WriteLine("Please enter the cost for " + x);
                try
                {
                    //Value entered by the user
                    double userInputAmount = Convert.ToDouble(Console.ReadLine());

                    //Adding the expense to the List 
                    hl.addExpensedouble(userInputAmount);

                    //Adding the expenses to the order object
                    hl.addRecord(x, userInputAmount);
                }
                catch (Exception)
                {
                    //When a invalid value is enetered restarting the basic expenses Loop
                    Console.WriteLine("---Invaild Value----\nPlease enter a number (Press Enter to Continue)");
                    Console.ReadKey();
                    goto expensesStart;

                }
            }

            //Getting the other expenses
            hl.getOtherExpenses();

            /*---------------Getting/Calculating the homeloan-----------------*/
            hl.calculateHomeloan();

            /*---------------Getting the vehicle expenses-----------------*/
            //Prompting of the basics
            myCar.getVehicleExpense();            

            //Ordering the expenses
            hl.organiseExpenses();

            //Displaying the details of the vehicle we recoreded but checking if we are buying first using a if statement
            if (myCar.getExists())
            {
                myCar.calculateVehicleDetails();
            }
            

            //Checking if the total expenses is over 75% of the gross income
            if (hl.getTotalExpense() > (grossSalary * 0.75))
            {
                Console.Beep();
                Console.WriteLine("{0}\n----------Warning!!!-------------\n{1}\n YOUR EXPENSES SURPASS YOUR INCOME BY 75%\n{2}\n---Press Enter to Continue---", hr, hr, hr);
                Console.ReadKey();
            }

            //Displaying the list of the expenses
            Console.WriteLine(hr + "\n--------List of All the Recorded Expenses--------\n" + hr);
            //Displaying the List of the expenses in desending order
            for (int i = 0; i < hl.getOrderLength(); i++)
            {
                //temporary object used to store an Order datatype using a getter method from the Order class
                Order temp = hl.getRecord(i);

                Console.WriteLine("\n{0}. " + temp.getName() + "\t\tR" + temp.getValue(), (i + 1));
            }

            Console.WriteLine("\n---Press Enter to Display your Net Salary---");

            //NSK remove this 
            Console.ReadKey();


            //Calculating the net salary
            netSalary = grossSalary - hl.getTotalExpense();            

            //Displaying the net salary to the user and a small check on the net salary if its below zero
            Console.WriteLine("Your net salary is : R{0}\n" + ((netSalary < 0) ? "Oops seems like your budget is below zero try cutting some expenses buddy :(\n" : "") + "-----------Press Enter to End Program--------------", netSalary);
            Console.ReadKey();       
            
            
        }
    }
}
