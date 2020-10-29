using System;
using System.Collections.Generic;
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

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            //schiff1.Entlade();

            #endregion

            #region Modul07: Generische Listen
            ////Deklaration und Initialisierung einer Liste von Strings
            //System.Collections.Generic.List<string> Städteliste = new List<string>();

            ////Hinzufügen von Listeneinträgen
            //Städteliste.Add("Berlin");
            //Städteliste.Add("Hamburg");
            //Städteliste.Add("München");
            //Städteliste.Add("Köln");
            //Städteliste.Add("Düsseldorf");

            ////Ausgabe der Länge der Liste
            //Console.WriteLine(Städteliste.Count);

            ////Ausgabe der 4. Listenposition
            //Console.WriteLine(Städteliste[3]);

            ////Manipulation der 5. Listenposition
            //Städteliste[4] = "Dresden";
            //Console.WriteLine(Städteliste[4]);

            ////Schleife über die Liste
            //foreach (var stadt in Städteliste)
            //{
            //    Console.WriteLine(stadt);
            //}

            ////Löschen des Eintrags 'München' (Nachfolgende Einträge rücken nach oben)
            //Städteliste.Remove("München");

            //List<Fahrzeug> Fahrzeugliste = new List<Fahrzeug>();

            //Fahrzeugliste.Add(new PKW("BMW", 250, 23000, 5));
            //Fahrzeugliste.Add(new Flugzeug("Boing", 750, 3000000, 9990));
            //Fahrzeugliste.Add(new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));

            //foreach (var fz in Fahrzeugliste)
            //{
            //    Console.WriteLine(fz.BeschreibeMich());
            //}

            ////Deklaration und Initialisierung eines Dictionarys (Key: String, Value: Int)
            //Dictionary<string, int> Einwohnerzahlen = new Dictionary<string, int>();

            ////Hinzufügen von Dictionary-Einträgen
            //Einwohnerzahlen.Add("Berlin", 3500000);
            //Einwohnerzahlen.Add("Hamburg", 2500000);
            //Einwohnerzahlen.Add("Leipzig", 60000);

            ////Ausgabe des Eintrags mit Key 'Leipzig'
            //Console.WriteLine(Einwohnerzahlen["Leipzig"]);
            ////Ändern des Eintrags mit dem Key 'Leipzig'
            //Einwohnerzahlen["Leipzig"] = 70000;

            ////Schleife über Dictionary
            //foreach (var item in Einwohnerzahlen)
            //{
            //    Console.WriteLine(item.Key + ": " +item.Value);
            //}

            //Dictionary<string, Fahrzeug> Dict2 = new Dictionary<string, Fahrzeug>();
            //Dict2.Add("Hugo", new PKW("BMW", 250, 23000, 5));
            //Dict2.Add("Anna", new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));

            //Console.WriteLine(Dict2["Anna"].BeschreibeMich());

            //Dictionary<Fahrzeug, List<string>> Passagiere = new Dictionary<Fahrzeug, List<string>>();
            //Passagiere.Add(new PKW("BMW", 250, 23000, 5), Städteliste);

            ////Deklaration und Initialisierung eines Hastables + Erstellung und Abruf von Einträgen (nicht-genereisches Dictionary nach dem Hash-Speicherprinzip)
            //Hashtable ht = new Hashtable();
            //ht.Add("Hallo", 450);
            //ht.Add(78.5, new PKW("VW", 260, 250020, 4));
            //Console.WriteLine(ht["Hallo"]);

            ////Deklaration und Initialisierung eines HashSets (generische Liste nach dem Hash-Speicherprinzip)
            //HashSet<int> hs = new HashSet<int>();
            //hs.Add(23); 
            #endregion


            #region Lab07 ZufälligeFahrzeuglisten

            //Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            Random generator = new Random();
            Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            //Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            int AnzahlFZs = 1000;

            //Schleife zur zufälligen Befüllung von Queue und Stack
            for (int i = 0; i < AnzahlFZs; i++)
            {
                //Würfeln einer zufälligen Zahl im Switch
                switch (generator.Next(1, 4))
                {
                    //Erzeugung von Objekten je nach zufälliger Zahl
                    case 1:
                        fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
                        fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
                        break;
                    case 2:
                        fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                        fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                        break;
                    case 3:
                        fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
                        fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
                        break;
                }
            }

            //Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            for (int i = 0; i < AnzahlFZs; i++)
            {
                //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
                if (fzQueue.Peek() is IBeladbar)
                {
                    //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
                    ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
                    //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
                    fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
                }
                else
                {
                    //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
                    fzQueue.Dequeue();
                    fzStack.Pop();
                }
            }

            //Erzwingen eines Durchlaufs der GarbageCollcetion (Löscht alle nicht-referenzierten Objekte aus dem RAM)
            GC.Collect();

            //Programmpause
            Console.ReadKey();
            Console.WriteLine("\n----------LADELISTE----------");

            //Schleife zur Ausgabe des Dictionaries
            foreach (var item in fzDict)
            {
                Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            }

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