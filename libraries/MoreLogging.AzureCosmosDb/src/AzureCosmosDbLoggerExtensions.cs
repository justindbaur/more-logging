using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MoreLogging.AzureCosmosDb;

namespace Microsoft.Extensions.Logging;

public static class AzureCosmosDbLoggerExtensions
{
    public static ILoggingBuilder AddAzureCosmosDb(this ILoggingBuilder builder, Action<AzureCosmosDbLoggerOptions> configure)
    {
        var services = builder.Services;

        services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, AzureCosmosDbLoggerProvider>());

        services.Configure(configure);
        return builder;
    }
}
