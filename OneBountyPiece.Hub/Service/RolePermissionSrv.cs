using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class RolePermissionSrv(CFactory factory)
{
    public async Task Create(RolePermissionMdl RolePermissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionSql.Insert, RolePermissionDto);
    }
    public async Task<IEnumerable<RolePermissionMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<RolePermissionMdl>(RolePermissionSql.Select);
    }

    public async Task<RolePermissionMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<RolePermissionMdl>(RolePermissionSql.SelectById, new { Id });
    }
    public async Task Update(RolePermissionMdl RolePermissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionSql.Update, RolePermissionDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionSql.Delete, new { Id });
    }
}
