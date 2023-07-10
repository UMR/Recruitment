namespace Recruitment.Persistence.Common;

public interface IDapperContext
{
    string ConnectionString { get; }

    IDbConnection CreateConnection { get; }

}