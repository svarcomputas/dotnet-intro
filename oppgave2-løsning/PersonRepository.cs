using FellesEntiteter;
using oppgave2.løsning.Database;

namespace oppgave2.løsning;

class PersonRepository
{
    IDatabase _database;

    public PersonRepository(IDatabase database){
        _database = database;
    }

    public Person HentPersonMedId(string id)
    {
        return _database.HentAllePersoner().Where(person => person.Id == id).First();
    }
}