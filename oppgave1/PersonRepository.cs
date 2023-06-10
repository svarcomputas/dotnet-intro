using FellesEntiteter;

namespace oppgave1;

class PersonRepository
{
    public Person HentPersonMedId(string id)
    {
        // TODO: implementer denne ved å filtrere listen returnert av HentAllePersoner med bruk av .Where og .First
        return ????
    }

    private static List<Person> HentAllePersoner()
    {
        return new List<Person>()
            {
                new Person()
                {
                    Id = "1",
                    Fornavn = "Roy",
                    Etternavn = "Roysen"
                },
                new Person()
                {
                    Id = "2",
                    Fornavn = "Ingrid",
                    Etternavn = "Ingridsen"
                }
            };
    }
}