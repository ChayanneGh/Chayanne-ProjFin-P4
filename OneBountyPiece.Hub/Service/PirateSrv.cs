using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class PirateSrv(CFactory factory)
{
    public async Task Create(PirateMdl PirateDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PirateSql.Insert, PirateDto);
    }
    public async Task<IEnumerable<PirateMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<PirateMdl>(PirateSql.Select);
    }

    public async Task<PirateMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<PirateMdl>(PirateSql.SelectById, new { Id });
    }
    public async Task Update(PirateMdl PirateDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PirateSql.Update, PirateDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PirateSql.Delete, new { Id });
    }
}
