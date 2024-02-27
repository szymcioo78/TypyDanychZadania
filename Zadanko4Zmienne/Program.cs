namespace Zadanko4Zmienne
{
    /*
    Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
    przypiszesz im następujące wartości:
    a. 10
    b. Szkoła Dotneta
    c. 12,5
    Pamiętaj o użyciu poprawnych typów danych.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            int calkowita = 10;
            string tekst = "Szkoła Dotneta";
            double rzeczywista = 12.5;

            Console.WriteLine("Zadeklarowane zmienne:");
            Console.WriteLine($"Liczba całkowita: {calkowita}");
            Console.WriteLine($"Tekst: {tekst}");
            Console.WriteLine($"Liczba rzeczywista: {rzeczywista}");
        }
    }
}

