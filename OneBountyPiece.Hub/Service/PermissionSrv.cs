using OneBountyPiece.Shared.Entities;
using OneBountyPiece.Hub.Sql;
using Dapper;
namespace OneBountyPiece.Hub.Service;

public class PermissionSrv(SqlConnectionFactory factory)
{
    public async Task Create(PermissionMdl PermissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Insert, PermissionDto);
    }
    public async Task<IEnumerable<PermissionMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<PermissionMdl>(PermissionSql.Select);
    }

    public async Task<PermissionMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<PermissionMdl>(PermissionSql.SelectById, new {Id});
    }
    public async Task Update(PermissionMdl permissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Update, permissionDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Delete, new { Id });
    }
}
