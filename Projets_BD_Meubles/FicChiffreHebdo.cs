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
    public partial class EcranChiffreHebdo : Form
    {
        string sConnexion;
        public EcranChiffreHebdo()
        {
            InitializeComponent();
        }

        private void EcranChiffreHebdo_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projets_BD_Meubles.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            dtpChiffreHedbo.Value = DateTime.Today.AddDays(-7);
        }
        private void bCalculer_Click(object sender, EventArgs e)
        {
            DateTime cmp = dtpChiffreHedbo.Value;
            double chiffre = 0;
            
            List<C_T_Details> lTmp1 = new G_T_Details(sConnexion).Lire("ID_Details");
            foreach (C_T_Details t in lTmp1)
            {
                List<C_T_Commande> lTmp2 = new G_T_Commande(sConnexion).Lire("ID_Commande");
                foreach (C_T_Commande d in lTmp2)
                {

                    for (int i = 0; i < 7; i++)
                    {
                        if (d.Cm_Date.Date == cmp.AddDays(i).Date)
                        {
                            chiffre = chiffre + t.D_Prix;
                        }
                    }
                }
                
            }
            
            lChiffreHebdo.Text = chiffre.ToString(".##") + " €";
            lChiffreHebdo.TextAlign = ContentAlignment.MiddleCenter;
        }

    }
}
