##Oppgave 2

Siden `PersonRepository.cs` er ansvarlig for å hente data fra databasen ønsker vi isedenfor at funksjonen `HentAllePersoner` returnerer alle personer så skal den hentes fra en database som sendes inn til `PersonRepository.cs` med bruk av dependency injection. 

Endringer må gjøres i:
- Startup.cs
- PersonRepository.cs 
- Database/IDatabase.cs