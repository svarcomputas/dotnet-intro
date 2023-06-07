using FellesEntiteter;
using oppgave1.Database;

namespace oppgave1.Repositories;

public interface IPersonRepository
{
    public Person HentPersonMedId(string Id);
}

public class PersonRepository : IPersonRepository
{
    private readonly List<Person> _allePersoner;

    public PersonRepository(IDatabase database)
    {
        _allePersoner = database.HentAllePersoner();
    }

    public Person HentPersonMedId(string Id)
    {
        var person = _allePersoner.Where(person => person.Id == Id).FirstOrDefault();
        if(person == null)
        {
            throw new ArgumentException($"Finner ingen person med {Id}");
        }

        return person;
    }
}