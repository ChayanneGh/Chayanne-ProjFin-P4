using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class CrewSrv(CFactory factory)
{
    public async Task Create(CrewMdl CrewDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(CrewSql.Insert, CrewDto);
    }
    public async Task<IEnumerable<CrewMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<CrewMdl>(CrewSql.Select);
    }

    public async Task<CrewMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<CrewMdl>(CrewSql.SelectById, new { Id });
    }
    public async Task Update(CrewMdl CrewDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(CrewSql.Update, CrewDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(CrewSql.Delete, new { Id });
    }
}
