using Microsoft.Extensions.DependencyInjection;
using oppgave4.løsning.Database;
using oppgave4.løsning.Repository;
using oppgave4.løsning.Service;

namespace oppgave4.løsning;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IPersonService, PersonService>();
        services.AddTransient<IPersonRepository, PersonRepository>();
        services.AddTransient<IBetalingsRepository, BetalingsRepository>();
        services.AddSingleton<IDatabase, Database.Database>();
    }
}