namespace CoinGeckoApi.Models;

public class ApiUsageResponse
{
    public long UsedEndpoints { get; set; }
    public long RequestsCount { get; set; }
    public long RequestsLimit { get; set; }
    public long RequestsRemaining { get; set; }
}