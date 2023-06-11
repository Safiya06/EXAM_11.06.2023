using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Country
{
    [Key]
    public int CountryId { get; set; }
    public string CountryName { get; set; }
    public string RegionId { get; set; }
    public Region Region { get; set; }
}