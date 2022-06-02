namespace Shared.RequestFeatures
{
    public class BattleParameters : RequestParameters
    {
        public BattleParameters() => OrderBy = "date";
        public DateTime MinDate { get; set; }
        public DateTime MaxDate { get; set; }
        public bool ValidDateRange => MaxDate >= MinDate;
        public string? SearchTerm { get; set; }
    }
}
