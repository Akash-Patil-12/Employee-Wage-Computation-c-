using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    class Employee
    {
        //variable
        int check;
        /// <summary>
        /// check employee present or absent
        /// </summary>
        public void checkEmployee()
        {
            Random random = new Random();
            check = random.Next(0, 2);
            if (check == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
