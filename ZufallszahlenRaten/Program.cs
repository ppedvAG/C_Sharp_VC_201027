using System;

namespace ZufallszahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int eingabe;

                Random generator = new Random();
                int zufallszahl = generator.Next(1, 6);

                do
                {
                    Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ");
                    eingabe = int.Parse(Console.ReadLine());

                    if (zufallszahl == eingabe)
                        Console.WriteLine("Deine Zahl ist richtig.");
                    else if (zufallszahl < eingabe)
                        Console.WriteLine("Deine Zahl ist zu groß.");
                    else
                        Console.WriteLine("Deine Zahl ist zu klein.");

                } while (eingabe != zufallszahl);

                Console.WriteLine("Möchtest du nochmal spielen? (Y/N)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}
