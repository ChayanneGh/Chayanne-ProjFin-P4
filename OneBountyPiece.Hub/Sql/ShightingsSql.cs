namespace OneBountyPiece.Hub.Sql;

public class ShightingsSql
{
    public const string Insert =
        "INSERT INTO Shightings (ReporterName, TargetType, TargerId, Description, IdAddress, ImageUrl, Status, CreateAt, AttendedBy) " +
        "VALUES(@ReporterName, @TargetType, @TargerId, @Description, @IdAddress, @ImageUrl, @Status, @CreateAt, @AttendedBy)";

    public const string Select =
        "SELECT * FROM Shightings";

    public const string SelectById =
        "SELECT * FROM Shightings " +
        "WHERE IdShighting = @ IdShighting";
    public const string Update =
        "UPDATE Shightings " +
        "ReporterName = @ReporterName, TargetType = @TargetType, TargerId = @TargerId, Description = @Description, " +
        "IdAddress = @IdAddress, ImageUrl = @ImageUrl, Status = @Status, CreateAt = @CreateAt, AttendedBy = @AttendedBy " +
        "WHERE IdShighting = @IdShighting";

    public const string Delete =
        "DELETE FROM Shightings " +
        "WHERE IdShighting = @IdShighting";
}
