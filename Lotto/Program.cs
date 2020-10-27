using System;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablendeklaration und -initialisierung
            Random generator = new Random();
            int[] benutzerZahlen = new int[3];
            int[] zufallsZahlen = new int[3];
            int treffer;

            do
            {
                treffer = 0;

                //Schleife zum Würfeln der Zahlen
                for (int i = 0; i < zufallsZahlen.Length; i++)
                {
                    //Deklaration eines Zwischenspeichers
                    int temp;
                    do
                    {
                        //Würfeln der Zahl in den Zwischenspeicher
                        temp = generator.Next(1, 11);
                        //Wdh der Schleife, wenn Zahl bereits im Array
                    } while (zufallsZahlen.Contains(temp));
                    //Übertrag des Zwischenspeichers in das Array
                    zufallsZahlen[i] = temp;
                }

                //Schleife zum Erfragen der Benutzerzahlen
                for (int i = 0; i < benutzerZahlen.Length; i++)
                {
                    Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
                    benutzerZahlen[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("\nGewinnzahlen:");
                //Schleife zum Ausgeben der Gewinnzahlen UND zum Zählen der Treffer
                foreach (var zahl in zufallsZahlen)
                {
                    Console.Write($" {zahl}");
                    //Hochzählen der Treffervariablen bei Vorkommen in beiden Arrays
                    if (benutzerZahlen.Contains(zahl))
                        treffer++;
                }

                //Ausgabe der Treffer:
                Console.WriteLine($"\n\nDu hast {treffer} richtige Zahl(en) erraten.");

                Console.WriteLine("Nochmal? Drücke Y!");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}
