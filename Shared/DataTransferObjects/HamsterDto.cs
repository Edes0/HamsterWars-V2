namespace Shared.DataTransferObjects
{
    public record HamsterDto(Guid Id, string Name, int Age, string? FavouriteFood, string? FavouriteActivity, string ImageName, int Wins, int Defeats, int Games, int Likes);
}
