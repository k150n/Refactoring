using RefactoringExample.Models;
namespace RefactoringExample.Services
{
    public class GradeService : IGradeService
    {
        public string GetGrade(Employee emp)
        {
            return emp.Department switch
            {
                "IT" => emp.YearsOfExperience switch
                {
                    > 10 => "A",
                    > 5 => "B",
                    _ => "C"
                },
                "HR" => emp.YearsOfExperience switch
                {
                    > 8 => "A",
                    > 4 => "B",
                    _ => "C"
                },
                _ => "C"
            };
        }
    }
}