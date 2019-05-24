using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stemcomputer
{
    public partial class Dashboard : Form
    {
        private StemSysteem stemSysteem;

        public Dashboard()
        {
            InitializeComponent();
            this.Size = new Size(420, 200);
            AutoScrollMinSize = new Size(0, 1700);
        }

        public Dashboard(StemSysteem stemSysteem)
        {
            this.stemSysteem = stemSysteem;
        }

    }
}
