using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;
using oppgave1.Services;
using oppgave1;

// Sett opp og konfigurer dependency injection
var services = new ServiceCollection();
Startup.ConfigureServices(services);

// Kall 
var brukerId = "1";
var resultat = services
    .AddTransient<PersonController, PersonController>()
    .BuildServiceProvider()
    .GetRequiredService<PersonController>()
    .HentBetalingsOppsummering(brukerId);

Console.WriteLine(resultat.ToString());

public class PersonController
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    // Simulering av API-kall til /person/{id}/betalingsinfo
    public BetalingsOppsummering HentBetalingsOppsummering(string personId)
    {
        return _personService.HentBetalingsoppsummering(personId);
    }
}

/*var personData = PersonData.HentPersonData();

var personerEldreEnn20MedGyldigEpost = personData.Where(person => person.Alder() > 20 && person.Epost.ErGyldigEpost()).ToList();

personerEldreEnn20MedGyldigEpost.ForEach(person => Console.WriteLine($"{person.Navn} er {person.Alder()} år og har gyldig epost ({person.Epost})."));


var betalingsOppsummeringSiste30Dager = personData.First().Betalinger.TilOppsummeringForSisteXDager(30);
Console.WriteLine(betalingsOppsummeringSiste30Dager.ToString());


BetalingsOppsumering FakeHentBetalingsoppsummeringEndepunkt(string personId)
{
    return new BetalingsOppsumering();
}

new PersonController();

partial class Program
{
    private readonly IPersonService _personService;
    private readonly Startup _startup;

    public Program(IPersonService personService)
    {
        _personService = personService;
        _startup = new Startup();
    }

    static void Main(string[] args)
    {
        _personService = personService;
        _startup = new Startup();

        var serviceProvider = new ServiceCollection();
        _startup.ConfigureServices(serviceProvider);

        var program = serviceProvider.GetRequiredService<Program>();
        program.Run();
    }

    public void Run()
    {
        _service.SomeMethod();
    }
}*/