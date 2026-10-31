namespace OneBountyPiece.Hub.Sql;

public class RoleSql
{
    public const string Insert =
    "INSERT INTO Roles (Description) VALUES(@Description)";

    public const string Select =
        "SELECT * FROM Roles";

    public const string SelectById =
        "SELECT * FROM Roles " +
        "WHERE IdRole = @ IdRole";
    public const string Update =
        "UPDATE Roles Set Description = @Description " +
        "WHERE IdRole = @IdRole";

    public const string Delete =
        "DELETE FROM Roles " +
        "WHERE IdRole = @IdRole";
}
