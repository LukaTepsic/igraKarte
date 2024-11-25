using System;

class Program
{
    static void Main()
    {
        int karte = 0;
        int cardCounter = 0;

        while (cardCounter < 31)
        {
            Console.WriteLine("Unesite vrijednost karte (1 - 13): ");
            karte = Convert.ToInt32(Console.ReadLine());

            if (karte >= 1 && karte <= 13)
            {
                cardCounter += karte;
            }
            else
            {
                Console.WriteLine("Vrijednost mora biti između 1 i 13.");
            }
        }

        if (cardCounter == 31)
        {
            Console.WriteLine("Pobjeda");
        }
        else
        {
            Console.WriteLine("Gubitak");
        }
        Console.ReadKey();
    }
}
