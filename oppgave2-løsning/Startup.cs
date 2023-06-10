using Microsoft.Extensions.DependencyInjection;
using oppgave2.løsning.Database;

namespace oppgave2.løsning;

public static class Startup
{
    // Legger til klasser for bruk i dependency injection
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IDatabase, Database.Database>();
    }
}