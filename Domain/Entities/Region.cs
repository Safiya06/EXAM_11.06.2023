using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Region
{
    [Key]
    public int RegionId { get; set; }
    public string RegionName { get; set; }
    
}