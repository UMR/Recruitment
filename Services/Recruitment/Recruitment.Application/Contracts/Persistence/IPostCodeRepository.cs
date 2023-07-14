namespace Recruitment.Application.Contracts.Persistence;

public interface IPostCodeRepository
{
    Task<IEnumerable<PostCode>> GetAllAsync();    

    Task<PostCode> GetByIdAsync(int id);    

    Task<bool> IsExistPostCodeAsync(string name, int? id = null);    

    Task<int> CreateAsync(PostCode model);

    Task<bool> UpdateAsync(int id, PostCode model);

    Task<bool> DeleteAsync(int id);
   
}
