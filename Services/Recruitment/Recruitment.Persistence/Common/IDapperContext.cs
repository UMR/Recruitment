namespace Recruitment.Persistence.Common;

public interface IDapperContext
{
    IDbConnection CreateConnection { get; }
    
}