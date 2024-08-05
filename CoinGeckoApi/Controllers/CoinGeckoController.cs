using CoinGeckoApi.Models;
using CoinGeckoApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoinGeckoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinGeckoController : ControllerBase
    {
        private readonly HttpClientService _httpClientService;

        public CoinGeckoController(HttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        [HttpGet("ping")]
        public async Task<ActionResult<PingResponse>> Ping()
        {
            var response = await _httpClientService.PingServerAsync();
            return Ok(response);
        }

        [HttpGet("simple-price")]
        public async Task<ActionResult<SimplePriceResponse>> GetSimplePrice([FromQuery] SimplePriceRequest request)
        {
            var response = await _httpClientService.GetSimplePriceAsync(request);
            return Ok(response);
        }

        [HttpGet("coins-top-gainers-losers")]
        public async Task<ActionResult<CoinsTopGainersLosersResponse>> GetCoinsTopGainersLosers([FromQuery] string vsCurrency, [FromQuery] int perPage = 10)
        {
            var response = await _httpClientService.GetCoinsTopGainersLosersAsync(vsCurrency, perPage);
            return Ok(response);
        }

        [HttpGet("api-usage")]
        public async Task<ActionResult<ApiUsageResponse>> GetApiUsage()
        {
            var response = await _httpClientService.GetApiUsageAsync();
            return Ok(response);
        }

        [HttpGet("coins-list-new")]
        public async Task<ActionResult<CoinsListNewResponse>> GetCoinsListNew()
        {
            var response = await _httpClientService.GetCoinsListNewAsync();
            return Ok(response);
        }

        [HttpGet("coins-id")]
        public async Task<ActionResult<CoinByIdResponse>> GetCoinById([FromQuery] string id)
        {
            var response = await _httpClientService.GetCoinByIdAsync(id);
            return Ok(response);
        }

        [HttpGet("coins-categories-list")]
        public async Task<ActionResult<CoinsCategoriesListResponse>> GetCoinsCategoriesList()
        {
            var response = await _httpClientService.GetCoinsCategoriesListAsync();
            return Ok(response);
        }

        [HttpGet("exchanges")]
        public async Task<ActionResult<ExchangesResponse>> GetExchanges()
        {
            var response = await _httpClientService.GetExchangesAsync();
            return Ok(response);
        }

        [HttpGet("exchanges-list")]
        public async Task<ActionResult<List<Exchange>>> GetExchangesList()
        {
            var response = await _httpClientService.GetExchangesListAsync();
            return Ok(response);
        }

        [HttpGet("exchanges-id")]
        public async Task<ActionResult<ExchangeByIdResponse>> GetExchangeById([FromQuery] string id)
        {
            var response = await _httpClientService.GetExchangeByIdAsync(id);
            return Ok(response);
        }

        [HttpGet("nfts-list")]
        public async Task<ActionResult<NftsListResponse>> GetNftsList()
        {
            var response = await _httpClientService.GetNftsListAsync();
            return Ok(response);
        }

        [HttpGet("nfts-id")]
        public async Task<ActionResult<NftByIdResponse>> GetNftById([FromQuery] string id)
        {
            var response = await _httpClientService.GetNftByIdAsync(id);
            return Ok(response);
        }

        [HttpGet("search-data")]
        public async Task<ActionResult<SearchDataResponse>> SearchData([FromQuery] string query)
        {
            var response = await _httpClientService.SearchDataAsync(query);
            return Ok(response);
        }

        [HttpGet("trending-search")]
        public async Task<ActionResult<TrendingSearchResponse>> GetTrendingSearch()
        {
            var response = await _httpClientService.GetTrendingSearchAsync();
            return Ok(response);
        }

        [HttpGet("crypto-global")]
        public async Task<ActionResult<CryptoGlobalResponse>> GetCryptoGlobal()
        {
            var response = await _httpClientService.GetCryptoGlobalAsync();
            return Ok(response);
        }

        [HttpGet("companies-public-treasury")]
        public async Task<ActionResult<CompaniesPublicTreasuryResponse>> GetCompaniesPublicTreasury([FromQuery] string coinId)
        {
            var response = await _httpClientService.GetCompaniesPublicTreasuryAsync(coinId);
            return Ok(response);
        }
    }
}
