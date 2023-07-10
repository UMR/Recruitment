namespace Recruitment.Persistence.Common
{
    public interface IDataAccessBase
    {
        string ConnectionString { get; }

        DataSet GetDataSet(CommandType commandType, string query, List<SqlParameter> parameters = null);

        DataTable GetDataTable(CommandType commandType, string query, List<SqlParameter> parameters = null);
    }
}