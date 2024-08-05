namespace CoinGeckoApi.Models
{
    public class NftByIdResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string TotalSupply { get; set; }
    }

    public class NftsListResponse
    {
        public List<Nft> Nfts { get; set; }
    }

    public class Nft
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Exchange
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class ExchangesResponse
    {
        public List<Exchange> Exchanges { get; set; }
    }

    public class ExchangeByIdResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string YearEstablished { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string HasTradingIncentive { get; set; }
    }


    public class SearchDataResponse
    {
        public List<SearchCoin> Coins { get; set; }
        public List<SearchExchange> Exchanges { get; set; }
        public List<SearchNft> Nfts { get; set; }
    }

    public class SearchCoin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class SearchExchange
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class SearchNft
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class TrendingSearchResponse
    {
        public List<TrendingCoin> Coins { get; set; }
    }

    public class TrendingCoin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int MarketCapRank { get; set; }
    }

    public class CryptoGlobalResponse
    {
        public CryptoData Data { get; set; }
    }

    public class CryptoData
    {
        public double TotalMarketCapUsd { get; set; }
        public double TotalVolumeUsd { get; set; }
        public double MarketCapChangePercentage24hUsd { get; set; }
    }

    public class CompaniesPublicTreasuryResponse
    {
        public List<CompanyHolding> Holdings { get; set; }
    }

    public class CompanyHolding
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double TotalAmount { get; set; }
        public double TotalValueUsd { get; set; }
    }

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

    public class Localization
    {
        public string En { get; set; }
        public string De { get; set; }
        public string Es { get; set; }
        public string Fr { get; set; }
        public string It { get; set; }
        public string Pl { get; set; }
        public string Ro { get; set; }
        public string Hu { get; set; }
        public string Nl { get; set; }
        public string Pt { get; set; }
        public string Sv { get; set; }
        public string Vi { get; set; }
        public string Tr { get; set; }
        public string Ru { get; set; }
        public string Ja { get; set; }
        public string Zh { get; set; }
        public string Zh_tw { get; set; }
        public string Ko { get; set; }
        public string Ar { get; set; }
        public string Th { get; set; }
    }

    public class PingResponse
    {
        public string Geckosays { get; set; }
    }

    public class SimplePriceResponse : Dictionary<string, Dictionary<string, decimal>>
    {
    }

    public class CoinsTopGainersLosersResponse : List<CoinMarket>
    {
    }

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

    public class ApiUsageResponse
    {
        public long UsedEndpoints { get; set; }
        public long RequestsCount { get; set; }
        public long RequestsLimit { get; set; }
        public long RequestsRemaining { get; set; }
    }

    public class CoinsCategoriesListResponse : List<CoinCategory>
    {
    }

    public class CoinCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CoinsListNewResponse : List<Coin>
    {
    }

    public class Coin
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    public class SimplePriceRequest
    {
        public string Ids { get; set; }
        public string VsCurrencies { get; set; }
    }
}
