using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;

namespace oppgave2.løsning;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        Startup.ConfigureServices(services);
        // Henter ut en instans av PersonRepository
        var personRepo = services
            .AddTransient<PersonRepository, PersonRepository>()
            .BuildServiceProvider()
            .GetRequiredService<PersonRepository>();

        KjørOppgave(personRepo);
    }

    static void KjørOppgave(PersonRepository personRepo){
        Oppgavebeskrivelse.PrintOppgaveBeskrivelse(2);
        var brukerId = "2";

        var person = personRepo.HentPersonMedId(brukerId);
        Console.WriteLine(person.ToString());
    }
}