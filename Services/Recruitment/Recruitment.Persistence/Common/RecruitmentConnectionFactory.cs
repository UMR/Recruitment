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
            if (_connection == null)
            {
                _connection = new SqlConnection(ConnectionString);
            }
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }
    }

    public void CloseConnection()
    {
        if (_connection != null && _connection.State == ConnectionState.Open)
        {
            _connection.Close();
        }
    }
}
