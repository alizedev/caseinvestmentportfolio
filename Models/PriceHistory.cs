namespace CaseInvestmentTracker.Models;

public class PriceHistory
{
    public int Id { get; set; }

    // Welcher Case
    public string CaseName { get; set; } = string.Empty;

    // Datum der Messung
    public DateTime Date { get; set; }

    // Preis an diesem Tag
    public decimal Price { get; set; }

    // Anzahl Verkäufe (optional)
    public int Volume { get; set; }

    public PriceHistory()
    {

    }

    public PriceHistory(string caseName, decimal price)
    {
        CaseName = caseName;
        Price = price;
        Date = DateTime.Now;
    }
}