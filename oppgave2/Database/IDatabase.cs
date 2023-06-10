using FellesEntiteter;

namespace oppgave2.Database;

public interface IDatabase
{
    public List<Person> HentAllePersoner();
}

public class Database : IDatabase
{
    // TODO: fullfør implementasjonen av interfacet ved å legge til HentAllePersoner
    // hint: den er lik som i PersonRepository fra oppgave 1
    
}
