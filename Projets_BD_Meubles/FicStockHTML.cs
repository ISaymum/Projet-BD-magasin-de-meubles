using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Projet_BDMeubles.Classes;
using Projet_BDMeubles.Gestion;
using System.IO;


namespace Projets_BD_Meubles
{
    public partial class EcranStockHTML : Form
    {
        string sConnexion;
        private DataTable dtStock;
        private BindingSource bsStock;
        public EcranStockHTML()
        {
            InitializeComponent();
        }

        private void RemplirDT()
        {
            int Vente, Achat;
            dtStock = new DataTable();
            dtStock.Columns.Add(new DataColumn("ID_Stock", System.Type.GetType("System.Int32")));
            dtStock.Columns.Add(new DataColumn("S_SeuilDeRecommande"));
            dtStock.Columns.Add(new DataColumn("S_Prix"));
            dtStock.Columns.Add(new DataColumn("S_Quantite"));
            dtStock.Columns.Add(new DataColumn("S_Nom"));
            List<C_T_Stock> lTmp = new G_T_Stock(sConnexion).Lire("ID_Stock");
            foreach (C_T_Stock s in lTmp)
            {
                    dtStock.Rows.Add(s.ID_Stock,s.S_SeuilDeRecommande,s.S_prix,s.S_Quantite,s.S_Nom);
                
            }
            bsStock = new BindingSource();
            bsStock.DataSource = dtStock;
        }
        private void EcranStockHTML_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDT();
            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<html>");
            strHTMLBuilder.Append("<head>");
            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");
            strHTMLBuilder.Append("<h2 style='text-align:center ; background - color:Green;color: pink;font-family:arial; '>Article disponible en stock</h1>");
            //strHTMLBuilder.Append("<h1 style='text-align:center ; style='color: blue';font-family:arial; '>voiture </h1>");
            strHTMLBuilder.Append("<table align='center' border='3px' cellpadding='5' cellspacing='1' bgcolor='Blue'style='color:white; border: 1px solid #ccc;font-size: 12pt;font-family:arial'>");
            strHTMLBuilder.Append("<tr>");
            foreach (DataColumn myColumn in dtStock.Columns)
            {
                strHTMLBuilder.Append("<td >");
                strHTMLBuilder.Append(myColumn.ColumnName);
                strHTMLBuilder.Append("</td>");

            }
            strHTMLBuilder.Append("</tr>");


            foreach (DataRow myRow in dtStock.Rows)
            {
                strHTMLBuilder.Append("<tr >");
                foreach (DataColumn myColumn in dtStock.Columns)
                {
                    strHTMLBuilder.Append("<td >");
                    strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());
                    strHTMLBuilder.Append("</td>");

                }
                strHTMLBuilder.Append("</tr>");
            }
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");
            string Htmltext = strHTMLBuilder.ToString();
            File.WriteAllText(@"C:\Users\Saymum Islam\Documents\HEL Bloc2 Q2\Programmation evenementielle\Progra_evenmentielle\Projets_BD_Meubles\Projets_BD_Meubles\bin\Debug\Stock.HTML", Htmltext);
            this.wbStockHTML.Navigate(@"C:\Users\Saymum Islam\Documents\HEL Bloc2 Q2\Programmation evenementielle\Progra_evenmentielle\Projets_BD_Meubles\Projets_BD_Meubles\bin\Debug\Stock.HTML");
        }
    }
}
