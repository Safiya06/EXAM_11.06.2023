using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class RegionService
{
    
    
    private readonly DataContext _context;

    public RegionService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Region>> GetRegions()
    {
        return await  _context.Regions.ToListAsync(); //select all from quotes
    }
    public async Task<Region>GetRegionById(int RegionId)
    {
        return await _context.Regions.FindAsync(RegionId);
    }
    public async Task<Region> AddRegion(Region region)
    {
        await  _context.Regions.AddAsync(region);
        await  _context.SaveChangesAsync();
        return region;
    }
    public async Task<Region> UpdateRegion(Region region)
    {
        var find = await _context.Regions.FindAsync(region.RegionId);
        find.RegionName=region.RegionName;
        await _context.SaveChangesAsync();
        return region;
    }
    public async Task<bool> Delete (int RegionId)
    {
        var find = await _context.Regions.FindAsync(RegionId);
        _context.Regions.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}