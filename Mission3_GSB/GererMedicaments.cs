using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_GSB
{
    public partial class GererMedicaments : Form
    {
        private gsbrapportsEntities mesDonnees;
        public GererMedicaments(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bindingSource1.DataSource = mesDonnees.famille.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAjoutFamille ajout = new FrmAjoutFamille(this.mesDonnees);
            ajout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            famille selectFamille = comboBox1.SelectedItem as famille;

            if (selectFamille != null)
            {
                var query = from medicament in mesDonnees.medicament
                            where medicament.famille.id == selectFamille.id
                            select medicament;

                var query2 = from medicament in mesDonnees.medicament
                             join offrir in mesDonnees.offrir on medicament.id equals offrir.medicament.id
                             where offrir.medicament.famille.id == selectFamille.id
                             select offrir;

                var listemedicaments = query.ToList();
                var listemedicaments2 = query2.ToList();

                FrmListeMedicaments lstMedoc = Application.OpenForms["ListeMedicament"] as FrmListeMedicaments;
                
                if (lstMedoc != null)
                {
                    lstMedoc.MettreAjourMedicaments(listemedicaments);
                    lstMedoc.MettreAjourMedicaments2(listemedicaments2);
                }
                else
                {
                    lstMedoc = new FrmListeMedicaments(mesDonnees);
                    lstMedoc.MettreAjourMedicaments(listemedicaments);
                    lstMedoc.MettreAjourMedicaments2(listemedicaments2);
                    lstMedoc.Show();
                }

            }
        }
    }
}

