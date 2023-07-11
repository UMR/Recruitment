namespace Recruitment.Application.Contracts.Persistence;

public interface IManageRoleRepository
{
    Task<IEnumerable<Role>> GetAllAsync();

    Task<Role> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string emailType, int? id = null);

    Task<int> CreateAsync(Role emailType);

    Task<bool> UpdateAsync(int id, Role emailType);

    Task<string> DeleteAsync(long id);    
    
}
