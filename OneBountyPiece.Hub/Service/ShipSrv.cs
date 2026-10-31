using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class ShipSrv(SqlConnectionFactory factory)
{
    public async Task Create(ShipMdl ShipDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShipSql.Insert, ShipDto);
    }
    public async Task<IEnumerable<ShipMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<ShipMdl>(ShipSql.Select);
    }

    public async Task<ShipMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<ShipMdl>(ShipSql.SelectById, new { Id });
    }
    public async Task Update(ShipMdl ShipDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShipSql.Update, ShipDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(ShipSql.Delete, new { Id });
    }
}
