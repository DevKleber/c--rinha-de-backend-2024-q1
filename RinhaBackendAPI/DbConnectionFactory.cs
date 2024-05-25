using System.Data;
using System.Reflection.Metadata;
using Npgsql;

namespace RinhaBackendAPI;


public class DbConnectionFactory
{
    private readonly IConfiguration configuration;
    
    public DbConnectionFactory(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public IDbConnection GetConnection()
    {
        return new NpgsqlConnection(configuration["connectionString"]);
    }
}