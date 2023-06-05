namespace Recruitment.Application.Contracts.Persistence;

public interface IMenuRepository
{
    Task<IEnumerable<Menu>> GetMenus();
    Task<Menu> GetMenuById(int id);
}
