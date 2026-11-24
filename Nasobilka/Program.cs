namespace Nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej hodnotu zakladu:");
            int zaklad;
            while (int.TryParse(Console.ReadLine(), out zaklad) == false || zaklad <= 0)
            {
                Console.WriteLine("Zadej hodnotu znovu");
            }
            Console.WriteLine("Nasobky pomoci for");
            //  int nasobek;
            for (int i = 1; i <= 10; i++)
            {
                //nasobek = zaklad * i;
                Console.WriteLine(i + ". násobek cisla " + zaklad + " je " + (zaklad * i));
            }
            int j = 1;
            Console.WriteLine("Nasobky pomoci while");
            while (j <= 10)
            {
                Console.WriteLine(j + ". násobek cisla " + zaklad + " je " + (zaklad * j));
                j++;
            }
            Console.WriteLine("Nasobky pomoci do..while");
            j = 1;
            do
            {
                Console.WriteLine(j + ". násobek cisla " + zaklad + " je " + (zaklad * j));
                j++;
            }while (j <= 10);
        }
    }
}

