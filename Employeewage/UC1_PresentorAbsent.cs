using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class UC1_PresentorAbsent
    {
        public void PresentorAbsent()
        {
            int fullTime = 1;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 2);
            if (checkPresent == fullTime)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
