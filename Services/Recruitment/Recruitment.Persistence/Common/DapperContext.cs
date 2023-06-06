namespace Recruitment.Persistence.Common;

public class DapperContext : IDapperContext
{
    private IDbConnection _connection;
    private readonly IConfiguration _configuration;

    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private string ConnectionString {
        get {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }

    public IDbConnection CreateConnection {
        get {
            return new SqlConnection(ConnectionString);
        }
    }   


}
