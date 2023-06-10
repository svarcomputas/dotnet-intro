using Microsoft.Extensions.DependencyInjection;
using oppgave3.Database;

namespace oppgave3;

public static class Startup
{
    // Legger til klasser for bruk i dependency injection
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IDatabase, Database.Database>();
    }
}