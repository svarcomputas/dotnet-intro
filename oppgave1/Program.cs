// See https://aka.ms/new-console-template for more information
using dotnet_intro.Extensions;
using oppgave1.Data;
using oppgave1.Extensions;

var personData = PersonData.HentPersonData();

var personerEldreEnn20MedGyldigEpost = personData.Where(person => person.Alder() > 20 && person.Epost.ErGyldigEpost()).ToList();

personerEldreEnn20MedGyldigEpost.ForEach(person => Console.WriteLine($"{person.Navn} er {person.Alder()} år og har gyldig epost ({person.Epost})."));