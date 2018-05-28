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
        //List<Produit> listMed;
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
            refreshDgvVisit();
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
            txbVisitLogin.Text = "";
            txbVisitNom.Text = "";
            txbVisitPassword.Text = "";
            txbVisitPrenom.Text = "";
            txbVisitRechercher.Text = "";
            txbVisitVille.Text = "";
            btnVisitAdd.Enabled = true;
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
            cbxPartSpé.Text = prat;
        }

        private void dgvVisiteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbVisitNom.Text = dgvVisiteur.CurrentRow.Cells[1].FormattedValue.ToString();
            txbVisitPrenom.Text = dgvVisiteur.CurrentRow.Cells[2].FormattedValue.ToString();
            txbVisitLogin.Text = dgvVisiteur.CurrentRow.Cells[3].FormattedValue.ToString();
            txbVisitPassword.Text = dgvVisiteur.CurrentRow.Cells[4].FormattedValue.ToString();
            txbVisitAdresse.Text = dgvVisiteur.CurrentRow.Cells[5].FormattedValue.ToString();
            txbVisitCP.Text = dgvVisiteur.CurrentRow.Cells[6].FormattedValue.ToString();
            txbVisitVille.Text = dgvVisiteur.CurrentRow.Cells[7].FormattedValue.ToString();
            dtpVisitDateEmb.Value = Convert.ToDateTime(dgvVisiteur.CurrentRow.Cells[8].FormattedValue);
            string zone = dgvVisiteur.CurrentRow.Cells[9].FormattedValue.ToString();
            cbxVisitZoneGeo.Text = zone;
            btnVisitAdd.Enabled = false;
        }

        private void btnVisitDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string unLogin = txbVisitLogin.Text;
                string unMdp = txbVisitPassword.Text;

                string id = DAOVisiteur.getIdentifiant(unLogin, unMdp);

                DAOVisiteur.DeleteVisiteurs(id);
                refreshDgvVisit();
                txbVisitAdresse.Text = "";
                txbVisitCP.Text = "";
                txbVisitLogin.Text = "";
                txbVisitNom.Text = "";
                txbVisitPassword.Text = "";
                txbVisitPrenom.Text = "";
                txbVisitRechercher.Text = "";
                txbVisitVille.Text = "";
                MessageBox.Show("Suppression Bien Effectué !");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVisitAdd_Click(object sender, EventArgs e)
        {
            string nomVisiteur = txbVisitNom.Text;
            string prenomVisiteur = txbVisitPrenom.Text;
            string loginVisiteur = txbVisitLogin.Text;
            string mdpVisiteur = txbVisitPassword.Text;
            string adresseVisiteur = txbVisitAdresse.Text;
            string cpVisiteur = txbVisitCP.Text;
            string villeVisiteur = txbVisitVille.Text;
            DateTime dateEmbVisiteur = dtpVisitDateEmb.Value;
            string zoneGeoVisiteur = cbxVisitZoneGeo.Text;
            try
            {
                if (nomVisiteur != "" && prenomVisiteur != "" && loginVisiteur != "" && mdpVisiteur != "" && adresseVisiteur != "" && cpVisiteur != "" && villeVisiteur != "" && zoneGeoVisiteur != "")
                {
                    if (DAOVisiteur.AddVisiteurs(nomVisiteur, prenomVisiteur, loginVisiteur, mdpVisiteur, adresseVisiteur, cpVisiteur, villeVisiteur, dateEmbVisiteur, zoneGeoVisiteur))
                    {
                        refreshDgvVisit();
                        MessageBox.Show("Ajout Bien Effectué !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Ce compte est déjà existant !");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : Veuillez remplir tous les champs !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVisitModif_Click(object sender, EventArgs e)
        {
            string unLogin = txbVisitLogin.Text;
            string unMdp = txbVisitPassword.Text;

            string unNom = txbVisitNom.Text;
            string unPrenom = txbVisitPrenom.Text;
            string uneAdresse = txbVisitAdresse.Text;
            string unCP = txbVisitCP.Text;
            string uneVille = txbVisitVille.Text;
            DateTime uneDateEmbauche = dtpVisitDateEmb.Value; string dateEmbauche = dtpVisitDateEmb.Text;
            string uneZoneGeo = cbxVisitZoneGeo.Text;
            try
            {
                string id = DAOVisiteur.getIdentifiant(unLogin, unMdp);
                DAOVisiteur.UpdateVisiteur(id, unNom, unPrenom, uneAdresse, unCP, uneVille, uneDateEmbauche, uneZoneGeo);
                listVis = DAOVisiteur.getAllVisiteurs();
                listZoneGeo = DAOVisiteur.getAllZones();
                dgvVisiteur.DataSource = null;
                dgvVisiteur.DataSource = listVis;
                MessageBox.Show("Modification Efféctuée !");
            }
            catch (Exception ex)
            {
                string id = DAOVisiteur.getIdentifiant(unLogin, unMdp);
                if (id == null)
                {
                    MessageBox.Show("Vous ne pouvez pas modifier le login et le Mot de passe !");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txbVisitRechercher_TextChanged(object sender, EventArgs e)
        {
            string unNom = txbVisitRechercher.Text;
            listVis = DAOVisiteur.getUnVisiteur(unNom);
            dgvVisiteur.DataSource = null;
            dgvVisiteur.DataSource = listVis;  
        }

        public void refreshDgvVisit()
        {
            listVis = DAOVisiteur.getAllVisiteurs();
            listZoneGeo = DAOVisiteur.getAllZones();
            dgvVisiteur.DataSource = null;
            dgvVisiteur.DataSource = listVis;
            cbxVisitZoneGeo.DataSource = new BindingSource(listZoneGeo, null);
            cbxVisitZoneGeo.DisplayMember = "Value";
            cbxVisitZoneGeo.ValueMember = "Key";
        }

        private void txbPratRechercherPracticien_TextChanged(object sender, EventArgs e)
        {
            string unNom = txbPratRechercherPracticien.Text;
            listPrat = DAOPraticien.getUnPraticien(unNom);
            dgvPrat.DataSource = null;
            dgvPrat.DataSource = listPrat;
        }
    }
}