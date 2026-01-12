using RefactoringExample.Models;
using RefactoringExample.Services;

namespace RefactoringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Id = "emp123",
                HoursWorked = 160,
                Rate = 25,
                Insurance = true,
                TaxExempt = false,
                Department = "IT",
                YearsOfExperience = 7
            };

            var gradeService = new GradeService();
            emp.Grade = gradeService.GetGrade(emp);

            var salaryService = new SalaryService();
            var result = salaryService.CalculateSalary(emp);

            var reportService = new ReportService();
            reportService.WriteSalary(result);

            Console.WriteLine($"Salary: {result.NetSalary}");
            Console.WriteLine($"Grade: {emp.Grade}");
        }
    }
}