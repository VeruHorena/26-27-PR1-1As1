namespace Had
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //souradnice had
            int x = 10;
            int y = 5;

            //souradnice prekazka
            int prekazkaX = 20;
            int prekazkaY = 5;
            while (true)
            {
                Console.Clear();
                //vykresleni
                Console.WriteLine("---------------------------------------");
                Console.SetCursorPosition(x, y);
                Console.Write("O");
                Console.SetCursorPosition(prekazkaX, prekazkaY);
                Console.Write("X");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");

                ConsoleKeyInfo stisknute = Console.ReadKey();
                if (stisknute.Key == ConsoleKey.RightArrow)
                {
                    x = x + 1;
                }
                if (stisknute.Key == ConsoleKey.LeftArrow)
                {
                    x = x - 1;
                }
                if (stisknute.Key == ConsoleKey.UpArrow)
                {
                    y = y - 1;
                }
                if (stisknute.Key == ConsoleKey.DownArrow)
                {
                    y = y + 1;
                }
                if(prekazkaX==x && prekazkaY == y)
                {
                    Console.Clear ();
                    Console.WriteLine("Prohral jsi, narazil jsi do prekazky.");
                    break;
                }
            }
        }
    }
}
