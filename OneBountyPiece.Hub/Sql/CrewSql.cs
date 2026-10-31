namespace OneBountyPiece.Hub.Sql;

public class CrewSql
{
    public const string Insert =
        "INSERT INTO Crews (Name, JollyRogerUrl, TotalBounty) VALUES(@Name, @JollyRogerUrl, @TotalBounty)";

    public const string Select =
        "SELECT * FROM Crews";

    public const string SelectById =
        "SELECT * FROM Crews " +
        "WHERE IdCrew = @ IdCrew";
    public const string Update =
        "UPDATE Crews Name = @Name, JollyRogerUrl = @JollyRogerUrl, TotalBounty = @TotalBounty " +
        "WHERE IdCrew = @IdCrew";

    public const string Delete =
        "DELETE FROM Crews " +
        "WHERE IdCrew = @IdCrew";
}
