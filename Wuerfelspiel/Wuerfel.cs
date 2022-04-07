using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErbenis;
        private bool gesichert;
        protected static Random md;

        public Wuerfel() : this(6)
        {
            
        }

        public Wuerfel(int anzahlSeiten)
        {
            if (md==null)
            {
                md = new Random();
            }
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
        public int Wuerfeln()
        {
            if (gesichert)
            {
                return letztesErbenis;
            }
            letztesErbenis=md.Next(1,anzahlSeiten);
            return letztesErbenis;
        }
        
     }
}
