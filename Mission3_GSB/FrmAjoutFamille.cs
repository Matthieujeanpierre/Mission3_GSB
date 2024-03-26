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
    public partial class FrmAjoutFamille : Form
    {
        private gsbrapportsEntities mesDonnees;
        public FrmAjoutFamille(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bindingSource1.DataSource = mesDonnees.famille.ToList();
        }


        private famille newFamille()
        {
            famille newFamille = new famille();
            newFamille.id = textBoxId.Text;
            newFamille.libelle = textBoxLibelle.Text;
            return newFamille;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.EndEdit();
            try
            {
                this.mesDonnees.famille.Add(newFamille());
                this.mesDonnees.SaveChanges();
                MessageBox.Show(" Enregistrement validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
