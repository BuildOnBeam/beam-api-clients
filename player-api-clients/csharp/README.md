# Beam for C#

[![license](https://img.shields.io/badge/License-GPLv3-blue)](./LICENSE)
[![nuget](https://img.shields.io/nuget/v/Beam)](https://www.nuget.org/packages/Beam)
![npm](https://img.shields.io/npm/v/%40onbeam%2Fnode)
![GitHub Workflow Status (with event)](https://img.shields.io/github/actions/workflow/status/Merit-Circle/beam-sdk/publish.yml)


---
The Beam client for the .NET ecosystem provides a type-safe interface for consuming the Beam API. Please note that this client is meant to be used in server side applications, as following these instructions in a client-side environment would expose your API key to all users.

## Connecting with Beam
In order to get started with Beam, you will need an API key. The API key for your game will be provided by your partner at Merit Circle.

## Using the library in your project
You have to register necessary services in your dependency injection container, then all Api Clients can be used easily by injecting them into your classes.

### Package reference
Simply include our Nuget from https://www.nuget.org/packages/BeamSelfCustody in your .csproj file like any other dependency:
```xml
<PackageReference Include="BeamSelfCustody" Version="1.0.*" />
```
Our deployment pipeline increments **patch** version on every deployment. You can either use a concrete version number or a wildcard(`*`) to always use newest SDK. We try to limit breaking changes but as this is still a new product, these might happen.

### Important changes:
#### 1.0.31
- Deprecated `RateLimitProvider` for tokens as it might cause high CPU usage in high throughput cases. Please use `SimpleApiKeyTokenProvider`` or simply remove `options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();` from `.AddApi()` if used before. `SimpleApiKeyTokenProvider` is the new default.

### DI registration
In case of generic host applications:
```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Beam.Api;
using Beam.Client;
using Beam.Model;
using Beam.Extensions;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IAssetsApi>();
            GetAssetApiResponse apiResponse = await api.GetAssetAsync("todo");
            GetAssetResponse model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, services, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>");
              options.AddTokens(token);

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(
                client: client => {
                  client.BaseAddress = new Uri("https://api.beta.onbeam.com/");
                },
                builder: builder => {
                  builder
                  .AddRetryPolicy(2)
                  .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                  .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30));
                  // add whatever middleware you prefer
                }
              );
          });
    }
}
```

or if you use new Web App templates:

```cs
using Beam.Client;
using Beam.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBeamApi(options =>
{
    // the type of token here depends on the api security specifications
    var token = new ApiKeyToken("<your token>");
    options.AddTokens(token);

    options.ConfigureJsonOptions((jsonOptions) =>
    {
        // your custom converters if any
    });

    options.AddApiHttpClients(
        client: client =>
        {
            client.BaseAddress = new Uri("https://api.preview.onbeam.com/");
        },
        builder: builder => {
            builder
            .AddRetryPolicy(2)
            .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
            .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30));
            // add whatever middleware you prefer
        }
    );
});

// Add other services to the container.

var app = builder.Build();

(...)

app.Run();

```

## Usage
To use Api clients provided by this SDK, simply inject them into your class:
  ```cs
  public class MyService
  {
      private readonly IGameApi _gameApi;

      public MyService(IGameApi gameApi)
      {
          _gameApi = gameApi;
      }

      public async Task GetMyGame()
      {
        var myGame = await _gameApi.GetGameAsync();
        (...)
      }
  }
  ```

<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  You can configure Polly in the AddApiHttpClients((...), builder: (x) => ...) method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method, you can implement your own if you don't want to get rate limited as well.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I specify different ApiKeyToken for different ApiClients?
  You can now use exposed ApiKeyTokenProvider one each client to set custom ApiKey if needed. That token will only be used for that ApiClient instance.
  ```cs
    _gameApi.ApiKeyProvider.SetToken(new ApiKeyToken("<your token>"));
  ```

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Beam API game key"></a>
### Beam API game key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header


---

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
