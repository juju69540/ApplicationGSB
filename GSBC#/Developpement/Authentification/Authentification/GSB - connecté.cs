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

<<<<<<< HEAD
        private void btnVisitAdd_Click(object sender, EventArgs e)
        {
            FrmAjouterVisiteur addVisiteur = new FrmAjouterVisiteur();
            addVisiteur.Show();
=======
        private void btnPracAdd_Click(object sender, EventArgs e)
        {
            FrmAjouterPracticien addPracticien = new FrmAjouterPracticien();
            addPracticien.Show();
        }

        private void btnPracModif_Click(object sender, EventArgs e)
        {
            FrmModifierPracticien modPracticien = new FrmModifierPracticien();
            modPracticien.Show();
        }

        private void btnPracDelete_Click(object sender, EventArgs e)
        {
            FrmSupprimerPracticien suppPracticien = new FrmSupprimerPracticien();
            suppPracticien.Show();
>>>>>>> devPIOT
        }
    }
}
