
namespace Recruitment.Application.Contracts.Persistence;

public interface IRoleRepository
{
    Task<IEnumerable<RoleListDto>> GetAllAsync();
    Task<IEnumerable<RoleListDto>> GetRoleByUserAsync(int userId);
    Task<Role> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string roleName, int? id = null);

    Task<int> CreateAsync(Role role);

    Task<bool> UpdateAsync(int id, Role role);

    Task<string> DeleteAsync(long id);    
    
}
