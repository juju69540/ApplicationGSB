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
        public GSB___connecté()
        {
            InitializeComponent();
        }

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
        }
    }
}
