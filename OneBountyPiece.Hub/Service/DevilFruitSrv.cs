using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class DevilFruitSrv(CFactory factory)
{
    public async Task Create(DevilFruitMdl DevilFruitDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(DevilFruitSql.Insert, DevilFruitDto);
    }
    public async Task<IEnumerable<DevilFruitMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<DevilFruitMdl>(DevilFruitSql.Select);
    }

    public async Task<DevilFruitMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<DevilFruitMdl>(DevilFruitSql.SelectById, new { Id });
    }
    public async Task Update(DevilFruitMdl DevilFruitDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(DevilFruitSql.Update, DevilFruitDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(DevilFruitSql.Delete, new { Id });
    }
}
