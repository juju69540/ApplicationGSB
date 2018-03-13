﻿using System;
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
        Dictionary<string, string> listFamilies;
<<<<<<< HEAD
        TabPage currentpage;
=======
        Dictionary<string, string> listZoneGeo;
        Dictionary<string, string> listSpecialite;
>>>>>>> devBENSTITI

        public GSB___connecté()
        {
            InitializeComponent();
        }

        private void GSB___connecté_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //Sert à récupérer les informations pour les mettre dans le tableau
            listMed = DAOProduit.getAllProduits();
            dgvMed.DataSource = listMed;
            //Récupère le dictionnaire des Familles de Produits pour ajouter chaque famille à la combobox
            listFamilies = DAOProduit.getAllFamilies();
            foreach(KeyValuePair<string, string> entry in listFamilies)
            {
                cbxMedFamille.Items.Add(entry.Value);
            }
=======
            //listMed = DAOProduit.getAllProduits();
            //TODO Résoudre le problème relatif aux Familles de produits
            //listFamilies = DAOProduit.getAllFamilies();

            listPrat = DAOPraticien.getAllPraticien();
            listSpecialite = DAOPraticien.getAllSpecialite();
            dgvPrat.DataSource = null;
            dgvPrat.DataSource = listPrat;
            cbxPartSpé.Items.Clear();
            cbxPartSpé.DataSource = new BindingSource(listSpecialite, null);
            cbxPartSpé.DisplayMember = "Value";
            cbxPartSpé.ValueMember = "Key";
>>>>>>> devBENSTITI

        }

        private void tbcOnglets_SelectedIndexChanged(object sender, EventArgs e)
        {

<<<<<<< HEAD
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

=======
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

>>>>>>> devBENSTITI
        private void tabVisit_Click(object sender, EventArgs e)
        {
            try
            {
                listVis = DAOVisiteur.getAllVisiteurs();
                listZoneGeo = DAOVisiteur.getAllZones();
                dgvVisiteur.DataSource = null;
                dgvVisiteur.DataSource = listVis;
                cbxVisitZoneGeo.Items.Clear();
                cbxVisitZoneGeo.DataSource = new BindingSource(listZoneGeo, null);
                cbxVisitZoneGeo.DisplayMember = "Value";
                cbxVisitZoneGeo.ValueMember = "Key";
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

        private void btnPratAnnuler_Click(object sender, EventArgs e)
        {
            txbPratAdresse.Text = "";
            txbPratCoefConf.Text = "";
            txbPratCoefConfiance.Text = "";
            txbPratCoefNoto.Text = "";
            txbPratCoefNotor.Text = "";
            txbPratNom.Text = "";
            txbPratRechercherPracticien.Text = "";
            txbPratSocial.Text = "";
        }

        private void medUpdateDgv()
        {
            dgvMed.Rows.Clear();
            listMed = DAOProduit.getAllProduits();
            dgvMed.DataSource = listMed;

        }
    }
}