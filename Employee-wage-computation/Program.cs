using System;

namespace Employee_wage_computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeWage("Jio",40,20,100);
            employee.EmployeeWage("LG", 20, 25, 130);
            employee.EmployeeWage("Google", 60, 15, 80);
        }
    }
}
