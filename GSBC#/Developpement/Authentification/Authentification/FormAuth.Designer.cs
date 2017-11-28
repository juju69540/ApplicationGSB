namespace Authentification
{
    partial class FormAuth
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblErrorConnect = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(140, 125);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(102, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(179, 122);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(100, 20);
            this.txbLogin.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(179, 160);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(65, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Authentification";
            // 
            // lblErrorConnect
            // 
            this.lblErrorConnect.AutoSize = true;
            this.lblErrorConnect.Location = new System.Drawing.Point(112, 235);
            this.lblErrorConnect.Name = "lblErrorConnect";
            this.lblErrorConnect.Size = new System.Drawing.Size(231, 13);
            this.lblErrorConnect.TabIndex = 5;
            this.lblErrorConnect.Text = "(n\'apparait pas en cas d\'authentifcation réussie)";
            this.lblErrorConnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(179, 200);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 32);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 329);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblErrorConnect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Name = "FormAuth";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblErrorConnect;
        private System.Windows.Forms.Button btnConnect;
    }
}

