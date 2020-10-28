using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugpark
{
    //vgl. IBeladbar
    public interface IBewegbar
    {
        int AnzahlRaeder { get; set; }

        void Crash();
    }
}
