namespace OneBountyPiece.Hub.Sql;

public class RolePermissionSql
{
    public const string Insert =
        "INSERT INTO RolePermissions (IdRole, IdPermission) VALUES(@IdRole, @IdPermission)";

    public const string Select =
        "SELECT * FROM RolePermissions";

    public const string SelectById =
        "SELECT * FROM RolePermissions " +
        "WHERE IdRolePermission = @ IdRolePermission";
    public const string Update =
        "UPDATE RolePermissions Set IdRole = @IdRole, IdPermission = IdPermission " +
        "WHERE IdRolePermission = @IdRolePermission";

    public const string Delete =
        "DELETE FROM RolePermissions " +
        "WHERE IdRolePermission = @IdRolePermission";
}
