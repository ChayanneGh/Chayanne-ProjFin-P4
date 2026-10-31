using Microsoft.Data.SqlClient;
namespace OneBountyPiece.Hub.Service;

public class SqlConnectionFactory(IConfiguration configuration)
{
    private readonly string _connectionString = configuration.GetConnectionString("OneBountyPiece");
    public SqlConnection createConnection()
    {
        return new SqlConnection(_connectionString);
    }
} 
