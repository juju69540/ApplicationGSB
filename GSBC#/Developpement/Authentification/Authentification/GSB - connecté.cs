using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentification
{
    public partial class GSB___connecté : Form
    {
        List<Produit> listMed;
        List<Visiteur> listVis;
        Dictionary<string, string> listFamilies;
        TabPage currentpage;

        public GSB___connecté()
        {
            InitializeComponent();
        }

        private void btnVisitAdd_Click(object sender, EventArgs e)
        {
            
        }


        private void btnParcAdd_Click(object sender, EventArgs e)
        {

        }

        private void GSB___connecté_Load(object sender, EventArgs e)
        {
            //Sert à récupérer les informations pour les mettre dans le tableau
            listMed = DAOProduit.getAllProduits();
            dgvMed.DataSource = listMed;
            //Récupère le dictionnaire des Familles de Produits pour ajouter chaque famille à la combobox
            listFamilies = DAOProduit.getAllFamilies();
            foreach(KeyValuePair<string, string> entry in listFamilies)
            {
                cbxMedFamille.Items.Add(entry.Value);
            }

        }

        private void tbcOnglets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbMedSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMedAdd_Click(object sender, EventArgs e)
        {
            bool success = false;
            string family = cbxMedFamille.SelectedText;
            foreach(KeyValuePair<string, string> entry in listFamilies)
            {
                if (entry.Value == family)
                {
                    family = entry.Key;
                }
            }
            success = DAOProduit.addMed(txbMedNom.Text, txbMedDescpt.Text, txbMedDos.Text, txbMedEffet.Text, txbMedContrIndic.Text, txbMedPrixHt.Text, txbMedPrixEchant.Text, family);
            if (success)
            {
                MessageBox.Show("Ajout réussi dans la BDD");
            }

        }

        private void tabVisit_Click(object sender, EventArgs e)
        {

        }

        private void dgvMed_Click(object sender, EventArgs e)
        {
            txbMedNom.Text = dgvMed.CurrentRow.Cells[0].FormattedValue.ToString();
            txbMedDescpt.Text = dgvMed.CurrentRow.Cells[2].FormattedValue.ToString();
            txbMedDos.Text = dgvMed.CurrentRow.Cells[3].FormattedValue.ToString();
            txbMedEffet.Text = dgvMed.CurrentRow.Cells[4].FormattedValue.ToString();
            txbMedContrIndic.Text = dgvMed.CurrentRow.Cells[5].FormattedValue.ToString();
            txbMedPrixHt.Text = dgvMed.CurrentRow.Cells[6].FormattedValue.ToString();
            //txbMedPrixEchant.Text = dgvMed.CurrentRow.Cells[7].FormattedValue.ToString();
            string fam = dgvMed.CurrentRow.Cells[1].FormattedValue.ToString();
            foreach(var item in cbxMedFamille.Items)
            {
                if (item.ToString() == fam)
                {
                    cbxMedFamille.SelectedItem = item;
                }
            }

        }

        private void btnMedCancel_Click(object sender, EventArgs e)
        {
            txbMedNom.Text = "";
            txbMedDescpt.Text = "";
            txbMedDos.Text = "";
            txbMedEffet.Text = "";
            txbMedContrIndic.Text = "";
            txbMedPrixHt.Text = "";

        }

        private void btnVisitAnnuler_Click(object sender, EventArgs e)
        {
            txbVisitAdresse.Text = "";
            txbVisitCP.Text = "";
            txbVisitDateEmbauche.Text = "";
            txbVisitLogin.Text = "";
            txbVisitNom.Text = "";
            txbVisitPassword.Text = "";
            txbVisitPrenom.Text = "";
            txbVisitRechercher.Text = "";
            txbVisitVille.Text = "";
        }

        private void tbcOnglets_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnVisitModif_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitDelete_Click(object sender, EventArgs e)
        {

        }

        private void tabPract_Click(object sender, EventArgs e)
        {

        }

        private void medUpdateDgv()
        {
            dgvMed.Rows.Clear();
            listMed = DAOProduit.getAllProduits();
            dgvMed.DataSource = listMed;

        }
    }
}
