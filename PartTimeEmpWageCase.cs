using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_day4_practiceProblems
{
    internal class PartTimeEmpWageCase
    {
        public static void Main(string[] args)
        {
            //Constants
            int PartTime = 1;
            int FullTime = 2;
            int empRatePerHour = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case PartTime:
                    empHrs = 4;
                    break;
                case FullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
