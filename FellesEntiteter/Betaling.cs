namespace FellesEntiteter;

public class Betaling
{
    public Guid PersonBetalingsId { get; set; }

    public BetalingsType BetalingsType { get; set; }

    public double Beløp { get; set; }

    public DateTime Dato { get; set; }
}

public enum BetalingsType
{
    InnPåKontoer = 1,
    UtFraKontoer = 2,
    OverføringEgneKontoer = 3
}
