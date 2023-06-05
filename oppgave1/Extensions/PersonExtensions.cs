using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet_intro.Entiteter;

namespace dotnet_intro.Extensions;

public static class PersonExtensions
{
    // Skal returnere alder på personene
    public static int Alder(this Person person)
    {
        var now = DateTime.Now;

        int years = now.Year - person.Fødselsdato.Year;

        if (now.Month < person.Fødselsdato.Month || (now.Month == person.Fødselsdato.Month && now.Day < person.Fødselsdato.Day))
        {
            years--;
        }

        return years;
    }
}
