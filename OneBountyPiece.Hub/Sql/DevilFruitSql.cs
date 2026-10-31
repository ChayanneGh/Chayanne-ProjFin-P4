namespace OneBountyPiece.Hub.Sql;

public class DevilFruitSql
{
    public const string Insert =
        "INSERT INTO DevilFruits (Name, Type, Description, IsAwakened) VALUES(@Name, @Type, @Description, @IsAwakened)";

    public const string Select =
        "SELECT * FROM DevilFruits";

    public const string SelectById =
        "SELECT * FROM DevilFruits " +
        "WHERE IdDevilFruit = @ IdDevilFruit";
    public const string Update =
        "UPDATE DevilFruits Name = @Name, Type = @Type, Description = @Description, IsAwakened = IsAwakened " +
        "WHERE IdDevilFruit = @IdDevilFruit";

    public const string Delete =
        "DELETE FROM DevilFruits " +
        "WHERE IdDevilFruit = @IdDevilFruit";
}
