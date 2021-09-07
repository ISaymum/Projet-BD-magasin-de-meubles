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
    public partial class EcranFournisseur : Form
    {
        string sConnexion;
        private DataTable dtFournisseur;
        private BindingSource bsFournisseur;
        public EcranFournisseur()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            dgvFournisseur.Enabled = lPrincipal;
            bAjouter.Enabled = bEditer.Enabled = bSupprimer.Enabled = lPrincipal;
            tbNom.Enabled = !lPrincipal;
            bConfirmer.Enabled = bAnnuler.Enabled = !lPrincipal;
        }
        private void RemplirDGV()
        {
            dtFournisseur = new DataTable();
            dtFournisseur.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtFournisseur.Columns.Add(new DataColumn("Afficher"));
            List<C_T_Fournisseur> lTmp = new G_T_Fournisseur(sConnexion).Lire("F_Nom");
            foreach (C_T_Fournisseur p in lTmp)
            {
                dtFournisseur.Rows.Add(p.ID_Fournisseur, p.F_Nom);
            }
            bsFournisseur = new BindingSource();
            bsFournisseur.DataSource = dtFournisseur;
            dgvFournisseur.DataSource = bsFournisseur;
        }

        private void EcranFournisseur_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvFournisseur.Rows.Count > 0)
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
            tbID.Text = tbNom.Text = "";
            Activer(false);
            tbNom.Focus();
        }

        private void bEditer_Click(object sender, EventArgs e)
        {
            if (dgvFournisseur.SelectedRows.Count > 0)
            {
                tbID.Text = dgvFournisseur.SelectedRows[0].Cells["cID"].Value.ToString();
                C_T_Fournisseur pTmp = new G_T_Fournisseur(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbNom.Text = pTmp.F_Nom;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvFournisseur.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvFournisseur.SelectedRows[0].Cells["cID"].Value;
                    new G_T_Fournisseur(sConnexion).Supprimer(iID);
                    bsFournisseur.RemoveCurrent();
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
                int iID = new G_T_Fournisseur(sConnexion).Ajouter(tbNom.Text);
                tbID.Text = iID.ToString();
                dtFournisseur.Rows.Add(iID, tbNom.Text);

            }
            else
            //Modification
            {
                new G_T_Fournisseur(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text);
                dgvFournisseur.SelectedRows[0].Cells["cAfficher"].Value = tbNom.Text;
                bsFournisseur.EndEdit();

            }
            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

    }
}
