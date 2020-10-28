using System;
using System.Text;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Modul04: OOP
            ////Instanzierung der Fahrzeuge
            //Fahrzeug fz1 = new Fahrzeug("BMW", 200);
            //Fahrzeug fz2 = new Fahrzeug("Audi", 180);

            ////Ausgabe von fz1
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");

            ////Veränderung des Namens von fz1
            //fz1.Name = "Opel";
            ////Ausgabe der Fahrzeugeigenschaften (fz1 wurde verändert, fz2 nicht)
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");
            //Console.WriteLine(fz2.Name + ": " + fz2.MaxGeschwindigkeit + "km/h");

            ////Ausgabe der BeschreibeMich-Methode von fz1
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Lab04: Fahrzeug_Klasse

            //Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            //Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            Console.WriteLine(fz1.BeschreibeMich() + "\n");

            //Diverse Methodenausführungen
            fz1.StarteMotor();
            fz1.Beschleunige(120);
            Console.WriteLine(fz1.BeschreibeMich() + "\n");

            fz1.Beschleunige(300);
            Console.WriteLine(fz1.BeschreibeMich() + "\n");

            fz1.StoppeMotor();
            Console.WriteLine(fz1.BeschreibeMich() + "\n");

            #endregion
        }
    }
}
