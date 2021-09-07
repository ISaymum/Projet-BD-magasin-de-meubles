
namespace Projets_BD_Meubles
{
    partial class EcranClient
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAffiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAfficheN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bEditer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.lPre = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cAffiche,
            this.cAfficheN});
            this.dgvClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvClients.Location = new System.Drawing.Point(12, 11);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(444, 265);
            this.dgvClients.TabIndex = 0;
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
            this.cAffiche.Width = 300;
            // 
            // cAfficheN
            // 
            this.cAfficheN.DataPropertyName = "AfficherN";
            this.cAfficheN.HeaderText = "Nom";
            this.cAfficheN.Name = "cAfficheN";
            this.cAfficheN.ReadOnly = true;
            this.cAfficheN.Width = 300;
            // 
            // bAjouter
            // 
            this.bAjouter.BackColor = System.Drawing.Color.Salmon;
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.ForeColor = System.Drawing.Color.White;
            this.bAjouter.Location = new System.Drawing.Point(12, 283);
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
            this.bEditer.Location = new System.Drawing.Point(166, 282);
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
            this.bSupprimer.Location = new System.Drawing.Point(339, 283);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(120, 42);
            this.bSupprimer.TabIndex = 3;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = false;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(12, 339);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(53, 13);
            this.lID.TabIndex = 4;
            this.lID.Text = "Identifiant";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(12, 355);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(444, 20);
            this.tbID.TabIndex = 5;
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(12, 394);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(444, 20);
            this.tbPre.TabIndex = 4;
            // 
            // lPre
            // 
            this.lPre.AutoSize = true;
            this.lPre.Location = new System.Drawing.Point(12, 378);
            this.lPre.Name = "lPre";
            this.lPre.Size = new System.Drawing.Size(43, 13);
            this.lPre.TabIndex = 6;
            this.lPre.Text = "Prénom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 433);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(444, 20);
            this.tbNom.TabIndex = 5;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(12, 417);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 8;
            this.lNom.Text = "Nom";
            // 
            // bConfirmer
            // 
            this.bConfirmer.BackColor = System.Drawing.Color.Salmon;
            this.bConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(12, 482);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(195, 33);
            this.bConfirmer.TabIndex = 6;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.Salmon;
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(248, 482);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(208, 33);
            this.bAnnuler.TabIndex = 7;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // EcranClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.ClientSize = new System.Drawing.Size(471, 557);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.lPre);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bEditer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.dgvClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClient";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.EcranClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bEditer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label lPre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAffiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAfficheN;
    }
}