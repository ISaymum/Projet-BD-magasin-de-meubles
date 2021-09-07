
namespace Projets_BD_Meubles
{
    partial class EcranDetails
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
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.cIDDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bEditer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.cbIDStock = new System.Windows.Forms.ComboBox();
            this.cbIDCommande = new System.Windows.Forms.ComboBox();
            this.tbIDDetails = new System.Windows.Forms.TextBox();
            this.lIDDetails = new System.Windows.Forms.Label();
            this.lIDStock = new System.Windows.Forms.Label();
            this.lID_Commande = new System.Windows.Forms.Label();
            this.bFacture = new System.Windows.Forms.Button();
            this.bBorderau = new System.Windows.Forms.Button();
            this.tbPrixTotal = new System.Windows.Forms.TextBox();
            this.lPrixTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDetails,
            this.cIDCommande,
            this.cIDStock,
            this.cPrixTotal});
            this.dgvDetails.Location = new System.Drawing.Point(12, 2);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(447, 292);
            this.dgvDetails.TabIndex = 0;
            // 
            // cIDDetails
            // 
            this.cIDDetails.DataPropertyName = "ID_Details";
            this.cIDDetails.HeaderText = "ID_Details";
            this.cIDDetails.Name = "cIDDetails";
            this.cIDDetails.ReadOnly = true;
            this.cIDDetails.Visible = false;
            // 
            // cIDCommande
            // 
            this.cIDCommande.DataPropertyName = "ID_Commande";
            this.cIDCommande.HeaderText = "ID_Commande";
            this.cIDCommande.Name = "cIDCommande";
            this.cIDCommande.ReadOnly = true;
            // 
            // cIDStock
            // 
            this.cIDStock.DataPropertyName = "ID_Stock";
            this.cIDStock.HeaderText = "ID_Stock";
            this.cIDStock.Name = "cIDStock";
            this.cIDStock.ReadOnly = true;
            // 
            // cPrixTotal
            // 
            this.cPrixTotal.DataPropertyName = "Prix_Total";
            this.cPrixTotal.HeaderText = "Prix_Total";
            this.cPrixTotal.Name = "cPrixTotal";
            // 
            // bAjouter
            // 
            this.bAjouter.BackColor = System.Drawing.Color.Salmon;
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.ForeColor = System.Drawing.Color.White;
            this.bAjouter.Location = new System.Drawing.Point(12, 300);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(120, 42);
            this.bAjouter.TabIndex = 1;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = false;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bEditer
            // 
            this.bEditer.BackColor = System.Drawing.Color.Salmon;
            this.bEditer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditer.ForeColor = System.Drawing.Color.White;
            this.bEditer.Location = new System.Drawing.Point(172, 300);
            this.bEditer.Name = "bEditer";
            this.bEditer.Size = new System.Drawing.Size(120, 42);
            this.bEditer.TabIndex = 2;
            this.bEditer.Text = "Editer";
            this.bEditer.UseVisualStyleBackColor = false;
            this.bEditer.Click += new System.EventHandler(this.bEditer_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.BackColor = System.Drawing.Color.Salmon;
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.ForeColor = System.Drawing.Color.White;
            this.bSupprimer.Location = new System.Drawing.Point(339, 300);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(120, 42);
            this.bSupprimer.TabIndex = 3;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = false;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.BackColor = System.Drawing.Color.Salmon;
            this.bConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(12, 456);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(218, 43);
            this.bConfirmer.TabIndex = 4;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.Salmon;
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(241, 456);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(218, 43);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // cbIDStock
            // 
            this.cbIDStock.FormattingEnabled = true;
            this.cbIDStock.Location = new System.Drawing.Point(198, 389);
            this.cbIDStock.Name = "cbIDStock";
            this.cbIDStock.Size = new System.Drawing.Size(75, 21);
            this.cbIDStock.TabIndex = 6;
            // 
            // cbIDCommande
            // 
            this.cbIDCommande.FormattingEnabled = true;
            this.cbIDCommande.Location = new System.Drawing.Point(380, 389);
            this.cbIDCommande.Name = "cbIDCommande";
            this.cbIDCommande.Size = new System.Drawing.Size(75, 21);
            this.cbIDCommande.TabIndex = 7;
            // 
            // tbIDDetails
            // 
            this.tbIDDetails.Location = new System.Drawing.Point(13, 389);
            this.tbIDDetails.Name = "tbIDDetails";
            this.tbIDDetails.Size = new System.Drawing.Size(100, 20);
            this.tbIDDetails.TabIndex = 8;
            // 
            // lIDDetails
            // 
            this.lIDDetails.AutoSize = true;
            this.lIDDetails.Location = new System.Drawing.Point(13, 370);
            this.lIDDetails.Name = "lIDDetails";
            this.lIDDetails.Size = new System.Drawing.Size(56, 13);
            this.lIDDetails.TabIndex = 9;
            this.lIDDetails.Text = "ID_Details";
            // 
            // lIDStock
            // 
            this.lIDStock.AutoSize = true;
            this.lIDStock.Location = new System.Drawing.Point(198, 370);
            this.lIDStock.Name = "lIDStock";
            this.lIDStock.Size = new System.Drawing.Size(52, 13);
            this.lIDStock.TabIndex = 10;
            this.lIDStock.Text = "ID_Stock";
            // 
            // lID_Commande
            // 
            this.lID_Commande.AutoSize = true;
            this.lID_Commande.Location = new System.Drawing.Point(380, 369);
            this.lID_Commande.Name = "lID_Commande";
            this.lID_Commande.Size = new System.Drawing.Size(77, 13);
            this.lID_Commande.TabIndex = 11;
            this.lID_Commande.Text = "ID_Commande";
            // 
            // bFacture
            // 
            this.bFacture.BackColor = System.Drawing.Color.Salmon;
            this.bFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFacture.ForeColor = System.Drawing.Color.White;
            this.bFacture.Location = new System.Drawing.Point(12, 505);
            this.bFacture.Name = "bFacture";
            this.bFacture.Size = new System.Drawing.Size(218, 43);
            this.bFacture.TabIndex = 12;
            this.bFacture.Text = "Facture";
            this.bFacture.UseVisualStyleBackColor = false;
            this.bFacture.Click += new System.EventHandler(this.bFacture_Click);
            // 
            // bBorderau
            // 
            this.bBorderau.BackColor = System.Drawing.Color.Salmon;
            this.bBorderau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorderau.ForeColor = System.Drawing.Color.White;
            this.bBorderau.Location = new System.Drawing.Point(241, 505);
            this.bBorderau.Name = "bBorderau";
            this.bBorderau.Size = new System.Drawing.Size(218, 43);
            this.bBorderau.TabIndex = 13;
            this.bBorderau.Text = "Bordereau";
            this.bBorderau.UseVisualStyleBackColor = false;
            this.bBorderau.Click += new System.EventHandler(this.bBorderau_Click);
            // 
            // tbPrixTotal
            // 
            this.tbPrixTotal.Location = new System.Drawing.Point(12, 430);
            this.tbPrixTotal.Name = "tbPrixTotal";
            this.tbPrixTotal.Size = new System.Drawing.Size(100, 20);
            this.tbPrixTotal.TabIndex = 14;
            // 
            // lPrixTotal
            // 
            this.lPrixTotal.AutoSize = true;
            this.lPrixTotal.Location = new System.Drawing.Point(12, 411);
            this.lPrixTotal.Name = "lPrixTotal";
            this.lPrixTotal.Size = new System.Drawing.Size(51, 13);
            this.lPrixTotal.TabIndex = 15;
            this.lPrixTotal.Text = "Prix Total";
            // 
            // EcranDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 563);
            this.Controls.Add(this.lPrixTotal);
            this.Controls.Add(this.tbPrixTotal);
            this.Controls.Add(this.bBorderau);
            this.Controls.Add(this.bFacture);
            this.Controls.Add(this.lID_Commande);
            this.Controls.Add(this.lIDStock);
            this.Controls.Add(this.lIDDetails);
            this.Controls.Add(this.tbIDDetails);
            this.Controls.Add(this.cbIDCommande);
            this.Controls.Add(this.cbIDStock);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bEditer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.dgvDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranDetails";
            this.Text = "Détails";
            this.Load += new System.EventHandler(this.EcranDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bEditer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.ComboBox cbIDStock;
        private System.Windows.Forms.ComboBox cbIDCommande;
        private System.Windows.Forms.TextBox tbIDDetails;
        private System.Windows.Forms.Label lIDDetails;
        private System.Windows.Forms.Label lIDStock;
        private System.Windows.Forms.Label lID_Commande;
        private System.Windows.Forms.Button bFacture;
        private System.Windows.Forms.Button bBorderau;
        private System.Windows.Forms.TextBox tbPrixTotal;
        private System.Windows.Forms.Label lPrixTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrixTotal;
    }
}