using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellesEntiteter;

public class Person
{
    public string Id { get; set; }

    public string Fornavn { get; set; }

    public string Etternavn { get; set; }

    public Guid BetalingsId { get; set; }

    public override string ToString()
    {
        return $"{Fornavn} {Etternavn} har personId {Id}";
    }
}
