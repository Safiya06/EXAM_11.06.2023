using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class RegionController
{  
    private readonly RegionService _regionService;

    public RegionController(RegionService regionService)
    {
        _regionService = regionService;
    }
    [HttpGet("getRegions")]
    public async Task<List<Region>> GetRegions()
    {
        return await  _regionService.GetRegions();
    }
    [HttpGet("GetRegionById")]
    public async Task<Region> GetRegionById(int RegionId)
    {
        return await _regionService.GetRegionById(RegionId);
    }
    [HttpPost("AddRegion")]
    public async Task<Region> AddRegion(Region region)
    {
        return await _regionService.AddRegion(region);
    }
    [HttpPut("UpdateRegion")]
    public async Task<Region> UpdateRegion(Region region)
    {
        return await _regionService.UpdateRegion(region);
    }
    [HttpDelete("DeleteRegion")]
    public async Task<bool> DeleteRegion(int RegionId)
    {
        return await _regionService.Delete(RegionId);
    }
    
}