namespace Recruitment.Application.Contracts.Persistence;

public interface ISpecialWordRepository
{
    Task<IEnumerable<SpecialWord>> GetAllAsync();

    Task<SpecialWord> GetByIdAsync(long id);

    Task<bool> IsExistWordAsync(string word, long? id = null);

    Task<int> CreateAsync(SpecialWord model);

    Task<bool> UpdateAsync(long id, SpecialWord model);

    Task<bool> DeleteAsync(long id);
}
