namespace OneBountyPiece.Hub.Sql;

public class TypeShipSql
{
    public const string Insert =
        "INSERT INTO TypeShips (Name, Length, heigth, Width, NetWeight, DeadWeiht, PassangerCapasity, Description) " +
        "VALUES(@Name, @Length, @heigth, @Width, @NetWeight, @DeadWeiht, @PassangerCapasity, @Description)";

    public const string Select =
        "SELECT * FROM TypeShips";

    public const string SelectById =
        "SELECT * FROM TypeShips " +
        "WHERE IdTypeShip = @ IdTypeShip";
    public const string Update =
        "UPDATE TypeShips Set Name = @Name, Length = @Length, Heigth = @Heigth, Width = @Widgth, NetWeight = @NetWeight, " +
        "DeadWeiht = @DeadWeight, PassangerCapasity = PassangerCapasity, Description = @Description " +
        "WHERE IdTypeShip = @IdTypeShip";

    public const string Delete =
        "DELETE FROM TypeShips " +
        "WHERE IdTypeShip = @IdTypeShip";
}
