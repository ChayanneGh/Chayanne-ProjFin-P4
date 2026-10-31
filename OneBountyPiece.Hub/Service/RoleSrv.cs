using Dapper;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub;

public class RoleSrv(SqlConnectionFactory factory)
{
    public async Task Create(RoleMdl RolesDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Insert, RolesDto);
    }
    public async Task<IEnumerable<RoleMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<RoleMdl>(PermissionSql.Select);
    }

    public async Task<RoleMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<RoleMdl>(PermissionSql.SelectById, new { Id });
    }
    public async Task Update(RoleMdl RolesDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Update, RolesDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PermissionSql.Delete, new { Id });
    }
}
