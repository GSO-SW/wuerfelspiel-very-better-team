using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class UcWuerfel : UserControl
    {
        private Wuerfel wuerfel;
        public int Wert => Wuerfel.LetztesErbenis;
        public Wuerfel Wuerfel => wuerfel;

        public UcWuerfel():this(new(6))
        {
          
        }

        public UcWuerfel(Wuerfel wuerfel) 
        {
            InitializeComponent();
            this.wuerfel = wuerfel;
            this.lblWürfelNr.Text = "Würfel mit 6S";
            this.tbxAugenAnzah.Text ="0";
            this.btnGesichert.Text = "Sichern";
        }

        public int Werfen()
        {
            Wuerfel.Wuerfeln();
            this.tbxAugenAnzah.Text = Wuerfel.LetztesErbenis.ToString();
            return Wuerfel.LetztesErbenis;
        }

        private void btnGesichert_Click(object sender, EventArgs e)
        {
            wuerfel.SicherungUmschalten();

            if (wuerfel.Gesichert)
            {
                this.btnGesichert.Text = "Gesichert";
            }
            else
            {
                this.btnGesichert.Text = "Sichern";
            }
        }
    }
}
