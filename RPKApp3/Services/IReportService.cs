using RefactoringExample.Models;
namespace RefactoringExample.Services
{
    public interface IReportService
    {
        void WriteSalary(SalaryResult result);
    }
}