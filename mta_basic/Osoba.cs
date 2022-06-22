using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//internal - widoczność modułowa (np. na poziomie modułu programowania, przestrzeni programu)
//private - widoczność elementu tylko dla danej klasy/obiektu
//protected - widoczność elementu jako public z założeniem, że chodzi o dziedziczenie pomiędzy klasami
//public - widoczność skladowej wszędzie (zarówno dla elementów klasy, klasy pochodnej jak i w każdej części naszego kodu)
namespace mta_basic
{
    internal class Osoba : Metody
    {
        protected string imie;
        protected string nazwisko;
        protected string pesel;
        protected string telefon;

        public Osoba() : this("",""){
            
        }

        public Osoba(string imie)  : this(imie, "")
        {
            
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie=imie;
            this.nazwisko = nazwisko;  
        }

        ~Osoba()
        {
            Console.WriteLine("Niszczę osobę!");
        }

        public string Imie { get { return imie; } set {
                imie = "";
                if (Char.IsUpper(value.ElementAt(0)))
                    imie = value;
                else
                    Console.WriteLine("Nie ustawiono - imię z małej litery! Wpisz ponownie.");
            } 
        }   

        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }

        public string PESEL { get => pesel; set => pesel=value; }
        public string Telefon { get => telefon; set => telefon=value; }

        public string toString()
        {
            return "Imię: " + imie + ", nazwisko: " + nazwisko;
        }

   /*     public void ustawImie()
        {
            ustawImie("Gustaw");
        }

        public void ustawImie(string imie)
        {
            this.imie = imie;
        }

        public string wyswietlImie()
        {
            return "Podane imię to: " + imie;
        }*/
    }
}
