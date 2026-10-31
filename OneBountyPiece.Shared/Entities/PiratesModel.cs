namespace OneBountyPiece.Shared.Entities;

public record PiratesModel(
    int Pirate,
    string FName,
    string LName,
    int Age,
    int Address,
    float reward,
    int IdCrew,
    int IdDevilFruit,
    string Speciality
    );