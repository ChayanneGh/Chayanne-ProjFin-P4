namespace OneBountyPiece.Hub.Sql
{
    public class SystemUserSql
    {
        public const string Insert =
        "INSERT INTO SystemUsers (Name, Password, IdRole, IsActive) VALUES(@Name, @Password, @IdRole, @IsActive)";

        public const string Select =
            "SELECT * FROM SystemUsers";

        public const string SelectById =
            "SELECT * FROM SystemUsers " +
            "WHERE IdSystemUser = @ IdSystemUser";
        public const string Update =
            "UPDATE SystemUsers Set Name = @Name, Password = @Password, IdRole = @IdRole, IsActive = @IsActive " +
            "WHERE IdSystemUser = @IdSystemUser";

        public const string Delete =
            "DELETE FROM SystemUsers " +
            "WHERE IdSystemUser = @IdSystemUser";
    }
}
