using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    class Employee
    {
        //variable
        int empCheck,totalWage;
        //constant
        const int WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, FULL_DAY = 0, HALF_DAY = 1;
       /// <summary>
       /// Calculate employee part time and full time wage using switch case
       /// </summary>
        public void EmployeeWage()
        {
            Random random = new Random();
            for (int day = 1; day <= 20; day++)
            {
                empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case FULL_DAY:
                        totalWage += WAGE_PER_HOUR * FULL_DAY_HOUR;
                        break;
                    case HALF_DAY:
                        totalWage += WAGE_PER_HOUR * HALF_DAY_HOUR;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Employee Wage of month is :" + totalWage);
        }
    }
}
