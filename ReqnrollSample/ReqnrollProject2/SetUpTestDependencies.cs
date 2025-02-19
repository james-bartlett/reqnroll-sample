using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reqnroll.Microsoft.Extensions.DependencyInjection;

namespace ReqnrollProject2;

internal class SetUpTestDependencies
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<SetUpTestDependencies>()
        .Build();

        var services = new ServiceCollection();
        return services;
    }
}