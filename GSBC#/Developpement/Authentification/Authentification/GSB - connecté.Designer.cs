namespace Authentification
{
    partial class GSB___connecté
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcOnglets = new System.Windows.Forms.TabControl();
            this.tabMed = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txbMedDos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMedFamille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbMedPrixEchant = new System.Windows.Forms.TextBox();
            this.txbPrixMedHt = new System.Windows.Forms.TextBox();
            this.txbMedContrIndic = new System.Windows.Forms.TextBox();
            this.txbMedEffet = new System.Windows.Forms.TextBox();
            this.txbMedDescpt = new System.Windows.Forms.TextBox();
            this.txbMedNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMedCancel = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btnMedDel = new System.Windows.Forms.Button();
            this.btnMedUpdt = new System.Windows.Forms.Button();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.tabVisit = new System.Windows.Forms.TabPage();
            this.lblVisitZoneGeo = new System.Windows.Forms.Label();
            this.txbVisitZoneGeo = new System.Windows.Forms.TextBox();
            this.lblVisitRechercherV = new System.Windows.Forms.Label();
            this.txbVisitRechercher = new System.Windows.Forms.TextBox();
            this.txbVisitDateEmbauche = new System.Windows.Forms.TextBox();
            this.txbVisitVille = new System.Windows.Forms.TextBox();
            this.txbVisitCP = new System.Windows.Forms.TextBox();
            this.txbVisitAdresse = new System.Windows.Forms.TextBox();
            this.txbVisitPassword = new System.Windows.Forms.TextBox();
            this.txbVisitLogin = new System.Windows.Forms.TextBox();
            this.txbVisitPrenom = new System.Windows.Forms.TextBox();
            this.txbVisitNom = new System.Windows.Forms.TextBox();
            this.lblVisitDateEmbauche = new System.Windows.Forms.Label();
            this.lblVisitVille = new System.Windows.Forms.Label();
            this.lblVisitCP = new System.Windows.Forms.Label();
            this.lblVisitAdresse = new System.Windows.Forms.Label();
            this.lblVisitMdp = new System.Windows.Forms.Label();
            this.lblVisitLogin = new System.Windows.Forms.Label();
            this.lblVisitPrenom = new System.Windows.Forms.Label();
            this.lblVisitNom = new System.Windows.Forms.Label();
            this.btnVisitAnnuler = new System.Windows.Forms.Button();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.btnVisitDelete = new System.Windows.Forms.Button();
            this.btnVisitModif = new System.Windows.Forms.Button();
            this.btnVisitAdd = new System.Windows.Forms.Button();
            this.tabPract = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPracRechercher = new System.Windows.Forms.Label();
            this.txbPracRechercherPracticien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txbPracCoefConfiance = new System.Windows.Forms.TextBox();
            this.txbPracCoefNoto = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbcOnglets.SuspendLayout();
            this.tabMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.tabVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            this.tabPract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcOnglets
            // 
            this.tbcOnglets.Controls.Add(this.tabMed);
            this.tbcOnglets.Controls.Add(this.tabVisit);
            this.tbcOnglets.Controls.Add(this.tabPract);
            this.tbcOnglets.Location = new System.Drawing.Point(12, 12);
            this.tbcOnglets.Name = "tbcOnglets";
            this.tbcOnglets.SelectedIndex = 0;
            this.tbcOnglets.Size = new System.Drawing.Size(966, 398);
            this.tbcOnglets.TabIndex = 0;
            this.tbcOnglets.SelectedIndexChanged += new System.EventHandler(this.tbcOnglets_SelectedIndexChanged_1);
            // 
            // tabMed
            // 
            this.tabMed.Controls.Add(this.comboBox2);
            this.tabMed.Controls.Add(this.txbMedDos);
            this.tabMed.Controls.Add(this.label6);
            this.tabMed.Controls.Add(this.cbxMedFamille);
            this.tabMed.Controls.Add(this.label1);
            this.tabMed.Controls.Add(this.textBox1);
            this.tabMed.Controls.Add(this.txbMedPrixEchant);
            this.tabMed.Controls.Add(this.txbPrixMedHt);
            this.tabMed.Controls.Add(this.txbMedContrIndic);
            this.tabMed.Controls.Add(this.txbMedEffet);
            this.tabMed.Controls.Add(this.txbMedDescpt);
            this.tabMed.Controls.Add(this.txbMedNom);
            this.tabMed.Controls.Add(this.label2);
            this.tabMed.Controls.Add(this.label3);
            this.tabMed.Controls.Add(this.label4);
            this.tabMed.Controls.Add(this.label5);
            this.tabMed.Controls.Add(this.label7);
            this.tabMed.Controls.Add(this.label8);
            this.tabMed.Controls.Add(this.label9);
            this.tabMed.Controls.Add(this.btnMedCancel);
            this.tabMed.Controls.Add(this.dgvMed);
            this.tabMed.Controls.Add(this.btnMedDel);
            this.tabMed.Controls.Add(this.btnMedUpdt);
            this.tabMed.Controls.Add(this.btnMedAdd);
            this.tabMed.Location = new System.Drawing.Point(4, 22);
            this.tabMed.Name = "tabMed";
            this.tabMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabMed.Size = new System.Drawing.Size(958, 372);
            this.tabMed.TabIndex = 0;
            this.tabMed.Text = "Produits";
            this.tabMed.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Par nom",
            "Par famille"});
            this.comboBox2.Location = new System.Drawing.Point(609, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // txbMedDos
            // 
            this.txbMedDos.Location = new System.Drawing.Point(319, 22);
            this.txbMedDos.Name = "txbMedDos";
            this.txbMedDos.Size = new System.Drawing.Size(100, 20);
            this.txbMedDos.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Effet thérapeutique";
            // 
            // cbxMedFamille
            // 
            this.cbxMedFamille.FormattingEnabled = true;
            this.cbxMedFamille.Location = new System.Drawing.Point(105, 47);
            this.cbxMedFamille.Name = "cbxMedFamille";
            this.cbxMedFamille.Size = new System.Drawing.Size(100, 21);
            this.cbxMedFamille.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Rechercher un produit :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 50;
            // 
            // txbMedPrixEchant
            // 
            this.txbMedPrixEchant.Location = new System.Drawing.Point(562, 47);
            this.txbMedPrixEchant.Name = "txbMedPrixEchant";
            this.txbMedPrixEchant.Size = new System.Drawing.Size(100, 20);
            this.txbMedPrixEchant.TabIndex = 49;
            // 
            // txbPrixMedHt
            // 
            this.txbPrixMedHt.Location = new System.Drawing.Point(562, 22);
            this.txbPrixMedHt.Name = "txbPrixMedHt";
            this.txbPrixMedHt.Size = new System.Drawing.Size(100, 20);
            this.txbPrixMedHt.TabIndex = 48;
            // 
            // txbMedContrIndic
            // 
            this.txbMedContrIndic.Location = new System.Drawing.Point(319, 74);
            this.txbMedContrIndic.Name = "txbMedContrIndic";
            this.txbMedContrIndic.Size = new System.Drawing.Size(100, 20);
            this.txbMedContrIndic.TabIndex = 47;
            // 
            // txbMedEffet
            // 
            this.txbMedEffet.Location = new System.Drawing.Point(319, 47);
            this.txbMedEffet.Name = "txbMedEffet";
            this.txbMedEffet.Size = new System.Drawing.Size(100, 20);
            this.txbMedEffet.TabIndex = 46;
            // 
            // txbMedDescpt
            // 
            this.txbMedDescpt.Location = new System.Drawing.Point(105, 74);
            this.txbMedDescpt.Name = "txbMedDescpt";
            this.txbMedDescpt.Size = new System.Drawing.Size(100, 20);
            this.txbMedDescpt.TabIndex = 44;
            // 
            // txbMedNom
            // 
            this.txbMedNom.Location = new System.Drawing.Point(105, 22);
            this.txbMedNom.Name = "txbMedNom";
            this.txbMedNom.Size = new System.Drawing.Size(100, 20);
            this.txbMedNom.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Prix échantillon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prix HT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Contre-indication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dosage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Famille";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nom";
            // 
            // btnMedCancel
            // 
            this.btnMedCancel.Location = new System.Drawing.Point(834, 64);
            this.btnMedCancel.Name = "btnMedCancel";
            this.btnMedCancel.Size = new System.Drawing.Size(112, 44);
            this.btnMedCancel.TabIndex = 33;
            this.btnMedCancel.Text = "Annuler";
            this.btnMedCancel.UseVisualStyleBackColor = true;
            this.btnMedCancel.Click += new System.EventHandler(this.btnMedCancel_Click);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(6, 170);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(946, 186);
            this.dgvMed.TabIndex = 32;
            this.dgvMed.Click += new System.EventHandler(this.dgvMed_Click);
            // 
            // btnMedDel
            // 
            this.btnMedDel.Location = new System.Drawing.Point(834, 16);
            this.btnMedDel.Name = "btnMedDel";
            this.btnMedDel.Size = new System.Drawing.Size(112, 42);
            this.btnMedDel.TabIndex = 31;
            this.btnMedDel.Text = "Supprimer";
            this.btnMedDel.UseVisualStyleBackColor = true;
            // 
            // btnMedUpdt
            // 
            this.btnMedUpdt.Location = new System.Drawing.Point(706, 64);
            this.btnMedUpdt.Name = "btnMedUpdt";
            this.btnMedUpdt.Size = new System.Drawing.Size(112, 44);
            this.btnMedUpdt.TabIndex = 30;
            this.btnMedUpdt.Text = "Modifier";
            this.btnMedUpdt.UseVisualStyleBackColor = true;
            // 
            // btnMedAdd
            // 
            this.btnMedAdd.Location = new System.Drawing.Point(706, 16);
            this.btnMedAdd.Name = "btnMedAdd";
            this.btnMedAdd.Size = new System.Drawing.Size(112, 42);
            this.btnMedAdd.TabIndex = 29;
            this.btnMedAdd.Text = "Ajouter";
            this.btnMedAdd.UseVisualStyleBackColor = true;
            // 
            // tabVisit
            // 
            this.tabVisit.Controls.Add(this.lblVisitZoneGeo);
            this.tabVisit.Controls.Add(this.txbVisitZoneGeo);
            this.tabVisit.Controls.Add(this.lblVisitRechercherV);
            this.tabVisit.Controls.Add(this.txbVisitRechercher);
            this.tabVisit.Controls.Add(this.txbVisitDateEmbauche);
            this.tabVisit.Controls.Add(this.txbVisitVille);
            this.tabVisit.Controls.Add(this.txbVisitCP);
            this.tabVisit.Controls.Add(this.txbVisitAdresse);
            this.tabVisit.Controls.Add(this.txbVisitPassword);
            this.tabVisit.Controls.Add(this.txbVisitLogin);
            this.tabVisit.Controls.Add(this.txbVisitPrenom);
            this.tabVisit.Controls.Add(this.txbVisitNom);
            this.tabVisit.Controls.Add(this.lblVisitDateEmbauche);
            this.tabVisit.Controls.Add(this.lblVisitVille);
            this.tabVisit.Controls.Add(this.lblVisitCP);
            this.tabVisit.Controls.Add(this.lblVisitAdresse);
            this.tabVisit.Controls.Add(this.lblVisitMdp);
            this.tabVisit.Controls.Add(this.lblVisitLogin);
            this.tabVisit.Controls.Add(this.lblVisitPrenom);
            this.tabVisit.Controls.Add(this.lblVisitNom);
            this.tabVisit.Controls.Add(this.btnVisitAnnuler);
            this.tabVisit.Controls.Add(this.dgvVisiteur);
            this.tabVisit.Controls.Add(this.btnVisitDelete);
            this.tabVisit.Controls.Add(this.btnVisitModif);
            this.tabVisit.Controls.Add(this.btnVisitAdd);
            this.tabVisit.Location = new System.Drawing.Point(4, 22);
            this.tabVisit.Name = "tabVisit";
            this.tabVisit.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisit.Size = new System.Drawing.Size(958, 372);
            this.tabVisit.TabIndex = 1;
            this.tabVisit.Text = "Visiteurs";
            this.tabVisit.UseVisualStyleBackColor = true;
            this.tabVisit.Click += new System.EventHandler(this.tabVisit_Click);
            // 
            // lblVisitZoneGeo
            // 
            this.lblVisitZoneGeo.AutoSize = true;
            this.lblVisitZoneGeo.Location = new System.Drawing.Point(441, 93);
            this.lblVisitZoneGeo.Name = "lblVisitZoneGeo";
            this.lblVisitZoneGeo.Size = new System.Drawing.Size(100, 13);
            this.lblVisitZoneGeo.TabIndex = 60;
            this.lblVisitZoneGeo.Text = "Zone géographique";
            // 
            // txbVisitZoneGeo
            // 
            this.txbVisitZoneGeo.Location = new System.Drawing.Point(569, 90);
            this.txbVisitZoneGeo.Name = "txbVisitZoneGeo";
            this.txbVisitZoneGeo.Size = new System.Drawing.Size(100, 20);
            this.txbVisitZoneGeo.TabIndex = 59;
            // 
            // lblVisitRechercherV
            // 
            this.lblVisitRechercherV.AutoSize = true;
            this.lblVisitRechercherV.Location = new System.Drawing.Point(363, 133);
            this.lblVisitRechercherV.Name = "lblVisitRechercherV";
            this.lblVisitRechercherV.Size = new System.Drawing.Size(120, 13);
            this.lblVisitRechercherV.TabIndex = 28;
            this.lblVisitRechercherV.Text = "Rechercher un visiteur :";
            // 
            // txbVisitRechercher
            // 
            this.txbVisitRechercher.Location = new System.Drawing.Point(500, 130);
            this.txbVisitRechercher.Name = "txbVisitRechercher";
            this.txbVisitRechercher.Size = new System.Drawing.Size(100, 20);
            this.txbVisitRechercher.TabIndex = 27;
            // 
            // txbVisitDateEmbauche
            // 
            this.txbVisitDateEmbauche.Location = new System.Drawing.Point(569, 59);
            this.txbVisitDateEmbauche.Name = "txbVisitDateEmbauche";
            this.txbVisitDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txbVisitDateEmbauche.TabIndex = 26;
            // 
            // txbVisitVille
            // 
            this.txbVisitVille.Location = new System.Drawing.Point(569, 30);
            this.txbVisitVille.Name = "txbVisitVille";
            this.txbVisitVille.Size = new System.Drawing.Size(100, 20);
            this.txbVisitVille.TabIndex = 25;
            // 
            // txbVisitCP
            // 
            this.txbVisitCP.Location = new System.Drawing.Point(316, 87);
            this.txbVisitCP.Name = "txbVisitCP";
            this.txbVisitCP.Size = new System.Drawing.Size(100, 20);
            this.txbVisitCP.TabIndex = 24;
            // 
            // txbVisitAdresse
            // 
            this.txbVisitAdresse.Location = new System.Drawing.Point(316, 59);
            this.txbVisitAdresse.Name = "txbVisitAdresse";
            this.txbVisitAdresse.Size = new System.Drawing.Size(100, 20);
            this.txbVisitAdresse.TabIndex = 23;
            // 
            // txbVisitPassword
            // 
            this.txbVisitPassword.Location = new System.Drawing.Point(316, 30);
            this.txbVisitPassword.Name = "txbVisitPassword";
            this.txbVisitPassword.Size = new System.Drawing.Size(100, 20);
            this.txbVisitPassword.TabIndex = 22;
            // 
            // txbVisitLogin
            // 
            this.txbVisitLogin.Location = new System.Drawing.Point(102, 82);
            this.txbVisitLogin.Name = "txbVisitLogin";
            this.txbVisitLogin.Size = new System.Drawing.Size(100, 20);
            this.txbVisitLogin.TabIndex = 21;
            // 
            // txbVisitPrenom
            // 
            this.txbVisitPrenom.Location = new System.Drawing.Point(102, 56);
            this.txbVisitPrenom.Name = "txbVisitPrenom";
            this.txbVisitPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbVisitPrenom.TabIndex = 20;
            // 
            // txbVisitNom
            // 
            this.txbVisitNom.Location = new System.Drawing.Point(102, 30);
            this.txbVisitNom.Name = "txbVisitNom";
            this.txbVisitNom.Size = new System.Drawing.Size(100, 20);
            this.txbVisitNom.TabIndex = 19;
            // 
            // lblVisitDateEmbauche
            // 
            this.lblVisitDateEmbauche.AutoSize = true;
            this.lblVisitDateEmbauche.Location = new System.Drawing.Point(450, 62);
            this.lblVisitDateEmbauche.Name = "lblVisitDateEmbauche";
            this.lblVisitDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.lblVisitDateEmbauche.TabIndex = 18;
            this.lblVisitDateEmbauche.Text = "Date d\'embauche";
            // 
            // lblVisitVille
            // 
            this.lblVisitVille.AutoSize = true;
            this.lblVisitVille.Location = new System.Drawing.Point(515, 33);
            this.lblVisitVille.Name = "lblVisitVille";
            this.lblVisitVille.Size = new System.Drawing.Size(26, 13);
            this.lblVisitVille.TabIndex = 17;
            this.lblVisitVille.Text = "Ville";
            // 
            // lblVisitCP
            // 
            this.lblVisitCP.AutoSize = true;
            this.lblVisitCP.Location = new System.Drawing.Point(228, 90);
            this.lblVisitCP.Name = "lblVisitCP";
            this.lblVisitCP.Size = new System.Drawing.Size(64, 13);
            this.lblVisitCP.TabIndex = 16;
            this.lblVisitCP.Text = "Code Postal";
            // 
            // lblVisitAdresse
            // 
            this.lblVisitAdresse.AutoSize = true;
            this.lblVisitAdresse.Location = new System.Drawing.Point(247, 59);
            this.lblVisitAdresse.Name = "lblVisitAdresse";
            this.lblVisitAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblVisitAdresse.TabIndex = 15;
            this.lblVisitAdresse.Text = "Adresse";
            // 
            // lblVisitMdp
            // 
            this.lblVisitMdp.AutoSize = true;
            this.lblVisitMdp.Location = new System.Drawing.Point(239, 30);
            this.lblVisitMdp.Name = "lblVisitMdp";
            this.lblVisitMdp.Size = new System.Drawing.Size(53, 13);
            this.lblVisitMdp.TabIndex = 14;
            this.lblVisitMdp.Text = "Password";
            // 
            // lblVisitLogin
            // 
            this.lblVisitLogin.AutoSize = true;
            this.lblVisitLogin.Location = new System.Drawing.Point(34, 90);
            this.lblVisitLogin.Name = "lblVisitLogin";
            this.lblVisitLogin.Size = new System.Drawing.Size(33, 13);
            this.lblVisitLogin.TabIndex = 13;
            this.lblVisitLogin.Text = "Login";
            // 
            // lblVisitPrenom
            // 
            this.lblVisitPrenom.AutoSize = true;
            this.lblVisitPrenom.Location = new System.Drawing.Point(24, 59);
            this.lblVisitPrenom.Name = "lblVisitPrenom";
            this.lblVisitPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblVisitPrenom.TabIndex = 12;
            this.lblVisitPrenom.Text = "Prénom";
            // 
            // lblVisitNom
            // 
            this.lblVisitNom.AutoSize = true;
            this.lblVisitNom.Location = new System.Drawing.Point(38, 30);
            this.lblVisitNom.Name = "lblVisitNom";
            this.lblVisitNom.Size = new System.Drawing.Size(29, 13);
            this.lblVisitNom.TabIndex = 11;
            this.lblVisitNom.Text = "Nom";
            // 
            // btnVisitAnnuler
            // 
            this.btnVisitAnnuler.Location = new System.Drawing.Point(831, 72);
            this.btnVisitAnnuler.Name = "btnVisitAnnuler";
            this.btnVisitAnnuler.Size = new System.Drawing.Size(112, 44);
            this.btnVisitAnnuler.TabIndex = 10;
            this.btnVisitAnnuler.Text = "Annuler";
            this.btnVisitAnnuler.UseVisualStyleBackColor = true;
            this.btnVisitAnnuler.Click += new System.EventHandler(this.btnVisitAnnuler_Click);
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(3, 178);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(946, 186);
            this.dgvVisiteur.TabIndex = 8;
            // 
            // btnVisitDelete
            // 
            this.btnVisitDelete.Location = new System.Drawing.Point(831, 24);
            this.btnVisitDelete.Name = "btnVisitDelete";
            this.btnVisitDelete.Size = new System.Drawing.Size(112, 42);
            this.btnVisitDelete.TabIndex = 7;
            this.btnVisitDelete.Text = "Supprimer";
            this.btnVisitDelete.UseVisualStyleBackColor = true;
            this.btnVisitDelete.Click += new System.EventHandler(this.btnVisitDelete_Click);
            // 
            // btnVisitModif
            // 
            this.btnVisitModif.Location = new System.Drawing.Point(703, 72);
            this.btnVisitModif.Name = "btnVisitModif";
            this.btnVisitModif.Size = new System.Drawing.Size(112, 44);
            this.btnVisitModif.TabIndex = 6;
            this.btnVisitModif.Text = "Modifier";
            this.btnVisitModif.UseVisualStyleBackColor = true;
            this.btnVisitModif.Click += new System.EventHandler(this.btnVisitModif_Click);
            // 
            // btnVisitAdd
            // 
            this.btnVisitAdd.Location = new System.Drawing.Point(703, 24);
            this.btnVisitAdd.Name = "btnVisitAdd";
            this.btnVisitAdd.Size = new System.Drawing.Size(112, 42);
            this.btnVisitAdd.TabIndex = 5;
            this.btnVisitAdd.Text = "Ajouter";
            this.btnVisitAdd.UseVisualStyleBackColor = true;
            this.btnVisitAdd.Click += new System.EventHandler(this.btnVisitAdd_Click);
            // 
            // tabPract
            // 
            this.tabPract.Controls.Add(this.button4);
            this.tabPract.Controls.Add(this.button1);
            this.tabPract.Controls.Add(this.button2);
            this.tabPract.Controls.Add(this.button3);
            this.tabPract.Controls.Add(this.lblPracRechercher);
            this.tabPract.Controls.Add(this.txbPracRechercherPracticien);
            this.tabPract.Controls.Add(this.dataGridView1);
            this.tabPract.Controls.Add(this.label10);
            this.tabPract.Controls.Add(this.textBox2);
            this.tabPract.Controls.Add(this.textBox3);
            this.tabPract.Controls.Add(this.textBox4);
            this.tabPract.Controls.Add(this.txbPracCoefConfiance);
            this.tabPract.Controls.Add(this.txbPracCoefNoto);
            this.tabPract.Controls.Add(this.textBox7);
            this.tabPract.Controls.Add(this.textBox8);
            this.tabPract.Controls.Add(this.textBox9);
            this.tabPract.Controls.Add(this.label11);
            this.tabPract.Controls.Add(this.label12);
            this.tabPract.Controls.Add(this.label13);
            this.tabPract.Controls.Add(this.label14);
            this.tabPract.Controls.Add(this.label15);
            this.tabPract.Controls.Add(this.label16);
            this.tabPract.Controls.Add(this.label17);
            this.tabPract.Controls.Add(this.label18);
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(958, 372);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 42);
            this.button4.TabIndex = 84;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 83;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 82;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 44);
            this.button3.TabIndex = 81;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblPracRechercher
            // 
            this.lblPracRechercher.AutoSize = true;
            this.lblPracRechercher.Location = new System.Drawing.Point(307, 141);
            this.lblPracRechercher.Name = "lblPracRechercher";
            this.lblPracRechercher.Size = new System.Drawing.Size(120, 13);
            this.lblPracRechercher.TabIndex = 80;
            this.lblPracRechercher.Text = "Rechercher un visiteur :";
            // 
            // txbPracRechercherPracticien
            // 
            this.txbPracRechercherPracticien.Location = new System.Drawing.Point(444, 138);
            this.txbPracRechercherPracticien.Name = "txbPracRechercherPracticien";
            this.txbPracRechercherPracticien.Size = new System.Drawing.Size(100, 20);
            this.txbPracRechercherPracticien.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 186);
            this.dataGridView1.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Zone géographique";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 76;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(580, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 75;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 74;
            // 
            // txbPracCoefConfiance
            // 
            this.txbPracCoefConfiance.Location = new System.Drawing.Point(327, 58);
            this.txbPracCoefConfiance.Name = "txbPracCoefConfiance";
            this.txbPracCoefConfiance.Size = new System.Drawing.Size(100, 20);
            this.txbPracCoefConfiance.TabIndex = 73;
            // 
            // txbPracCoefNoto
            // 
            this.txbPracCoefNoto.Location = new System.Drawing.Point(327, 29);
            this.txbPracCoefNoto.Name = "txbPracCoefNoto";
            this.txbPracCoefNoto.Size = new System.Drawing.Size(100, 20);
            this.txbPracCoefNoto.TabIndex = 72;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(113, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 71;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(113, 55);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 70;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(113, 29);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Date d\'embauche";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Ville";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Code Postal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(258, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Adresse";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(250, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Login";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Prénom";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Nom";
            // 
            // GSB___connecté
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 420);
            this.Controls.Add(this.tbcOnglets);
            this.Name = "GSB___connecté";
            this.Text = "GSB___connecté";
            this.Load += new System.EventHandler(this.GSB___connecté_Load);
            this.tbcOnglets.ResumeLayout(false);
            this.tabMed.ResumeLayout(false);
            this.tabMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.tabVisit.ResumeLayout(false);
            this.tabVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            this.tabPract.ResumeLayout(false);
            this.tabPract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOnglets;
        private System.Windows.Forms.TabPage tabVisit;
        private System.Windows.Forms.TabPage tabPract;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Button btnVisitDelete;
        private System.Windows.Forms.Button btnVisitModif;
        private System.Windows.Forms.Button btnVisitAdd;
        private System.Windows.Forms.TabPage tabMed;
        private System.Windows.Forms.TextBox txbVisitDateEmbauche;
        private System.Windows.Forms.TextBox txbVisitVille;
        private System.Windows.Forms.TextBox txbVisitCP;
        private System.Windows.Forms.TextBox txbVisitAdresse;
        private System.Windows.Forms.TextBox txbVisitPassword;
        private System.Windows.Forms.TextBox txbVisitLogin;
        private System.Windows.Forms.TextBox txbVisitPrenom;
        private System.Windows.Forms.TextBox txbVisitNom;
        private System.Windows.Forms.Label lblVisitDateEmbauche;
        private System.Windows.Forms.Label lblVisitVille;
        private System.Windows.Forms.Label lblVisitCP;
        private System.Windows.Forms.Label lblVisitAdresse;
        private System.Windows.Forms.Label lblVisitMdp;
        private System.Windows.Forms.Label lblVisitLogin;
        private System.Windows.Forms.Label lblVisitPrenom;
        private System.Windows.Forms.Label lblVisitNom;
        private System.Windows.Forms.Button btnVisitAnnuler;
        private System.Windows.Forms.Label lblVisitRechercherV;
        private System.Windows.Forms.TextBox txbVisitRechercher;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txbMedDos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMedFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbMedPrixEchant;
        private System.Windows.Forms.TextBox txbPrixMedHt;
        private System.Windows.Forms.TextBox txbMedContrIndic;
        private System.Windows.Forms.TextBox txbMedEffet;
        private System.Windows.Forms.TextBox txbMedDescpt;
        private System.Windows.Forms.TextBox txbMedNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMedCancel;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.Button btnMedDel;
        private System.Windows.Forms.Button btnMedUpdt;
        private System.Windows.Forms.Button btnMedAdd;
        private System.Windows.Forms.TextBox txbVisitZoneGeo;
        private System.Windows.Forms.Label lblVisitZoneGeo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txbPracCoefConfiance;
        private System.Windows.Forms.TextBox txbPracCoefNoto;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPracRechercher;
        private System.Windows.Forms.TextBox txbPracRechercherPracticien;
    }
    #region Windows Form Designer generated code
        #endregion
    /*
        private System.Windows.Forms.TextBox txbPracContact;
        private System.Windows.Forms.TextBox txbPracTel;
        private System.Windows.Forms.TextBox txbPracAdresse;
        private System.Windows.Forms.TextBox txbPracSocial;
        private System.Windows.Forms.TextBox txbPracNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPracSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPracAnnuler; */
}