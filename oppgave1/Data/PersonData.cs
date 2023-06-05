using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet_intro.Entiteter;

namespace oppgave1.Data
{
    public static class PersonData
    {
        public static List<Person> HentPersonData()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Navn = "Test Testesen",
                    Fødselsdato = DateTime.Now.AddYears(-20),
                    Epost = "Gydlig@epost.no"
                },
                new Person()
                {
                    Navn = "Testersen Test",
                    Fødselsdato = DateTime.Now.AddYears(-40),
                    Epost = "IkkeGyldigEpost"
                },
                new Person()
                {
                    Navn = "Roy Roysen",
                    Fødselsdato = DateTime.Now.AddYears(-60),
                    Epost = "roy@roysen.com"
                }
            };
        }
    }
}
