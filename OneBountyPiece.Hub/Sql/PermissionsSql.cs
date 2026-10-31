namespace OneBountyPiece.Hub.Sql;

public class PermissionsSql
{
    public const string Insert =
        "INSERT INTO Permissions (Name) VALUES(@Name)";

    public const string Select =
        "SELECT * FROM Permissions";

    public const string SelectById =
        "SELECT * FROM Permissions " +
        "WHERE IdPermission = @ IdPermission";
    public const string Update =
        "UPDATE Permissions Name = @Name " +
        "WHERE IdPermission = @IdPermission";

    public const string Delete =
        "DELETE FROM Permissions " +
        "WHERE IdPermission = @IdPermission";
}
