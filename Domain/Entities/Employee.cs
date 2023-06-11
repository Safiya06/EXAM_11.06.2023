using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace DefaultNamespace;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber     { get; set; }
    public DateTime HireDate { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    public decimal Salary { get; set; }
    public decimal CommissionPct { get; set; }
    public int DeprtmentId { get; set; }
    public Department Department { get; set; }
    
}