using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class TypeShipSrv(SqlConnectionFactory factory)
{
    public async Task Create(TypeShipMdl TypeShipDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(TypeShipSql.Insert, TypeShipDto);
    }
    public async Task<IEnumerable<TypeShipMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<TypeShipMdl>(TypeShipSql.Select);
    }

    public async Task<TypeShipMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<TypeShipMdl>(TypeShipSql.SelectById, new { Id });
    }
    public async Task Update(TypeShipMdl TypeShipDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(TypeShipSql.Update, TypeShipDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(TypeShipSql.Delete, new { Id });
    }
}
