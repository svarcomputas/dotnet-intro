using FellesEntiteter;

namespace oppgave1.Database;

public interface IDatabase
{
    public List<Person> HentAllePersoner();

    public List<Betaling> HentAlleBetalinger();
}

public class Database : IDatabase
{
    private Guid _betalingsIdPerson1;
    private Guid _betalingsIdPerson2;

    public Database()
    {
        _betalingsIdPerson1 = Guid.NewGuid();
        _betalingsIdPerson2 = Guid.NewGuid();
    }

    public List<Person> HentAllePersoner()
    {
        return new List<Person>()
        {
            new Person()
            {
                Id = "1",
                Fornavn = "Else",
                Etternavn = "Tester",
                BetalingsId = _betalingsIdPerson1
            },
            new Person()
            {
                Id = "2",
                Fornavn = "Kåre",
                Etternavn = "Tester",
                BetalingsId = _betalingsIdPerson2
            }
        };
    }
    public List<Betaling> HentAlleBetalinger()
        => new List<Betaling>()
        {
            NyBetaling(_betalingsIdPerson1, 1000),
            NyBetaling(_betalingsIdPerson1, 5000, BetalingsType.UtFraKontoer, DateTime.Now.AddDays(-3)),
            NyBetaling(_betalingsIdPerson1, 5000, BetalingsType.OverføringEgneKontoer, DateTime.Now.AddDays(-5)),
            NyBetaling(_betalingsIdPerson1, 10000, BetalingsType.InnPåKontoer, DateTime.Now.AddDays(-7)),
            NyBetaling(_betalingsIdPerson1, 303.3, BetalingsType.UtFraKontoer, DateTime.Now.AddDays(-10)),
            NyBetaling(_betalingsIdPerson2, 4000.4, BetalingsType.InnPåKontoer, DateTime.Now.AddDays(-12))
        };

    private static Betaling NyBetaling(Guid personBetalingsId, double beløp, BetalingsType type = BetalingsType.InnPåKontoer, DateTime? dato = null)
        => new Betaling()
        {
            PersonBetalingsId = personBetalingsId,
            Beløp = beløp,
            BetalingsType = type,
            Dato = dato ?? DateTime.Now
        };
}
