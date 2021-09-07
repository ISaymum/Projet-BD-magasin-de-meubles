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
    public partial class EcranDetails : Form
    {
        string sConnexion;
        private DataTable dtDetails;
        private BindingSource bsDetails;
        public EcranDetails()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            dgvDetails.Enabled = lPrincipal;
            bAjouter.Enabled = bEditer.Enabled = bSupprimer.Enabled = bFacture.Enabled = bBorderau.Enabled = lPrincipal;
            cbIDCommande.Enabled = cbIDStock.Enabled = tbPrixTotal.Enabled = !lPrincipal;
            bConfirmer.Enabled = bAnnuler.Enabled = !lPrincipal;
        }
        private void RemplirDGV()
        {
            List<C_T_Commande> lTmp1 = new G_T_Commande(sConnexion).Lire("ID_Commande");
            foreach (C_T_Commande c in lTmp1)
            {
                cbIDCommande.Items.Add(c.ID_Commande);
            }
            List<C_T_Stock> lTmp2 = new G_T_Stock(sConnexion).Lire("IDVoiture");
            foreach (C_T_Stock v in lTmp2)
            {
                cbIDStock.Items.Add(v.ID_Stock);
            }
            dtDetails = new DataTable();
            dtDetails.Columns.Add(new DataColumn("ID_Details", Type.GetType("System.Int32")));
            dtDetails.Columns.Add(new DataColumn("ID_Commande", Type.GetType("System.Int32")));
            dtDetails.Columns.Add(new DataColumn("ID_Stock", Type.GetType("System.Int32")));
            dtDetails.Columns.Add(new DataColumn("Prix_Total"));
            
            List<C_T_Details> lTmp3 = new G_T_Details(sConnexion).Lire("ID_Details");
            foreach (C_T_Details t in lTmp3)
            {
                dtDetails.Rows.Add(t.ID_Details,t.ID_Commande,t.ID_Stock,t.D_Prix);
            }
            bsDetails = new BindingSource();
            bsDetails.DataSource = dtDetails;
            dgvDetails.DataSource = bsDetails;
        }
        private void EcranDetails_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvDetails.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbIDDetails.Text = tbPrixTotal.Text = "";
            cbIDCommande.SelectedIndex = cbIDStock.SelectedIndex = -1;
            Activer(false);
            cbIDCommande.Focus();
        }

        private void bEditer_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                tbIDDetails.Text = dgvDetails.SelectedRows[0].Cells["cIDDetails"].Value.ToString();
                C_T_Details pTmp = new G_T_Details(sConnexion).Lire_ID(int.Parse(tbIDDetails.Text));
                cbIDCommande.Text = pTmp.ID_Commande.ToString();
                cbIDStock.Text = pTmp.ID_Stock.ToString();
                tbPrixTotal.Text = pTmp.D_Prix.ToString();
                Activer(false);
            }
            else
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvDetails.SelectedRows[0].Cells["cIDDetails"].Value;
                    new G_T_Details(sConnexion).Supprimer(iID);
                    bsDetails.RemoveCurrent();
                }
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            decimal num;
            bool TestPrix = Decimal.TryParse(tbPrixTotal.Text, out num);

            if (cbIDCommande.Text.Trim() == "" || cbIDCommande.Text.Trim() == "" || tbPrixTotal.Text.Trim() == "")
                MessageBox.Show("Certains enregistrements sont nécessaires, veuillez svp encoder les informations");
            else if (!TestPrix)
                MessageBox.Show("Erreur ! Les caractères encodés ne sont pas autorisés");
            else if (tbIDDetails.Text == "")
            {
                C_T_Stock st = new G_T_Stock(sConnexion).Lire_ID(int.Parse(cbIDStock.Text));
                C_T_Commande cm = new G_T_Commande(sConnexion).Lire_ID(int.Parse(cbIDCommande.Text));
                if(cm.Cm_Quantite>st.S_Quantite)
                {
                    MessageBox.Show("Stock insuffisant");
                    
                }
                else
                {
                
                int iID = new G_T_Details(sConnexion).Ajouter(int.Parse(cbIDCommande.Text), int.Parse(cbIDStock.Text), double.Parse(tbPrixTotal.Text));
                tbIDDetails.Text = iID.ToString();
                dtDetails.Rows.Add(iID, cbIDCommande.Text, cbIDStock.Text, tbPrixTotal.Text);
                    //st.S_Quantite -= cm.Cm_Quantite;
                    new G_T_Stock(sConnexion).Modifier(int.Parse(cbIDStock.Text), st.S_SeuilDeRecommande, st.S_prix, st.S_Quantite - cm.Cm_Quantite, st.S_Nom); 
                }

            }
            else
            {
                new G_T_Details(sConnexion).Modifier(int.Parse(tbIDDetails.Text), int.Parse(cbIDCommande.Text), int.Parse(cbIDStock.Text), double.Parse(tbPrixTotal.Text));
                dgvDetails.SelectedRows[0].Cells["cIDCommande"].Value = cbIDCommande.Text;
                dgvDetails.SelectedRows[0].Cells["cIDStock"].Value = cbIDStock.Text;
                dgvDetails.SelectedRows[0].Cells["cPrixTotal"].Value = double.Parse(tbPrixTotal.Text);
                bsDetails.EndEdit();
            }
           
            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bFacture_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                string id = dgvDetails.SelectedRows[0].Cells["cIDCommande"].Value.ToString();
                string idDetails = dgvDetails.SelectedRows[0].Cells["cIDDetails"].Value.ToString();
                string chemin = "Facture-";
                C_T_Commande pTmp = new G_T_Commande(sConnexion).Lire_ID(int.Parse(id));
                C_T_Client client = new G_T_Client(sConnexion).Lire_ID(pTmp.ID_Client);                
                C_T_Details details = new G_T_Details(sConnexion).Lire_ID(int.Parse(idDetails));
                C_T_Stock stk = new G_T_Stock(sConnexion).Lire_ID(details.ID_Stock);
                if (!File.Exists(chemin + id + ".txt"))
                {
                    File.Create(chemin + id + ".txt").Close();
                    using (StreamWriter sw = File.AppendText(chemin + id + ".txt"))
                    {
                        sw.WriteLine("***************FACTURE*****************");
                        sw.WriteLine("\n        Numéro de facture       :    " + id);
                        sw.WriteLine("\n        Article                 :    " + stk.S_Nom);
                        sw.WriteLine("\n        Quantité                :    " + pTmp.Cm_Quantite);
                        sw.WriteLine("\n        Prix                    :    " + details.D_Prix.ToString()+ " €");
                        sw.WriteLine("\n        Date d' achat           :    " + pTmp.Cm_Date.Date.ToString("d"));
                        sw.WriteLine("\n        Nom                     :    " + client.C_Nom);
                        sw.WriteLine("\n        Prénom                  :    " + client.C_Prenom);
                        sw.WriteLine("\n*************************************");
                    }
                }
                else
                {
                    File.WriteAllText(chemin + id + ".txt", String.Empty);
                    using (StreamWriter sw = File.AppendText(chemin + id + ".txt"))
                    {
                        sw.WriteLine("***************FACTURE*****************");
                        sw.WriteLine("\n        Numéro de facture       :    " + id);
                        sw.WriteLine("\n        Article                 :    " + stk.S_Nom);
                        sw.WriteLine("\n        Quantité                :    " + pTmp.Cm_Quantite);
                        sw.WriteLine("\n        Prix                    :    " + details.D_Prix.ToString() + " €");
                        sw.WriteLine("\n        Date d' achat           :    " + pTmp.Cm_Date.Date.ToString("d"));
                        sw.WriteLine("\n        Nom                     :    " + client.C_Nom);
                        sw.WriteLine("\n        Prénom                  :    " + client.C_Prenom);
                        sw.WriteLine("\n*************************************");
                    }
                }
                Process.Start(chemin + id + ".txt");
            }
            else
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        private void bBorderau_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                string id = dgvDetails.SelectedRows[0].Cells["cIDCommande"].Value.ToString();
                string idDetails = dgvDetails.SelectedRows[0].Cells["cIDDetails"].Value.ToString();
                string chemin = "Bordereau-";
                C_T_Commande pTmp = new G_T_Commande(sConnexion).Lire_ID(int.Parse(id));
                C_T_Client client = new G_T_Client(sConnexion).Lire_ID(pTmp.ID_Client);
                C_T_Fournisseur fournisseur = new G_T_Fournisseur(sConnexion).Lire_ID(pTmp.ID_Fournisseur);
                C_T_Details details = new G_T_Details(sConnexion).Lire_ID(int.Parse(idDetails));
                C_T_Stock stk = new G_T_Stock(sConnexion).Lire_ID(details.ID_Stock);
                if (!File.Exists(chemin + id + ".txt"))
                {
                    File.Create(chemin + id + ".txt").Close();
                    using (StreamWriter sw = File.AppendText(chemin + id + ".txt"))
                    {
                        sw.WriteLine("***********BORDEREAU*******************");
                        sw.WriteLine("\n        Numéro de bordereau     :    " + id);
                        sw.WriteLine("\n        Article                 :    " + stk.S_Nom);
                        sw.WriteLine("\n        Quantité                :    " + pTmp.Cm_Quantite);
                        sw.WriteLine("\n        Prix unitaire           :    " + stk.S_prix+ " €");
                        sw.WriteLine("\n        Prix total              :    " + (stk.S_prix*pTmp.Cm_Quantite)+ " €");
                        sw.WriteLine("\n        Date d' achat           :    " + pTmp.Cm_Date.Date.ToString("d"));
                        sw.WriteLine("\n        Nom                     :    " + client.C_Nom);
                        sw.WriteLine("\n        Prénom                  :    " + client.C_Prenom);
                        sw.WriteLine("\n        Fournisseur             :    " + fournisseur.F_Nom);
                        sw.WriteLine("\n*************************************");
                    }
                }
                else
                {
                    File.WriteAllText(chemin + id + ".txt", String.Empty);
                    using (StreamWriter sw = File.AppendText(chemin + id + ".txt"))
                    {
                        sw.WriteLine("***********BORDEREAU*******************");
                        sw.WriteLine("\n        Numéro de bordereau     :    " + id);
                        sw.WriteLine("\n        Article                 :    " + stk.S_Nom);
                        sw.WriteLine("\n        Quantité                :    " + pTmp.Cm_Quantite);
                        sw.WriteLine("\n        Prix unitaire           :    " + stk.S_prix + " €");
                        sw.WriteLine("\n        Prix total              :    " + (stk.S_prix * pTmp.Cm_Quantite) + " €");
                        sw.WriteLine("\n        Date d' achat           :    " + pTmp.Cm_Date.Date.ToString("d"));
                        sw.WriteLine("\n        Nom                     :    " + client.C_Nom);
                        sw.WriteLine("\n        Prénom                  :    " + client.C_Prenom);
                        sw.WriteLine("\n        Fournisseur             :    " + fournisseur.F_Nom);
                        sw.WriteLine("\n*************************************");
                    }
                }
                Process.Start(chemin + id + ".txt");
            }
            else
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }
    }
}
