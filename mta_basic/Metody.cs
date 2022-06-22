using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_basic
{
    internal interface Metody
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        public string PESEL { get; set; }
        public string Telefon { get; set; }
    }
}
