namespace Recruitment.Persistence.Common
{
    public interface IDataAccessBase
    {
        string ConnectionString { get; }

        DataSet GetDataSet(CommandType commandType, string commandText, List<SqlParameter> parameters = null);

        DataTable GetDataTable(CommandType commandType, string commandText, List<SqlParameter> parameters = null);
    }
}