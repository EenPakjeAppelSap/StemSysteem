using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stemcomputer
{
    public partial class uKandidaten : UserControl
    {
        public StemSysteem _Form1;
        public uPartijen uPartijen;

        public uKandidaten(StemSysteem form1)
        {
            InitializeComponent();
            _Form1 = form1;
        }

        public uKandidaten(uPartijen uPartijen)
        {
            this.uPartijen = uPartijen;
        }

        public string Voornaam;
        private string Kandidaatachternaam;
        private string Kandidaatnummer;

        public string KandidaatNaam
        {
            set
            {
         
            }
            get
            {
                return Voornaam;
            }

        }

        public string KandidaatAchterNaam
        {
            set
            {
         
            }
            get
            {
                return Kandidaatachternaam;
            }

        }


        public string KandidaatNummer
        {
            set
            {
         
            }
        }

        private void ButtonKandidaat_Click(object sender, EventArgs e)
        {
   
        }

       
    }
}
