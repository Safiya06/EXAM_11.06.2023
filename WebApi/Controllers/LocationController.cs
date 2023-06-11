using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class LocationController 
{   
    private readonly LocationService _locationService;

    public LocationController(LocationService locationService)
    {
        _locationService = locationService;
    }
    [HttpGet("getLocations")]
    public async Task<List<Location>> GetLocations()
    {
        return await  _locationService.GetLocations();
    }
    [HttpGet("GetLocationById")]
    public async Task<Location> GetLocationById(int LocationId)
    {
        return await _locationService.GetLocationById(LocationId);
    }
    [HttpPost("AddLocation")]
    public async Task<Location> AddLocation(Location location)
    {
        return await _locationService.AddLocation(location);
    }
    [HttpPut("UpdateLocation")]
    public async Task<Location> UpdateLocation(Location location)
    {
        return await _locationService.UpdateJob(location);
    }
    [HttpDelete("DeleteLocation")]
    public async Task<bool> DeleteLocation(int LocationId)
    {
        return await _locationService.Delete(LocationId);
    }
    
}