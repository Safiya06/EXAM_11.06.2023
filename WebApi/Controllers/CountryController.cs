using Microsoft.AspNetCore.Mvc;

namespace DefaultNamespace;

public class CountryController : ControllerBase
{ private readonly CountryService _countryService;

    public CountryController(CountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet("getcountries")]
    public async Task<List<Country>> GetCountries()
    {
        return await  _countryService.GetCountries();
    }

    [HttpGet("GetCountryById")]
    public async Task<Country> GetCountryById(int CountryId)
    {
        return await _countryService.GetCountryById(CountryId);
    }

    [HttpPost("AddCountry")]
    public async Task<Country> AddCountry(Country country)
    {
        return await _countryService.AddCountry(country);
    }
    [HttpPut("UpdateCountry")]
    public async Task<Country> UpdateCountry(Country country)
    {
        return await _countryService.UpdateCountry(country);
    }
    
    [HttpDelete("DeleteCountry")]
    public async Task<bool> DeleteCountry(int CountryId)
    {
        return await _countryService.Delete(CountryId);
    }
    
}