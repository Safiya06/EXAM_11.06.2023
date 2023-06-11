using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Department
{
    [Key] 
    public int DepartmantId { get; set; }

    public string DepartmentName { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    
}