# CoinGecko API Integration

This project is an ASP.NET Core Web API that integrates with the CoinGecko API to fetch various cryptocurrency-related data. It includes support for fetching current prices, top gainers and losers, market data, coin categories, and more.

## Features

- Fetch current prices of cryptocurrencies in various fiat currencies
- Retrieve market data for top gainers and losers
- Get information about specific coins
- List new coins
- Fetch categories of cryptocurrencies
- Fetch data about exchanges and NFTs
- Support for API key authorization using Swagger
- Middleware to extract API key from request headers

Add your CoinGecko API key to the `appsettings.json` file:

```json
{
  "CoinGecko": {
    "ApiKey": "your-coingecko-api-key"
  }
}

## Endpoints

### Ping

- **URL:** `/CoinGecko/ping`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "geckosays": "(V3) To the Moon!"
  }
  ```

### Simple Price

- **URL:** `/CoinGecko/simple-price`
- **Method:** `GET`
- **Query Parameters:**
  - `ids` (string): Comma-separated list of cryptocurrency IDs
  - `vs_currencies` (string): Comma-separated list of fiat currencies
- **Response:**
  ```json
  {
    "bitcoin": {
      "usd": 40000.0
    },
    "ethereum": {
      "usd": 2500.0
    }
  }
  ```

### Coins Top Gainers and Losers

- **URL:** `/CoinGecko/coins-top-gainers-losers`
- **Method:** `GET`
- **Query Parameters:**
  - `vsCurrency` (string): The fiat currency (e.g., `usd`)
  - `perPage` (int): Number of results per page (default: 10)
- **Response:**
  ```json
  [
    {
      "id": "bitcoin",
      "symbol": "btc",
      "name": "Bitcoin",
      "currentPrice": 40000.0,
      "marketCap": 750000000000,
      "marketCapRank": 1,
      "totalVolume": 35000000000,
      "high24h": 41000.0,
      "low24h": 39000.0,
      "priceChange24h": 500.0,
      "priceChangePercentage24h": 1.25,
      "image": "https://assets.coingecko.com/coins/images/1/large/bitcoin.png"
    }
    // More results...
  ]
  ```

### API Usage

- **URL:** `/CoinGecko/api-usage`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "usedEndpoints": 100,
    "requestsCount": 2000,
    "requestsLimit": 10000,
    "requestsRemaining": 8000
  }
  ```

### Coins List New

- **URL:** `/CoinGecko/coins-list-new`
- **Method:** `GET`
- **Response:**
  ```json
  [
    {
      "id": "newcoin",
      "symbol": "nwc",
      "name": "New Coin"
    }
    // More results...
  ]
  ```

### Coin by ID

- **URL:** `/CoinGecko/coins-id`
- **Method:** `GET`
- **Query Parameters:**
  - `id` (string): The ID of the cryptocurrency
- **Response:**
  ```json
  {
    "id": "bitcoin",
    "symbol": "btc",
    "name": "Bitcoin",
    "localization": {
      "en": "Bitcoin",
      "de": "Bitcoin",
      // Other localizations...
    },
    "description": "Bitcoin is a cryptocurrency...",
    "image": "https://assets.coingecko.com/coins/images/1/large/bitcoin.png",
    "marketCap": 750000000000,
    "marketCapRank": 1,
    "totalVolume": 35000000000,
    "high24h": 41000.0,
    "low24h": 39000.0,
    "priceChangePercentage24h": 1.25,
    "currentPrice": {
      "usd": 40000.0
    }
  }
  ```

### Coins Categories List

- **URL:** `/CoinGecko/coins-categories-list`
- **Method:** `GET`
- **Response:**
  ```json
  [
    {
      "id": "defi",
      "name": "Decentralized Finance (DeFi)"
    }
    // More results...
  ]
  ```

### Exchanges

- **URL:** `/CoinGecko/exchanges`
- **Method:** `GET`
- **Response:**
  ```json
  [
    {
      "id": "binance",
      "name": "Binance",
      "description": "Binance is a cryptocurrency exchange...",
      "url": "https://www.binance.com",
      "image": "https://assets.coingecko.com/exchanges/images/4/large/binance.png"
    }
    // More results...
  ]
  ```

### Exchanges List

- **URL:** `/CoinGecko/exchanges-list`
- **Method:** `GET`
- **Response:**
  ```json
  [
    {
      "id": "binance",
      "name": "Binance"
    }
    // More results...
  ]
  ```

### Exchange by ID

- **URL:** `/CoinGecko/exchanges-id`
- **Method:** `GET`
- **Query Parameters:**
  - `id` (string): The ID of the exchange
- **Response:**
  ```json
  {
    "id": "binance",
    "name": "Binance",
    "description": "Binance is a cryptocurrency exchange...",
    "url": "https://www.binance.com",
    "image": "https://assets.coingecko.com/exchanges/images/4/large/binance.png"
  }
  ```

### NFTs List

- **URL:** `/CoinGecko/nfts-list`
- **Method:** `GET`
- **Response:**
  ```json
  [
    {
      "id": "cryptopunks",
      "name": "CryptoPunks",
      "symbol": "PUNK",
      "imageUrl": "https://assets.coingecko.com/nfts/images/1/large/cryptopunks.png"
    }
    // More results...
  ]
  ```

### NFT by ID

- **URL:** `/CoinGecko/nfts-id`
- **Method:** `GET`
- **Query Parameters:**
  - `id` (string): The ID of the NFT
- **Response:**
  ```json
  {
    "id": "cryptopunks",
    "name": "CryptoPunks",
    "symbol": "PUNK",
    "imageUrl": "https://assets.coingecko.com/nfts/images/1/large/cryptopunks.png",
    "description": "CryptoPunks is a non-fungible token (NFT) collection...",
    "totalSupply": 10000
  }
  ```

### Search Data

- **URL:** `/CoinGecko/search-data`
- **Method:** `GET`
- **Query Parameters:**
  - `query` (string): The search query
- **Response:**
  ```json
  {
    "coins": [
      {
        "id": "bitcoin",
        "name": "Bitcoin",
        "symbol": "btc"
      }
      // More results...
    ],
    "exchanges": [
      {
        "id": "binance",
        "name": "

Binance"
      }
      // More results...
    ],
    "nfts": [
      {
        "id": "cryptopunks",
        "name": "CryptoPunks"
      }
      // More results...
    ]
  }
  ```

### Trending Search

- **URL:** `/CoinGecko/trending-search`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "coins": [
      {
        "id": "shiba-inu",
        "name": "Shiba Inu",
        "symbol": "shib",
        "marketCapRank": 11
      }
      // More results...
    ]
  }
  ```

### Crypto Global

- **URL:** `/CoinGecko/crypto-global`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "data": {
      "totalMarketCapUsd": 2100000000000,
      "totalVolumeUsd": 90000000000,
      "marketCapChangePercentage24hUsd": 2.5
    }
  }
  ```

### Companies Public Treasury

- **URL:** `/CoinGecko/companies-public-treasury`
- **Method:** `GET`
- **Query Parameters:**
  - `coinId` (string): The ID of the cryptocurrency
- **Response:**
  ```json
  {
    "holdings": [
      {
        "name": "MicroStrategy",
        "symbol": "MSTR",
        "totalAmount": 124000,
        "totalValueUsd": 4000000000
      }
      // More results...
    ]
  }
  ```

## Middleware

### ApiKeyMiddleware

The `ApiKeyMiddleware` extracts the API key from the request headers and sets it in the `HttpClientService`.

**Middleware/ApiKeyMiddleware.cs**

```csharp
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

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
```

## Swagger Configuration

Swagger is configured to use the API key for authorization.

**Program.cs**

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddHttpClient<HttpClientService>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoinGecko API", Version = "v1" });
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "API Key Authorization header",
        Type = SecuritySchemeType.ApiKey,
        Name = "X-CG-API-KEY",
        In = ParameterLocation.Header,
        Scheme = "ApiKeyScheme"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoinGecko API v1"));
}

app.UseHttpsRedirection();

app.UseMiddleware<ApiKeyMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
```
