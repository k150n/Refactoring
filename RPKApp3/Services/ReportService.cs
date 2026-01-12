using RefactoringExample.Models;
using System.IO;
namespace RefactoringExample.Services
{
    public class ReportService : IReportService
    {
        public void WriteSalary(SalaryResult result)
        {
            string line = $"Employee {result.EmployeeId}: {result.NetSalary} on {result.Date:yyyy-MM-dd}\n";
            File.AppendAllText("salary_report.txt", line);
        }
    }
}