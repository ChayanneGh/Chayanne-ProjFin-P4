namespace OneBountyPiece.Shared.Entities;

public record SystemUsersModel(
    int IdSystemUser,
    string Name,
    string Password,
    int Role,
    bool IsActive
    );