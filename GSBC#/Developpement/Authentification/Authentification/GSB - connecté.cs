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
        Dictionary<string, string> listFamilies;

        public GSB___connecté()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnVisitAdd_Click(object sender, EventArgs e)
        {
            FrmAjouterVisiteur addVisiteur = new FrmAjouterVisiteur();
            addVisiteur.Show();
        }

        private void btnMedAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParcAdd_Click(object sender, EventArgs e)
        {
            FrmAjouterPracticien addPracticien = new FrmAjouterPracticien();
            addPracticien.Show();
=======
        private void GSB___connecté_Load(object sender, EventArgs e)
        {
            //listMed = DAOProduit.getAllProduits();
            //TODO Résoudre le problème relatif aux Familles de produits
            //listFamilies = DAOProduit.getAllFamilies();
            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbMedSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMedAdd_Click(object sender, EventArgs e)
        {
            FrmAddMed newMed = new FrmAddMed();
            newMed.Show();
>>>>>>> devBENSTITI
        }
    }
}
