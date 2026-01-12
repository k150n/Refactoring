using RefactoringExample.Models;
using RefactoringExample.Services;
using Xunit;

public class GradeServiceTests
{
    [Theory]
    [InlineData(11, "A")]
    [InlineData(7, "B")]
    [InlineData(3, "C")]
    public void Test_Grade_IT(int years, string expected)
    {
        var service = new GradeService();
        var emp = new Employee { Department = "IT", YearsOfExperience = years };
        Assert.Equal(expected, service.GetGrade(emp));
    }
}