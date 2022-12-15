using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class UC5_CalcultionWageforMonth
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_of_working_Days = 20;
        public void CalcultionWageforMonth()
        {
            int empHrs = 0, empWage = 0, totalEmpwage = 0;
            for (int day = 0; day <= Num_of_working_Days; day++)
            {
                Random randobj = new Random();
                int checkPresent = randobj.Next(0, 3);
                Console.WriteLine("Randome number=" + checkPresent);
                switch (checkPresent)
                {
                    case partTime:
                        empHrs = 4;
                        break;
                    case fullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpwage += empWage;
                Console.WriteLine("Employee wage:" + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpwage);
        }
    }
}
