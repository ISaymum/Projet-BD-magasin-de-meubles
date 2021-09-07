
namespace Projets_BD_Meubles
{
    partial class EcranCommande
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
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.cIDCommandes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bEditer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.lID_Commande = new System.Windows.Forms.Label();
            this.lID_Fournisseur = new System.Windows.Forms.Label();
            this.lID_Client = new System.Windows.Forms.Label();
            this.tbID_Commande = new System.Windows.Forms.TextBox();
            this.lQuantite = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.dtpDateCommande = new System.Windows.Forms.DateTimePicker();
            this.cbIDFournisseur = new System.Windows.Forms.ComboBox();
            this.cbIDClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDCommandes,
            this.cQuantite,
            this.cDate,
            this.cIDClient,
            this.cIDFournisseur});
            this.dgvCommandes.Location = new System.Drawing.Point(12, 12);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.RowHeadersVisible = false;
            this.dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandes.Size = new System.Drawing.Size(468, 277);
            this.dgvCommandes.TabIndex = 0;
            // 
            // cIDCommandes
            // 
            this.cIDCommandes.DataPropertyName = "ID_Commande";
            this.cIDCommandes.HeaderText = "ID_Commande";
            this.cIDCommandes.Name = "cIDCommandes";
            this.cIDCommandes.ReadOnly = true;
            this.cIDCommandes.Visible = false;
            // 
            // cQuantite
            // 
            this.cQuantite.DataPropertyName = "Quantite";
            this.cQuantite.HeaderText = "Quantite";
            this.cQuantite.Name = "cQuantite";
            this.cQuantite.ReadOnly = true;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "Date_Commande";
            this.cDate.HeaderText = "Date";
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            // 
            // cIDClient
            // 
            this.cIDClient.DataPropertyName = "ID_Client";
            this.cIDClient.HeaderText = "ID_Client";
            this.cIDClient.Name = "cIDClient";
            this.cIDClient.ReadOnly = true;
            // 
            // cIDFournisseur
            // 
            this.cIDFournisseur.DataPropertyName = "ID_Fournisseur";
            this.cIDFournisseur.HeaderText = "ID_Fournisseur";
            this.cIDFournisseur.Name = "cIDFournisseur";
            this.cIDFournisseur.ReadOnly = true;
            // 
            // bAjouter
            // 
            this.bAjouter.BackColor = System.Drawing.Color.Salmon;
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.ForeColor = System.Drawing.Color.White;
            this.bAjouter.Location = new System.Drawing.Point(12, 295);
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
            this.bEditer.Location = new System.Drawing.Point(181, 295);
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
            this.bSupprimer.Location = new System.Drawing.Point(360, 295);
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
            this.bConfirmer.Location = new System.Drawing.Point(12, 507);
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
            this.bAnnuler.Location = new System.Drawing.Point(255, 507);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(225, 43);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // lID_Commande
            // 
            this.lID_Commande.AutoSize = true;
            this.lID_Commande.Location = new System.Drawing.Point(12, 353);
            this.lID_Commande.Name = "lID_Commande";
            this.lID_Commande.Size = new System.Drawing.Size(77, 13);
            this.lID_Commande.TabIndex = 6;
            this.lID_Commande.Text = "ID_Commande";
            // 
            // lID_Fournisseur
            // 
            this.lID_Fournisseur.AutoSize = true;
            this.lID_Fournisseur.Location = new System.Drawing.Point(207, 351);
            this.lID_Fournisseur.Name = "lID_Fournisseur";
            this.lID_Fournisseur.Size = new System.Drawing.Size(78, 13);
            this.lID_Fournisseur.TabIndex = 7;
            this.lID_Fournisseur.Text = "ID_Fournisseur";
            // 
            // lID_Client
            // 
            this.lID_Client.AutoSize = true;
            this.lID_Client.Location = new System.Drawing.Point(392, 351);
            this.lID_Client.Name = "lID_Client";
            this.lID_Client.Size = new System.Drawing.Size(50, 13);
            this.lID_Client.TabIndex = 8;
            this.lID_Client.Text = "ID_Client";
            // 
            // tbID_Commande
            // 
            this.tbID_Commande.Location = new System.Drawing.Point(12, 369);
            this.tbID_Commande.Name = "tbID_Commande";
            this.tbID_Commande.ReadOnly = true;
            this.tbID_Commande.Size = new System.Drawing.Size(100, 20);
            this.tbID_Commande.TabIndex = 9;
            // 
            // lQuantite
            // 
            this.lQuantite.AutoSize = true;
            this.lQuantite.Location = new System.Drawing.Point(9, 404);
            this.lQuantite.Name = "lQuantite";
            this.lQuantite.Size = new System.Drawing.Size(47, 13);
            this.lQuantite.TabIndex = 14;
            this.lQuantite.Text = "Quantite";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(271, 404);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(111, 13);
            this.lDate.TabIndex = 12;
            this.lDate.Text = "Date de la commande";
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(12, 420);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(185, 20);
            this.tbQuantite.TabIndex = 15;
            // 
            // dtpDateCommande
            // 
            this.dtpDateCommande.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCommande.Location = new System.Drawing.Point(274, 420);
            this.dtpDateCommande.Name = "dtpDateCommande";
            this.dtpDateCommande.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCommande.TabIndex = 17;
            // 
            // cbIDFournisseur
            // 
            this.cbIDFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDFournisseur.FormattingEnabled = true;
            this.cbIDFournisseur.Location = new System.Drawing.Point(201, 367);
            this.cbIDFournisseur.Name = "cbIDFournisseur";
            this.cbIDFournisseur.Size = new System.Drawing.Size(100, 21);
            this.cbIDFournisseur.TabIndex = 18;
            // 
            // cbIDClient
            // 
            this.cbIDClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDClient.FormattingEnabled = true;
            this.cbIDClient.Location = new System.Drawing.Point(384, 367);
            this.cbIDClient.Name = "cbIDClient";
            this.cbIDClient.Size = new System.Drawing.Size(96, 21);
            this.cbIDClient.TabIndex = 19;
            // 
            // EcranCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.ClientSize = new System.Drawing.Size(496, 565);
            this.Controls.Add(this.cbIDClient);
            this.Controls.Add(this.cbIDFournisseur);
            this.Controls.Add(this.dtpDateCommande);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.lQuantite);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.tbID_Commande);
            this.Controls.Add(this.lID_Client);
            this.Controls.Add(this.lID_Fournisseur);
            this.Controls.Add(this.lID_Commande);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bEditer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.dgvCommandes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranCommande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.EcranCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bEditer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Label lID_Commande;
        private System.Windows.Forms.Label lID_Fournisseur;
        private System.Windows.Forms.Label lID_Client;
        private System.Windows.Forms.TextBox tbID_Commande;
        private System.Windows.Forms.Label lQuantite;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.DateTimePicker dtpDateCommande;
        private System.Windows.Forms.ComboBox cbIDFournisseur;
        private System.Windows.Forms.ComboBox cbIDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDCommandes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDFournisseur;
    }
}