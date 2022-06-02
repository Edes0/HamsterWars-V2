public sealed class BattleNotFoundException : NotFoundException
{
    public BattleNotFoundException(Guid battleId)
    : base($"The battle with id: {battleId} doesn't exist in the database.")
    {
    }
}
