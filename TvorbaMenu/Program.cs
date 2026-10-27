namespace TvorbaMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volba;
            int a = 0;
            int b = 0;
            bool nacteno = false;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MENU");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Načti hodnoty");
                Console.WriteLine("2. Vypiš hodnoty");
                Console.WriteLine("3. Proveď součet");
                Console.WriteLine("4. Konec programu");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Zadej svoji volbu");
                while (int.TryParse(Console.ReadLine(), out volba) == false)
                {
                    Console.WriteLine("Neplatná volba, proveď volbu znovu:");
                }
                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadej hodnotu a:");
                        while (int.TryParse(Console.ReadLine(), out a) == false)
                        {
                            Console.WriteLine("Neplatná hodnota, zadej znovu hodnotu a:");
                        }
                        Console.WriteLine("Zadej hodnotu b:");
                        while (int.TryParse(Console.ReadLine(), out b) == false)
                        {
                            Console.WriteLine("Neplatná hodnota, zadej znovu hodnotu b:");
                        }
                        nacteno = true;
                        break;
                    case 2:
                        if (nacteno == true)
                        {
                            Console.WriteLine("Hodnota a: " + a);
                            Console.WriteLine("Hodnota b: " + b);
                        }
                        else
                            Console.WriteLine("Hodnoty ještě nebyly načteny.");
                        break;
                    case 3:
                        if (nacteno == true)
                        {
                            int soucet = a + b;
                            Console.WriteLine($"Soucet hodnot {a} a {b} je {soucet}");
                        }
                        else
                            Console.WriteLine("Hodnoty ještě nebyly načteny.");
                        break;
                    case 4: return;
                }
            }
        }
    }
}
