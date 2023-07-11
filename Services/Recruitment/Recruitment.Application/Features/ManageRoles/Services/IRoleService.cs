namespace Recruitment.Application.Features.ManageRole
{
    public interface IRoleService
    {
        Task<List<RoleListDto>> GetAllAsync();

        Task<RoleListDto> GetByIdAsync(int id);

        Task<bool> IsExistAsync(string roleName, int? id = null);

        Task<BaseCommandResponse> CreateAsync(CreateRoleDto request);        

        Task<BaseCommandResponse> UpdateAsync(int id, UpdateRoleDto request);

        Task<BaseCommandResponse> DeleteAsync(int id);
    }
}