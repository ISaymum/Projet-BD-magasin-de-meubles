
namespace Projets_BD_Meubles
{
    partial class EcranChiffreHebdo
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
            this.dtpChiffreHedbo = new System.Windows.Forms.DateTimePicker();
            this.bCalculer = new System.Windows.Forms.Button();
            this.lChiffreHebdo = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpChiffreHedbo
            // 
            this.dtpChiffreHedbo.Location = new System.Drawing.Point(15, 57);
            this.dtpChiffreHedbo.Name = "dtpChiffreHedbo";
            this.dtpChiffreHedbo.Size = new System.Drawing.Size(200, 20);
            this.dtpChiffreHedbo.TabIndex = 0;
            // 
            // bCalculer
            // 
            this.bCalculer.BackColor = System.Drawing.Color.Coral;
            this.bCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculer.ForeColor = System.Drawing.Color.White;
            this.bCalculer.Location = new System.Drawing.Point(12, 83);
            this.bCalculer.Name = "bCalculer";
            this.bCalculer.Size = new System.Drawing.Size(200, 45);
            this.bCalculer.TabIndex = 1;
            this.bCalculer.Text = "Calculer";
            this.bCalculer.UseVisualStyleBackColor = false;
            this.bCalculer.Click += new System.EventHandler(this.bCalculer_Click);
            // 
            // lChiffreHebdo
            // 
            this.lChiffreHebdo.BackColor = System.Drawing.Color.Coral;
            this.lChiffreHebdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChiffreHebdo.ForeColor = System.Drawing.Color.Transparent;
            this.lChiffreHebdo.Location = new System.Drawing.Point(9, 131);
            this.lChiffreHebdo.Name = "lChiffreHebdo";
            this.lChiffreHebdo.Size = new System.Drawing.Size(203, 60);
            this.lChiffreHebdo.TabIndex = 2;
            this.lChiffreHebdo.Text = "Chiffre d\'affaire hebdomadaire";
            this.lChiffreHebdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMessage
            // 
            this.lMessage.BackColor = System.Drawing.Color.Green;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.ForeColor = System.Drawing.Color.White;
            this.lMessage.Location = new System.Drawing.Point(12, 9);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(203, 45);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "Choisir date:";
            this.lMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EcranChiffreHebdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projets_BD_Meubles.Properties.Resources.meuble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 214);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lChiffreHebdo);
            this.Controls.Add(this.bCalculer);
            this.Controls.Add(this.dtpChiffreHedbo);
            this.Name = "EcranChiffreHebdo";
            this.Text = "Chiffre d\'affaire hebdomadaire";
            this.Load += new System.EventHandler(this.EcranChiffreHebdo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpChiffreHedbo;
        private System.Windows.Forms.Button bCalculer;
        private System.Windows.Forms.Label lChiffreHebdo;
        private System.Windows.Forms.Label lMessage;
    }
}