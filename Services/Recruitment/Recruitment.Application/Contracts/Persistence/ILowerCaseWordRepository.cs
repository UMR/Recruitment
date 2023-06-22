namespace Recruitment.Application.Contracts.Persistence
{
    public interface ILowerCaseWordRepository
    {
        Task<IEnumerable<LowerCaseWord>> GetAllAsync();

        Task<LowerCaseWord> GetByIdAsync(long id);

        Task<bool> IsExistWordAsync(string word, long? id = null);

        Task<int> CreateAsync(LowerCaseWord model);

        Task<bool> UpdateAsync(long id, LowerCaseWord model);

        Task<bool> DeleteAsync(long id);
    }
}
