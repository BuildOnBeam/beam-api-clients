# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=net7.0',
    'validatable=true',
    'nullableReferenceTypes=false',
    'hideGenerationTimestamp=true',
    'packageVersion=1.0.0',
    'packageAuthors=OpenAPI',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'packageName=Beam',
    'packageTags=',
    'packageTitle=OpenAPI Library'
) -join ","

$global = @(
    'apiDocs=false',
    'modelDocs=false',
    'apiTests=false',
    'modelTests=false'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "GIT_REPO_ID" `
    --git-user-id "GIT_USER_ID" `
    --release-note "Minor update"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

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

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(
                client: client => {
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
    }
}
```

or if you use new Web App templates:

```cs
using Beam.Client;
using Beam.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApi(options =>
{
    // the type of token here depends on the api security specifications
    ApiKeyToken token = new("<your token>", prefix: string.Empty);
    options.AddTokens(token);

    // optionally choose the method the tokens will be provided with, default is RateLimitProvider
    options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

```

<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace Beam.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Beam API game key"></a>
### Beam API game key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header


## Build
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Beam game development API
- appVersion: 1.0.0
- appDescription: The Beam game development API is a service to integrate your game with Beam

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel:
- supportingFiles:
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: false
- modelDocs: false
- apiTests: false
- modelTests: false
- withXml:

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers:
- apiName: Api
- caseInsensitiveResponseHeaders:
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent:
- gitHost: github.com
- gitRepoId: GIT_REPO_ID
- gitUserId: GIT_USER_ID
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId:
- modelPropertyNaming:
- netCoreProjectFile: true
- nonPublicApi: false
- nullableReferenceTypes: false
- optionalAssemblyInfo:
- optionalEmitDefaultValues: false
- optionalMethodArgument: false
- optionalProjectFile:
- packageAuthors: OpenAPI
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {B9F59C51-AA17-4ECC-8B26-D42311D97287}
- packageName: Beam
- packageTags:
- packageTitle: OpenAPI Library
- packageVersion: 1.0.0
- releaseNote: Minor update
- returnICollection: true
- sortParamsByRequiredFlag:
- sourceFolder: src
- targetFramework: net7.0
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: true

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
