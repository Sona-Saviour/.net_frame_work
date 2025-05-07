

using Microsoft.Data.SqlClient;

namespace api_example2.context
{
    public class DataContext
    {
      
            private readonly string _connectionString;

            public DataContext(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("SQLConnection");
            }

            public SqlConnection CreateConnection()
            {
                return new SqlConnection(_connectionString);
            }

        

    }
}
