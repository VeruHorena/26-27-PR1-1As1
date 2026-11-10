namespace CyklyProcviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cyklus for
            Console.WriteLine("Vypis pomoci cyklu for:");
            Console.WriteLine("Vypis od nejmensiho po nejvetsi");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Vypis od nejvetsiho po nejmensi");
          for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Vypis pomoci cyklu while:");
            Console.WriteLine("Vypis od nejmensiho po nejvetsi");
            int cislo = 1;
            while (cislo <= 10)
            {
                Console.WriteLine(cislo);
                cislo++; //velice delezity krok, jinak dojde k zacykleni
            }
            Console.WriteLine("Vypis od nejvetsiho po nejmensi");
            int cislo2 = 10;
            while (cislo2 >= 1)
            {
                Console.WriteLine(cislo2);
                cislo2--;
            }
            Console.WriteLine("Vypis pomoci cyklu do..while:");
            Console.WriteLine("Vypis od nejmensiho po nejvetsi");
            int cislo3 = 1;
            do
            {
                Console.WriteLine(cislo3);
                cislo3++;
            } while (cislo3 <= 10);
            Console.WriteLine("Vypis od nejvetsiho po nejmensi");
            int cislo4 = 10;
            do
            {
                Console.WriteLine(cislo4);
                cislo4--;
            } while (cislo4 >= 1);

            Console.WriteLine("Zadej hodnotu horni hranice:");
            int cislo5;
            while(int.TryParse(Console.ReadLine(),out cislo5) == false || cislo5<=0)
            {
                Console.WriteLine("Zadej správnou hodnotu");
            }
            for(int i = 1; i <= cislo5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
