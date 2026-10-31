using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class RolePermissionSrv(SqlConnectionFactory factory)
{
    public async Task Create(RolePermissionsModel RolePermissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionsSql.Insert, RolePermissionDto);
    }
    public async Task<IEnumerable<RolePermissionsModel>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<RolePermissionsModel>(RolePermissionsSql.Select);
    }

    public async Task<RolePermissionsModel> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<RolePermissionsModel>(RolePermissionsSql.SelectById, new { Id });
    }
    public async Task Update(RolePermissionsModel RolePermissionDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionsSql.Update, RolePermissionDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RolePermissionsSql.Delete, new { Id });
    }
}
