namespace OneBountyPiece.Shared.Entities;

public record SystemUserMdl(
    int IdSystemUser,
    string Name,
    string Password,
    int Role,
    bool IsActive
    );