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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace UberVVA
{
    public partial class FromajtMenu : Form
    {
        public FromajtMenu()
        {
            InitializeComponent();
        }

        private void Fromgm_Load(object sender, EventArgs e)
        {

        }


        private void linkLbackmenus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AcceuilG ag = new AcceuilG();
            ag.Show();
            this.Hide();
        }

        private void labelTitlegm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBnameAM.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void BTvalidergm_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=foodmaps; user id=root; pwd=";
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            { 
                connexion.Open();
                string insertQuery = "INSERT INTO menu (NomN, Description, Prix, Type) VALUES (@NomN, @Description, @Prix, @Type)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connexion))
                {
                    //On ajoute les valeurs des champs du formulaire dans la base de données
                    cmd.Parameters.AddWithValue("@NomN", TBnameAM.Text);
                    cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Prix", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Type", comboBox1.Text);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Le menu a été ajouté");
                    }

                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'ajout du menu");
                    }
                }
            }
        }

        private void TBnameAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
