using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_basic
{
    internal class Nauczyciel : Osoba
    {
        string przedmiot;

        public Nauczyciel(string imie, string nazwisko, string przedmiot) : base(imie, nazwisko) 
        {
            this.przedmiot = przedmiot;
        }

        public string Przedmiot { get { return przedmiot; } set { przedmiot = value; } } 
        
        public string toString()
        {
            return "Imię: " + imie + ", nazwisko: " + nazwisko + " , przedmiot nauczany: " + przedmiot;
        }
    }
}
