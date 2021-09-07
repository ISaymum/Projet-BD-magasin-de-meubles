
namespace Projets_BD_Meubles
{
    partial class EcranStockHTML
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
            this.wbStockHTML = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbStockHTML
            // 
            this.wbStockHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbStockHTML.Location = new System.Drawing.Point(0, 0);
            this.wbStockHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbStockHTML.Name = "wbStockHTML";
            this.wbStockHTML.Size = new System.Drawing.Size(800, 450);
            this.wbStockHTML.TabIndex = 0;
            // 
            // EcranStockHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbStockHTML);
            this.Name = "EcranStockHTML";
            this.Text = "Stock HTML";
            this.Load += new System.EventHandler(this.EcranStockHTML_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbStockHTML;
    }
}