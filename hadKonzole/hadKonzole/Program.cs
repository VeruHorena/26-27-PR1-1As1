namespace hadKonzole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            int prekazkaX = 20;
            int prekazkaY = 5;

            while (true)
            {
                Console.Clear();

                // Překážka
                Console.SetCursorPosition(prekazkaX, prekazkaY);
                Console.Write("X");

                // Had
                Console.SetCursorPosition(x, y);
                Console.Write("O");

                ConsoleKeyInfo klavesa = Console.ReadKey(true);

                if (klavesa.Key == ConsoleKey.RightArrow)
                {
                    x = x + 1;
                }

                if (klavesa.Key == ConsoleKey.LeftArrow)
                {
                    x = x - 1;
                }

                if (klavesa.Key == ConsoleKey.UpArrow)
                {
                    y = y - 1;
                }

                if (klavesa.Key == ConsoleKey.DownArrow)
                {
                    y = y + 1;
                }

                // Kontrola nárazu
                if (x == prekazkaX && y == prekazkaY)
                {
                    Console.Clear();
                    Console.WriteLine("BUM!");
                    Console.WriteLine("Had narazil do překážky.");
                    break;
                }
            }
        }
    }
}
