using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class PirateSrv(SqlConnectionFactory factory)
{
    public async Task Create(PirateMdl PirateDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PiratesSql.Insert, PirateDto);
    }
    public async Task<IEnumerable<PirateMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<PirateMdl>(PiratesSql.Select);
    }

    public async Task<PirateMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<PirateMdl>(PiratesSql.SelectById, new { Id });
    }
    public async Task Update(PirateMdl PirateDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PiratesSql.Update, PirateDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(PiratesSql.Delete, new { Id });
    }
}
