//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HelloWorld
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Ausgabe eines String-Literals (Literale sind 'ausgeschriebene' Werte, im Gegensatz zu Werten die in einer Variablen stecken)
            Console.WriteLine("Hello World!");

            //Deklaration einer Integer-Variable 
            int Alter;
            //Initialisierung der Integer-Variablen
            Alter = 31;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string Stadt = "Berlin";
            //Ausgabe der Variablen
            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);
            //Ausgabe eines Double-Literals
            Console.WriteLine(45.4);
            //Deklaration und Initialisierung einer Integer-Variablen mithilfe einer anderen Integer-Variablen
            int DoppeltesAlter = Alter * 2;
            Console.WriteLine(DoppeltesAlter);
            //Int-Berechnung innerhalb String-Ausgabe
            Console.WriteLine(Alter + DoppeltesAlter);

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell' über Stringverknüpfung (+-Operator)
            string Satz = "Ich bin " + Alter + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter + " Jahre alt und wohne in " + Stadt + ".");
            //Index (Variablen werden durch Index-Platzhalter vertreten und später definiert)
            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);
            //$-Operator (Variablen werde direkt in {}-Klammern geschrieben)
            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            //Ausgabe einer Berchnung in Strings
            int a = 45;
            int b = 12;
            Console.WriteLine($"{a} + {b} = {a + b}");

            //String-Formatierung mittels Escape-Sequenzen
            string bsp = "Dies ist ein \t Tabulator und dies ein \nZeilenumbruch \a.";
            Console.WriteLine(bsp);
            //Bsp für Pfadausgabe mittels Escape-Sequenzen
            string path = "C\\:Programme\\MeinOrdner\\MeineExe.exe";
            Console.WriteLine(path);

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, dynamische Inhalte mittels $ schon)
            string verbatim = @"Dies ist ein    Tabulator und dies ein
Zeilenumbruch";
            Console.WriteLine(verbatim);
            //Bsp für Pfadausgabe in Verbatim-String
            Console.WriteLine($@"C:\Programme\Anwendung.exe");

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib deinen Namen ein:");
            string input = Console.ReadLine();
            //Ausgabe
            Console.WriteLine($"Du heist also {input}.");

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein:");
            string eingegebeneZahl = Console.ReadLine();

            int umgewandelteZahl = int.Parse(eingegebeneZahl);
            int summe = umgewandelteZahl + umgewandelteZahl;
            //Ausgabe
            Console.WriteLine(summe);

            //Benutzereingabe (Tastendruck) hier als Programmpause, bis Benutzer einer Taste drückt
            Console.ReadKey();

            //Bsp für numerische Umwandlung
            double kommazahl = 123.756;
            //Cast: Double -> Int
            int ganzzahl = (int)kommazahl;
            Console.WriteLine(ganzzahl);

            //Bsp für Teilung durch 0 von Gleitkommazahlen
            double z = 5.7 / 0.0;
            Console.WriteLine(z);
        }


    }
}