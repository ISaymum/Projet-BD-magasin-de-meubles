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
    public partial class EcranStock : Form
    {
        string sConnexion;
        private DataTable dtStock;
        private BindingSource bsStock;
        public EcranStock()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            dgvStock.Enabled = lPrincipal;
            bAjouter.Enabled = bEditer.Enabled = bSupprimer.Enabled = lPrincipal;
            tbPrix.Enabled = tbSeuil.Enabled = tbQuantite.Enabled = tbSNom.Enabled = !lPrincipal;
            bConfirmer.Enabled = bAnnuler.Enabled = !lPrincipal;
        }

        private void RemplirDGV()
        {
            dtStock = new DataTable();
            dtStock.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtStock.Columns.Add(new DataColumn("Seuil"));
            dtStock.Columns.Add(new DataColumn("Prix"));
            dtStock.Columns.Add(new DataColumn("Quantite"));
            dtStock.Columns.Add(new DataColumn("Nom"));
            List<C_T_Stock> lTmp = new G_T_Stock(sConnexion).Lire("Prix");
            foreach (C_T_Stock p in lTmp)
            {
                dtStock.Rows.Add(p.ID_Stock, p.S_SeuilDeRecommande, p.S_prix, p.S_Quantite, p.S_Nom);
            }

            bsStock = new BindingSource();
            bsStock.DataSource = dtStock;
            dgvStock.DataSource = bsStock;


        }
        private void EcranStock_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvStock.Rows.Count > 0)
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
            tbID.Text = tbPrix.Text = tbQuantite.Text = tbSeuil.Text = "";
            Activer(false);
            tbPrix.Focus();
        }

        private void bEditer_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                tbID.Text = dgvStock.SelectedRows[0].Cells["cID"].Value.ToString();
                C_T_Stock pTmp = new G_T_Stock(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbPrix.Text = pTmp.S_prix.ToString();
                tbSeuil.Text = pTmp.S_SeuilDeRecommande.ToString();
                tbQuantite.Text = pTmp.S_Quantite.ToString();
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvStock.SelectedRows[0].Cells["cID"].Value;
                    new G_T_Stock(sConnexion).Supprimer(iID);
                    bsStock.RemoveCurrent();
                }
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (tbPrix.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le prix");
            }
            else if (tbID.Text == "")
            //Ajout
            {
                int iID = new G_T_Stock(sConnexion).Ajouter(int.Parse(tbSeuil.Text), float.Parse(tbPrix.Text), int.Parse(tbQuantite.Text), tbSNom.Text);
                tbID.Text = iID.ToString();
                dtStock.Rows.Add(iID, tbSeuil.Text, tbPrix.Text, tbQuantite.Text, tbSNom.Text);

            }
            else
            //Modification
            {
                new G_T_Stock(sConnexion).Modifier(int.Parse(tbID.Text), int.Parse(tbSeuil.Text), float.Parse(tbPrix.Text), int.Parse(tbQuantite.Text), tbSNom.Text);
                dgvStock.SelectedRows[0].Cells["cSeuil"].Value = tbSeuil;
                dgvStock.SelectedRows[0].Cells["cPrix"].Value = tbPrix;
                dgvStock.SelectedRows[0].Cells["cQuantite"].Value = tbQuantite;
                dgvStock.SelectedRows[0].Cells["cSNom"].Value = tbQuantite;
                bsStock.EndEdit();

            }
            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bHtml_Click(object sender, EventArgs e)
        {
            EcranStockHTML f = new EcranStockHTML();
            f.ShowDialog();
        }

        private void bDetails_Click(object sender, EventArgs e)
        {
            File.Create("Meubles.txt").Close();
            using (StreamWriter sw = File.AppendText("Meubles.txt"))
            {
                // STOCK
                // Recuprere les ID de la table Stock
                List<C_T_Stock> lTmp = new G_T_Stock(sConnexion).Lire("ID_Stock");

                foreach (C_T_Stock p in lTmp)
                {
                    // Ecrit dans le fichier le veritable nom du meuble
                    sw.WriteLine("Nom meuble : " + p.S_Nom);

                    // DETAILS
                    List<C_T_Details> lTmpMeuble = new G_T_Details(sConnexion).Lire("ID_Details");
                    foreach (C_T_Details m in lTmpMeuble)
                    {
                        //COMMANDE
                        List<C_T_Commande> lTmpCommande = new G_T_Commande(sConnexion).Lire("ID_Commande");
                        foreach (C_T_Commande c in lTmpCommande)
                        {
                            
                             //Recupere les id des clients
                             if (c.ID_Commande==m.ID_Commande && p.ID_Stock==m.ID_Stock)
                             {
                                 C_T_Client lClient = new G_T_Client(sConnexion).Lire_ID(c.ID_Client);


                                 sw.WriteLine("Nom client :  " + lClient.C_Nom);
                                 sw.WriteLine(" ");
                             }

                        }



                    }
                    
                }
                
            }
        }
    }
}
