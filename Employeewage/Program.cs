using System;
using System.Diagnostics;

namespace Employeewage
{
    class Program
    {   
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_of_working_Days = 20;
        public const int Max_Hrs_In_Month = 100;
        static void Main(string[] args)
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