## Oppgave 3

Det er nå lagt til en ny funksjon i `IDatabase` som heter `HentAlleBetalinger` som returnerer en liste med alle betalinger. En betaling inneholder:
1. `personId` for personen betalingen gjelder for
2. `beløp`
3. `type` som er en av verdiene `UtFraKontoer`, `InnPåKontoer`, `OverføringEgneKontoer`
4. `dato`

Klassen `BetlaingsRepository.cs` er også lagt til med funksjonen `HentBetalingerForPersonMedId(string personId)` som returnere alle betalinger tilknyttet en person. 

Oppgaven er å implementere extension metoden `TilOppsummeringForSisteXDager` i `/Extensions/BetalingsExtensions.cs`