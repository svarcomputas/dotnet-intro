using FellesEntiteter;
using oppgave2.Database;

namespace oppgave2;

class PersonRepository
{
    // TODO: Bytt ut 'var' (skal det stå IDatabase eller Database?)
    var _database;

    public PersonRepository(var database){
        _database = database;
    }

    public Person HentPersonMedId(string id)
    {
        return _database.HentAllePersoner().Where(person => person.Id == id).First();
    }
}