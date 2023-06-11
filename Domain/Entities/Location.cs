using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Location
{
    [Key]
    public int LocationId { get; set; }
    public string StreetAddress { get; set; }
    public string PostalCode { get; set; }
    
    public string City { get; set; }
    public string StateProvince { get; set; }
    
    public int CounrtyId { get; set; }
    public Country Country { get; set; }
}