
namespace Projets_BD_Meubles
{
    partial class EcranAcceuil
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
            this.bClients = new System.Windows.Forms.Button();
            this.bCommande = new System.Windows.Forms.Button();
            this.bDetails = new System.Windows.Forms.Button();
            this.bStock = new System.Windows.Forms.Button();
            this.bFournisseur = new System.Windows.Forms.Button();
            this.bChiffreHebdo = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dgvFournisseur = new System.Windows.Forms.DataGridView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAffiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAfficheN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSeuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lClient = new System.Windows.Forms.Label();
            this.lFournisseur = new System.Windows.Forms.Label();
            this.lStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // bClients
            // 
            this.bClients.BackColor = System.Drawing.Color.Salmon;
            this.bClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClients.ForeColor = System.Drawing.Color.White;
            this.bClients.Location = new System.Drawing.Point(50, 40);
            this.bClients.Name = "bClients";
            this.bClients.Size = new System.Drawing.Size(120, 42);
            this.bClients.TabIndex = 0;
            this.bClients.Text = "Clients";
            this.bClients.UseVisualStyleBackColor = false;
            this.bClients.Click += new System.EventHandler(this.bClients_Click);
            // 
            // bCommande
            // 
            this.bCommande.BackColor = System.Drawing.Color.Salmon;
            this.bCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCommande.ForeColor = System.Drawing.Color.White;
            this.bCommande.Location = new System.Drawing.Point(49, 88);
            this.bCommande.Name = "bCommande";
            this.bCommande.Size = new System.Drawing.Size(120, 42);
            this.bCommande.TabIndex = 1;
            this.bCommande.Text = "Commande";
            this.bCommande.UseVisualStyleBackColor = false;
            this.bCommande.Click += new System.EventHandler(this.bCommande_Click);
            // 
            // bDetails
            // 
            this.bDetails.BackColor = System.Drawing.Color.Salmon;
            this.bDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetails.ForeColor = System.Drawing.Color.White;
            this.bDetails.Location = new System.Drawing.Point(50, 136);
            this.bDetails.Name = "bDetails";
            this.bDetails.Size = new System.Drawing.Size(120, 42);
            this.bDetails.TabIndex = 2;
            this.bDetails.Text = "Détails";
            this.bDetails.UseVisualStyleBackColor = false;
            this.bDetails.Click += new System.EventHandler(this.bDetails_Click);
            // 
            // bStock
            // 
            this.bStock.BackColor = System.Drawing.Color.Salmon;
            this.bStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStock.ForeColor = System.Drawing.Color.White;
            this.bStock.Location = new System.Drawing.Point(50, 184);
            this.bStock.Name = "bStock";
            this.bStock.Size = new System.Drawing.Size(120, 42);
            this.bStock.TabIndex = 3;
            this.bStock.Text = "Stock";
            this.bStock.UseVisualStyleBackColor = false;
            this.bStock.Click += new System.EventHandler(this.bStock_Click);
            // 
            // bFournisseur
            // 
            this.bFournisseur.BackColor = System.Drawing.Color.Salmon;
            this.bFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFournisseur.ForeColor = System.Drawing.Color.White;
            this.bFournisseur.Location = new System.Drawing.Point(50, 232);
            this.bFournisseur.Name = "bFournisseur";
            this.bFournisseur.Size = new System.Drawing.Size(120, 42);
            this.bFournisseur.TabIndex = 4;
            this.bFournisseur.Text = "Fournisseur";
            this.bFournisseur.UseVisualStyleBackColor = false;
            this.bFournisseur.Click += new System.EventHandler(this.bFournisseur_Click);
            // 
            // bChiffreHebdo
            // 
            this.bChiffreHebdo.BackColor = System.Drawing.Color.Salmon;
            this.bChiffreHebdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChiffreHebdo.ForeColor = System.Drawing.Color.White;
            this.bChiffreHebdo.Location = new System.Drawing.Point(49, 280);
            this.bChiffreHebdo.Name = "bChiffreHebdo";
            this.bChiffreHebdo.Size = new System.Drawing.Size(120, 42);
            this.bChiffreHebdo.TabIndex = 5;
            this.bChiffreHebdo.Text = "ChiffHebdo";
            this.bChiffreHebdo.UseVisualStyleBackColor = false;
            this.bChiffreHebdo.Click += new System.EventHandler(this.bChiffreHebdo_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cAffiche,
            this.cAfficheN});
            this.dgvClient.Location = new System.Drawing.Point(215, 52);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(231, 150);
            this.dgvClient.TabIndex = 6;
            // 
            // dgvFournisseur
            // 
            this.dgvFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDFournisseur,
            this.cNom});
            this.dgvFournisseur.Location = new System.Drawing.Point(452, 52);
            this.dgvFournisseur.Name = "dgvFournisseur";
            this.dgvFournisseur.RowHeadersVisible = false;
            this.dgvFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFournisseur.Size = new System.Drawing.Size(166, 150);
            this.dgvFournisseur.TabIndex = 7;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDStock,
            this.cSeuil,
            this.cSPrix,
            this.cSQuantite,
            this.cSNom});
            this.dgvStock.Location = new System.Drawing.Point(215, 266);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.Size = new System.Drawing.Size(403, 150);
            this.dgvStock.TabIndex = 8;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            // 
            // cAffiche
            // 
            this.cAffiche.DataPropertyName = "Afficher";
            this.cAffiche.HeaderText = "Prénom";
            this.cAffiche.Name = "cAffiche";
            this.cAffiche.ReadOnly = true;
            // 
            // cAfficheN
            // 
            this.cAfficheN.DataPropertyName = "AfficherN";
            this.cAfficheN.HeaderText = "Nom";
            this.cAfficheN.Name = "cAfficheN";
            this.cAfficheN.ReadOnly = true;
            // 
            // cIDFournisseur
            // 
            this.cIDFournisseur.DataPropertyName = "ID_Fournisseur";
            this.cIDFournisseur.HeaderText = "ID_Fournisseur";
            this.cIDFournisseur.Name = "cIDFournisseur";
            this.cIDFournisseur.Visible = false;
            // 
            // cNom
            // 
            this.cNom.DataPropertyName = "Nom";
            this.cNom.HeaderText = "Nom";
            this.cNom.Name = "cNom";
            // 
            // cIDStock
            // 
            this.cIDStock.DataPropertyName = "ID_Stock";
            this.cIDStock.HeaderText = "ID_Stock";
            this.cIDStock.Name = "cIDStock";
            this.cIDStock.Visible = false;
            // 
            // cSeuil
            // 
            this.cSeuil.DataPropertyName = "S_Seuil";
            this.cSeuil.HeaderText = "S_Seuil";
            this.cSeuil.Name = "cSeuil";
            // 
            // cSPrix
            // 
            this.cSPrix.DataPropertyName = "S_prix";
            this.cSPrix.HeaderText = "S_prix";
            this.cSPrix.Name = "cSPrix";
            // 
            // cSQuantite
            // 
            this.cSQuantite.DataPropertyName = "S_Quantite";
            this.cSQuantite.HeaderText = "S_Quantite";
            this.cSQuantite.Name = "cSQuantite";
            // 
            // cSNom
            // 
            this.cSNom.DataPropertyName = "S_Nom";
            this.cSNom.HeaderText = "S_Nom";
            this.cSNom.Name = "cSNom";
            // 
            // lClient
            // 
            this.lClient.BackColor = System.Drawing.Color.Transparent;
            this.lClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClient.ForeColor = System.Drawing.Color.White;
            this.lClient.Location = new System.Drawing.Point(215, 33);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(100, 23);
            this.lClient.TabIndex = 9;
            this.lClient.Text = "Client";
            // 
            // lFournisseur
            // 
            this.lFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.lFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFournisseur.ForeColor = System.Drawing.Color.White;
            this.lFournisseur.Location = new System.Drawing.Point(453, 33);
            this.lFournisseur.Name = "lFournisseur";
            this.lFournisseur.Size = new System.Drawing.Size(112, 23);
            this.lFournisseur.TabIndex = 10;
            this.lFournisseur.Text = "Fournisseur";
            // 
            // lStock
            // 
            this.lStock.BackColor = System.Drawing.Color.Transparent;
            this.lStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStock.ForeColor = System.Drawing.Color.White;
            this.lStock.Location = new System.Drawing.Point(215, 247);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(100, 23);
            this.lStock.TabIndex = 11;
            this.lStock.Text = "Stock";
            // 
            // EcranAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.lStock);
            this.Controls.Add(this.lFournisseur);
            this.Controls.Add(this.lClient);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.dgvFournisseur);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.bChiffreHebdo);
            this.Controls.Add(this.bFournisseur);
            this.Controls.Add(this.bStock);
            this.Controls.Add(this.bDetails);
            this.Controls.Add(this.bCommande);
            this.Controls.Add(this.bClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAcceuil";
            this.Text = "Magasin de meubles HEL";
            this.Load += new System.EventHandler(this.EcranAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClients;
        private System.Windows.Forms.Button bCommande;
        private System.Windows.Forms.Button bDetails;
        private System.Windows.Forms.Button bStock;
        private System.Windows.Forms.Button bFournisseur;
        private System.Windows.Forms.Button bChiffreHebdo;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvFournisseur;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAffiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAfficheN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSeuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNom;
        private System.Windows.Forms.Label lClient;
        private System.Windows.Forms.Label lFournisseur;
        private System.Windows.Forms.Label lStock;
    }
}

