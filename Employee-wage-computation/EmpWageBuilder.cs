﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage_computation
{
    class EmpWageBuilder
    {
        Dictionary<string, int> companyToEmpWageMap = new Dictionary<string, int>();
        List<CompanyEmpWage> companyEmpWageList = new List<CompanyEmpWage>();
        /// <summary>
        /// Calculate total employee wage and save it in dictionary
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Add(companyEmpWage);
            //this.companyToEmpWageMap.Add(companyName, companyEmpWage.EmployeeWage());
        }
        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage1 in companyEmpWageList)
            {
                this.companyToEmpWageMap.Add(companyEmpWage1.companyName,companyEmpWage1.EmployeeWage());
            }
        }
        /// <summary>
        /// Display the total Employee wage according to specific company
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company];
        }
    }
}
