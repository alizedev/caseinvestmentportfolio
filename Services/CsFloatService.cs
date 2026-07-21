using System.Net.Http.Headers;

public class CsFloatService
{
    private readonly HttpClient _client = new();

    public CsFloatService(string apiKey)
    {
        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue(apiKey);
    }

    public async Task<string> GetListingsAsync(string item)
    {
        return await _client.GetStringAsync(
            $"https://csfloat.com/api/v1/listings?market_hash_name={Uri.EscapeDataString(item)}");
    }
}