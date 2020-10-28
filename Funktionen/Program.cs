using System;

namespace Funktionen
{
    class Program
    {
        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        public static int Addiere(int a, int b)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b;

            Console.WriteLine("Wird nicht ausgeführt");
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        public static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static double Addiere(double a, double b, double c = 0.0, double d = 0.0)
        {
            return a + b + c + d;
        }

        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        public static double AddiereBeliebigeDoubles(params double[] doubleZahlen)
        {
            //Deklaration einer Integer-Hilfsvariablen und initialisierung auf 0
            double summe = 0;
            //Schleife über das übergebene Array
            foreach (var item in doubleZahlen)
            {
                //Hinzufügen der im Array betrachteten Zahl zur Variable
                summe += item;
            }
            //Rückgabe der Variablen
            return summe;
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden
        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }


        static void Main(string[] args)
        {
            //Aufruf der Addiere(int,int)-Funktion (optinale Parameter werden auf ihren Default-Wert gesetzt)
            int summe = Addiere(12, 78);

            //Aufruf einer Funktion unter Verwendung der optionalen Parameter
            double doubleSumme = Addiere(12.5, 78.5, 78.1);

            //Aufruf der Params-Funktion mit Übergabe eines Arrays, einer bleiebigen Anzahl von Ints und nichts
            doubleSumme = AddiereBeliebigeDoubles(new double[] { 2, 4, 5 });
            doubleSumme = AddiereBeliebigeDoubles();
            doubleSumme = AddiereBeliebigeDoubles(12.0, 45.7, 789.5, -78);

            //Aufruf der Out-Funktion
            summe = AddiereUndSubtrahiere(12, 89, out int diff);
            //Ausgabe
            Console.WriteLine($"Summe: {summe}, Differenz: {diff}");

            //TryParse() als Bsp für Out-Verwendung
            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result * result);
            }

            //Gegenbeispiel: Parse mit Prüfung (ohne TryParse)
            //if (eingabe.All(x => char.IsDigit(x)))
            //{
            //    Console.WriteLine(int.Parse(eingabe) * 2);
            //}

            //Vorzeitiges Beenden der Konsolenapplikation
            Environment.Exit(0);
        }
    }
}
