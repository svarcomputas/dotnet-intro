using System;
using FellesEntiteter;

namespace oppgave3.Extensions
{
    public static class BetalingExtensions
    {
        // TODO: implementer denne funksjonen. Den skal returnere en BetalingsOppsummering av alle betalinger gjort de siste `dager` dagene. 
        // oppsummeringen skal returnere summen av beløpene for alle betalinger som har samme type.
        public static BetalingsOppsummering TilOppsummeringForSisteXDager(this List<Betaling> betalinger, int dager)
        {
            // TODO: filtrer alle betalinger som er gjort de siste dagene
            // Hint: Bruk Datetime.Now.AddDays() til å sammenligne datoer 
            var betalingerSistDager = betalinger.Where(?????).ToList();
            return new BetalingsOppsummering()
            {
                SisteDager = dager,
                TotaltInnPåKontoer = ,// TODO: summer alle betalingerSistDager som er av typen InnPåKontoer,
                TotaltUtFraKontoer = ,// TODO: summer alle betalingerSistDager som er av typen UtAvKontoer,
                TotaltOverførtEgneKontoer = ,// TODO: summer alle betalingerSistDager som er av typen OverføringEgneKontoer,
            };
        }
    }
}
