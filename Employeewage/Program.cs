using System;
using System.Diagnostics;

namespace Employeewage
{
    class Program
    {   
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int Emp_Rate_Per_Hour = 20;
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0;
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
            Console.WriteLine("Employee wage:" + empWage);

        }
    }
}