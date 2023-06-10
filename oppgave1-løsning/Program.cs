using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;

namespace oppgave1.løsning;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        // Henter ut en instans av PersonRepository
        var personRepo = services
            .AddTransient<PersonRepository, PersonRepository>()
            .BuildServiceProvider()
            .GetRequiredService<PersonRepository>();

        KjørOppgave(personRepo);
    }

    static void KjørOppgave(PersonRepository personRepo){
        Oppgavebeskrivelse.PrintOppgaveBeskrivelse(1);
        var brukerId = "1";

        var person = personRepo.HentPersonMedId(brukerId);
        Console.WriteLine(person.ToString());
    }
}