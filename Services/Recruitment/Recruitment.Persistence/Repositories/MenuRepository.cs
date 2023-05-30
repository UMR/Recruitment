namespace Recruitment.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly IRecruitmentConnectionFactory _recruitmentConnectionFactory;

        //private readonly IConfiguration _configuration;

        //public MenuRepository(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //private string ConnectionString
        //{
        //    get
        //    {
        //        return _configuration.GetConnectionString("DefaultConnection");
        //    }
        //}


        public MenuRepository(IRecruitmentConnectionFactory recruitmentConnectionFactory)
        {
            _recruitmentConnectionFactory = recruitmentConnectionFactory;
        }

        //public async Task<IEnumerable<Menu>> GetMenus()
        //{
        //    List<Menu> menus = new List<Menu>();
        //    DataTable dataTable = new DataTable();
        //    string sql = @"SELECT * FROM Menu ORDER BY MenuId DESC";

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        SqlCommand command = new SqlCommand(sql, con);
        //        command.CommandType = CommandType.Text;

        //        await con.OpenAsync();
        //        await command.ExecuteNonQueryAsync();
        //        await con.CloseAsync();

        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(dataTable);
        //    }

        //    menus = DataTableHelper.ConvertDataTable<Menu>(dataTable);

        //    //menus = dataTable.AsEnumerable().Select(row =>
        //    //    new Menu
        //    //    {
        //    //        MenuId = Convert.ToInt32(row.Field<string>("MenuId")),
        //    //        Culture = row.Field<string>("Culture"),
        //    //        Title = row.Field<string>("Title"),
        //    //        CreatedBy = Convert.ToInt32(row.Field<string>("CreatedBy")),
        //    //        CreatedDate = Convert.ToDateTime(row.Field<string>("CreatedDate")),
        //    //        UpdatedBy = Convert.ToInt32(row.Field<string>("UpdatedBy")),
        //    //        UpdatedDate = Convert.ToDateTime(row.Field<string>("UpdatedDate")),
        //    //    }).ToList();


        //    return menus;            

        //}

        public async Task<IEnumerable<Menu>> GetMenus()
        {
            var query = @"SELECT * FROM Menu";

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
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

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
            {
                var menu = await conn.QueryFirstOrDefaultAsync<Menu>(query, parameters);
                return menu;
            }
        }
    }
}
