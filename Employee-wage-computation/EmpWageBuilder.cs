using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    class EmpWageBuilder:IEmpWage
    {
        Dictionary<string, int> companyToEmpWageMap = new Dictionary<string, int>();
        List<CompanyEmpWage> companyEmpWageList = new List<CompanyEmpWage>();
        List<int> storeDailyWage = new List<int>();
        /// <summary>
        /// Create object of CompanyEmpWage and save it in CompanyEmpWageList
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Add(companyEmpWage);
        }
        /// <summary>
        /// Calculate total employee wage and save it in dictionary 
        /// </summary>
        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWageVariable in companyEmpWageList)
            {
                this.companyToEmpWageMap.Add(companyEmpWageVariable.companyName,companyEmpWageVariable.EmployeeWage(storeDailyWage));
            }
        }
        /// <summary>
        /// Display the total Employee wage according to specific company name
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company];
        }
    }
}
