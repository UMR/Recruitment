namespace Recruitment.Application.Contracts.Persistence;

public interface ICountryRepository
{
    Task<IEnumerable<Country>> GetAllAsync();

    Task<Country> GetByIdAsync(int id);

    Task<bool> IsExistNameAsync(string name, int? id = null);

    Task<int> CreateAsync(Country model);

    Task<bool> UpdateAsync(int id, Country model);

    Task<bool> DeleteAsync(int id);
}
