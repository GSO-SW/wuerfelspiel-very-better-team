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
        private Wuerfel Wuerfel;
        private int Wert => Wuerfel.LetztesErbenis;

        public UcWuerfel():this(new(6))
        {
          
        }

        public UcWuerfel(Wuerfel wuerfel) 
        {
            InitializeComponent();
            Wuerfel = wuerfel;
        }

        private void Click() { }
        private void DoubleClick() { }


    }
}
