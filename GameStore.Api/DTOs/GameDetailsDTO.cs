namespace GameStore.Api.DTOs;

public record class GameDetailsDTO(
    int id,
    string name,
    int GenreID,
    decimal price,
    DateOnly releaseDate);