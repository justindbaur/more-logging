using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MoreLogging.AzureCosmosDb;

public class AzureCosmosDbLoggerProvider : ILoggerProvider
{
    private readonly CosmosClient _client;
    private readonly IOptionsMonitor<AzureCosmosDbLoggerOptions> _options;

    public AzureCosmosDbLoggerProvider(IOptionsMonitor<AzureCosmosDbLoggerOptions> options)
    {
        _client = new CosmosClientBuilder("")
            .Build();

        _options = options;
    }
    public ILogger CreateLogger(string categoryName)
    {

        return null;
    }

    public void Dispose()
    {

    }
}
