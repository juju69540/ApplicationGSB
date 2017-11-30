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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int answerBDD = DAOAuthentification.logToGSB(txbLogin.Text, txbPassword.Text);
            switch(answerBDD)
            {
                case 0: FrmGSB connected = new FrmGSB(); connected.Show(); break;
                case 1: lblErrorConnect.Text = "Login incorrect ou inexistant";lblErrorConnect.Visible = true; break;
                case 2: lblErrorConnect.Text = "Mot de passe incorrect"; lblErrorConnect.Visible = true; break;
                case 3: lblErrorConnect.Text = "Erreur inconnue au bataillon"; lblErrorConnect.Visible = true; break;
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            lblErrorConnect.Visible = false;
            lblErrorConnect.ForeColor = Color.Red;
        }
    }
}
