
namespace Projets_BD_Meubles
{
    partial class EcranStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSeuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bEditer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSeuil = new System.Windows.Forms.TextBox();
            this.lSeuil = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.lPrix = new System.Windows.Forms.Label();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.lQuantite = new System.Windows.Forms.Label();
            this.tbSNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.bHtml = new System.Windows.Forms.Button();
            this.bDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cSeuil,
            this.cPrix,
            this.cQuantite,
            this.cSNom});
            this.dgvStock.Location = new System.Drawing.Point(12, 12);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(457, 265);
            this.dgvStock.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            // 
            // cSeuil
            // 
            this.cSeuil.DataPropertyName = "Seuil";
            this.cSeuil.HeaderText = "Seuil";
            this.cSeuil.Name = "cSeuil";
            this.cSeuil.ReadOnly = true;
            // 
            // cPrix
            // 
            this.cPrix.DataPropertyName = "Prix";
            this.cPrix.HeaderText = "Prix";
            this.cPrix.Name = "cPrix";
            this.cPrix.ReadOnly = true;
            // 
            // cQuantite
            // 
            this.cQuantite.DataPropertyName = "Quantite";
            this.cQuantite.HeaderText = "Quantite";
            this.cQuantite.Name = "cQuantite";
            this.cQuantite.ReadOnly = true;
            // 
            // cSNom
            // 
            this.cSNom.DataPropertyName = "Nom";
            this.cSNom.HeaderText = "Nom";
            this.cSNom.Name = "cSNom";
            // 
            // bAjouter
            // 
            this.bAjouter.BackColor = System.Drawing.Color.Salmon;
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.ForeColor = System.Drawing.Color.White;
            this.bAjouter.Location = new System.Drawing.Point(12, 284);
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
            this.bEditer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditer.ForeColor = System.Drawing.Color.White;
            this.bEditer.Location = new System.Drawing.Point(179, 283);
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
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.ForeColor = System.Drawing.Color.White;
            this.bSupprimer.Location = new System.Drawing.Point(349, 283);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(120, 42);
            this.bSupprimer.TabIndex = 3;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = false;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.Salmon;
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(254, 461);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(214, 35);
            this.bAnnuler.TabIndex = 4;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.BackColor = System.Drawing.Color.Salmon;
            this.bConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(12, 461);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(201, 35);
            this.bConfirmer.TabIndex = 5;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(13, 334);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(53, 13);
            this.lID.TabIndex = 6;
            this.lID.Text = "Identifiant";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(12, 350);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 7;
            // 
            // tbSeuil
            // 
            this.tbSeuil.Location = new System.Drawing.Point(369, 350);
            this.tbSeuil.Name = "tbSeuil";
            this.tbSeuil.Size = new System.Drawing.Size(100, 20);
            this.tbSeuil.TabIndex = 9;
            // 
            // lSeuil
            // 
            this.lSeuil.AutoSize = true;
            this.lSeuil.Location = new System.Drawing.Point(366, 334);
            this.lSeuil.Name = "lSeuil";
            this.lSeuil.Size = new System.Drawing.Size(101, 13);
            this.lSeuil.TabIndex = 8;
            this.lSeuil.Text = "Seuil de recomande";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(12, 398);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 11;
            // 
            // lPrix
            // 
            this.lPrix.AutoSize = true;
            this.lPrix.Location = new System.Drawing.Point(13, 382);
            this.lPrix.Name = "lPrix";
            this.lPrix.Size = new System.Drawing.Size(24, 13);
            this.lPrix.TabIndex = 10;
            this.lPrix.Text = "Prix";
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(369, 398);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(100, 20);
            this.tbQuantite.TabIndex = 13;
            // 
            // lQuantite
            // 
            this.lQuantite.AutoSize = true;
            this.lQuantite.Location = new System.Drawing.Point(366, 382);
            this.lQuantite.Name = "lQuantite";
            this.lQuantite.Size = new System.Drawing.Size(47, 13);
            this.lQuantite.TabIndex = 12;
            this.lQuantite.Text = "Quantité";
            // 
            // tbSNom
            // 
            this.tbSNom.Location = new System.Drawing.Point(244, 350);
            this.tbSNom.Name = "tbSNom";
            this.tbSNom.Size = new System.Drawing.Size(100, 20);
            this.tbSNom.TabIndex = 14;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(241, 334);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 15;
            this.lNom.Text = "Nom";
            // 
            // bHtml
            // 
            this.bHtml.BackColor = System.Drawing.Color.Salmon;
            this.bHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHtml.ForeColor = System.Drawing.Color.White;
            this.bHtml.Location = new System.Drawing.Point(12, 424);
            this.bHtml.Name = "bHtml";
            this.bHtml.Size = new System.Drawing.Size(201, 35);
            this.bHtml.TabIndex = 16;
            this.bHtml.Text = "Stock HTML";
            this.bHtml.UseVisualStyleBackColor = false;
            this.bHtml.Click += new System.EventHandler(this.bHtml_Click);
            // 
            // bDetails
            // 
            this.bDetails.BackColor = System.Drawing.Color.Salmon;
            this.bDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetails.ForeColor = System.Drawing.Color.White;
            this.bDetails.Location = new System.Drawing.Point(254, 424);
            this.bDetails.Name = "bDetails";
            this.bDetails.Size = new System.Drawing.Size(212, 34);
            this.bDetails.TabIndex = 17;
            this.bDetails.Text = "Details";
            this.bDetails.UseVisualStyleBackColor = false;
            this.bDetails.Click += new System.EventHandler(this.bDetails_Click);
            // 
            // EcranStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 514);
            this.Controls.Add(this.bDetails);
            this.Controls.Add(this.bHtml);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbSNom);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.lQuantite);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.lPrix);
            this.Controls.Add(this.tbSeuil);
            this.Controls.Add(this.lSeuil);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bEditer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.dgvStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.EcranStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bEditer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSeuil;
        private System.Windows.Forms.Label lSeuil;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label lPrix;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.Label lQuantite;
        private System.Windows.Forms.TextBox tbSNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSeuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNom;
        private System.Windows.Forms.Button bHtml;
        private System.Windows.Forms.Button bDetails;
    }
}