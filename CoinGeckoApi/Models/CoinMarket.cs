namespace CoinGeckoApi.Models;

public class CoinMarket
{
    public string Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double CurrentPrice { get; set; }
    public long MarketCap { get; set; }
    public int MarketCapRank { get; set; }
    public long TotalVolume { get; set; }
    public double High24h { get; set; }
    public double Low24h { get; set; }
    public double PriceChange24h { get; set; }
    public double PriceChangePercentage24h { get; set; }
    public string Image { get; set; }
}