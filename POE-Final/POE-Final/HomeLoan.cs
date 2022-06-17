using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Final
{
    class HomeLoan : Expense
    {
        
        double propertyTotalCost;
        double propertyInterest;
        double propertyNumberOfMonths;
        double propertyDeposit;
        double gross;

        public void calculateHomeloan()
        {
            start:
            //Asking the user if he/she wants to rent or buy a property
            Console.WriteLine("Do you wish to rent or buy a property enter 1 for rent and 2 for buying (1/2)");
            String userInput = Console.ReadLine();

            //Checking the users responce
            for (; ; )
            {
                String control = "";
                switch (userInput)
                {
                    case "1":
                    //Prompting for the rent amount
                    startPrompt:
                        Console.WriteLine("Enter the amount you pay for rent per month");
                        //Value Entered by the user
                        double rentAmount;
                        try
                        {
                            rentAmount = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You entered an invalid value(Press Enter to Retry)");
                            Console.ReadKey();
                            goto startPrompt;

                        }
                        
                        newMyExpenses.Add(rentAmount);

                        //Adding a record to the ordering obeject
                        order.Add(new Order("Monthly Rental", rentAmount));

                        control = "continue";
                        break;
                    case "2":

                        //Making sure valid values are entered by the user
                        for (; ;)
                        {
                            try
                            {
                                Console.WriteLine("Enter to total cost of the property");
                                propertyTotalCost = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the deposit amount of the property");
                                propertyDeposit = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the interest rate of the property(0 - 100)");
                                propertyInterest = (Convert.ToDouble(Console.ReadLine()) / 100);

                                //Making sure the value entered is between 240 and 360
                                for (; ; )
                                {
                                    Console.WriteLine("Enter the number of months you are going to pay the amount due(240 - 360)");
                                    propertyNumberOfMonths = Convert.ToInt16(Console.ReadLine());

                                    if (propertyNumberOfMonths >=240 && propertyNumberOfMonths <= 360)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry but the value has to be between 240 and 360 ---Press Enter to Continue---");
                                        Console.ReadKey();
                                        continue;
                                    }
                                }
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid value deteted please try again!!!---Press Enter to Continue--");
                                continue;                                
                            }
                        }

                        //Removing the deposit from the total price
                        propertyTotalCost -= propertyDeposit;

                        //Calculating the total due
                        propertyTotalCost = propertyTotalCost * (1 + (propertyInterest) * (propertyNumberOfMonths / 12));

                        //Displaying a simple report
                        Console.WriteLine("-------------Home Loan Report----------------" +
                            "\nTotal Amount due: R" + propertyTotalCost + "" +
                            "\nMonthly Repayment Amount: R" + (propertyTotalCost / propertyNumberOfMonths) + "" +
                            "\n-----------------Press Enter to Continue-------------------");
                        Console.ReadKey();

                        //Getting the monthly payment amount
                        newMyExpenses.Add(propertyTotalCost / propertyNumberOfMonths);

                        //Adding a record in the ordering object
                        order.Add(new Order("Home Loan Repayment", propertyTotalCost / propertyNumberOfMonths));

                        //Checking if the Loan will be approved
                        if (newMyExpenses[6] > (gross / 3))
                        {
                            Console.Beep();
                            Console.WriteLine("Warning the Loan might not get approved(Press Enter)");
                            Console.ReadKey();
                        }

                        control = "continue";
                        break;
                    default:

                        Console.WriteLine("Invaild input please try again!!!");
                        goto start;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  }

                if (control.Equals("continue"))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        

    }
}
