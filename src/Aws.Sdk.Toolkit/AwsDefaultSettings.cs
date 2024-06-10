using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Aws.Sdk.Toolkit;

[ExcludeFromCodeCoverage]
public static class AwsDefaultSettings
{
    public static IServiceCollection AddAwsDefaultSettings(this IServiceCollection services,
        IConfiguration configuration, IHostEnvironment environment)
    {
        if (!environment.IsDevelopment())
            services.AddDefaultAWSOptions(configuration.GetAWSOptions());

        return services;
    }
}