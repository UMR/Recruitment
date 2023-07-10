namespace Recruitment.Persistence.Common
{
    public class DataAccessBase
    {
        private readonly IDapperContext _dapperContext;

        public DataAccessBase(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public DataSet GetDataSet(string query, SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = new SqlConnection(_dapperContext.ConnectionString))
            {
                SqlCommand sqlcommand = new SqlCommand()
                {
                    CommandText = query,
                    Connection = connection,
                    CommandType = CommandType.Text
                };

                sqlcommand.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
                da.Fill(ds);
            }

            return ds;
        }
    }
}
