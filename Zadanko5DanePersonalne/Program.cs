using System.ComponentModel.DataAnnotations;

namespace Zadanko5DanePersonalne
{
    /*
    Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
    numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
    i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
    typDanych.Parse(odpowiedźOdUżytkownika). 
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            string odpowiedzOdUzytkownika;

            string imie;
            string nazwisko;
            string numerTelefonu;
            string adresEMail;
            int wzrost;
            double waga;
            string PESEL;
            char plec;
            bool prawoJazdyKategoriiB;

            Console.WriteLine("Poproszę o Twoje dane personalne.");

            Console.WriteLine("Imię:");
            imie = Console.ReadLine();

            Console.WriteLine("Nazwisko:");
            nazwisko = Console.ReadLine();

            Console.WriteLine("Numer telefonu:");
            numerTelefonu = Console.ReadLine();

            Console.WriteLine("Adres e-mail:");
            adresEMail = Console.ReadLine();

            Console.WriteLine("Wzrost (w cm):");
            odpowiedzOdUzytkownika = Console.ReadLine();
            wzrost = Int32.Parse(odpowiedzOdUzytkownika);

            Console.WriteLine("Waga (w kg, może być z dokładnością do 0,1 kg):");
            odpowiedzOdUzytkownika = Console.ReadLine();
            waga = Double.Parse(odpowiedzOdUzytkownika);

            Console.WriteLine("PESEL:");
            PESEL = Console.ReadLine();

            Console.WriteLine("Płeć (podaj K jeśli kobieta, M jeśli mężczyzna):");
            odpowiedzOdUzytkownika = Console.ReadLine();
            plec = Char.Parse(odpowiedzOdUzytkownika);

            Console.WriteLine("Czy posiadasz prawo jazdy kategorii B (jeśli tak wpisz true, jeśli nie wpisz false:");
            odpowiedzOdUzytkownika = Console.ReadLine();
            prawoJazdyKategoriiB = Boolean.Parse(odpowiedzOdUzytkownika);

            Console.WriteLine("Dziękuję!\r\nOto Twoje dane personalne:");
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Numer telefonu: {numerTelefonu}");
            Console.WriteLine($"Adres e-mail: {adresEMail}");
            Console.WriteLine($"Wzrost: {wzrost}");
            Console.WriteLine($"Waga: {waga}");
            Console.WriteLine($"PESEL: {PESEL}");
            Console.WriteLine($"Płeć: {plec}");
            Console.WriteLine($"Prawo jazdy kategorii B: {prawoJazdyKategoriiB}");            
        }
    }
}
