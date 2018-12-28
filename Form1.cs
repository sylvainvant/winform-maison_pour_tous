using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
// 
namespace maison_pour_tous
{
    public partial class Form1 : Form
    {
        DataTable Aff = new DataTable();
        DataTable adhff = new DataTable();
        int chx, chx1;
        MySqlConnection toto = new MySqlConnection("SERVER=127.0.0.1 ; DATABASE=maisonpourtous ; UID=root ; pwd=");
        public Form1()
        {
            InitializeComponent();
            toto.Open();
            Representation affrep = new Representation();
            affrep.afficher( Aff);
            for (int i=0; i< Aff.Rows.Count;i++)
            {
                repreBox.Items.Add("Date: "+Aff.Rows[i][1].ToString() + " Spectacle: "+ Aff.Rows[i][3].ToString() +" Tarif/pers: "+ Aff.Rows[i][2].ToString());
            }
            Adherent affadh = new Adherent();
            affadh.afficher(adhff);
            for (int j = 0; j < adhff.Rows.Count; j++)
            {
                adherentBox.Items.Add("Nom: " + adhff.Rows[j][1].ToString() + " Prénom: " + adhff.Rows[j][2].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string numrepr;
        int tot;
        private void repreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chx = repreBox.SelectedIndex;
            numrepr = Aff.Rows[chx][0].ToString();
            int tarif = Convert.ToInt32(Aff.Rows[chx][2].ToString());
            try
            {
                tot = (Convert.ToInt32(nbBox.Text));
            }
            catch (Exception)
            { MessageBox.Show("Saisissez une valeur numérique pour le nb de personne"); }
            int toto = tarif * tot;
            totoBox.Text = toto.ToString() ;
        }

        private void nbBox_TextChanged(object sender, EventArgs e)
        {
            chx = repreBox.SelectedIndex;
            numrepr = Aff.Rows[chx][0].ToString();
            int tarif = Convert.ToInt32(Aff.Rows[chx][2].ToString());

            try
            {
                tot = (Convert.ToInt32(nbBox.Text));
            }
            catch (Exception)
            { MessageBox.Show("Saisissez une valeur numérique pour le nb de personne"); }

            int totoo = tarif * tot;
            totoBox.Text = totoo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chx1 = adherentBox.SelectedIndex;
            string numAdh = adhff.Rows[chx1][0].ToString();
            string resa = "INSERT INTO reservation (NUMADHERENT,NUMREPRESENTATION,NBPERSONNES,DATERESA) VALUES ('" + numAdh + "','" + numrepr + "','" + nbBox.Text + "',CURDATE())";
            MySqlCommand res = new MySqlCommand(resa, toto);
            res.ExecuteNonQuery();
            res.Dispose();
            MessageBox.Show("Votre réservation est validée.");
            toto.Close();
            }

     
        }

    } 

