## Oppgave 4

Vi øsnker å retuerne klassen `PersonBetalingsOppsummering` men har ikke lyst til å gjøre logikk i API endepunktet (som er `Program.cs` i dette tilfellet).
Vi introduserer derfor Servicen `IPersonService` som gjør logikken. Interfacet og logikken der er implementert. Men konstruktøren skal ta inn `IBetalingsRepository` og `IPersonRepository` derfor må også `BetalingsRepository` og `PersonRepository` klassene skrives om til interfacer. 

Det som skal gjøres:
- Implementer interfacet i `IBetalingsRepository`
- Implementer interfacet i `IPersonRepository`
- Implementer konstruktøren i `PersonService` klassen
- I `Startup.cs` legg til klassene `IBetalingsRepository`, `IPersonRepository` og `IPersonService` tilgjenglig for dependency injection. 