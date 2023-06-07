using FellesEntiteter;

namespace oppgave1.løsning;

class Program
{
    static List<Person> allePersoner;

    static void Main(string[] args)
    {
        allePersoner = HentAllePersoner();
        var brukerId = "1";

        var person = HentPersonMedId(brukerId);
        Console.WriteLine(person.ToString());
    }


    private static Person HentPersonMedId(string id)
    {
        return allePersoner.Where(person => person.Id == id).First();
    }


    private static List<Person> HentAllePersoner()
    {
        return new List<Person>()
            {
                new Person()
                {
                    Id = "1",
                    Fornavn = "Roy",
                    Etternavn = "Roysen"
                },
                new Person()
                {
                    Id = "2",
                    Fornavn = "Ingrid",
                    Etternavn = "Ingridsen"
                }
            };
    }
}