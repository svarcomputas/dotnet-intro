using Microsoft.Extensions.DependencyInjection;
using oppgave1.Database;
using oppgave1.Repositories;
using oppgave1.Services;

namespace oppgave1;

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