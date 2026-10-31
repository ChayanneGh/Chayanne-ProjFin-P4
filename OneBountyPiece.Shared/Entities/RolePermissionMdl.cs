namespace OneBountyPiece.Shared.Entities;

public record RolePermissionMdl(
    int IdRolePermission,
    int IdRole,
    int IdPermission
    );