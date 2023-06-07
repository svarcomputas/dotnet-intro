using FellesEntiteter;
using oppgave1.Database;

namespace oppgave1.Repositories;

public interface IBetalingsRepository
{
    public List<Betaling> HentBetalingerForPersonMedId(Guid personId);
}

public class BetalingsRepository : IBetalingsRepository
{
    private readonly List<Betaling> _alleBetalinger;

    public BetalingsRepository(IDatabase database)
    {
        _alleBetalinger = database.HentAlleBetalinger();
    }

    public List<Betaling> HentBetalingerForPersonMedId(Guid personId)
    {
        return _alleBetalinger.Where(betaling => betaling.PersonBetalingsId == personId).ToList();
    }
}