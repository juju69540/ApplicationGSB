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
            this.cbxMedSearch = new System.Windows.Forms.ComboBox();
            this.txbMedDos = new System.Windows.Forms.TextBox();
            this.lblMedEffet = new System.Windows.Forms.Label();
            this.cbxMedFamille = new System.Windows.Forms.ComboBox();
            this.lblMedSearch = new System.Windows.Forms.Label();
            this.txbMedSearch = new System.Windows.Forms.TextBox();
            this.txbMedPrixEchant = new System.Windows.Forms.TextBox();
            this.txbPrixMedHt = new System.Windows.Forms.TextBox();
            this.txbMedContrIndic = new System.Windows.Forms.TextBox();
            this.txbMedEffet = new System.Windows.Forms.TextBox();
            this.txbMedDescpt = new System.Windows.Forms.TextBox();
            this.txbMedNom = new System.Windows.Forms.TextBox();
            this.lblMedPrixEchant = new System.Windows.Forms.Label();
            this.lblMedPrix = new System.Windows.Forms.Label();
            this.lblMedContrIndic = new System.Windows.Forms.Label();
            this.lblMedDos = new System.Windows.Forms.Label();
            this.lblMedDesc = new System.Windows.Forms.Label();
            this.lblMedFamille = new System.Windows.Forms.Label();
            this.lblMedNom = new System.Windows.Forms.Label();
            this.btnMedCancel = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btnMedDel = new System.Windows.Forms.Button();
            this.btnMedUpdt = new System.Windows.Forms.Button();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.tabVisit = new System.Windows.Forms.TabPage();
            this.cbxVisitZoneGeo = new System.Windows.Forms.ComboBox();
            this.lblVisitZoneGeo = new System.Windows.Forms.Label();
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
            this.btnPracAjouter = new System.Windows.Forms.Button();
            this.btnPracAnnuler = new System.Windows.Forms.Button();
            this.btnPracSupp = new System.Windows.Forms.Button();
            this.btnPracModifier = new System.Windows.Forms.Button();
            this.lblPracRechercher = new System.Windows.Forms.Label();
            this.txbPracRechercherPracticien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbPracCoefConfiance = new System.Windows.Forms.TextBox();
            this.txbPracCoefNoto = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblParcCoefConfiance = new System.Windows.Forms.Label();
            this.lblParcCoefNoto = new System.Windows.Forms.Label();
            this.lblParcContact = new System.Windows.Forms.Label();
            this.lblParcTelephone = new System.Windows.Forms.Label();
            this.lblParcAdresse = new System.Windows.Forms.Label();
            this.lblParcSocial = new System.Windows.Forms.Label();
            this.lblParcNom = new System.Windows.Forms.Label();
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
            this.tabMed.Controls.Add(this.cbxMedSearch);
            this.tabMed.Controls.Add(this.txbMedDos);
            this.tabMed.Controls.Add(this.lblMedEffet);
            this.tabMed.Controls.Add(this.cbxMedFamille);
            this.tabMed.Controls.Add(this.lblMedSearch);
            this.tabMed.Controls.Add(this.txbMedSearch);
            this.tabMed.Controls.Add(this.txbMedPrixEchant);
            this.tabMed.Controls.Add(this.txbPrixMedHt);
            this.tabMed.Controls.Add(this.txbMedContrIndic);
            this.tabMed.Controls.Add(this.txbMedEffet);
            this.tabMed.Controls.Add(this.txbMedDescpt);
            this.tabMed.Controls.Add(this.txbMedNom);
            this.tabMed.Controls.Add(this.lblMedPrixEchant);
            this.tabMed.Controls.Add(this.lblMedPrix);
            this.tabMed.Controls.Add(this.lblMedContrIndic);
            this.tabMed.Controls.Add(this.lblMedDos);
            this.tabMed.Controls.Add(this.lblMedDesc);
            this.tabMed.Controls.Add(this.lblMedFamille);
            this.tabMed.Controls.Add(this.lblMedNom);
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
            // cbxMedSearch
            // 
            this.cbxMedSearch.FormattingEnabled = true;
            this.cbxMedSearch.Items.AddRange(new object[] {
            "Par nom",
            "Par famille"});
            this.cbxMedSearch.Location = new System.Drawing.Point(609, 122);
            this.cbxMedSearch.Name = "cbxMedSearch";
            this.cbxMedSearch.Size = new System.Drawing.Size(95, 21);
            this.cbxMedSearch.TabIndex = 55;
            // 
            // txbMedDos
            // 
            this.txbMedDos.Location = new System.Drawing.Point(319, 22);
            this.txbMedDos.Name = "txbMedDos";
            this.txbMedDos.Size = new System.Drawing.Size(100, 20);
            this.txbMedDos.TabIndex = 54;
            // 
            // lblMedEffet
            // 
            this.lblMedEffet.AutoSize = true;
            this.lblMedEffet.Location = new System.Drawing.Point(216, 50);
            this.lblMedEffet.Name = "lblMedEffet";
            this.lblMedEffet.Size = new System.Drawing.Size(97, 13);
            this.lblMedEffet.TabIndex = 53;
            this.lblMedEffet.Text = "Effet thérapeutique";
            // 
            // cbxMedFamille
            // 
            this.cbxMedFamille.FormattingEnabled = true;
            this.cbxMedFamille.Location = new System.Drawing.Point(105, 47);
            this.cbxMedFamille.Name = "cbxMedFamille";
            this.cbxMedFamille.Size = new System.Drawing.Size(100, 21);
            this.cbxMedFamille.TabIndex = 52;
            // 
            // lblMedSearch
            // 
            this.lblMedSearch.AutoSize = true;
            this.lblMedSearch.Location = new System.Drawing.Point(378, 125);
            this.lblMedSearch.Name = "lblMedSearch";
            this.lblMedSearch.Size = new System.Drawing.Size(119, 13);
            this.lblMedSearch.TabIndex = 51;
            this.lblMedSearch.Text = "Rechercher un produit :";
            // 
            // txbMedSearch
            // 
            this.txbMedSearch.Location = new System.Drawing.Point(503, 122);
            this.txbMedSearch.Name = "txbMedSearch";
            this.txbMedSearch.Size = new System.Drawing.Size(100, 20);
            this.txbMedSearch.TabIndex = 50;
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
            // lblMedPrixEchant
            // 
            this.lblMedPrixEchant.AutoSize = true;
            this.lblMedPrixEchant.Location = new System.Drawing.Point(478, 50);
            this.lblMedPrixEchant.Name = "lblMedPrixEchant";
            this.lblMedPrixEchant.Size = new System.Drawing.Size(78, 13);
            this.lblMedPrixEchant.TabIndex = 41;
            this.lblMedPrixEchant.Text = "Prix échantillon";
            // 
            // lblMedPrix
            // 
            this.lblMedPrix.AutoSize = true;
            this.lblMedPrix.Location = new System.Drawing.Point(514, 25);
            this.lblMedPrix.Name = "lblMedPrix";
            this.lblMedPrix.Size = new System.Drawing.Size(42, 13);
            this.lblMedPrix.TabIndex = 40;
            this.lblMedPrix.Text = "Prix HT";
            // 
            // lblMedContrIndic
            // 
            this.lblMedContrIndic.AutoSize = true;
            this.lblMedContrIndic.Location = new System.Drawing.Point(227, 77);
            this.lblMedContrIndic.Name = "lblMedContrIndic";
            this.lblMedContrIndic.Size = new System.Drawing.Size(86, 13);
            this.lblMedContrIndic.TabIndex = 39;
            this.lblMedContrIndic.Text = "Contre-indication";
            // 
            // lblMedDos
            // 
            this.lblMedDos.AutoSize = true;
            this.lblMedDos.Location = new System.Drawing.Point(269, 25);
            this.lblMedDos.Name = "lblMedDos";
            this.lblMedDos.Size = new System.Drawing.Size(44, 13);
            this.lblMedDos.TabIndex = 38;
            this.lblMedDos.Text = "Dosage";
            // 
            // lblMedDesc
            // 
            this.lblMedDesc.AutoSize = true;
            this.lblMedDesc.Location = new System.Drawing.Point(39, 77);
            this.lblMedDesc.Name = "lblMedDesc";
            this.lblMedDesc.Size = new System.Drawing.Size(60, 13);
            this.lblMedDesc.TabIndex = 36;
            this.lblMedDesc.Text = "Description";
            // 
            // lblMedFamille
            // 
            this.lblMedFamille.AutoSize = true;
            this.lblMedFamille.Location = new System.Drawing.Point(60, 54);
            this.lblMedFamille.Name = "lblMedFamille";
            this.lblMedFamille.Size = new System.Drawing.Size(39, 13);
            this.lblMedFamille.TabIndex = 35;
            this.lblMedFamille.Text = "Famille";
            // 
            // lblMedNom
            // 
            this.lblMedNom.AutoSize = true;
            this.lblMedNom.Location = new System.Drawing.Point(60, 25);
            this.lblMedNom.Name = "lblMedNom";
            this.lblMedNom.Size = new System.Drawing.Size(29, 13);
            this.lblMedNom.TabIndex = 34;
            this.lblMedNom.Text = "Nom";
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
            this.tabVisit.Controls.Add(this.cbxVisitZoneGeo);
            this.tabVisit.Controls.Add(this.lblVisitZoneGeo);
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
            // cbxVisitZoneGeo
            // 
            this.cbxVisitZoneGeo.FormattingEnabled = true;
            this.cbxVisitZoneGeo.Location = new System.Drawing.Point(569, 90);
            this.cbxVisitZoneGeo.Name = "cbxVisitZoneGeo";
            this.cbxVisitZoneGeo.Size = new System.Drawing.Size(100, 21);
            this.cbxVisitZoneGeo.TabIndex = 61;
            this.cbxVisitZoneGeo.Click += new System.EventHandler(this.cbxVisitZoneGeo_Click);
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
            this.tabPract.Controls.Add(this.btnPracAjouter);
            this.tabPract.Controls.Add(this.btnPracAnnuler);
            this.tabPract.Controls.Add(this.btnPracSupp);
            this.tabPract.Controls.Add(this.btnPracModifier);
            this.tabPract.Controls.Add(this.lblPracRechercher);
            this.tabPract.Controls.Add(this.txbPracRechercherPracticien);
            this.tabPract.Controls.Add(this.dataGridView1);
            this.tabPract.Controls.Add(this.textBox2);
            this.tabPract.Controls.Add(this.textBox3);
            this.tabPract.Controls.Add(this.txbPracCoefConfiance);
            this.tabPract.Controls.Add(this.txbPracCoefNoto);
            this.tabPract.Controls.Add(this.textBox7);
            this.tabPract.Controls.Add(this.textBox8);
            this.tabPract.Controls.Add(this.textBox9);
            this.tabPract.Controls.Add(this.lblParcCoefConfiance);
            this.tabPract.Controls.Add(this.lblParcCoefNoto);
            this.tabPract.Controls.Add(this.lblParcContact);
            this.tabPract.Controls.Add(this.lblParcTelephone);
            this.tabPract.Controls.Add(this.lblParcAdresse);
            this.tabPract.Controls.Add(this.lblParcSocial);
            this.tabPract.Controls.Add(this.lblParcNom);
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(958, 372);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            this.tabPract.Click += new System.EventHandler(this.tabPract_Click);
            // 
            // btnPracAjouter
            // 
            this.btnPracAjouter.Location = new System.Drawing.Point(703, 25);
            this.btnPracAjouter.Name = "btnPracAjouter";
            this.btnPracAjouter.Size = new System.Drawing.Size(112, 42);
            this.btnPracAjouter.TabIndex = 84;
            this.btnPracAjouter.Text = "Ajouter";
            this.btnPracAjouter.UseVisualStyleBackColor = true;
            // 
            // btnPracAnnuler
            // 
            this.btnPracAnnuler.Location = new System.Drawing.Point(831, 73);
            this.btnPracAnnuler.Name = "btnPracAnnuler";
            this.btnPracAnnuler.Size = new System.Drawing.Size(112, 44);
            this.btnPracAnnuler.TabIndex = 83;
            this.btnPracAnnuler.Text = "Annuler";
            this.btnPracAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnPracSupp
            // 
            this.btnPracSupp.Location = new System.Drawing.Point(831, 25);
            this.btnPracSupp.Name = "btnPracSupp";
            this.btnPracSupp.Size = new System.Drawing.Size(112, 42);
            this.btnPracSupp.TabIndex = 82;
            this.btnPracSupp.Text = "Supprimer";
            this.btnPracSupp.UseVisualStyleBackColor = true;
            // 
            // btnPracModifier
            // 
            this.btnPracModifier.Location = new System.Drawing.Point(703, 73);
            this.btnPracModifier.Name = "btnPracModifier";
            this.btnPracModifier.Size = new System.Drawing.Size(112, 44);
            this.btnPracModifier.TabIndex = 81;
            this.btnPracModifier.Text = "Modifier";
            this.btnPracModifier.UseVisualStyleBackColor = true;
            // 
            // lblPracRechercher
            // 
            this.lblPracRechercher.AutoSize = true;
            this.lblPracRechercher.Location = new System.Drawing.Point(324, 104);
            this.lblPracRechercher.Name = "lblPracRechercher";
            this.lblPracRechercher.Size = new System.Drawing.Size(133, 13);
            this.lblPracRechercher.TabIndex = 80;
            this.lblPracRechercher.Text = "Rechercher un practicien :";
            // 
            // txbPracRechercherPracticien
            // 
            this.txbPracRechercherPracticien.Location = new System.Drawing.Point(461, 101);
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
            // lblParcCoefConfiance
            // 
            this.lblParcCoefConfiance.AutoSize = true;
            this.lblParcCoefConfiance.Location = new System.Drawing.Point(461, 61);
            this.lblParcCoefConfiance.Name = "lblParcCoefConfiance";
            this.lblParcCoefConfiance.Size = new System.Drawing.Size(108, 13);
            this.lblParcCoefConfiance.TabIndex = 68;
            this.lblParcCoefConfiance.Text = "Coefficiant Confiance";
            // 
            // lblParcCoefNoto
            // 
            this.lblParcCoefNoto.AutoSize = true;
            this.lblParcCoefNoto.Location = new System.Drawing.Point(466, 32);
            this.lblParcCoefNoto.Name = "lblParcCoefNoto";
            this.lblParcCoefNoto.Size = new System.Drawing.Size(103, 13);
            this.lblParcCoefNoto.TabIndex = 67;
            this.lblParcCoefNoto.Text = "Coefficiant Notoriété";
            // 
            // lblParcContact
            // 
            this.lblParcContact.AutoSize = true;
            this.lblParcContact.Location = new System.Drawing.Point(258, 61);
            this.lblParcContact.Name = "lblParcContact";
            this.lblParcContact.Size = new System.Drawing.Size(44, 13);
            this.lblParcContact.TabIndex = 65;
            this.lblParcContact.Text = "Contact";
            // 
            // lblParcTelephone
            // 
            this.lblParcTelephone.AutoSize = true;
            this.lblParcTelephone.Location = new System.Drawing.Point(244, 32);
            this.lblParcTelephone.Name = "lblParcTelephone";
            this.lblParcTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblParcTelephone.TabIndex = 64;
            this.lblParcTelephone.Text = "Téléphone";
            // 
            // lblParcAdresse
            // 
            this.lblParcAdresse.AutoSize = true;
            this.lblParcAdresse.Location = new System.Drawing.Point(45, 84);
            this.lblParcAdresse.Name = "lblParcAdresse";
            this.lblParcAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblParcAdresse.TabIndex = 63;
            this.lblParcAdresse.Text = "Adresse";
            // 
            // lblParcSocial
            // 
            this.lblParcSocial.AutoSize = true;
            this.lblParcSocial.Location = new System.Drawing.Point(54, 58);
            this.lblParcSocial.Name = "lblParcSocial";
            this.lblParcSocial.Size = new System.Drawing.Size(36, 13);
            this.lblParcSocial.TabIndex = 62;
            this.lblParcSocial.Text = "Social";
            // 
            // lblParcNom
            // 
            this.lblParcNom.AutoSize = true;
            this.lblParcNom.Location = new System.Drawing.Point(61, 29);
            this.lblParcNom.Name = "lblParcNom";
            this.lblParcNom.Size = new System.Drawing.Size(29, 13);
            this.lblParcNom.TabIndex = 61;
            this.lblParcNom.Text = "Nom";
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
        private System.Windows.Forms.ComboBox cbxMedSearch;
        private System.Windows.Forms.TextBox txbMedDos;
        private System.Windows.Forms.Label lblMedEffet;
        private System.Windows.Forms.ComboBox cbxMedFamille;
        private System.Windows.Forms.Label lblMedSearch;
        private System.Windows.Forms.TextBox txbMedSearch;
        private System.Windows.Forms.TextBox txbMedPrixEchant;
        private System.Windows.Forms.TextBox txbPrixMedHt;
        private System.Windows.Forms.TextBox txbMedContrIndic;
        private System.Windows.Forms.TextBox txbMedEffet;
        private System.Windows.Forms.TextBox txbMedDescpt;
        private System.Windows.Forms.TextBox txbMedNom;
        private System.Windows.Forms.Label lblMedPrixEchant;
        private System.Windows.Forms.Label lblMedPrix;
        private System.Windows.Forms.Label lblMedContrIndic;
        private System.Windows.Forms.Label lblMedDos;
        private System.Windows.Forms.Label lblMedDesc;
        private System.Windows.Forms.Label lblMedFamille;
        private System.Windows.Forms.Label lblMedNom;
        private System.Windows.Forms.Button btnMedCancel;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.Button btnMedDel;
        private System.Windows.Forms.Button btnMedUpdt;
        private System.Windows.Forms.Button btnMedAdd;
        private System.Windows.Forms.Label lblVisitZoneGeo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txbPracCoefConfiance;
        private System.Windows.Forms.TextBox txbPracCoefNoto;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblParcCoefConfiance;
        private System.Windows.Forms.Label lblParcCoefNoto;
        private System.Windows.Forms.Label lblParcContact;
        private System.Windows.Forms.Label lblParcTelephone;
        private System.Windows.Forms.Label lblParcAdresse;
        private System.Windows.Forms.Label lblParcSocial;
        private System.Windows.Forms.Label lblParcNom;
        private System.Windows.Forms.Button btnPracAjouter;
        private System.Windows.Forms.Button btnPracAnnuler;
        private System.Windows.Forms.Button btnPracSupp;
        private System.Windows.Forms.Button btnPracModifier;
        private System.Windows.Forms.Label lblPracRechercher;
        private System.Windows.Forms.TextBox txbPracRechercherPracticien;
        private System.Windows.Forms.ComboBox cbxVisitZoneGeo;
    }
}