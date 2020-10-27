using System;

namespace Enumeratoren
{
    //ENUMERATOREN sind spezialisierte selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
    ///Dabei ist jeder Zustand an einen Integer-Wert gekoppelt, wodurch eine explizite Umwandlung (Cast) möglich ist.
    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnertag, Freitag, Samstag, Sonntag }

    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heute = Wochentag.Mittwoch;
            Console.WriteLine($"Heute ist also {heute}.");

            //For-Schleife über die möglichen Zustande des Enumerators
            Console.WriteLine("Welcher Wochentag ist dein Lieblingstag?");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            //Speichern einer Benutzereingabe (Int) als Enumerator
            //Cast: Int -> Wochentag
            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Dein Lieblingstag ist also {heute}.");

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Habe eine schöne Woche.");
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnertag:
                    Console.WriteLine("Nicht überarbeiten!");
                    break;
                case Wochentag.Freitag:
                    Console.WriteLine("Bald ist Wochenende");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Schönes Wochenende");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int a = 11;
            switch (a)
            {
                case 5:
                    Console.WriteLine("Irgendwas");
                    break;
                //a wird in b eingelegt (zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b when b != 10:
                    Console.WriteLine("a ist größer als 10");
                    break;
                case 11:
                    Console.WriteLine("Wird nicht angezeigt");
                    break;
                default:
                    break;
            }
        }
    }
}
