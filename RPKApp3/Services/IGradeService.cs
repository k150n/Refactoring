using RefactoringExample.Models;
namespace RefactoringExample.Services
{
    public interface IGradeService
    {
        string GetGrade(Employee emp);
    }
}