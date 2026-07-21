public class Case
{
    public string Name { get; set; }

    public decimal BuyPrice { get; set; }

    public decimal CurrentPrice { get; set; }

    public int Quantity { get; set; }

    public string ImageUrl { get; set; }

    public decimal Invested => BuyPrice * Quantity;

    public decimal CurrentValue => CurrentPrice * Quantity;

    public decimal Profit => CurrentValue - Invested;

    public decimal ProfitPercent =>
        Invested == 0 ? 0 :
            ((CurrentValue - Invested) / Invested) * 100;
}