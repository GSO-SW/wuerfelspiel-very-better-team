using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErbenis;
        private bool gesichert;

        public Wuerfel() : this(6)
        {
            
        }

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
            this.letztesErbenis = -1;
            this.gesichert = false;
        }

        public int AnzahlSeiten => anzahlSeiten;

        public int LetztesErbenis => letztesErbenis;
        public bool Gesichert => gesichert;
        public void SicherungUmschalten()
        {
            gesichert = !gesichert;

        }
     }
}
