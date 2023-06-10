using FellesEntiteter;

namespace oppgave1.løsning;

class PersonRepository
{
    public Person HentPersonMedId(string id)
    {
        var allePersoner = HentAllePersoner();
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