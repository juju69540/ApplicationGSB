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
        List<Praticien> listPrat;
        List<Visiteur> listVis;
        //Dictionary<string, string> listFamilies;
        Dictionary<string, string> listZoneGeo;
        Dictionary<string, string> listSpecialite;

        public GSB___connecté()
        {
            InitializeComponent();
        }

        private void GSB___connecté_Load(object sender, EventArgs e)
        {
            // Part affichage Medicaments

            // Part affichage Visiteur
            listVis = DAOVisiteur.getAllVisiteurs();
            listZoneGeo = DAOVisiteur.getAllZones();
            dgvVisiteur.DataSource = null;
            dgvVisiteur.DataSource = listVis;
            cbxVisitZoneGeo.Items.Clear();
            cbxVisitZoneGeo.DataSource = new BindingSource(listZoneGeo, null);
            cbxVisitZoneGeo.DisplayMember = "Value";
            cbxVisitZoneGeo.ValueMember = "Key";
            // Part affichage Praticien
            listPrat = DAOPraticien.getAllPraticien();
            listSpecialite = DAOPraticien.getAllSpecialite();
            dgvPrat.DataSource = null;
            dgvPrat.DataSource = listPrat;
            cbxPartSpé.Items.Clear();
            cbxPartSpé.DataSource = new BindingSource(listSpecialite, null);
            cbxPartSpé.DisplayMember = "Value";
            cbxPartSpé.ValueMember = "Key";

        }

        private void tbcOnglets_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                //Switch doesn't work, you have to add your own tab with a else if
                if (tbcOnglets.SelectedTab == tbcOnglets.TabPages["tabMed"])
                {
                    listMed = DAOProduit.getAllProduits();
                    dgvMed.DataSource = null;
                    dgvMed.DataSource = listMed;
                }
                else if (tbcOnglets.SelectedTab == tbcOnglets.TabPages["tabVisit"])
                {
                    listVis = DAOVisiteur.getAllVisiteurs();
                    listZoneGeo = DAOVisiteur.getAllZones();
                    dgvVisiteur.DataSource = null;
                    dgvVisiteur.DataSource = listVis;
                    /*cbxVisitZoneGeo.Items.Clear();
                    cbxVisitZoneGeo.DataSource = new BindingSource(listZoneGeo, null);
                    cbxVisitZoneGeo.DisplayMember = "Value";
                    cbxVisitZoneGeo.ValueMember = "Key";*/
                }
                else
                {
                    listPrat = DAOPraticien.getAllPraticien();
                    dgvPrat.DataSource = null;
                    dgvPrat.DataSource = listPrat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnPratAnnuler_Click(object sender, EventArgs e)
        {
            txbPratAdresse.Text = "";
            txbPratContact.Text = "";
            txbPratCoefConfiance.Text = "";
            txbPratTel.Text = "";
            txbPratCoefNoto.Text = "";
            txbPratNom.Text = "";
            txbPratRechercherPracticien.Text = "";
            txbPratSocial.Text = "";
        }

        private void txbPratQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvPrat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPratNom.Text = dgvPrat.CurrentRow.Cells[0].FormattedValue.ToString();
            txbPratSocial.Text = dgvPrat.CurrentRow.Cells[1].FormattedValue.ToString();
            txbPratAdresse.Text = dgvPrat.CurrentRow.Cells[2].FormattedValue.ToString();
            txbPratTel.Text = dgvPrat.CurrentRow.Cells[3].FormattedValue.ToString();
            txbPratContact.Text = dgvPrat.CurrentRow.Cells[4].FormattedValue.ToString();
            txbPratCoefNoto.Text = dgvPrat.CurrentRow.Cells[5].FormattedValue.ToString();
            txbPratCoefConfiance.Text = dgvPrat.CurrentRow.Cells[6].FormattedValue.ToString();
            string prat = dgvPrat.CurrentRow.Cells[7].FormattedValue.ToString();
            foreach (var item in cbxPartSpé.Items)
            {
                if(item.ToString() == prat)
                {
                    cbxPartSpé.SelectedItem = item;
                }
            }
        }
    }
}