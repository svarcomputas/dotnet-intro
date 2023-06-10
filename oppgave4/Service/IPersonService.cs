﻿using FellesEntiteter;
using oppgave4.Extensions;
using oppgave4.Repository;

namespace oppgave4.Service;

public interface IPersonService
{
    public PersonBetalingsOppsummering HentPersonBetalingsoppsummering(string personId); 
}

public class PersonService : IPersonService
{
    // TODO: Bytt ut '??'
    private ?? _personRepository;
    private ?? _betalingsRepository;

    public PersonService(?? personRepository, ?? betalingsRepository)
    {
        _personRepository = personRepository;
        _betalingsRepository = betalingsRepository;
    }

    public PersonBetalingsOppsummering HentPersonBetalingsoppsummering(string personId)
    {
        var person = _personRepository.HentPersonMedId(personId);
        var betalinger = _betalingsRepository.HentBetalingerForPersonMedId(personId);
        var oppsummering = betalinger.TilOppsummeringForSisteXDager(30);
        return new PersonBetalingsOppsummering
        {
            Person = person,
            BetalingsOppsummering = oppsummering
        };
    }
}
