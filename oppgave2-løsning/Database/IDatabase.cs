using FellesEntiteter;

namespace oppgave2.løsning.Database;

public interface IDatabase
{
    public List<Person> HentAllePersoner();
}

public class Database : IDatabase
{
    public List<Person> HentAllePersoner()
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
