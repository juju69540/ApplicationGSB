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
            this.tabVisit = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisitDelete = new System.Windows.Forms.Button();
            this.btnVisitModif = new System.Windows.Forms.Button();
            this.btnVisitAdd = new System.Windows.Forms.Button();
            this.tabPract = new System.Windows.Forms.TabPage();
            this.txbFindPrac = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPracDelete = new System.Windows.Forms.Button();
            this.btnPracModif = new System.Windows.Forms.Button();
            this.btnParcAdd = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.btnMedUpd = new System.Windows.Forms.Button();
            this.btnMedDel = new System.Windows.Forms.Button();
            this.txbMedSearch = new System.Windows.Forms.TextBox();
            this.cbxMedType = new System.Windows.Forms.ComboBox();
            this.tabMed = new System.Windows.Forms.TabPage();
            this.btnVisitAnnuler = new System.Windows.Forms.Button();
            this.lblVisitNom = new System.Windows.Forms.Label();
            this.lblVisitPrenom = new System.Windows.Forms.Label();
            this.lblVisitLogin = new System.Windows.Forms.Label();
            this.lblVisitMdp = new System.Windows.Forms.Label();
            this.lblVisitAdresse = new System.Windows.Forms.Label();
            this.lblVisitCP = new System.Windows.Forms.Label();
            this.lblVisitVille = new System.Windows.Forms.Label();
            this.lblVisitDateEmbauche = new System.Windows.Forms.Label();
            this.txbVisitNom = new System.Windows.Forms.TextBox();
            this.txbVisitPrenom = new System.Windows.Forms.TextBox();
            this.txbVisitLogin = new System.Windows.Forms.TextBox();
            this.txbVisitPassword = new System.Windows.Forms.TextBox();
            this.txbVisitAdresse = new System.Windows.Forms.TextBox();
            this.txbVisitCP = new System.Windows.Forms.TextBox();
            this.txbVisitVille = new System.Windows.Forms.TextBox();
            this.txbVisitDateEmbauche = new System.Windows.Forms.TextBox();
            this.txbVisitRechercher = new System.Windows.Forms.TextBox();
            this.lblVisitRechercherV = new System.Windows.Forms.Label();
            this.tbcOnglets.SuspendLayout();
            this.tabVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.tabMed.SuspendLayout();
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
            this.tabMed.Controls.Add(this.cbxMedType);
            this.tabMed.Controls.Add(this.txbMedSearch);
            this.tabMed.Controls.Add(this.dgvMed);
            this.tabMed.Controls.Add(this.btnMedDel);
            this.tabMed.Controls.Add(this.btnMedUpd);
            this.tabMed.Controls.Add(this.btnMedAdd);
            this.tabMed.Location = new System.Drawing.Point(4, 22);
            this.tabMed.Name = "tabMed";
            this.tabMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabMed.Size = new System.Drawing.Size(436, 265);
            this.tabMed.TabIndex = 0;
            this.tabMed.Text = "Produits";
            this.tabMed.UseVisualStyleBackColor = true;
            // 
            // cbxMedType
            // 
            this.cbxMedType.FormattingEnabled = true;
            this.cbxMedType.Items.AddRange(new object[] {
            "Par nom",
            "Par famille"});
            this.cbxMedType.Location = new System.Drawing.Point(248, 81);
            this.cbxMedType.Name = "cbxMedType";
            this.cbxMedType.Size = new System.Drawing.Size(121, 21);
            this.cbxMedType.TabIndex = 5;
            // 
            // txbMedSearch
            // 
            this.txbMedSearch.Location = new System.Drawing.Point(104, 81);
            this.txbMedSearch.Name = "txbMedSearch";
            this.txbMedSearch.Size = new System.Drawing.Size(100, 20);
            this.txbMedSearch.TabIndex = 4;
            this.txbMedSearch.TextChanged += new System.EventHandler(this.txbMedSearch_TextChanged);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(6, 107);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(424, 141);
            this.dgvMed.TabIndex = 3;
            // 
            // btnMedDel
            // 
            this.btnMedDel.Location = new System.Drawing.Point(248, 38);
            this.btnMedDel.Name = "btnMedDel";
            this.btnMedDel.Size = new System.Drawing.Size(75, 23);
            this.btnMedDel.TabIndex = 2;
            this.btnMedDel.Text = "Supprimer";
            this.btnMedDel.UseVisualStyleBackColor = true;
            // 
            // btnMedUpd
            // 
            this.btnMedUpd.Location = new System.Drawing.Point(176, 38);
            this.btnMedUpd.Name = "btnMedUpd";
            this.btnMedUpd.Size = new System.Drawing.Size(75, 23);
            this.btnMedUpd.TabIndex = 1;
            this.btnMedUpd.Text = "Modifier";
            this.btnMedUpd.UseVisualStyleBackColor = true;
            // 
            // btnMedAdd
            // 
            this.btnMedAdd.Location = new System.Drawing.Point(104, 38);
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
            this.tabPract.Controls.Add(this.txbFindPrac);
            this.tabPract.Controls.Add(this.dataGridView2);
            this.tabPract.Controls.Add(this.btnPracDelete);
            this.tabPract.Controls.Add(this.btnPracModif);
            this.tabPract.Controls.Add(this.btnParcAdd);
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(958, 415);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            // 
            // tabPract
            // 
            this.tabPract.Controls.Add(this.txbFindPrac);
            this.tabPract.Controls.Add(this.dataGridView2);
            this.tabPract.Controls.Add(this.btnPracDelete);
            this.tabPract.Controls.Add(this.btnPracModif);
            this.tabPract.Controls.Add(this.btnParcAdd);
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(436, 265);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            // 
            // txbFindPrac
            // 
            this.txbFindPrac.Location = new System.Drawing.Point(165, 56);
            this.txbFindPrac.Name = "txbFindPrac";
            this.txbFindPrac.Size = new System.Drawing.Size(100, 20);
            this.txbFindPrac.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(424, 141);
            this.dataGridView2.TabIndex = 8;
            // 
            // btnPracDelete
            // 
            this.btnPracDelete.Location = new System.Drawing.Point(257, 27);
            this.btnPracDelete.Name = "btnPracDelete";
            this.btnPracDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPracDelete.TabIndex = 7;
            this.btnPracDelete.Text = "Supprimer";
            this.btnPracDelete.UseVisualStyleBackColor = true;
            // 
            // btnPracModif
            // 
            this.btnPracModif.Location = new System.Drawing.Point(176, 27);
            this.btnPracModif.Name = "btnPracModif";
            this.btnPracModif.Size = new System.Drawing.Size(75, 23);
            this.btnPracModif.TabIndex = 6;
            this.btnPracModif.Text = "Modifier";
            this.btnPracModif.UseVisualStyleBackColor = true;
            // 
            // btnParcAdd
            // 
            this.btnParcAdd.Location = new System.Drawing.Point(95, 27);
            this.btnParcAdd.Name = "btnParcAdd";
            this.btnParcAdd.Size = new System.Drawing.Size(75, 23);
            this.btnParcAdd.TabIndex = 5;
            this.btnParcAdd.Text = "Ajouter";
            this.btnParcAdd.UseVisualStyleBackColor = true;
            this.btnParcAdd.Click += new System.EventHandler(this.btnParcAdd_Click);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(28, 114);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(150, 141);
            this.dgvMed.TabIndex = 3;
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
            // btnMedUpd
            // 
            this.btnMedUpd.Location = new System.Drawing.Point(249, 159);
            this.btnMedUpd.Name = "btnMedUpd";
            this.btnMedUpd.Size = new System.Drawing.Size(75, 23);
            this.btnMedUpd.TabIndex = 1;
            this.btnMedUpd.Text = "Modifier";
            this.btnMedUpd.UseVisualStyleBackColor = true;
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
            // txbMedSearch
            // 
            this.txbMedSearch.Location = new System.Drawing.Point(203, 71);
            this.txbMedSearch.Name = "txbMedSearch";
            this.txbMedSearch.Size = new System.Drawing.Size(100, 20);
            this.txbMedSearch.TabIndex = 4;
            // 
            // cbxMedType
            // 
            this.cbxMedType.FormattingEnabled = true;
            this.cbxMedType.Items.AddRange(new object[] {
            "Par nom",
            "Par famille"});
            this.cbxMedType.Location = new System.Drawing.Point(168, 28);
            this.cbxMedType.Name = "cbxMedType";
            this.cbxMedType.Size = new System.Drawing.Size(121, 21);
            this.cbxMedType.TabIndex = 5;
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
            this.tabMed.Size = new System.Drawing.Size(735, 415);
            this.tabMed.TabIndex = 0;
            this.tabMed.Text = "Produits";
            this.tabMed.UseVisualStyleBackColor = true;
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
            // lblVisitNom
            // 
            this.lblVisitNom.AutoSize = true;
            this.lblVisitNom.Location = new System.Drawing.Point(38, 30);
            this.lblVisitNom.Name = "lblVisitNom";
            this.lblVisitNom.Size = new System.Drawing.Size(29, 13);
            this.lblVisitNom.TabIndex = 11;
            this.lblVisitNom.Text = "Nom";
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
            // lblVisitLogin
            // 
            this.lblVisitLogin.AutoSize = true;
            this.lblVisitLogin.Location = new System.Drawing.Point(34, 90);
            this.lblVisitLogin.Name = "lblVisitLogin";
            this.lblVisitLogin.Size = new System.Drawing.Size(33, 13);
            this.lblVisitLogin.TabIndex = 13;
            this.lblVisitLogin.Text = "Login";
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
            // lblVisitAdresse
            // 
            this.lblVisitAdresse.AutoSize = true;
            this.lblVisitAdresse.Location = new System.Drawing.Point(247, 59);
            this.lblVisitAdresse.Name = "lblVisitAdresse";
            this.lblVisitAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblVisitAdresse.TabIndex = 15;
            this.lblVisitAdresse.Text = "Adresse";
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
            // lblVisitVille
            // 
            this.lblVisitVille.AutoSize = true;
            this.lblVisitVille.Location = new System.Drawing.Point(477, 46);
            this.lblVisitVille.Name = "lblVisitVille";
            this.lblVisitVille.Size = new System.Drawing.Size(26, 13);
            this.lblVisitVille.TabIndex = 17;
            this.lblVisitVille.Text = "Ville";
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
            // txbVisitNom
            // 
            this.txbVisitNom.Location = new System.Drawing.Point(102, 30);
            this.txbVisitNom.Name = "txbVisitNom";
            this.txbVisitNom.Size = new System.Drawing.Size(100, 20);
            this.txbVisitNom.TabIndex = 19;
            // 
            // txbVisitPrenom
            // 
            this.txbVisitPrenom.Location = new System.Drawing.Point(102, 56);
            this.txbVisitPrenom.Name = "txbVisitPrenom";
            this.txbVisitPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbVisitPrenom.TabIndex = 20;
            // 
            // txbVisitLogin
            // 
            this.txbVisitLogin.Location = new System.Drawing.Point(102, 82);
            this.txbVisitLogin.Name = "txbVisitLogin";
            this.txbVisitLogin.Size = new System.Drawing.Size(100, 20);
            this.txbVisitLogin.TabIndex = 21;
            // 
            // txbVisitPassword
            // 
            this.txbVisitPassword.Location = new System.Drawing.Point(316, 30);
            this.txbVisitPassword.Name = "txbVisitPassword";
            this.txbVisitPassword.Size = new System.Drawing.Size(100, 20);
            this.txbVisitPassword.TabIndex = 22;
            // 
            // txbVisitAdresse
            // 
            this.txbVisitAdresse.Location = new System.Drawing.Point(316, 59);
            this.txbVisitAdresse.Name = "txbVisitAdresse";
            this.txbVisitAdresse.Size = new System.Drawing.Size(100, 20);
            this.txbVisitAdresse.TabIndex = 23;
            // 
            // txbVisitCP
            // 
            this.txbVisitCP.Location = new System.Drawing.Point(316, 87);
            this.txbVisitCP.Name = "txbVisitCP";
            this.txbVisitCP.Size = new System.Drawing.Size(100, 20);
            this.txbVisitCP.TabIndex = 24;
            // 
            // txbVisitVille
            // 
            this.txbVisitVille.Location = new System.Drawing.Point(569, 46);
            this.txbVisitVille.Name = "txbVisitVille";
            this.txbVisitVille.Size = new System.Drawing.Size(100, 20);
            this.txbVisitVille.TabIndex = 25;
            // 
            // txbVisitDateEmbauche
            // 
            this.txbVisitDateEmbauche.Location = new System.Drawing.Point(569, 83);
            this.txbVisitDateEmbauche.Name = "txbVisitDateEmbauche";
            this.txbVisitDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txbVisitDateEmbauche.TabIndex = 26;
            // 
            // txbVisitRechercher
            // 
            this.txbVisitRechercher.Location = new System.Drawing.Point(500, 130);
            this.txbVisitRechercher.Name = "txbVisitRechercher";
            this.txbVisitRechercher.Size = new System.Drawing.Size(100, 20);
            this.txbVisitRechercher.TabIndex = 27;
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
            this.tabVisit.ResumeLayout(false);
            this.tabVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPract.ResumeLayout(false);
            this.tabPract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.tabMed.ResumeLayout(false);
            this.tabMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOnglets;
        private System.Windows.Forms.TabPage tabVisit;
        private System.Windows.Forms.TabPage tabPract;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisitDelete;
        private System.Windows.Forms.Button btnVisitModif;
        private System.Windows.Forms.Button btnVisitAdd;
        private System.Windows.Forms.TextBox txbFindPrac;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}