using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugpark
{
    //vgl auch PKW
    public class Flugzeug : Fahrzeug, IBewegbar
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRaeder { get; set; }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRaeder = 12;
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $" Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("BiepBiep");
        }

        public void Crash()
        {
            Console.WriteLine("Da stand jemand auf der Rollbahn");
            this.AnzahlRaeder -= 2;
        }
    }
}
