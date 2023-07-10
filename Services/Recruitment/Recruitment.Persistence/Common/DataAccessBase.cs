namespace Recruitment.Persistence.Common
{
    public class DataAccessBase : IDataAccessBase
    {
        private readonly IConfiguration _configuration;

        public DataAccessBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ConnectionString {
            get {
                return _configuration.GetConnectionString("DefaultConnection");
            }
        }

        public DataSet GetDataSet(CommandType commandType, string query, List<SqlParameter> parameters = null)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlcommand = new SqlCommand()
                {
                    CommandText = query,
                    Connection = connection,
                    CommandType = commandType
                };

                if (parameters != null && parameters.Count > 0)
                {
                    sqlcommand.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
                da.Fill(ds);
            }

            return ds;
        }
    }
}
