namespace GameStore.Api.DTOs;

public record class GameSummaryDTO(
    int id,
    string name,
    string genre,
    decimal price,
    DateOnly releaseDate);