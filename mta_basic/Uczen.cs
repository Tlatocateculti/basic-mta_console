using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_basic
{
    internal class Uczen : Osoba, Metody
    {
        public string ImieUczen { get => imie; set => Imie = value; }

        string klasa;

        public string Klasa { get => klasa; set => klasa = value; }

        ~Uczen()
        {
            Console.WriteLine("Destruktor ucznia");
        }
    }
}
