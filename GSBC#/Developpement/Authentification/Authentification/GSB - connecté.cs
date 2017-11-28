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
        List<Dictionary<string, string>> listFamilies;

        public GSB___connecté()
        {
            InitializeComponent();
        }

        private void GSB___connecté_Load(object sender, EventArgs e)
        {
            listMed = DAOProduit.getAllProduits();
            //TODO Résoudre le problème relatif aux Familles de produits
            //listFamilies = DAOProduit.getAllFamilies();
        }
    }
}
