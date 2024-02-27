namespace Zadanko3Przekatna
{
    /*
    Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
    przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            string tekstZKlawiatury;

            int podstawa;
            int wysokosc;            
            double sumaKwadratow;
            double przekatna;

            Console.WriteLine("Podaj długość podstawy prostokąta:");
            tekstZKlawiatury = Console.ReadLine();
            podstawa = Int32.Parse(tekstZKlawiatury);

            Console.WriteLine("Podaj wysokość prostokąta:");
            tekstZKlawiatury = Console.ReadLine();
            wysokosc = Int32.Parse(tekstZKlawiatury);

            //pitagoras
            sumaKwadratow = Math.Pow(podstawa, 2) + Math.Pow(wysokosc, 2);
            przekatna = Math.Sqrt(sumaKwadratow);

            Console.WriteLine($"Przekątna tego prostokąta wynosi: {przekatna}");
        }
    }
}
