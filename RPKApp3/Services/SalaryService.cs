using RefactoringExample.Models;
using System;
namespace RefactoringExample.Services
{
    public class SalaryService : ISalaryService
    {
        public SalaryResult CalculateSalary(Employee emp)
        {
            double baseSalary = emp.HoursWorked * emp.Rate;
            double allowance = emp.Grade switch
            {
                "A" => baseSalary * 0.20,
                "B" => baseSalary * 0.10,
                "C" => baseSalary * 0.05,
                _ => 0
            };
            double deductions = 0;
            if (emp.Insurance) deductions += baseSalary * 0.05;
            if (!emp.TaxExempt) deductions += baseSalary * 0.10;

            return new SalaryResult
            {
                EmployeeId = emp.Id,
                NetSalary = baseSalary + allowance - deductions,
                Date = DateTime.Today
            };
        }
    }
}