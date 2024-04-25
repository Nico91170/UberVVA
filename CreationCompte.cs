using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UberVVA
{
    public partial class CreationCompte : Form
    {
        public CreationCompte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void valid_Click(object sender, EventArgs e)
        {
            
        }
    

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        FormConn CO = new FormConn();
            CO.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=foodmaps; user id=root; pwd=";
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string insertQuery = "INSERT INTO user (nom, prenom, username, password, role) VALUES (@nom, @prenom, @username, @password, @role)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connexion))
                {
                    cmd.Parameters.AddWithValue("@nom", name.Text);
                    cmd.Parameters.AddWithValue("@prenom", name2.Text);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@role", role.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Votre compte est créé");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la création du compte");
                    }
                }
            }
        }
    }
}
