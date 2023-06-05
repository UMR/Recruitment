namespace Recruitment.Persistence.Common;

public class RecruitmentConnectionFactory : IRecruitmentConnectionFactory
{
    private IDbConnection _connection;
    private readonly IConfiguration _configuration;

    public RecruitmentConnectionFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private string ConnectionString {
        get {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }

    public IDbConnection GetConnection {
        get {
            return _connection = new SqlConnection(ConnectionString);
        }
    }
    
}
