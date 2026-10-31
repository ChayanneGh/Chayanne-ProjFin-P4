namespace OneBountyPiece.Shared.Entities;

public record ShightingsModel(
    int Shightting,
    string ReporterName,
    string TargerType,
    int TargetId,
    string Description,
    int Address,
    string ImageUrl,
    string Status,
    string CreateAt,
    int AttendedBy
    );