using Dapper;
using RinhaBackendAPI.Models;

namespace RinhaBackendAPI.Repository;

public class ClienteRepository
{
    private readonly DbConnectionFactory dbConnectionFactory;

    public ClienteRepository(DbConnectionFactory dbConnectionFactory)
    {
        this.dbConnectionFactory = dbConnectionFactory;
    }

    public Cliente Get(int id)
    {
        var sql = "select * from clientes where id = @Id";
        var conn = dbConnectionFactory.GetConnection();
        return conn.QuerySingle<Cliente>(sql, new { Id = id });
    }
}