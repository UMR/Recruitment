namespace Recruitment.Application.Contracts.Persistence;

public interface IPostCodeRepository
{
    Task<IEnumerable<PostCodeEntity>> GetAllAsync();    

    Task<PostCodeEntity> GetByIdAsync(int id);    

    Task<bool> IsExistPostCodeAsync(string name, int? id = null);    

    Task<int> CreateAsync(PostCodeEntity model);

    Task<bool> UpdateAsync(int id, PostCodeEntity model);

    Task<bool> DeleteAsync(int id);
   
}
