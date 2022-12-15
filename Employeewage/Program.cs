using System;
using System.Diagnostics;

namespace Employeewage
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program \nEnter the number for select UC" +
                "\n1 UC1 Present or Absent \n2 UC2 Daily Employee Wage \n3 Add Part time Employe wage" +
                "\n4 Using Switch Case \n5 UC5_Calculate Wage for month \n6 total working hours to reach month \n" +
                "7 Multiple company");
            int Choice=Convert.ToInt32(Console.ReadLine()); 
            switch(Choice)
            {
                case 1:
                    UC1_PresentorAbsent uC1_PresentorAbsent = new UC1_PresentorAbsent();
                    uC1_PresentorAbsent.PresentorAbsent();
                    break;

                case 2:
                    UC2_DailyEmployeeWage uC2_DailyEmployeeWage = new UC2_DailyEmployeeWage();
                    uC2_DailyEmployeeWage.DailyEmployeeWage();
                    break; 

                case 3:
                    UC3_AddPartTimeEmployeeWage uC3_AddPartTimeEmployeeWage = new UC3_AddPartTimeEmployeeWage();
                    uC3_AddPartTimeEmployeeWage.AddPartTimeEmployeeWage();
                    break;

                case 4:
                    UC4_UsingSwitchCase uC4_UsingSwitchCase = new UC4_UsingSwitchCase();
                    uC4_UsingSwitchCase.UsingSwitchCase();
                    break;

                case 5:
                    UC5_CalcultionWageforMonth uC5_CalcultionWageforMonth = new UC5_CalcultionWageforMonth();
                    uC5_CalcultionWageforMonth.CalcultionWageforMonth();
                    break;

                case 6:
                    UC6_Total_Working_Hours_or_days_is_reach_for_month uC6_Total_Working_Hours_Or_Days_Is_Reach_For_Month = new UC6_Total_Working_Hours_or_days_is_reach_for_month();
                    uC6_Total_Working_Hours_Or_Days_Is_Reach_For_Month.Total_Working_Hours();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;

            }
        }
    }
}