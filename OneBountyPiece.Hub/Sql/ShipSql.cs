namespace OneBountyPiece.Hub.Sql;

public class ShipSql
{
    public const string Insert =
        "INSERT INTO Ships (Name, IdCaptain, BirthDate, IdTypeShip, UtilityRooms, Speciality)" +
        " VALUES(@Name, @IdCaptain, @BirthDate, @IdTypeShip, @UtilityRooms, @Speciality)";

    public const string Select =
        "SELECT * FROM Ships";

    public const string SelectById =
        "SELECT * FROM Ships " +
        "WHERE IdShip = @ IdShip";
    public const string Update =
        "UPDATE Ships Name = @Name, IdCaptain = IdCaptain, BirthDate = BirthDate, IdTypeShip = IdTypeShip, " +
        "UtilityRooms = UtilityRooms, Speciality = Speciality " +
        "WHERE IdShip = @IdShip";

    public const string Delete =
        "DELETE FROM Ships " +
        "WHERE IdShip = @IdShip";
}
