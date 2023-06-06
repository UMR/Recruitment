namespace Recruitment.Persistence.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly IDapperContext _dapperContext;

    public MenuRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }    

    public async Task<IEnumerable<Menu>> GetMenus()
    {
        var query = @"SELECT * FROM Menu";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var menus = await conn.QueryAsync<Menu>(query);
            return menus.ToList();
        }
    }

    public async Task<Menu> GetMenuById(int id)
    {
        var query = @"SELECT * FROM Menu WHERE MenuId=@MenuId";

        var parameters = new DynamicParameters();
        parameters.Add("MenuId", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var menu = await conn.QueryFirstOrDefaultAsync<Menu>(query, parameters);
            return menu;
        }
    }
}
