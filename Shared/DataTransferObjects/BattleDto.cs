namespace Shared.DataTransferObjects
{
    public record BattleDto(Guid Id, Guid Winner_ID, Guid Loser_ID, DateTime Date);
}
