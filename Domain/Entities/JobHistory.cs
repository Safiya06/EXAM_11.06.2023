using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class JobHistory
{
    [Key]
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate     { get; set; }
    
    public int JobId { get; set; }
    public Job     Job { get; set; }
    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}