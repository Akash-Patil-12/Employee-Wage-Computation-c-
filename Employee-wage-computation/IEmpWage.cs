using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    interface IEmpWage
    {
        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int GetTotalWage(string company);
    }
}
