using RefactoringExample.Models;
namespace RefactoringExample.Services
{
    public interface ISalaryService
    {
        SalaryResult CalculateSalary(Employee emp);
    }
}