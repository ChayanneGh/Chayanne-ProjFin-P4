namespace OneBountyPiece.Shared.Entities;

public record ShipMdl(
    int IdShip,
    string Name,
    int IdCaptain,
    string Birthdate,
    int IdTypeShip,
    string UtilitiesRooms,
    string Speciality
    );