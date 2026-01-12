namespace RefactoringExample.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public int HoursWorked { get; set; }
        public double Rate { get; set; }
        public string Grade { get; set; }
        public bool Insurance { get; set; }
        public bool TaxExempt { get; set; }
        public string Department { get; set; }
        public int YearsOfExperience { get; set; }
    }
}