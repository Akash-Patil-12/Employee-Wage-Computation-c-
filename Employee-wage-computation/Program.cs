using System;

namespace Employee_wage_computation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Dell", 30, 25, 100);
            empWageBuilder.AddCompanyEmpWage("Sony", 40, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Apple", 50, 20, 120);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total wages for Dell company is :" + empWageBuilder.GetTotalWage("Dell"));
            Console.WriteLine("Total wages for Sony company is :" + empWageBuilder.GetTotalWage("Sony"));
            Console.WriteLine("Total wages for Apple company is :" + empWageBuilder.GetTotalWage("Apple"));
        }
    }
}
