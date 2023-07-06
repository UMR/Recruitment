namespace Recruitment.Application.Contracts.Persistence;

public interface ILanguageRepository
{
    Task<IEnumerable<Language>> GetAllAsync();

    Task<Language> GetByIdAsync(int id);

    Task<bool> IsExistVisaTypeAsync(string visaType, int? id = null);

    Task<int> CreateAsync(Language model);

    Task<bool> UpdateAsync(int id, Language model);

    Task<bool> DeleteAsync(int id);
    
}
