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
            this.txbFindVisit = new System.Windows.Forms.TextBox();
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
            this.tbcOnglets.Size = new System.Drawing.Size(444, 291);
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
            // 
            // tabVisit
            // 
            this.tabVisit.Controls.Add(this.txbFindVisit);
            this.tabVisit.Controls.Add(this.dataGridView1);
            this.tabVisit.Controls.Add(this.btnVisitDelete);
            this.tabVisit.Controls.Add(this.btnVisitModif);
            this.tabVisit.Controls.Add(this.btnVisitAdd);
            this.tabVisit.Location = new System.Drawing.Point(4, 22);
            this.tabVisit.Name = "tabVisit";
            this.tabVisit.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisit.Size = new System.Drawing.Size(436, 265);
            this.tabVisit.TabIndex = 1;
            this.tabVisit.Text = "Visiteurs";
            this.tabVisit.UseVisualStyleBackColor = true;
            // 
            // txbFindVisit
            // 
            this.txbFindVisit.Location = new System.Drawing.Point(176, 70);
            this.txbFindVisit.Name = "txbFindVisit";
            this.txbFindVisit.Size = new System.Drawing.Size(100, 20);
            this.txbFindVisit.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 141);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnVisitDelete
            // 
            this.btnVisitDelete.Location = new System.Drawing.Point(248, 27);
            this.btnVisitDelete.Name = "btnVisitDelete";
            this.btnVisitDelete.Size = new System.Drawing.Size(75, 23);
            this.btnVisitDelete.TabIndex = 7;
            this.btnVisitDelete.Text = "Supprimer";
            this.btnVisitDelete.UseVisualStyleBackColor = true;
            // 
            // btnVisitModif
            // 
            this.btnVisitModif.Location = new System.Drawing.Point(176, 27);
            this.btnVisitModif.Name = "btnVisitModif";
            this.btnVisitModif.Size = new System.Drawing.Size(75, 23);
            this.btnVisitModif.TabIndex = 6;
            this.btnVisitModif.Text = "Modifier";
            this.btnVisitModif.UseVisualStyleBackColor = true;
            // 
            // btnVisitAdd
            // 
            this.btnVisitAdd.Location = new System.Drawing.Point(104, 27);
            this.btnVisitAdd.Name = "btnVisitAdd";
            this.btnVisitAdd.Size = new System.Drawing.Size(75, 23);
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
            this.tabPract.Size = new System.Drawing.Size(436, 265);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
            // 
            // txbFindPrac
            // 
            this.txbFindPrac.Location = new System.Drawing.Point(104, 70);
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
            this.btnPracDelete.Location = new System.Drawing.Point(248, 27);
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
            this.btnParcAdd.Location = new System.Drawing.Point(104, 27);
            this.btnParcAdd.Name = "btnParcAdd";
            this.btnParcAdd.Size = new System.Drawing.Size(75, 23);
            this.btnParcAdd.TabIndex = 5;
            this.btnParcAdd.Text = "Ajouter";
            this.btnParcAdd.UseVisualStyleBackColor = true;
            // 
            // GSB___connecté
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.tbcOnglets);
            this.Name = "GSB___connecté";
            this.Text = "GSB___connecté";
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
        private System.Windows.Forms.TabPage tabMed;
        private System.Windows.Forms.ComboBox cbxMedType;
        private System.Windows.Forms.TextBox txbMedSearch;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.Button btnMedDel;
        private System.Windows.Forms.Button btnMedUpd;
        private System.Windows.Forms.Button btnMedAdd;
        private System.Windows.Forms.TabPage tabVisit;
        private System.Windows.Forms.TabPage tabPract;
        private System.Windows.Forms.TextBox txbFindVisit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisitDelete;
        private System.Windows.Forms.Button btnVisitModif;
        private System.Windows.Forms.Button btnVisitAdd;
        private System.Windows.Forms.TextBox txbFindPrac;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPracDelete;
        private System.Windows.Forms.Button btnPracModif;
        private System.Windows.Forms.Button btnParcAdd;
    }
}