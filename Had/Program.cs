namespace Had
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pocetkroku
            int pocet = 0;
            //pocet snezeneho jidla
            int jidlo = 0;

            //souradnice had
            int x = 10;
            int y = 5;

            //souradnice prekazka
            int prekazkaX = 20;
            int prekazkaY = 5;

            Random generator = new Random();
            int jidloX = generator.Next(1, 31);
            int jidloY = generator.Next(1, 21);
            while (true)
            {
                Console.Clear();
                //vykresleni
                Console.WriteLine("---------------------------------------");
                Console.SetCursorPosition(x, y);
                Console.Write("O");
                Console.SetCursorPosition(prekazkaX, prekazkaY);
                Console.Write("X");
                Console.SetCursorPosition(jidloX, jidloY);
                Console.Write("J");
                Console.SetCursorPosition(0, 21);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Aktualni skore: " + jidlo);

                ConsoleKeyInfo stisknute = Console.ReadKey();
                if (stisknute.Key == ConsoleKey.RightArrow && x < 30)
                {
                    x = x + 1;
                    pocet++; //pocet = pocet+1;
                }
                if (stisknute.Key == ConsoleKey.LeftArrow && x > 0)
                {
                    x = x - 1;
                    pocet++;
                }
                if (stisknute.Key == ConsoleKey.UpArrow && y > 0)
                {
                    y = y - 1;
                    pocet++;
                }
                if (stisknute.Key == ConsoleKey.DownArrow && y < 20)
                {
                    y = y + 1;
                    pocet++;
                }
                if(prekazkaX==x && prekazkaY == y)
                {
                    Console.Clear ();
                    Console.WriteLine("Prohral jsi, narazil jsi do prekazky.");
                    Console.WriteLine("Pocet kroku: " + pocet + " Pocet snedeneho jidla: " + jidlo);
                    break;
                }
                if(jidloX==x && jidloY == y)
                {
                    jidloX = generator.Next(1, 31);
                    jidloY = generator.Next(1, 21);
                    jidlo = jidlo + 1;
                }
            }
        }
    }
}
