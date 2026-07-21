public static class ProfitCalculator
{
    public static decimal CalculateProfit(decimal buy, decimal current, int amount)
    {
        return (current - buy) * amount;
    }

    public static decimal CalculateROI(decimal buy, decimal current)
    {
        return buy == 0
            ? 0
            : ((current - buy) / buy) * 100;
    }
}