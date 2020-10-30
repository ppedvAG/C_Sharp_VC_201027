﻿using System;
using System.Runtime.CompilerServices;

namespace Fahrzeugpark
{
    public abstract class Fahrzeug
    {
        #region Statische Member
        //Als STATIC markierte Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten.
        public static int AnzahlErstellterFahrzeuge { get; set; } = 0;

        public static string ZeigeAnzahlFahrzeuge()
        {
            return $"Es wurden {AnzahlErstellterFahrzeuge} Fahrzeuge gebaut.";
        }

        //Mittels des OPERATOR-Stichworts können für einzelne Klassen Operatoren definiert werden
        //(Für Verwendung siehe TesteFahrzeugpark)
        public static bool operator ==(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.Equals(fz2);

            return fz1.Name == fz2.Name;
        }

        public static bool operator !=(Fahrzeug fz1, Fahrzeug fz2)
        {
            return !fz1.Equals(fz2);
        }
        #endregion


        #region Felder und Eigenschaften
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private int maxGeschwindigkeit;
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        //Snippet: propfull
        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
            set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value >= 0)
                    maxGeschwindigkeit = value;
            }
        }
        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        //Snippet: prop
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public bool MotorLäuft { get; set; }

        #endregion

        #region Konstruktor und Destruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Fahrzeug(string name, int maxG, decimal preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;

            AnzahlErstellterFahrzeuge++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        public Fahrzeug()
        {

        }

        //Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn ein Objekt aus dem Speicher gelöscht wird. Der Destruktor wird 
        ///automatisch (unsichtbar) erzeugt und muss nur selbst geschrieben werden, wenn neben der Objektzerstörung noch andere Anweisungen
        ///ausgeführt werden sollen.
        ~Fahrzeug()
        {
            Console.WriteLine($"{this.Name} wurde gerade verschrottet.");
        }
        #endregion

        #region Methoden
        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
        public void Beschleunige(int a)
        {
            if (this.MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;

                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }

        public void StarteMotor()
        {
            this.MotorLäuft = true;
            Console.WriteLine($"Der Motor von {this.Name} wurde gestartet.");
        }

        public void StoppeMotor()
        {
            this.MotorLäuft = false;
            this.AktGeschwindigkeit = 0;
            Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt.");
        }

        public virtual string BeschreibeMich()
        {
            if (this.MotorLäuft)
                return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
            else
                return $"{this.Name} kostet {this.Preis}€ und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
        }

        public override string ToString()
        {
            //return this.BeschreibeMich();

            return this.Name + ": " + this.Preis + "€"; 
        }

        public abstract void Hupe();

        #endregion
    }
}