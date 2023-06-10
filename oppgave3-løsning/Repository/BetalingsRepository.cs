using FellesEntiteter;
using oppgave3.løsning.Database;

namespace oppgave3.løsning;

public class BetalingsRepository
{
    private readonly IDatabase  _database;

    public BetalingsRepository(IDatabase database)
    {
        _database = database;
    }

    public List<Betaling> HentBetalingerForPersonMedId(string personId)
    {
        return _database.HentAlleBetalinger().Where(betaling => betaling.PersonId == personId).ToList();
    }
}