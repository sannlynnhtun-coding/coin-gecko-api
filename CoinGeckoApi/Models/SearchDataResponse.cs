namespace CoinGeckoApi.Models;

public class SearchDataResponse
{
    public List<SearchCoin> Coins { get; set; }
    public List<SearchExchange> Exchanges { get; set; }
    public List<SearchNft> Nfts { get; set; }
}