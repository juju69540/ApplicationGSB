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
            this.cbxMedType = new System.Windows.Forms.ComboBox();
            this.txbMedSearch = new System.Windows.Forms.TextBox();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btnMedDel = new System.Windows.Forms.Button();
            this.btnMedUpd = new System.Windows.Forms.Button();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.tabVisit = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisitDelete = new System.Windows.Forms.Button();
            this.btnVisitModif = new System.Windows.Forms.Button();
            this.btnVisitAdd = new System.Windows.Forms.Button();
            this.tabPract = new System.Windows.Forms.TabPage();
            this.lblPracRechercher = new System.Windows.Forms.Label();
            this.txbPracRechercherPracticien = new System.Windows.Forms.TextBox();
            this.txbPracCoefNoto = new System.Windows.Forms.TextBox();
            this.txbPracCoefConfiance = new System.Windows.Forms.TextBox();
            this.txbPracContact = new System.Windows.Forms.TextBox();
            this.txbPracTel = new System.Windows.Forms.TextBox();
            this.txbPracAdresse = new System.Windows.Forms.TextBox();
            this.txbPracSocial = new System.Windows.Forms.TextBox();
            this.txbPracNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPracSocial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPracAnnuler = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPracDelete = new System.Windows.Forms.Button();
            this.btnPracModif = new System.Windows.Forms.Button();
            this.btnParcAdd = new System.Windows.Forms.Button();
            this.tbcOnglets.SuspendLayout();
            this.tabMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.tabVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // 
            // tabMed
            // 
            this.tabMed.Controls.Add(this.txbMedSearch);
            this.tabMed.Controls.Add(this.dgvMed);
            this.tabMed.Controls.Add(this.cbxMedType);
            this.tabMed.Controls.Add(this.btnMedUpd);
            this.tabMed.Controls.Add(this.btnMedDel);
            this.tabMed.Controls.Add(this.btnMedAdd);
            this.tabMed.Location = new System.Drawing.Point(4, 22);
            this.tabMed.Name = "tabMed";
            this.tabMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabMed.Size = new System.Drawing.Size(958, 372);
            this.tabMed.TabIndex = 0;
            this.tabMed.Text = "Produits";
            this.tabMed.UseVisualStyleBackColor = true;
            // 
            // cbxMedType
            // 
            this.cbxMedType.FormattingEnabled = true;
            this.cbxMedType.Items.AddRange(new object[] {
            "Par nom",
            "Par famille",
            "Par nom",
            "Par famille"});
            this.cbxMedType.Location = new System.Drawing.Point(168, 28);
            this.cbxMedType.Name = "cbxMedType";
            this.cbxMedType.Size = new System.Drawing.Size(121, 21);
            this.cbxMedType.TabIndex = 5;
            // 
            // txbMedSearch
            // 
            this.txbMedSearch.Location = new System.Drawing.Point(203, 71);
            this.txbMedSearch.Name = "txbMedSearch";
            this.txbMedSearch.Size = new System.Drawing.Size(100, 20);
            this.txbMedSearch.TabIndex = 4;
            this.txbMedSearch.TextChanged += new System.EventHandler(this.txbMedSearch_TextChanged);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(28, 114);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(150, 141);
            this.dgvMed.TabIndex = 3;
            // 
            // btnMedDel
            // 
            this.btnMedDel.Location = new System.Drawing.Point(268, 201);
            this.btnMedDel.Name = "btnMedDel";
            this.btnMedDel.Size = new System.Drawing.Size(75, 23);
            this.btnMedDel.TabIndex = 2;
            this.btnMedDel.Text = "Supprimer";
            this.btnMedDel.UseVisualStyleBackColor = true;
            // 
            // btnMedUpd
            // 
            this.btnMedUpd.Location = new System.Drawing.Point(249, 159);
            this.btnMedUpd.Name = "btnMedUpd";
            this.btnMedUpd.Size = new System.Drawing.Size(75, 23);
            this.btnMedUpd.TabIndex = 1;
            this.btnMedUpd.Text = "Modifier";
            this.btnMedUpd.UseVisualStyleBackColor = true;
            // 
            // btnMedAdd
            // 
            this.btnMedAdd.Location = new System.Drawing.Point(168, 179);
            this.btnMedAdd.Name = "btnMedAdd";
            this.btnMedAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMedAdd.TabIndex = 0;
            this.btnMedAdd.Text = "Ajouter";
            this.btnMedAdd.UseVisualStyleBackColor = true;
            this.btnMedAdd.Click += new System.EventHandler(this.btnMedAdd_Click);
            // 
            // tabVisit
            // 
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
            this.tabVisit.Controls.Add(this.dataGridView1);
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
            this.txbVisitDateEmbauche.Location = new System.Drawing.Point(569, 83);
            this.txbVisitDateEmbauche.Name = "txbVisitDateEmbauche";
            this.txbVisitDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txbVisitDateEmbauche.TabIndex = 26;
            // 
            // txbVisitVille
            // 
            this.txbVisitVille.Location = new System.Drawing.Point(569, 46);
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
            this.lblVisitDateEmbauche.Location = new System.Drawing.Point(450, 82);
            this.lblVisitDateEmbauche.Name = "lblVisitDateEmbauche";
            this.lblVisitDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.lblVisitDateEmbauche.TabIndex = 18;
            this.lblVisitDateEmbauche.Text = "Date d\'embauche";
            // 
            // lblVisitVille
            // 
            this.lblVisitVille.AutoSize = true;
            this.lblVisitVille.Location = new System.Drawing.Point(477, 46);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 186);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnVisitDelete
            // 
            this.btnVisitDelete.Location = new System.Drawing.Point(831, 24);
            this.btnVisitDelete.Name = "btnVisitDelete";
            this.btnVisitDelete.Size = new System.Drawing.Size(112, 42);
            this.btnVisitDelete.TabIndex = 7;
            this.btnVisitDelete.Text = "Supprimer";
            this.btnVisitDelete.UseVisualStyleBackColor = true;
            // 
            // btnVisitModif
            // 
            this.btnVisitModif.Location = new System.Drawing.Point(703, 72);
            this.btnVisitModif.Name = "btnVisitModif";
            this.btnVisitModif.Size = new System.Drawing.Size(112, 44);
            this.btnVisitModif.TabIndex = 6;
            this.btnVisitModif.Text = "Modifier";
            this.btnVisitModif.UseVisualStyleBackColor = true;
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
            this.tabPract.Controls.Add(this.lblPracRechercher);
            this.tabPract.Controls.Add(this.txbPracRechercherPracticien);
            this.tabPract.Controls.Add(this.txbPracCoefNoto);
            this.tabPract.Controls.Add(this.txbPracCoefConfiance);
            this.tabPract.Controls.Add(this.txbPracContact);
            this.tabPract.Controls.Add(this.txbPracTel);
            this.tabPract.Controls.Add(this.txbPracAdresse);
            this.tabPract.Controls.Add(this.txbPracSocial);
            this.tabPract.Controls.Add(this.txbPracNom);
            this.tabPract.Controls.Add(this.label2);
            this.tabPract.Controls.Add(this.label3);
            this.tabPract.Controls.Add(this.label4);
            this.tabPract.Controls.Add(this.label5);
            this.tabPract.Controls.Add(this.label6);
            this.tabPract.Controls.Add(this.lblPracSocial);
            this.tabPract.Controls.Add(this.label9);
            this.tabPract.Controls.Add(this.btnPracAnnuler);
            this.tabPract.Controls.Add(this.dataGridView2);
            this.tabPract.Controls.Add(this.btnPracDelete);
            this.tabPract.Controls.Add(this.btnPracModif);
            this.tabPract.Controls.Add(this.btnParcAdd);
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(958, 372);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            // 
            // lblPracRechercher
            // 
            this.lblPracRechercher.AutoSize = true;
            this.lblPracRechercher.Location = new System.Drawing.Point(339, 102);
            this.lblPracRechercher.Name = "lblPracRechercher";
            this.lblPracRechercher.Size = new System.Drawing.Size(120, 13);
            this.lblPracRechercher.TabIndex = 51;
            this.lblPracRechercher.Text = "Rechercher un visiteur :";
            // 
            // txbPracRechercherPracticien
            // 
            this.txbPracRechercherPracticien.Location = new System.Drawing.Point(465, 99);
            this.txbPracRechercherPracticien.Name = "txbPracRechercherPracticien";
            this.txbPracRechercherPracticien.Size = new System.Drawing.Size(100, 20);
            this.txbPracRechercherPracticien.TabIndex = 49;
            // 
            // txbPracCoefNoto
            // 
            this.txbPracCoefNoto.Location = new System.Drawing.Point(558, 29);
            this.txbPracCoefNoto.Name = "txbPracCoefNoto";
            this.txbPracCoefNoto.Size = new System.Drawing.Size(100, 20);
            this.txbPracCoefNoto.TabIndex = 48;
            // 
            // txbPracCoefConfiance
            // 
            this.txbPracCoefConfiance.Location = new System.Drawing.Point(558, 55);
            this.txbPracCoefConfiance.Name = "txbPracCoefConfiance";
            this.txbPracCoefConfiance.Size = new System.Drawing.Size(100, 20);
            this.txbPracCoefConfiance.TabIndex = 47;
            // 
            // txbPracContact
            // 
            this.txbPracContact.Location = new System.Drawing.Point(318, 55);
            this.txbPracContact.Name = "txbPracContact";
            this.txbPracContact.Size = new System.Drawing.Size(100, 20);
            this.txbPracContact.TabIndex = 46;
            // 
            // txbPracTel
            // 
            this.txbPracTel.Location = new System.Drawing.Point(318, 29);
            this.txbPracTel.Name = "txbPracTel";
            this.txbPracTel.Size = new System.Drawing.Size(100, 20);
            this.txbPracTel.TabIndex = 45;
            // 
            // txbPracAdresse
            // 
            this.txbPracAdresse.Location = new System.Drawing.Point(104, 81);
            this.txbPracAdresse.Name = "txbPracAdresse";
            this.txbPracAdresse.Size = new System.Drawing.Size(100, 20);
            this.txbPracAdresse.TabIndex = 44;
            // 
            // txbPracSocial
            // 
            this.txbPracSocial.Location = new System.Drawing.Point(104, 55);
            this.txbPracSocial.Name = "txbPracSocial";
            this.txbPracSocial.Size = new System.Drawing.Size(100, 20);
            this.txbPracSocial.TabIndex = 43;
            // 
            // txbPracNom
            // 
            this.txbPracNom.Location = new System.Drawing.Point(104, 29);
            this.txbPracNom.Name = "txbPracNom";
            this.txbPracNom.Size = new System.Drawing.Size(100, 20);
            this.txbPracNom.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Coëfficiant confiance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Coëfficiant notoriéter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Adresse";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Téléphone";
            // 
            // lblPracSocial
            // 
            this.lblPracSocial.AutoSize = true;
            this.lblPracSocial.Location = new System.Drawing.Point(46, 58);
            this.lblPracSocial.Name = "lblPracSocial";
            this.lblPracSocial.Size = new System.Drawing.Size(36, 13);
            this.lblPracSocial.TabIndex = 35;
            this.lblPracSocial.Text = "Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nom";
            // 
            // btnPracAnnuler
            // 
            this.btnPracAnnuler.Location = new System.Drawing.Point(833, 71);
            this.btnPracAnnuler.Name = "btnPracAnnuler";
            this.btnPracAnnuler.Size = new System.Drawing.Size(112, 44);
            this.btnPracAnnuler.TabIndex = 33;
            this.btnPracAnnuler.Text = "Annuler";
            this.btnPracAnnuler.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(946, 186);
            this.dataGridView2.TabIndex = 32;
            // 
            // btnPracDelete
            // 
            this.btnPracDelete.Location = new System.Drawing.Point(833, 24);
            this.btnPracDelete.Name = "btnPracDelete";
            this.btnPracDelete.Size = new System.Drawing.Size(112, 41);
            this.btnPracDelete.TabIndex = 7;
            this.btnPracDelete.Text = "Supprimer";
            this.btnPracDelete.UseVisualStyleBackColor = true;
            // 
            // btnPracModif
            // 
            this.btnPracModif.Location = new System.Drawing.Point(705, 71);
            this.btnPracModif.Name = "btnPracModif";
            this.btnPracModif.Size = new System.Drawing.Size(112, 44);
            this.btnPracModif.TabIndex = 6;
            this.btnPracModif.Text = "Modifier";
            this.btnPracModif.UseVisualStyleBackColor = true;
            // 
            // btnParcAdd
            // 
            this.btnParcAdd.Location = new System.Drawing.Point(705, 24);
            this.btnParcAdd.Name = "btnParcAdd";
            this.btnParcAdd.Size = new System.Drawing.Size(112, 41);
            this.btnParcAdd.TabIndex = 5;
            this.btnParcAdd.Text = "Ajouter";
            this.btnParcAdd.UseVisualStyleBackColor = true;
            this.btnParcAdd.Click += new System.EventHandler(this.btnParcAdd_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPract.ResumeLayout(false);
            this.tabPract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOnglets;
        private System.Windows.Forms.TabPage tabPract;
        private System.Windows.Forms.Button btnPracDelete;
        private System.Windows.Forms.Button btnPracModif;
        private System.Windows.Forms.Button btnParcAdd;
        private System.Windows.Forms.TabPage tabMed;
        private System.Windows.Forms.TextBox txbMedSearch;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.ComboBox cbxMedType;
        private System.Windows.Forms.Button btnMedUpd;
        private System.Windows.Forms.Button btnMedDel;
        private System.Windows.Forms.Button btnMedAdd;
        private System.Windows.Forms.TabPage tabVisit;
        private System.Windows.Forms.Label lblVisitRechercherV;
        private System.Windows.Forms.TextBox txbVisitRechercher;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisitDelete;
        private System.Windows.Forms.Button btnVisitModif;
        private System.Windows.Forms.Button btnVisitAdd;
        private System.Windows.Forms.Label lblPracRechercher;
        private System.Windows.Forms.TextBox txbPracRechercherPracticien;
        private System.Windows.Forms.TextBox txbPracCoefNoto;
        private System.Windows.Forms.TextBox txbPracCoefConfiance;
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
        private System.Windows.Forms.Button btnPracAnnuler;
    }
}