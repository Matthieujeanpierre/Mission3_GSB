using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission3_GSB
{
    public partial class FrmListeMedicaments : Form
    {
        private gsbrapportsEntities mesDonnees;
        private string familleSelectionnee;
        public FrmListeMedicaments(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bindingSource1.DataSource = mesDonnees.medicament.ToList();
            this.BdgOffert.DataSource = mesDonnees.offrir.ToList();
            this.familleSelectionnee = "";
        }

        public void MettreAjourMedicaments(List<medicament> medicaments)
        {
            this.bindingSource1.DataSource = medicaments;
          
        }

        public void MettreAjourMedicaments2(List<offrir> offrir)
        {
            this.BdgOffert.DataSource = offrir;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.EndEdit();
            try
            {
                this.mesDonnees.SaveChanges();
                MessageBox.Show(" Enregistrement validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Stockez la famille sélectionnée avant la suppression
            string familleAvantSuppression = familleSelectionnee;

            // Récupérez les lignes sélectionnées
            List<DataGridViewRow> lignesASupprimer = new List<DataGridViewRow>();

            foreach (DataGridViewRow ligne in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell celluleCheckBox = ligne.Cells["Column1"] as DataGridViewCheckBoxCell;

                if (celluleCheckBox != null && Convert.ToBoolean(celluleCheckBox.Value))
                {
                    lignesASupprimer.Add(ligne);
                }
            }

            // Supprimez les médicaments correspondants dans votre source de données
            foreach (DataGridViewRow ligne in lignesASupprimer)
            {
                medicament medicamentASupprimer = ligne.DataBoundItem as medicament;

                if (medicamentASupprimer != null)
                {
                    mesDonnees.medicament.Remove(medicamentASupprimer);
                }
            }

            // Enregistrez les modifications
            mesDonnees.SaveChanges();

            // Rechargez la liste de médicaments de la famille sélectionnée
            if (!string.IsNullOrEmpty(familleAvantSuppression))
            {
                this.bindingSource1.DataSource = mesDonnees.medicament.Where(m => m.famille != null && m.famille.Equals(familleAvantSuppression)).ToList();
                dataGridView1.Refresh();
                dataGridView1.Update();
            }

            MessageBox.Show("Médicaments supprimés avec succès.");
        }
    



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BdgOffert_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
