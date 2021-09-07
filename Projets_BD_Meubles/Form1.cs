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

namespace Projets_BD_Meubles
{
    public partial class EcranAcceuil : Form
    {
        string sConnexion;
        private DataTable dtClient;
        private BindingSource bsClient;
        private DataTable dtStock;
        private BindingSource bsStock;
        private DataTable dtFournisseur;
        private BindingSource bsFournisseur;

        public EcranAcceuil()
        {
            InitializeComponent();
        }
        private void RemplirDGV()
        {
            //-------------------------------------------------------------------
            dtClient = new DataTable();
            //Nombre de colonnes
            dtClient.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtClient.Columns.Add(new DataColumn("Afficher"));
            dtClient.Columns.Add(new DataColumn("AfficherN"));
            //Nombre de lignes
            List<C_T_Client> lTmp = new G_T_Client(sConnexion).Lire("C_Nom");
            foreach (C_T_Client c in lTmp)
            {
                dtClient.Rows.Add(c.ID_Client, c.C_Prenom, c.C_Nom);
            }
            bsClient = new BindingSource();
            bsClient.DataSource = dtClient;
            dgvClient.DataSource = bsClient;
            //--------------------------------------------------------------------
            dtStock = new DataTable();
            dtStock.Columns.Add(new DataColumn("ID_Stock", System.Type.GetType("System.Int32")));
            dtStock.Columns.Add(new DataColumn("S_Seuil"));
            dtStock.Columns.Add(new DataColumn("S_prix"));
            dtStock.Columns.Add(new DataColumn("S_Quantite"));
            dtStock.Columns.Add(new DataColumn("S_Nom"));
            List<C_T_Stock> lTmp1 = new G_T_Stock(sConnexion).Lire("S_prix");
            foreach (C_T_Stock p in lTmp1)
            {
                dtStock.Rows.Add(p.ID_Stock, p.S_SeuilDeRecommande, p.S_prix, p.S_Quantite, p.S_Nom);
            }

            bsStock = new BindingSource();
            bsStock.DataSource = dtStock;
            dgvStock.DataSource = bsStock;
            //-------------------------------------------------------------------
            dtFournisseur = new DataTable();
            dtFournisseur.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtFournisseur.Columns.Add(new DataColumn("Nom"));
            List<C_T_Fournisseur> lTmp2 = new G_T_Fournisseur(sConnexion).Lire("Nom");
            foreach (C_T_Fournisseur p in lTmp2)
            {
                dtFournisseur.Rows.Add(p.ID_Fournisseur, p.F_Nom);
            }
            bsFournisseur = new BindingSource();
            bsFournisseur.DataSource = dtFournisseur;
            dgvFournisseur.DataSource = bsFournisseur;
        }
        private void EcranAcceuil_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
        }

        private void bClients_Click(object sender, EventArgs e)
        {
            EcranClient f = new EcranClient();
            f.ShowDialog();
        }

        private void bCommande_Click(object sender, EventArgs e)
        {
            EcranCommande f = new EcranCommande();
            f.ShowDialog();
        }

        private void bDetails_Click(object sender, EventArgs e)
        {
            EcranDetails f = new EcranDetails();
            f.ShowDialog();
        }

        private void bStock_Click(object sender, EventArgs e)
        {
            EcranStock f = new EcranStock();
            f.ShowDialog();
        }

        private void bFournisseur_Click(object sender, EventArgs e)
        {
            EcranFournisseur f = new EcranFournisseur();
            f.ShowDialog();
        }

        private void bChiffreHebdo_Click(object sender, EventArgs e)
        {
            EcranChiffreHebdo f = new EcranChiffreHebdo();
            f.ShowDialog();
        }

    }
}
