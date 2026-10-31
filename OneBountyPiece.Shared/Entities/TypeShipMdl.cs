namespace OneBountyPiece.Shared.Entities;

public record TypeShipMdl(
    int TypeShip,
    string Name,
    int Length,
    int Heigth,
    int Width,
    float NetWeight,
    float DeadWeight,
    int PassangerCapacity,
    string Description
    );