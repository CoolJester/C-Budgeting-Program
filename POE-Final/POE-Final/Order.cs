using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Final
{
    class Order
    {
        //Variables storing the name and amount for an expense
        string name;
        double amount;

        //Constructor
        public Order(string str, double value)
        {
            this.name = str;
            this.amount = value;
        } 

        //Setting the Name
        public void setName(string s)
        {
            this.name = s;
        }
        //Setting the Amount
        public void setAmount(double d)
        {
            this.amount = d;
        }

        //Returing the Name
        public string getName()
        {
            return this.name;
        }

        //Returing the Value
        public double getValue()
        {
            return this.amount;
        }
    }
}
