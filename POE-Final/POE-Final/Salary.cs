using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Final
{
    class Salary
    {

        private static double grossSalary = 0;

        public void setGrossSalary(double s)
        {
            grossSalary = s;
        }

        public double getGrossSalary()
        {
            return grossSalary;
        }
    }
}
