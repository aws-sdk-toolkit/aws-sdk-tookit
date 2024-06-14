using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AwsTool.Sdk.Extensions;

[ExcludeFromCodeCoverage]
public static class AwsDefaultSettingsExtensions
{
    /// <summary>
    /// Loads the configurations for running the application on AWS.
    /// </summary>
    /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
    /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
    /// <param name="environment">Provides information about the hosting environment an application is running in.</param>
    /// <returns>Specifies the contract for a collection of service descriptors.</returns>
    public static IServiceCollection AddAwsDefaultSettings(this IServiceCollection services,
        IConfiguration configuration, IHostEnvironment environment)
    {
        if (!environment.IsDevelopment())
            services.AddDefaultAWSOptions(configuration.GetAWSOptions());

        return services;
    }
}