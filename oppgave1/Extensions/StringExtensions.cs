using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave1.Extensions
{
    public static class StringExtensions
    {
        // Epost er på format <identitet>@<domene>
        // eks: john.doe@example.com
        // Domene må inneholde et '.'
        // Adressen må inneholde et '@'
        // lengden på domene må være mer enn 2 
        public static bool ErGyldigEpost(this string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            if (atIndex <= 0 || dotIndex <= atIndex || dotIndex == email.Length - 1)
                return false;

            string domain = email.Substring(atIndex + 1);
            if (domain.Length < 2)
                return false;

            return true;
        }
    }
}
