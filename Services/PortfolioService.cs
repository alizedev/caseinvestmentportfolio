using CaseInvestmentTracker.Models;

namespace CaseInvestmentTracker.Services;

public class PortfolioService
{
    public List<Case> Cases { get; } = new();

    public decimal TotalInvested =>
        Cases.Sum(c => c.Invested);

    public decimal CurrentValue =>
        Cases.Sum(c => c.CurrentValue);

    public decimal TotalProfit =>
        CurrentValue - TotalInvested;

    public decimal ROI =>
        TotalInvested == 0
            ? 0
            : (TotalProfit / TotalInvested) * 100;

    public void AddCase(Case item)
    {
        Cases.Add(item);
    }

    public void RemoveCase(Case item)
    {
        Cases.Remove(item);
    }

    public void Clear()
    {
        Cases.Clear();
    }

    public decimal GetDailyProfit(decimal yesterdayValue)
    {
        return CurrentValue - yesterdayValue;
    }

    public Case? GetBestInvestment()
    {
        return Cases
            .OrderByDescending(c => c.ProfitPercent)
            .FirstOrDefault();
    }

    public Case? GetWorstInvestment()
    {
        return Cases
            .OrderBy(c => c.ProfitPercent)
            .FirstOrDefault();
    }

    public decimal GetAverageROI()
    {
        if (!Cases.Any())
            return 0;

        return Cases.Average(c => c.ProfitPercent);
    }
}