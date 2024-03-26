using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_GSB
{
    public partial class FrmMenu : Form
    {
        private gsbrapportsEntities mesDonnees;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonnees = new gsbrapportsEntities();
        }

        private void medicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererMedicaments gerer = new GererMedicaments(this.mesDonnees);
            gerer.Show();
        }
    }
}
