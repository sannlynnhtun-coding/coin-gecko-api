namespace CoinGeckoApi.Models;

public class CoinByIdResponse
{
    public string Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public Localization Localization { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public double MarketCap { get; set; }
    public double MarketCapRank { get; set; }
    public double TotalVolume { get; set; }
    public double High24h { get; set; }
    public double Low24h { get; set; }
    public double PriceChangePercentage24h { get; set; }
    public Dictionary<string, double> CurrentPrice { get; set; }
}