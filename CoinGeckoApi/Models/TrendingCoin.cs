namespace CoinGeckoApi.Models;

public class TrendingCoin
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public int MarketCapRank { get; set; }
}