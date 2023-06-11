using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class LocationService
{
    
    private readonly DataContext _context;

    public LocationService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Location>> GetLocations()
    {
        return await  _context.Locations.ToListAsync(); //select all from quotes
    }
    public async Task<Location>GetLocationById(int LocationId)
    {
        return await _context.Locations.FindAsync(LocationId);
    }
    public async Task< Location> AddLocation(Location location)
    {
        await  _context.Locations.AddAsync(location);
        await  _context.SaveChangesAsync();
        return location;
    }
    public async Task<Location> UpdateJob(Location location)
    {
        var find = await _context.Locations.FindAsync(location.LocationId);
        find.StreetAddress=location.StreetAddress;
        find.PostalCode=location.PostalCode;
        find.City=location.City;
        find.StateProvince=location.StateProvince;
        find.CounrtyId=location.CounrtyId;
        await _context.SaveChangesAsync();
        return location;
    }
    public async Task<bool> Delete (int LocationId)
    {
        var find = await _context.Locations.FindAsync(LocationId);
        _context.Locations.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
    
}