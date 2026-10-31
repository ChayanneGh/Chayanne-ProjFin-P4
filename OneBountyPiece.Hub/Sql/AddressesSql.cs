namespace OneBountyPiece.Hub.Sql;

public class AddressesSql
{
    public const string Insert =
        "INSERT INTO Addresses (Country, Region) VALUES(@Country, @Region)";

    public const string Select =
        "SELECT * FROM Addresses";

    public const string SelectById =
        "SELECT * FROM Addresses " +
        "WHERE IdAddress = @ IdAddress";
    public const string Update =
        "UPDATE Addresses Set Country = @Country, Region = @Region " +
        "WHERE IdAddress = @IdAddress";

    public const string Delete =
        "DELETE FROM Addresses " +
        "WHERE IdAddress = @IdAddress";
}
