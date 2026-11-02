using Dapper;
using OneBountyPiece.Hub.Sql;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Service;

public class AddressSrv(CFactory factory)
{
    public async Task Create(AddressMdl AddresseDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(AddressSql.Insert, AddresseDto);
    }
    public async Task<IEnumerable<AddressMdl>> Read()
    {
        using var connection = factory.createConnection();
        return await connection.QueryAsync<AddressMdl>(AddressSql.Select);
    }

    public async Task<AddressMdl> ReadOne(int Id)
    {
        using var connection = factory.createConnection();
        return await connection.QueryFirstOrDefaultAsync<AddressMdl>(AddressSql.SelectById, new { Id });
    }
    public async Task Update(AddressMdl AddresseDto)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(AddressSql.Update, AddresseDto);
    }
    public async Task Delete(int Id)
    {
        using var connection = factory.createConnection();
        await connection.ExecuteAsync(AddressSql.Delete, new { Id });
    }
}
