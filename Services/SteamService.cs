using System.Globalization;
using System.Net.Http;
using System.Text.Json;

namespace CaseInvestmentTracker.Services;

public class SteamService
{
    private readonly HttpClient _httpClient = new();

    public async Task<decimal?> GetLowestPriceAsync(string marketHashName)
    {
        try
        {
            string url =
                $"https://steamcommunity.com/market/priceoverview/" +
                $"?currency=3&appid=730&market_hash_name={Uri.EscapeDataString(marketHashName)}";

            string json = await _httpClient.GetStringAsync(url);

            var result = JsonSerializer.Deserialize<SteamPriceResponse>(json);

            if (result == null || string.IsNullOrEmpty(result.lowest_price))
                return null;

            string price = result.lowest_price
                .Replace("€", "")
                .Replace(",", ".")
                .Trim();

            if (decimal.TryParse(price,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal value))
            {
                return value;
            }

            return null;
        }
        catch
        {
            return null;
        }
    }
}