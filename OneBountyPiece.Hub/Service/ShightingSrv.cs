using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class ShightingsSrv(CFactory factory)
{
    public async Task Create(ShightingMdl ShightingDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShightingSql.Insert, ShightingDto);
    }
    public async Task<IEnumerable<ShightingMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<ShightingMdl>(ShightingSql.Select);
    }

    public async Task<ShightingMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<ShightingMdl>(ShightingSql.SelectById, new { Id });
    }
    public async Task Update(ShightingMdl ShightingDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShightingSql.Update, ShightingDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShightingSql.Delete, new { Id });
    }
}