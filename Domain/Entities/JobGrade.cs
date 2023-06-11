using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class JobGrade
{
    [Key]
    public int Id { get; set; }
    public string GradeLevel { get; set; }
    public int LowestSalary { get; set; }
    public int HighestService { get; set; }
}