namespace FellesEntiteter;

public static class Oppgavebeskrivelse
{
    private static List<string> oppgavebeskrivelser = new List<string>{
@"Oppgave 1: implementer HentPersonMedId(string id)
Skal returnere:
Roy Roysen har personId 1

Implementasjonen returnerte:",

@"Oppgave 2: Sett opp dependency injection
Skal returnere:
Ingrid Ingridsen har personId 2

Implementasjonen returnerte:",

@"Oppgave 3: Implementere extension metode
Skal returnere:
Betlaingsoppsummering for de siste 30 dagene:
Totalt inn på kontoer:               11000
Totalt ut fra kontoer:               5303.3
Totalt overført mellom egne kontoer: 5000

Implementasjonen returnerte:",

@"Oppgave 4: Implementere extension metode
Skal returnere:
Roy Roysen har personId 1
Betlaingsoppsummering for de siste 30 dagene:
Totalt inn på kontoer:               11000
Totalt ut fra kontoer:               5303.3
Totalt overført mellom egne kontoer: 5000

Implementasjonen returnerte:"
    };

    public static void PrintOppgaveBeskrivelse(int oppgaveId)
        => Console.WriteLine(oppgavebeskrivelser[oppgaveId - 1]);
}