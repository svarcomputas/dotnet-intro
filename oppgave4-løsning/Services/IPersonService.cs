using FellesEntiteter;
using oppgave1.Extensions;
using oppgave1.Repositories;

namespace oppgave1.Services;

public interface IPersonService
{
    public BetalingsOppsummering HentBetalingsoppsummering(string personId); 
}

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    private readonly IBetalingsRepository _betalingsRepository;

    public PersonService(IPersonRepository personRepository, IBetalingsRepository betalingsRepository)
    {
        _personRepository = personRepository;
        _betalingsRepository = betalingsRepository;
    }

    public BetalingsOppsummering HentBetalingsoppsummering(string personId)
    {
        var person = _personRepository.HentPersonMedId(personId);
        var betalinger = _betalingsRepository.HentBetalingerForPersonMedId(person.BetalingsId);
        var oppsummering = betalinger.TilOppsummeringForSisteXDager(30);
        return oppsummering;
    }
}
