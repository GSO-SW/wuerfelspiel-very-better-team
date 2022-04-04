using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErbenis;
        private bool gesichert;
        Random rnd = new Random();

        public Wuerfel()
        {
            this.anzahlSeiten = AnzahlSeiten;
            this.letztesErbenis = LetztesErbenis;   
            this.gesichert = true;
        }

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
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
        }
     }
}
