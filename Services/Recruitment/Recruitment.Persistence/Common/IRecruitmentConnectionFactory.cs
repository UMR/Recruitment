namespace Recruitment.Persistence.Common;

public interface IRecruitmentConnectionFactory
{
    IDbConnection GetConnection { get; }

    void CloseConnection();
}