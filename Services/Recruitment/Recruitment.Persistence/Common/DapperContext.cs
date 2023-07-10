namespace Recruitment.Persistence.Common;

public class DapperContext : IDapperContext
{    
    private readonly IConfiguration _configuration;

    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string ConnectionString {
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
