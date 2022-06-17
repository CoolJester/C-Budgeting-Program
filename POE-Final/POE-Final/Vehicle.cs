using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Final
{
    class Vehicle : Expense
    {
        //Control varaible for checking if the user is buying
        private static bool isBuy = false;

        //Variables recording the make and model of the vehicle
        private string model;
        private string make;

        //Variable used to see if we are buying the car or not
        bool exists = false;

        //List containing the names of the vehicle expenses applicable
        List<string> vehicleExpNames = new List<string>() { 
                "Purchase Price",
                "Total Deposit",
                "Interest Rate Percentage(0 - 100)",
                "Insurance Premium",
                "Total Monthly Cost"
        };
        //List
        List<double> vehicleExpenses = new List<double>();

        //
        public void setBuying(bool b)
        {
            isBuy = b;
        }

        public bool getBuying()
        {
            return isBuy;
        }

        //Returning if we are going to be buying the car or not
        public bool getExists()
        {
            return exists;
        }

        //Setter methods for the model and make
        public void setModel(string str)
        {
            this.model = str;
        }
        public void setMake(string str)
        {
            this.make = str;
        }

        //Getter methods for the model and make
        public string getModel()
        {
            return this.model;
        }
        public string getMake()
        {
            return this.make;
        }

        //Setter method for the name of the expense
        public void setVehicleExpense(double value)
        {
            vehicleExpenses.Add(value);
        }

        //Getter method for the vehicle expense
        public double getVehicleExpense(int index)
        {
            return vehicleExpenses[index];
        } 
        
        //Setter method for the name of the expense name
        public void setVehicleExpName(string value)
        {
            vehicleExpNames.Add(value);
        }

        //Getter method for the vehicle expense name
        public string getVehicleExpName(int index)
        {
            return vehicleExpNames[index];
        }

        //Prompting for the vehicle expenses
        public void getVehicleExpense()
        {
            for (; ;)
            {
                //Checking if the user wants to buy a car
                Console.WriteLine("Would you like to buy a car (Yes/No)");
                string userInput = Console.ReadLine();

                if (userInput == "Yes" || userInput == "yes" || userInput == "YES")
                {
                    //Changing the exists variable to true becoz we are buying a car
                    exists = true;

                    //Promting for the make
                    Console.WriteLine("What is the make of the Vehicle");
                    this.make = Console.ReadLine();
                    //Prompting for the model
                    Console.WriteLine("What is the model of the Vehicle");
                    this.model = Console.ReadLine();
                    
                    //Prompting to the user
                    for (int i = 0; i < 3; i++)
                    {
                        //Execption handling
                        vehicleExpPrompt:
                        Console.WriteLine("Please Enter the {0} of the vehicle", vehicleExpNames[i]);
                        try
                        {
                            //Adding the expenses to the vehicle expenses List
                            vehicleExpenses.Add(Convert.ToDouble(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            //Error Message
                            Console.WriteLine("Oops, you entered an invalid amount ---Press Enter to continue---");
                            Console.ReadKey();
                            //Retrying to enter value
                            goto vehicleExpPrompt;
                        }
                    }

                //Getting the insurance premium with error handling and recording to the order object
                insure:
                    Console.WriteLine("Please Enter the insurance premium amount of the vehicle");
                    try
                    {
                        //Storing
                        vehicleExpenses.Add(Convert.ToDouble(Console.ReadLine()));
                        //Recording the insurance premium in the order object
                        addRecord("Insurance Premium", vehicleExpenses[3]);
                        //Adding the insurance to the list containing the expesnes
                        newMyExpenses.Add(vehicleExpenses[3]);
                    }
                    catch (Exception)
                    {
                        //Error Message
                        Console.WriteLine("Oops, you entered an invalid amount for the insurance amount---Press Enter to continue---");
                        Console.ReadKey();
                        //Retrying to enter value
                        goto insure;
                    }                    
                    //Stop the loop
                    break;
                }
                else if (userInput == "No" || userInput == "no" || userInput == "NO")
                {
                    //Message
                    Console.WriteLine("No Vehicle will not be recorded.---Press Enter to Continue---");
                    Console.ReadKey();
                    //Stop the loop
                    break;
                }
                else
                {
                    //When a invalid value is entered by the user
                    Console.WriteLine("You entered an invalid value press ENTER to try again");
                    Console.ReadKey();
                    continue;
                }
            }
        }

        //Calculating the vehicle repayment and displaying a report
        public void calculateVehicleDetails()
        {
            //Initializing the monthly amount to 0
            vehicleExpenses.Add(0);

            //Removing the deposit
            vehicleExpenses[0] -= vehicleExpenses[1];

            //Using the simple interest formula to get the total repayment amount
            vehicleExpenses[4] = vehicleExpenses[0] * (1 + (vehicleExpenses[2] / 100) * (5));

            //Converting the total repayment amount to monthly repayments
            vehicleExpenses[4] /= 60;

            //Recording the total monthly payment in the order class
            addRecord("Vehicle Payment   ", vehicleExpenses[4]);

            //Adding the insurance to the list containing the expesnes
            newMyExpenses.Add(vehicleExpenses[4]);

            //Displaying a report about the vehicle we recoreded
            //line break variable
            String lb = "*************************************";

            //Displaying a Report on the vehicle we recoreding 
            Console.WriteLine("{0}\n-------Vehicle Report-------\n{1}\nVehicle Name: {2} - {3}\nVehicle Price: R{4}\nDeposit Made for Vehicle: R{5}\nInterest applied: {6}%\n{7}\nTotal Amount due: R{8}\n{9}\n-----Monthly Payments Report-----\n{10}\nMonthly Payments Due: R{11}\nInsurance Premium: R{12}\n{13}\n---Press Enter to Continue---", lb, lb, this.getMake(), this.getModel(), vehicleExpenses[0], vehicleExpenses[1], vehicleExpenses[2], lb, (vehicleExpenses[4] * 60), lb, lb, vehicleExpenses[4], vehicleExpenses[3], lb);
            Console.ReadKey();
        }

        //Getting the vehicles monthly repyament amount
        public double getVehicleRepayment()
        {
            return vehicleExpenses[4];
        }


        //Getting the insurance premium
        public double getInsurance()
        {
            return vehicleExpenses[3];
        }

    }
}
