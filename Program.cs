// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Net.NetworkInformation;

string liczba1 = Console.ReadLine();    
String liczba2 = Console.ReadLine();    
 int odczytanaLiczba1 = int.Parse(liczba1);
int odczytanaLiczba2 = int.Parse(liczba2);
if (odczytanaLiczba1 > odczytanaLiczba2)
{
    Console.WriteLine("Liczba pierwsza jest większa");
}
else
{ Console.WriteLine("Liczba piersza jest mniejsza"); }
string nazwaPostaci;
string rasaPostaci;
Console.WriteLine("1. Nowa gra");
Console.WriteLine("2. Wczytaj grę");
Console.WriteLine("3. Koniec");

string opcja = Console.ReadLine();
string opcja2 = Console.ReadLine();
if (opcja == "1")
{
   
    Console.Clear();
    Console.Write("Podaj imię postaci: ");
    nazwaPostaci = Console.ReadLine();
 
}
else if (opcja == "2")
{

}
else
{
    Console.Clear();
    Console.WriteLine("Dziękujemy za grę");
}
