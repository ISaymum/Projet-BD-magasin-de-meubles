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
using System.Diagnostics;

namespace Projets_BD_Meubles
{
    public partial class EcranCommande : Form
    {
        string sConnexion;
        private DataTable dtCommande; //dtClient, dtFournisseur;
        private BindingSource bsCommande; //bsClient, bsFournisseur;
        public EcranCommande()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            dgvCommandes.Enabled = lPrincipal;
            bAjouter.Enabled = bEditer.Enabled = bSupprimer.Enabled = lPrincipal;
            dtpDateCommande.Enabled = tbQuantite.Enabled =cbIDClient.Enabled=cbIDFournisseur.Enabled= !lPrincipal;
            bConfirmer.Enabled = bAnnuler.Enabled = !lPrincipal;
        }
        private void RemplirDGV()
        {
            
            List<C_T_Client> lTmp1 = new G_T_Client(sConnexion).Lire("ID_Client");
            foreach (C_T_Client c in lTmp1)
            {
                cbIDClient.Items.Add(c.ID_Client);
            }

            List<C_T_Fournisseur> lTmp2 = new G_T_Fournisseur(sConnexion).Lire("ID_Fournisseur");
            foreach (C_T_Fournisseur f in lTmp2)
            {
                cbIDFournisseur.Items.Add(f.ID_Fournisseur);
            }

            dtCommande = new DataTable();
            dtCommande.Columns.Add(new DataColumn("ID_Commande", System.Type.GetType("System.Int32")));
            dtCommande.Columns.Add(new DataColumn("Quantite"));
            dtCommande.Columns.Add(new DataColumn("Date_Commande"));
            dtCommande.Columns.Add(new DataColumn("ID_Client", System.Type.GetType("System.Int32")));
            dtCommande.Columns.Add(new DataColumn("ID_Fournisseur", System.Type.GetType("System.Int32")));
            List<C_T_Commande> lTmp = new G_T_Commande(sConnexion).Lire("Quantite");          
            foreach (C_T_Commande p in lTmp)
            {
                dtCommande.Rows.Add(p.ID_Commande, p.Cm_Quantite, p.Cm_Date.ToString("d"), p.ID_Client, p.ID_Fournisseur);
            }

            


            bsCommande = new BindingSource();
            bsCommande.DataSource = dtCommande;
            dgvCommandes.DataSource = bsCommande;
        }
        private void EcranCommande_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvCommandes.Rows.Count > 0)
            {
                Activer(true);
            }
            else
            {
                Activer(false);
            }
        }
        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbID_Commande.Text = tbQuantite.Text = "";
            cbIDClient.SelectedIndex = cbIDFournisseur.SelectedIndex = -1;
            dtpDateCommande.Value = DateTime.Today;
            Activer(false);
            tbQuantite.Focus();
        }


        private void bEditer_Click(object sender, EventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                tbID_Commande.Text = dgvCommandes.SelectedRows[0].Cells["cIDCommandes"].Value.ToString();
                C_T_Commande pTmp = new G_T_Commande(sConnexion).Lire_ID(int.Parse(tbID_Commande.Text));
                cbIDClient.Text = pTmp.ID_Client.ToString();
                cbIDFournisseur.Text = pTmp.ID_Fournisseur.ToString();
                tbQuantite.Text = pTmp.Cm_Quantite.ToString();
                dtpDateCommande.Value = pTmp.Cm_Date == null ? DateTime.Today : (DateTime)pTmp.Cm_Date;
                Activer(false);
            }
            else
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvCommandes.SelectedRows[0].Cells["cIDCommandes"].Value;
                    new G_T_Commande(sConnexion).Supprimer(iID);
                    bsCommande.RemoveCurrent();
                }
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            decimal num;
            

            if (cbIDClient.Text.Trim() == "" || cbIDFournisseur.Text.Trim() == "" || tbQuantite.Text.Trim() == "" )
                MessageBox.Show("Certains enregistrements sont nécessaires, veuillez svp encoder les informations");
            
            else if (tbID_Commande.Text == "")
            {
                int iID = new G_T_Commande(sConnexion).Ajouter(int.Parse(tbQuantite.Text),dtpDateCommande.Value,int.Parse(cbIDClient.Text),int.Parse(cbIDFournisseur.Text));
                tbID_Commande.Text = iID.ToString();
                dtCommande.Rows.Add(iID, tbQuantite.Text, dtpDateCommande.Value.Date.ToString("d"), int.Parse(cbIDClient.Text), int.Parse(cbIDFournisseur.Text));

            }
            else
            {
                new G_T_Commande(sConnexion).Modifier(int.Parse(tbID_Commande.Text),int.Parse(tbQuantite.Text), dtpDateCommande.Value, int.Parse(cbIDClient.Text), int.Parse(cbIDFournisseur.Text));
                dgvCommandes.SelectedRows[0].Cells["cQuantite"].Value = int.Parse(tbQuantite.Text);
                dgvCommandes.SelectedRows[0].Cells["cDate"].Value = dtpDateCommande.Value.Date.ToString("d");
                dgvCommandes.SelectedRows[0].Cells["cIDClient"].Value = cbIDClient.Text;
                dgvCommandes.SelectedRows[0].Cells["cIDFournisseur"].Value = cbIDFournisseur.Text;
                bsCommande.EndEdit();
            }
            /*
            List<C_T_Commande> lTmp = new G_T_Commande(sConnexion).Lire("Quantite");
            List<C_T_Details> lTmpD = new G_T_Details(sConnexion).Lire("ID_Details");
            foreach (C_T_Commande v in lTmp)
            {

                foreach (C_T_Details t in lTmpD)
                {
                    if (v.ID_Commande == t.ID_Commande)
                    {
                        C_T_Stock stk = new G_T_Stock(sConnexion).Lire_ID(t.ID_Stock);
                        if (v.Cm_Quantite > stk.S_Quantite)
                        {
                            MessageBox.Show("Stock insuffisant");
                        }
                        else
                        {
                            stk.S_Quantite -= v.Cm_Quantite;
                        }
                        if (stk.S_Quantite <= stk.S_SeuilDeRecommande)
                        {
                            MessageBox.Show("Remettre en stock cette article : " + stk.ID_Stock);
                        }
                    }
                }

            }
            */
            Activer(true);
        }


        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
       
    }
}
