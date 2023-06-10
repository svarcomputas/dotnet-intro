using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;
using oppgave3.Extensions;

namespace oppgave3;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        Startup.ConfigureServices(services);
        // Henter ut en instans av PersonRepository
        var betalingsRepo = services
            .AddTransient<BetalingsRepository, BetalingsRepository>()
            .BuildServiceProvider()
            .GetRequiredService<BetalingsRepository>();

        KjørOppgave(betalingsRepo);
    }

    static void KjørOppgave(BetalingsRepository betalingsRepo){
        Oppgavebeskrivelse.PrintOppgaveBeskrivelse(3);
        var brukerId = "1";

        var betalinger = betalingsRepo.HentBetalingerForPersonMedId(brukerId);
        var oppsummeing = betalinger.TilOppsummeringForSisteXDager(30);
        Console.WriteLine(oppsummeing.ToString());
    }
}