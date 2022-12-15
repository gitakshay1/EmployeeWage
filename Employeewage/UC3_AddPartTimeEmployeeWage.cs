using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class UC3_AddPartTimeEmployeeWage
    {
        public void AddPartTimeEmployeeWage()
        {
            int fullTime = 1, partTime = 2, Emp_Rate_Per_Hour = 20, empHrs = 0, empWage = 0;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 3);
            Console.WriteLine("Randome number=" + checkPresent);
            if (checkPresent == partTime)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present part time");
            }

            else if (checkPresent == fullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present full time");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage:" + empWage);
        }
    }
}
