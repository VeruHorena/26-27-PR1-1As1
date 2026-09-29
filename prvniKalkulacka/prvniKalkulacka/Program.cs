namespace prvniKalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej hodnotu a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej hodnotu b:");
            double b = double.Parse(Console.ReadLine());
            double vysledek;
            Console.WriteLine("Zadej operaci:");
            char operace = Console.ReadKey().KeyChar;
            if(operace == '+')
            {
                vysledek = a + b;
            }
            else
            {
                vysledek =  a - b;
            }
            Console.WriteLine("\n Vysledek vypoctu je: " + vysledek);
        }
    }
}
