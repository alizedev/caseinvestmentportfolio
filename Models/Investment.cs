public class PortfolioService
{
    public List<Case> Cases { get; set; } = new();

    public decimal TotalInvested =>
        Cases.Sum(x => x.Invested);

    public decimal CurrentValue =>
        Cases.Sum(x => x.CurrentValue);

    public decimal TotalProfit =>
        CurrentValue - TotalInvested;

    public decimal ROI =>
        TotalInvested == 0
            ? 0
            : (TotalProfit / TotalInvested) * 100;
}