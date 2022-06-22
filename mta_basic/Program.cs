//// See https://aka.ms/new-console-template for more information
#pragma warning disable CS8600 // Konwertowanie literału o wartości null lub możliwej wartości null na nienullowalny typ.


/*mta_basic.Osoba osoba = new("Władysław");

Console.Write("Podaj imię: ");
for (; ; )
{
    osoba.Imie = Console.ReadLine();
    if (osoba.Imie != "")
        break;
}
//osoba.ustawImie(Console.ReadLine());
Console.WriteLine("Podaje imię to: " + osoba.Imie);

mta_basic.Uczen uczen = new();
uczen.ImieUczen = Console.ReadLine();
Console.WriteLine(uczen.ImieUczen);
Console.WriteLine(uczen.Imie);


//Console.WriteLine("Podaj imię: ");
//osoba.imie = Console.ReadLine();*/

mta_basic.Nauczyciel nauczyciel = new("Roman", "Iksiński", "Matematyka");
Console.WriteLine(nauczyciel.toString());

mta_basic.Osoba nauczyciel2 = new mta_basic.Nauczyciel("Alicja", "Romańska", "Fizyka");
Console.WriteLine(((mta_basic.Nauczyciel)nauczyciel2).toString());

nauczyciel.PESEL = "8888888888";