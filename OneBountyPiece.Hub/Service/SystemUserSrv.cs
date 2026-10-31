using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class SystemUserSrv(SqlConnectionFactory factory)
{
    public async Task Create(SystemUserMdl SystemUserDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(SystemUserSql.Insert, SystemUserDto);
    }
    public async Task<IEnumerable<SystemUserMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<SystemUserMdl>(SystemUserSql.Select);
    }

    public async Task<SystemUserMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<SystemUserMdl>(SystemUserSql.SelectById, new { Id });
    }
    public async Task Update(SystemUserMdl SystemUserDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(SystemUserSql.Update, SystemUserDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(SystemUserSql.Delete, new { Id });
    }
}
