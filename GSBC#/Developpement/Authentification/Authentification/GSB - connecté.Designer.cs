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
            this.tabVisit = new System.Windows.Forms.TabPage();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.btnMedUpd = new System.Windows.Forms.Button();
            this.btnMedDel = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.txbMedSearch = new System.Windows.Forms.TextBox();
            this.cbxMedType = new System.Windows.Forms.ComboBox();
            this.tabPract = new System.Windows.Forms.TabPage();
            this.tbcOnglets.SuspendLayout();
            this.tabMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
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
            // tabVisit
            // 
            this.tabVisit.Location = new System.Drawing.Point(4, 22);
            this.tabVisit.Name = "tabVisit";
            this.tabVisit.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisit.Size = new System.Drawing.Size(436, 265);
            this.tabVisit.TabIndex = 1;
            this.tabVisit.Text = "Visiteurs";
            this.tabVisit.UseVisualStyleBackColor = true;
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
            // btnMedUpd
            // 
            this.btnMedUpd.Location = new System.Drawing.Point(176, 38);
            this.btnMedUpd.Name = "btnMedUpd";
            this.btnMedUpd.Size = new System.Drawing.Size(75, 23);
            this.btnMedUpd.TabIndex = 1;
            this.btnMedUpd.Text = "Modifier";
            this.btnMedUpd.UseVisualStyleBackColor = true;
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
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(6, 107);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(424, 141);
            this.dgvMed.TabIndex = 3;
            // 
            // txbMedSearch
            // 
            this.txbMedSearch.Location = new System.Drawing.Point(104, 81);
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
            this.cbxMedType.Location = new System.Drawing.Point(248, 81);
            this.cbxMedType.Name = "cbxMedType";
            this.cbxMedType.Size = new System.Drawing.Size(121, 21);
            this.cbxMedType.TabIndex = 5;
            // 
            // tabPract
            // 
            this.tabPract.Location = new System.Drawing.Point(4, 22);
            this.tabPract.Name = "tabPract";
            this.tabPract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPract.Size = new System.Drawing.Size(436, 265);
            this.tabPract.TabIndex = 2;
            this.tabPract.Text = "Practiciens";
            this.tabPract.UseVisualStyleBackColor = true;
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
    }
}