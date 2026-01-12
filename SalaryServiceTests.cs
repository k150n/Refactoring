using RefactoringExample.Models;
using RefactoringExample.Services;
using Xunit;

public class SalaryServiceTests
{
    [Fact]
    public void Salary_Calculation_Works()
    {
        var service = new SalaryService();
        var emp = new Employee
        {
            Id = "emp1",
            HoursWorked = 100,
            Rate = 20,
            Grade = "B",
            Insurance = true,
            TaxExempt = false
        };
        var result = service.CalculateSalary(emp);
        Assert.Equal("emp1", result.EmployeeId);
        Assert.True(result.NetSalary > 0);
    }
}