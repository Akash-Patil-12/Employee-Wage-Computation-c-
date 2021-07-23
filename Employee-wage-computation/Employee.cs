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
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOUR = 8;
        /// <summary>
        /// calculate employee daily wage
        /// </summary>
        public void EmployeeWage()
        {
            totalWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            Console.WriteLine("Employee Daily Wage is :" + totalWage);
        }
    }
}
