using System;
namespace Employee_wage_computation
{
    public class CompanyEmpWage
    {
        //variable
        int empCheck = 0, totalWorkingDays, totalEmpHours = 0, empHoursPerDay = 0, empRatePerHour, numOfWorkingDays, maxHoursPerMonth;
      public  string companyName;
        //constant
        const int FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, FULL_DAY = 0, HALF_DAY = 1;  
        public CompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpHours = 0;
        }
        /// <summary>
        /// Calculate employee part time and full time wage using switch case and display it with it's company name also return totalWages
        /// </summary>
        public int EmployeeWage()
        {
            Random random = new Random();
            totalWorkingDays = 0;
            //totalEmpHours = 0;
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
            return (totalEmpHours * empRatePerHour);
        }
    }
}
