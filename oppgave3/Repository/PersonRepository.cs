using FellesEntiteter;
using oppgave3.Database;

namespace oppgave3;

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