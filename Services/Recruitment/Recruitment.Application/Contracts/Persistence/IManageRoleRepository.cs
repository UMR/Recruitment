using Recruitment.Application.Features.ManageRole;

namespace Recruitment.Application.Contracts.Persistence;

public interface IManageRoleRepository
{
    Task<IEnumerable<RoleListDto>> GetAllAsync();

    Task<Role> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string roleName, int? id = null);

    Task<int> CreateAsync(Role role);

    Task<bool> UpdateAsync(int id, Role role);

    Task<string> DeleteAsync(long id);    
    
}
