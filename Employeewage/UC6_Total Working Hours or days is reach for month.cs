using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class UC6_Total_Working_Hours_or_days_is_reach_for_month
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_of_working_Days = 20;
        public const int Max_Hrs_In_Month = 100;
        public void Total_Working_Hours()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays <= Num_of_working_Days)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
    }
}
