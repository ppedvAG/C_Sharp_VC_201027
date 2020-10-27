using System;
using System.Linq;

namespace Kontrollstruckturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 1;
            int b = 31;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
                Console.WriteLine("A ist gleich B");

            Console.WriteLine("Ende des If-Blocks");

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                a++;

                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                if (a == 15)
                    break;
            }

            a = 0;

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine($"{a} ist größer als 0");
                a--;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;

                Console.WriteLine("Wird niemals ausgeführt");

            } while (a > 0);

            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Dies ist Durchlauf Nr. {i}.");
            }
            //Bsp einer For-Schleife von 1-1000 mit einer Verdoppelung des Index nach jedem Durchlauf
            for (double index = 1; index < 1000; index *= 2)
            {
                Console.WriteLine(index);
            }
            //Bsp für eine rückwärtslaufende Schleife von 10-1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlen = { 2, 4, 78, 789, -102, -8, 0, 111111 };
            //Der Zurgiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlen[4]);
            zahlen[4] = 123;
            Console.WriteLine(zahlen[4]);

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (var item in zahlen)
            {
                Console.WriteLine(item);
            }

            //Array-Deklaration ohne direkte Initialisierung der Positionen (Größe muss angegeben werden)
            string[] worte = new string[5];

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[3, 5];
            zweiDimArray[0, 0] = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }
            Console.WriteLine(zweiDimArray[2, 3]);

            //String als Char-Array
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);

            //Verwendung der Contains-Funktion eines Arrays (überprüft auf das Vorhandensein eines Elements)
            Console.WriteLine(beispiel.Contains('a'));
            Console.WriteLine(zahlen.Contains(500));
        }
    }
}
