using OneBountyPiece.Shared.Entities;
using OneBountyPiece.Hub.Sql;
using Dapper;
namespace OneBountyPiece.Hub.Service
{
    public class PermissionsService(SqlConnectionFactory factory)
    {
        public async Task Create(PermissionsModel PermissionDto)
        {
            using var connection = factory.createConnection();
            await connection.ExecuteAsync(PermissionsSql.Insert, PermissionDto);
        }
        public async Task<IEnumerable<PermissionsModel>> Read()
        {
            using var connection = factory.createConnection();
            return await connection.QueryAsync<PermissionsModel>(PermissionsSql.Select);
        }

        public async Task<PermissionsModel> ReadOne(int Id)
        {
            using var connection = factory.createConnection();
            return await connection.QueryFirstOrDefaultAsync<PermissionsModel>(PermissionsSql.SelectById, new {Id});
        }
        public async Task Update(PermissionsModel permissionDto)
        {
            using var connection = factory.createConnection();
            await connection.ExecuteAsync(PermissionsSql.Update, permissionDto);
        }
        public async Task Delete(int Id)
        {
            using var connection = factory.createConnection();
            await connection.ExecuteAsync(PermissionsSql.Delete, new { Id });
        }
    }
}
