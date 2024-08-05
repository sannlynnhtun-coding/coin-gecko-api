using CoinGeckoApi.Services;

namespace CoinGeckoApi
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, HttpClientService httpClientService)
        {
            if (context.Request.Headers.TryGetValue("X-CG-API-KEY", out var extractedApiKey))
            {
                httpClientService.SetApiKey(extractedApiKey);
            }

            await _next(context);
        }
    }
}
