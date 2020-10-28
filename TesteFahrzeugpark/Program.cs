using System;
using System.Runtime.CompilerServices;
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

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich() + "\n");

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich() + "\n");

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich() + "\n");

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich() + "\n");

            #endregion

            #region Modul05: Vererbung

            //PKW pkw1 = new PKW("BMW", 210, 26000, 5);

            //Console.WriteLine(pkw1.BeschreibeMich());

            //Console.WriteLine(pkw1);

            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);
            //pkw1 = new PKW("BMW", 210, 26000, 5);

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Lab05: PKW-, Schiff- und Flugzeug-Klasse

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());
            //pkw1.Hupe();

            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());
            //schiff1.Hupe();

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());
            //flugzeug1.Hupe();

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Modul06: Interfaces und Polymorphismus

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);

            //Fahrzeug fz1 = pkw1;

            //IBewegbar bewegbaresObjekt = pkw1;

            //bewegbaresObjekt.Crash();

            //MontiereNeuesRad(pkw1);

            //BenenneFahrzeugUm("Opel", pkw1);

            #endregion

            #region Lab06: IBeladbar

            PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            BeladeFahrzeuge(pkw1, flugzeug1);
            BeladeFahrzeuge(flugzeug1, schiff1);
            BeladeFahrzeuge(schiff1, pkw1);

            Console.WriteLine("\n" + schiff1.BeschreibeMich());

            schiff1.Entlade();

            #endregion
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

        //Bsp-Methoden Modul06
        public static void MontiereNeuesRad(IBewegbar bewegbaresObjekt)
        {
            bewegbaresObjekt.AnzahlRaeder++;

            if (bewegbaresObjekt is Fahrzeug)
            {
                Console.WriteLine(((Fahrzeug)bewegbaresObjekt).Name + " hat nen neuen Reifen.");

                Console.WriteLine((bewegbaresObjekt as Fahrzeug).Name + " hat nen neuen Reifen.");
            }
        }

        public static void BenenneFahrzeugUm(string neuerName, Fahrzeug fz1)
        {
            fz1.Name = neuerName;
        }
    }
}