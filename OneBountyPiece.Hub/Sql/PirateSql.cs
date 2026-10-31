namespace OneBountyPiece.Hub.Sql;

public class PirateSql
{
    public const string Insert =
    "INSERT INTO PiratesSql (FName, LName, Age, IdAddress, Reward, IdCrew, IdDevilFruit, Speciality) " +
        "VALUES(@FName, @LName, @Age, @IdAddress, @Reward, @IdCrew, @IdDevilFruit, @Speciality)";

    public const string Select =
        "SELECT * FROM PiratesSql";

    public const string SelectById =
        "SELECT * FROM PiratesSql " +
        "WHERE IPirate = @ IPirate";
    public const string Update =
        "UPDATE PiratesSql Set FName = @FName, LName = @LName, Age = @Age, IdAddress = IdAddress, Reward = @Reward, " +
        "IdCrew = IdCrew, IdDevilFruit = @IdDevilFruit, Speciality = @Speciality " +
        "WHERE IPirate = @IPirate";

    public const string Delete =
        "DELETE FROM PiratesSql " +
        "WHERE IPirate = @IPirate";
}
