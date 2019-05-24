using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stemcomputer
{
    public partial class StemSysteem : Form
    {
        public StemSysteem()
        {
            InitializeComponent();
            GetPartijen();
            panelPartijen.AutoScrollMinSize = new Size(0, 1700);
        }
        public string Nummer;
        public string id;
        public Image Img1;
        public string Voornaam;
        public string Achternaam;
        public string NummerKandidaat;

        Image returnImage;
        public List<uPartijen> partijenlist;
        public List<string> idPartijen;

        public byte[] myImage;

        public void GetPartijen()
        {
            Database con = new Database();
            partijenlist = new List<uPartijen>();
            idPartijen = new List<string>();
            con.SqlQuery("SELECT * FROM `partij` ");

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                uPartijen proitem = new uPartijen(this);

                myImage = (byte[])dr[3];
                Nummer = dr[4].ToString();

                Img1 = byteArrayToImage(myImage);
                proitem.afbeelding = Img1;
                proitem.ProductNummer = Nummer;

                partijenlist.Add(proitem);

                idPartijen.Add(Nummer);

            }
            panelPartijen.Controls.Clear();
            panelPartijen.Controls.AddRange(partijenlist.ToArray());
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true); 
            }
            catch
            {
            }

            return returnImage;
        }

        private void CheckBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                var myForm = new Dashboard();
                myForm.Show();
            }
        }
    }
}
