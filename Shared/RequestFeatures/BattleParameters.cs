namespace Shared.RequestFeatures
{
    public class BattleParameters : RequestParameters
    {
        public BattleParameters() => OrderBy = "date";
        public DateTime MinDate { get; set; } = DateTime.MinValue;
        public DateTime MaxDate { get; set; } = DateTime.MaxValue;
        public bool ValidDateRange => MaxDate >= MinDate;
        public string? SearchTerm { get; set; }
        public string? HamsterId { get; set; }
    }
}
