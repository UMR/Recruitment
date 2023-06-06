namespace Recruitment.Application.Features.Menus
{
    public interface IMenuService
    {
        Task<List<MenuListDto>> GetMenusAsync();

        Task<MenuListDto> GetMenuByIdAsync(int id);
        
    }
}