namespace Recruitment.Application.Contracts.Persistence;

public interface IUpperCaseWordRepository
{
    Task<IEnumerable<UpperCaseWord>> GetAllAsync();

    Task<UpperCaseWord> GetByIdAsync(long id);

    Task<bool> IsExistWordAsync(string word, long? id = null);

    Task<int> CreateAsync(UpperCaseWord model);

    Task<bool> UpdateAsync(long id, UpperCaseWord model);

    Task<bool> DeleteAsync(long id);
}
