using System;

namespace Employeewage
{
    internal class Program
    {
        static void Main(string[] args)
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