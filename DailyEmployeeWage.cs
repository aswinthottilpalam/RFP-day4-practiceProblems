using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_day4_practiceProblems
{
    internal class DailyEmployeeWage
    {
        public static void Main(string[] args)
        {
            //Constants
            int isFullTime = 1;
            int empRatePerHour = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
