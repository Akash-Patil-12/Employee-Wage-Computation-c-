using System;
namespace Employee_wage_computation
{
    class Employee
    {
        //variable
        int empCheck = 0, totalWorkingDays, totalEmpHours = 0, empHoursPerDay = 0;
        //constant
        const int FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, FULL_DAY = 0, HALF_DAY = 1;       
       /// <summary>
       /// Calculate employee part time and full time wage using switch case and display it with it's company name
       /// </summary>
        public void EmployeeWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Random random = new Random();
            totalWorkingDays = 0;
            totalEmpHours = 0;
            while(totalEmpHours<=maxHoursPerMonth && totalWorkingDays<=numOfWorkingDays)
            {
                totalWorkingDays++;
                empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case FULL_DAY:
                        empHoursPerDay= FULL_DAY_HOUR;
                        break;
                    case HALF_DAY:
                        empHoursPerDay = HALF_DAY_HOUR;
                        break;
                    default:
                        break;
                }
                totalEmpHours += empHoursPerDay;
                if (totalEmpHours >= maxHoursPerMonth)
                    break;
                Console.WriteLine("Day :" + totalWorkingDays + " Employee Work Hours :" + empHoursPerDay);
            }
            Console.WriteLine("Total Employee wage for company :"+companyName+" is :"+(totalEmpHours * empRatePerHour));
        }
    }
}
