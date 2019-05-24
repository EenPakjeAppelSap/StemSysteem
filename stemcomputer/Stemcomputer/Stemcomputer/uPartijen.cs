using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Stemcomputer
{
    public partial class uPartijen : UserControl
    {

        public StemSysteem _Form1;


        public uPartijen(StemSysteem  form1)
        {
            InitializeComponent();
             _Form1 = form1;
        }

        private string Nummer;
        public string Voornaam;
        public string Achternaam;
        public string NummerKandidaat;

        public List<uKandidaten> Kandidatenlist;
        public List<string> idKandidaten;

        public string ProductNummer
        {
            set
            {
                Nummer = value;
                labelNummer.Text = Nummer;
            }
        }


        public Image afbeelding
        {
            get
            {
                return pictureBoxPartijen.Image;
            }
            set
            {
                pictureBoxPartijen.Image = value;
            }
        }
        private void ButtonPartij_Click_1(object sender, EventArgs e)
        {
            Database con = new Database();

            if (_Form1.idPartijen.Contains(labelNummer.Text))
            {
                con.SqlQuery("SELECT * FROM `kandidaat` where `partijnummer` =@nummer ");
                con.Cmd.Parameters.Add("@nummer", MySql.Data.MySqlClient.MySqlDbType.VarString).Value = labelNummer.Text;

                Kandidatenlist = new List<uKandidaten>();
                idKandidaten = new List<string>();


                foreach (DataRow dr in con.QueryEx().Rows)
                {
                    uKandidaten proitem = new uKandidaten(this);

                    Voornaam = dr[2].ToString();
                    Achternaam = dr[3].ToString();
                    NummerKandidaat = dr[6].ToString();
                 
                    proitem.KandidaatNaam = Voornaam;
                    proitem.KandidaatAchterNaam = Achternaam;
                    proitem.KandidaatNummer = NummerKandidaat;

                    Kandidatenlist.Add(proitem);


                }
                _Form1.panelPartijen.Controls.Clear();
                _Form1.panelPartijen.Controls.AddRange(Kandidatenlist.ToArray());

            }
        }
    }
}
