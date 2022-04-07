using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErbenis;
        private bool gesichert;

        public Wuerfel(int letztesErbenis, bool gesichert)
        {
            this.letztesErbenis = letztesErbenis;   
            this.gesichert = gesichert;
        }

        public Wuerfel(int anzahlSeiten, int letztesErbenis, bool gesichert)
        {
            this.anzahlSeiten = anzahlSeiten;
            this.letztesErbenis = letztesErbenis;
            this.gesichert = gesichert;
        }
        public int AnzahlSeiten
        {
            get 
            {
                return anzahlSeiten;
            }
        }
        public int LetztesErbenis
        { 
        get 
            { 

                return letztesErbenis;
            }
        }
        public bool Gesichert
        {
            get 
            {
                return gesichert; 
            }
            set
            {
                this.gesichert = value;
            }
        }
        public void SicherungUmschalten()
        {
            throw new NotImplementedException();

        }
     }
}
