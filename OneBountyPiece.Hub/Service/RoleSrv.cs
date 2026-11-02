using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class RoleSrv(CFactory factory)
{
    public async Task Create(RoleMdl RolesDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RoleSql.Insert, RolesDto);
    }
    public async Task<IEnumerable<RoleMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<RoleMdl>(RoleSql.Select);
    }

    public async Task<RoleMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<RoleMdl>(RoleSql.SelectById, new { Id });
    }
    public async Task Update(RoleMdl RolesDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RoleSql.Update, RolesDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(RoleSql.Delete, new { Id });
    }
}
