using Microsoft.VisualBasic;

int cena = 0;
int interval = 0;
int cele = 0;
Console.WriteLine("Zadej pocet minut:");
int minuty = int.Parse(Console.ReadLine());
if(minuty<1 || minuty>720)
{
    Console.WriteLine("Neplatna hodnota");
}
else if(minuty<=30)
{
    cena = 40;
    Console.WriteLine("Vysledna cena je: " + cena);
} else
{
    cele = (minuty-30) % 30;
    if (cele == 0)
    {
        interval = (minuty - 30)/ 30;   
    }
    else
    {
        interval = 1 + (minuty - 30) / 30;
    }
    cena = 40 + interval * 25;
    if (cena > 190)
    {
        cena = 190;
    }
    Console.WriteLine("Vysledna cena je: " + cena);
}

