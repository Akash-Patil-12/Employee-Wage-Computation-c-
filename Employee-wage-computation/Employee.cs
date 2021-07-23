using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    class Employee
    {
        //variable
        int totalWage;
        //constant
        const int WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, FULL_DAY = 0;

       /// <summary>
       /// Calculate employee part time and full time wage
       /// </summary>
        public void EmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_DAY)
            {
                totalWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            }
            else
            {
                totalWage = WAGE_PER_HOUR * HALF_DAY_HOUR;
            }

            Console.WriteLine("Employee Wage is :" + totalWage);
        }
    }
}
