using FellesEntiteter;
using oppgave4.løsning.Database;

namespace oppgave4.løsning.Repository;

public interface IBetalingsRepository
{
    public List<Betaling> HentBetalingerForPersonMedId(string personId);
}

public class BetalingsRepository : IBetalingsRepository
{
    private readonly List<Betaling> _alleBetalinger;

    public BetalingsRepository(IDatabase database)
    {
        _alleBetalinger = database.HentAlleBetalinger();
    }

    public List<Betaling> HentBetalingerForPersonMedId(string personId)
    {
        return _alleBetalinger.Where(betaling => betaling.PersonId == personId).ToList();
    }
}