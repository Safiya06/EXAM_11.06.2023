using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class CountryService
{
    private readonly DataContext _context;

    public CountryService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Country>> GetCountries()
    {
        return await  _context.Countries.ToListAsync(); //select all from quotes
    }
    public async Task<Country>GetCountryById(int CountryId)
    {
        return await _context.Countries.FindAsync(CountryId);
    }
    public async Task< Country> AddCountry(Country country)
    {
        await  _context.Countries.AddAsync(country);
        await  _context.SaveChangesAsync();
        return country;
    }
    public async Task<Country> UpdateCountry(Country country)
    {
        var find = await _context.Countries.FindAsync(country.CountryId);
        find.CountryName=country.CountryName;
        find.RegionId=country.RegionId;
        await _context.SaveChangesAsync();
        return country;
    }
    public async Task<bool> Delete (int CountryId)
    {
        var find = await _context.Countries.FindAsync(CountryId);
        _context.Countries.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}