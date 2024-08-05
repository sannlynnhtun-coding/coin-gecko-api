using CoinGeckoApi.Models;
using Newtonsoft.Json;
using System.Text;

namespace CoinGeckoApi.Services;

public class HttpClientService
{
    private readonly HttpClient _client;
    private string _apiKey;

    public HttpClientService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
    }

    public void SetApiKey(string apiKey)
    {
        _apiKey = apiKey;
    }

    public async Task<T> ExecuteAsync<T>(
        string endpoint,
        EnumHttpMethod httpMethod = EnumHttpMethod.Get,
        object reqModel = null)
    {
        T model = default;
        HttpResponseMessage response = null;
        HttpContent content = null;

        // Add the API key to the request headers
        _client.DefaultRequestHeaders.Clear();
        if (!string.IsNullOrEmpty(_apiKey))
        {
            _client.DefaultRequestHeaders.Add("X-CG-API-KEY", _apiKey);
        }

        if (reqModel != null)
        {
            content = new StringContent(JsonConvert.SerializeObject(reqModel), Encoding.UTF8, "application/json");
        }

        switch (httpMethod)
        {
            case EnumHttpMethod.Post:
                response = await _client.PostAsync(endpoint, content);
                break;
            case EnumHttpMethod.Put:
                response = await _client.PutAsync(endpoint, content);
                break;
            case EnumHttpMethod.Patch:
                response = await _client.PatchAsync(endpoint, content);
                break;
            case EnumHttpMethod.Delete:
                response = await _client.DeleteAsync(endpoint);
                break;
            case EnumHttpMethod.Get:
            default:
                response = await _client.GetAsync(endpoint);
                break;
        }

        if (response.IsSuccessStatusCode)
        {
            var jsonStr = await response.Content.ReadAsStringAsync();
            model = JsonConvert.DeserializeObject<T>(jsonStr);
        }

        return model;
    }

    // Method to call the /ping endpoint
    public async Task<PingResponse> PingServerAsync()
    {
        return await ExecuteAsync<PingResponse>("ping");
    }

    // Method to call the /simple/price endpoint
    public async Task<SimplePriceResponse> GetSimplePriceAsync(SimplePriceRequest request)
    {
        string endpoint = $"simple/price?ids={request.Ids}&vs_currencies={request.VsCurrencies}";
        return await ExecuteAsync<SimplePriceResponse>(endpoint);
    }

    // Method to call the /coins/markets endpoint for top gainers/losers
    public async Task<CoinsTopGainersLosersResponse> GetCoinsTopGainersLosersAsync(string vsCurrency, int perPage)
    {
        string endpoint = $"coins/markets?vs_currency={vsCurrency}&order=market_cap_desc&per_page={perPage}&page=1&sparkline=false";
        return await ExecuteAsync<CoinsTopGainersLosersResponse>(endpoint);
    }

    // Method to call the /api/v3/api_usage endpoint
    public async Task<ApiUsageResponse> GetApiUsageAsync()
    {
        return await ExecuteAsync<ApiUsageResponse>("api_usage");
    }

    // Method to call the /coins/list/new endpoint
    public async Task<CoinsListNewResponse> GetCoinsListNewAsync()
    {
        return await ExecuteAsync<CoinsListNewResponse>("coins/list/new");
    }

    // Method to call the /coins/{id} endpoint
    public async Task<CoinByIdResponse> GetCoinByIdAsync(string id)
    {
        string endpoint = $"coins/{id}";
        return await ExecuteAsync<CoinByIdResponse>(endpoint);
    }

    // Method to call the /coins/categories/list endpoint
    public async Task<CoinsCategoriesListResponse> GetCoinsCategoriesListAsync()
    {
        return await ExecuteAsync<CoinsCategoriesListResponse>("coins/categories/list");
    }

    // Method to call the /exchanges endpoint
    public async Task<ExchangesResponse> GetExchangesAsync()
    {
        return await ExecuteAsync<ExchangesResponse>("exchanges");
    }

    // Method to call the /exchanges/list endpoint
    public async Task<List<Exchange>> GetExchangesListAsync()
    {
        return await ExecuteAsync<List<Exchange>>("exchanges/list");
    }

    // Method to call the /exchanges/{id} endpoint
    public async Task<ExchangeByIdResponse> GetExchangeByIdAsync(string id)
    {
        string endpoint = $"exchanges/{id}";
        return await ExecuteAsync<ExchangeByIdResponse>(endpoint);
    }

    // Method to call the /nfts/list endpoint
    public async Task<NftsListResponse> GetNftsListAsync()
    {
        return await ExecuteAsync<NftsListResponse>("nfts/list");
    }

    // Method to call the /nfts/{id} endpoint
    public async Task<NftByIdResponse> GetNftByIdAsync(string id)
    {
        string endpoint = $"nfts/{id}";
        return await ExecuteAsync<NftByIdResponse>(endpoint);
    }

    // Method to call the /search endpoint
    public async Task<SearchDataResponse> SearchDataAsync(string query)
    {
        string endpoint = $"search?query={query}";
        return await ExecuteAsync<SearchDataResponse>(endpoint);
    }

    // Method to call the /search/trending endpoint
    public async Task<TrendingSearchResponse> GetTrendingSearchAsync()
    {
        return await ExecuteAsync<TrendingSearchResponse>("search/trending");
    }

    // Method to call the /global endpoint
    public async Task<CryptoGlobalResponse> GetCryptoGlobalAsync()
    {
        return await ExecuteAsync<CryptoGlobalResponse>("global");
    }

    // Method to call the /companies/public_treasury endpoint
    public async Task<CompaniesPublicTreasuryResponse> GetCompaniesPublicTreasuryAsync(string coinId)
    {
        string endpoint = $"companies/public_treasury/{coinId}";
        return await ExecuteAsync<CompaniesPublicTreasuryResponse>(endpoint);
    }
}