
# Getting Started with Cypress Test API

## Introduction

This is a sample API to demonstrate an OpenAPI spec with multiple endpoints and a custom model.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package TestSDK --version 2.1.8
```

You can also view the package at:
https://www.nuget.org/packages/TestSDK/2.1.8

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/log-builder.md) | Represents the logging configuration builder for API calls |

The API client can be initialized as follows:

```csharp
CypressTestAPIClient client = new CypressTestAPIClient.Builder()
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## List of APIs

* [API](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/controllers/api.md)

## SDK Infrastructure

### Configuration

* [HttpClientConfiguration](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-callback.md)
* [HttpContext](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-context.md)
* [HttpRequest](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-request.md)
* [HttpResponse](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/api-exception.md)
* [ApiResponse](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/api-response.md)
* [ApiHelper](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/tahaali2000/test-dotnet-sdk/tree/2.1.8/doc/unix-date-time-converter.md)

