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
    public partial class EcranClient : Form
    {
        
        string sConnexion;
        private DataTable dtClient;
        private BindingSource bsClient;
        public EcranClient()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            dgvClients.Enabled = lPrincipal;
            bAjouter.Enabled = bEditer.Enabled = bSupprimer.Enabled = lPrincipal;
            tbPre.Enabled = tbNom.Enabled = !lPrincipal;
            bConfirmer.Enabled = bAnnuler.Enabled = !lPrincipal;
        }
        private void RemplirDGV()
        {
            dtClient = new DataTable();
            //Nombre de colonnes
            dtClient.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtClient.Columns.Add(new DataColumn("Afficher"));
            dtClient.Columns.Add(new DataColumn("AfficherN"));
            //Nombre de lignes
           List<C_T_Client> lTmp = new G_T_Client(sConnexion).Lire("C_Nom");
            foreach(C_T_Client c in lTmp)
            {
                dtClient.Rows.Add(c.ID_Client, c.C_Prenom, c.C_Nom);
            }
            bsClient = new BindingSource();
            bsClient.DataSource = dtClient;
            dgvClients.DataSource = bsClient;
        }
        private void EcranClient_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvClients.Rows.Count > 0)
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
            tbID.Text = tbPre.Text = tbNom.Text = "";
            Activer(false);
            tbPre.Focus();
        }

        private void bEditer_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                tbID.Text = dgvClients.SelectedRows[0].Cells["cID"].Value.ToString();
                C_T_Client pTmp = new G_T_Client(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbPre.Text = pTmp.C_Prenom;
                tbNom.Text = pTmp.C_Nom;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvClients.SelectedRows[0].Cells["cID"].Value;
                    new G_T_Client(sConnexion).Supprimer(iID);
                    bsClient.RemoveCurrent();
                }
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le nom");
            }
            else if (tbID.Text == "")
            //Ajout
            {
                int iID = new G_T_Client(sConnexion).Ajouter(tbNom.Text, tbPre.Text);
                tbID.Text = iID.ToString();
                dtClient.Rows.Add(iID, tbPre.Text,tbNom.Text);

            }
            else
            //Modification
            {
                new G_T_Client(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text, tbPre.Text);
                dgvClients.SelectedRows[0].Cells["cAffiche"].Value = tbPre.Text;
                dgvClients.SelectedRows[0].Cells["cAfficheN"].Value = tbNom.Text;
                bsClient.EndEdit();

            }
            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

    }
}
