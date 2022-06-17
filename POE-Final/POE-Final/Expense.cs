using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Final
{
    abstract class Expense
    {
        //The lists that help calculate and store the expenses
        protected static List<double> newMyExpenses = new List<double>();
        //other expenses personal lists
        private List<string> expenseName2 = new List<string>();
        private List<double> expensePrice2 = new List<double>();

        //List used to order the expenses in decending order
        protected static List<Order> order = new List<Order>();

        //Method for add a row to the ordering object
        public void addRecord(string s, double v)
        {
            order.Add(new Order(s, v));
        }

        //Getting the values from the ordering object
        public Order getRecord(int index)
        {
            return order[index];
        }
        //Getting the length of the total expenses stored in the order list
        public int getOrderLength()
        {
            return order.Count;
        }

        //Setting the order for the expenses recoreded
        public void organiseExpenses()
        {
            //Temporary object used to switch the positions
            Order temp = new Order("Default", 0);

            //Loop used to access and check all the objects in the order List
            for (int x = 0; x < order.Count; x++)
            {
                //Checking between two elements and moving the greater element higher
                for (int i = 0; i < (order.Count - 1); i++)
                {
                    if (order[i].getValue() < order[(i + 1)].getValue())
                    {
                        //Store the greater expenses in a temporary object
                        temp = order[(i + 1)];
                        //replacing the greater objects spot with the lower object
                        order[(i + 1)] = order[i];
                        //Moving the higher number up
                        order[i] = temp;
                    }
                }
            }

        }         

        //Setter methods for the expenses
        public void addExpensedouble(double value)
        {
            newMyExpenses.Add(value);
        }
        //Changing a pre existing expense
        public void changeExpense(int index, double value)
        {
            newMyExpenses[index] = value;
        }

        //Getting a expense
        public double getNewExpense(int index)
        {
            return newMyExpenses[index];
        }

        //Getting any additional expenses from the user
        public void getOtherExpenses()
        {
            /*-----Checking for other expenses-----*/
            //Setting the default value used to store the other expenses
            newMyExpenses.Add(0);
            //Counter variable for arrays in the do-while loop
            int counter = 0;
            //Boolean variable for controlling the do-while loop
            bool active = true;

            do
            {
                //Asking the user if there are more expenses or not
                Console.WriteLine("Do you have any other expenses you wish to add?. Reply with a Y for Yes and N for No (Y/N)");
                String userInputOne = Console.ReadLine();

                //Checking the users input
                if (userInputOne.Equals("Y") || userInputOne.Equals("y"))
                {
                    //Getting the expenses name
                    Console.WriteLine("Enter the name of the expense you wish to add");
                    expenseName2.Add(Console.ReadLine());
                    //Getting the expenses price
                    Console.WriteLine("Enter the price of the expense you wish to add");
                    expensePrice2.Add(Convert.ToDouble(Console.ReadLine()));

                    //Increamenting the counter variable used to control some of the lists
                    counter++;

                    //Reporting to the user
                    Console.WriteLine("The expense has been successfully added, you will be prompted again if you wish to add another expense.");
                    Console.WriteLine("--Press Enter To Continue--");
                    Console.ReadKey();
                    //Repeating the loop
                    continue;

                }
                else if (userInputOne.Equals("N") || userInputOne.Equals("n"))
                {
                    //Displaying that no expenses were added
                    Console.WriteLine("Total Expenses Added: {0}", counter);

                    if (expensePrice2.Count.Equals(0))
                    {
                        Console.WriteLine("-----There were no additional expenses added(Press Enter)------");
                    }
                    else
                    {
                        //Variable used to control the foreach loop
                        int control = 0;
                        //Displaying the additional values added
                        foreach (double x in expensePrice2)
                        {
                            //incrementing the otherExpenses variable containing the total
                            newMyExpenses[5] += x;
                            Console.WriteLine("Expense no.{0} name : {1},\tPrice : R{2}", (control + 1), expenseName2[control], x);

                            //Increasing the control variable
                            control++;
                        }
                        Console.WriteLine("\n-----------------------------------------------------\nTotal Due for other Expenses: R{0}\n-----------------------------------------------------\nPress Enter to Continue", newMyExpenses[5]);
                    }
                    break;
                }
                else
                {
                    //Message displayed when a wrong value is added
                    Console.WriteLine("You entered an invalid value please try again. Value found : {0}", userInputOne);
                    continue;
                }


            } while (active);

            //Adding a record to the ordering object
            order.Add(new Order("Other Expenses      ", newMyExpenses[5]));

            Console.ReadKey();
        }

        //Adding all the expenses to get a total of all the expenses
        public double getTotalExpense()
        {
            //Varaible used to store the sum of the expenses
            double totalExpenses = 0;

            //Loop for iterating and adding to the totalExpense variable
            for (int i = 0; i < newMyExpenses.Count; i++)
            {
                totalExpenses += newMyExpenses[i];
            }

            //Returning the Total of all the expeneses
            return totalExpenses;
        }
    }
}
