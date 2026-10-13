namespace VicenasobneRozhodovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej \n 1: pro týden od pondělí do neděle \n 2: pro týden od neděle do soboty");
            int volba;
            if (int.TryParse(Console.ReadLine(), out volba) == false)
            {
                Console.WriteLine("Neplatný vstup.");
                return;
            }
            Console.WriteLine("Zadej číslo dne:");
            int den; //= int.Parse(Console.ReadLine());
            if(int.TryParse(Console.ReadLine(), out den) == false)
            {
                Console.WriteLine("Neplatný vstup.");
                return;
            }

            if (volba == 2) {
                //den = den - 1; NELZE
                if (den == 1)
                    den = 7;
                else
                    den = den - 1;
            }

                switch (den)
                {
                    case 1: Console.WriteLine("Je to pondělí");
                        break;
                    case 2:
                        Console.WriteLine("Je to úterý");
                        break;
                    case 3:
                        Console.WriteLine("Je to středa");
                        break;
                    case 4:
                        Console.WriteLine("Je to čtvrtek");
                        break;
                    case 5:
                        Console.WriteLine("Je to pátek");
                        break;
                    case 6:
                        Console.WriteLine("Je to sobota");
                        break;
                    case 7:
                        Console.WriteLine("Je to neděle");
                        break;
                default: 
                    Console.WriteLine("Neplatný vstup");
                    break;
                }
            
        }
    }
}
