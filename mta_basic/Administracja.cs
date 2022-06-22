using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_basic
{
    internal class Administracja : Osoba {
        string stanowisko;

        public string Stanowisko { get { return stanowisko; } set { stanowisko = value;} }
    }
}
