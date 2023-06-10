using Microsoft.Extensions.DependencyInjection;
using oppgave3.løsning.Database;

namespace oppgave3.løsning;

public static class Startup
{
    // Legger til klasser for bruk i dependency injection
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IDatabase, Database.Database>();
    }
}