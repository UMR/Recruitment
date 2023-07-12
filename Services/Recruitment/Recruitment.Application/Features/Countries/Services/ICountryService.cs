namespace Recruitment.Application.Features.Countries;

public interface ICountryService
{
    Task<List<CountryListDto>> GetAllAsync();    

    Task<CountryListDto> GetByIdAsync(int id);   

    Task<bool> IsExistNameAsync(string name, int? id = null);    

    Task<BaseCommandResponse> CreateAsync(CreateCountryDto request);    

    Task<BaseCommandResponse> UpdateAsync(int id, UpdateCountryDto request);    

    Task<BaseCommandResponse> DeleteAsync(int id);
    
}
