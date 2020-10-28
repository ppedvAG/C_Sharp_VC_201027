using System;

namespace Taschenrechner
{
    //Definition des Enumerator-Datentyps 'Rechenoperation'
    enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration der benötigten Variablen
            double zahl1, zahl2, ergebnis;
            int auswahl;
            Rechenoperation op;

            //Abfragen der Zahlen über Benutzereingabe
            do
                Console.Write("Gib eine Zahl ein: ");
            while (!double.TryParse(Console.ReadLine(), out zahl1));
            do
                Console.Write("Gib eine weitere Zahl ein: ");
            while (!double.TryParse(Console.ReadLine(), out zahl2));

            Console.WriteLine("Wähle eine Rechenoperation aus: ");
            //Präsentation der möglichen Optionen
            for (int i = 1; i <= Enum.GetValues(typeof(Rechenoperation)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Rechenoperation)i}");
            }
            //Abfragen der gewünschten Operation über Benutzereingabe und Cast
            while (!int.TryParse(Console.ReadLine(), out auswahl))
                Console.WriteLine("Bitte wähle eine Zahl aus der obigen Liste.");
            op = (Rechenoperation)auswahl;

            //Aufruf der Berechne()-Funktion mit Übergabe der Zahlen und der gewählten Operation und Speichern des Rückgabewerts
            ergebnis = Berechne(zahl1, zahl2, op);

            if (double.IsNaN(ergebnis))
                Console.WriteLine("Fehlerhafte Eingabe");
            else
                //Ausgabe des Ergebnisses
                Console.WriteLine("Ergebnis: " + ergebnis);
        }

        //Funktion zur Berechnung der gewählten Operation
        public static double Berechne(double a, double b, Rechenoperation operation)
        {
            //Verzweigung je nach gewählter Operation
            switch (operation)
            {
                case Rechenoperation.Addition:
                    return a + b;
                case Rechenoperation.Subtraktion:
                    return a - b;
                case Rechenoperation.Multiplikation:
                    return a * b;
                case Rechenoperation.Division:
                    return a / b;
                default:
                    //Rückgabe der Double-Konstanten 'NaN' (Not A Number) bei fehlerhafter Eingabe durch den Benutzer
                    return double.NaN;
            }
        }
    }
}
