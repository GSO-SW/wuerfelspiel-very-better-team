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
