using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberVVA
{

    public partial class SelectionMenu : Form
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void LbAffichageMenus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTafficherMenu_Click(object sender, EventArgs e)
        {
            // 1. On crée une connexion à la base de données
            string connectionString = "server=localhost; database=foodmaps; user id=root; pwd=";
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                // 2. On ouvre la connexion
                connexion.Open();
                // 3. On crée une requête SQL pour sélectionner tous les éléments de la table menu
                string selectQuery = "SELECT * FROM menu";
                // 4. On exécute la requête
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connexion))
                {
                    // 5. On lit les résultats de la requête
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 6. On ajoute les résultats à la listebox
                            LbAffichageMenus.Items.Add(reader["NomN"].ToString() + " / " + reader["Description"].ToString() + " / " + reader["Prix"].ToString() + " / " + reader["Type"].ToString());
                        }
                    }
                }
            }
        }

        private void SelectionMenu_Load(object sender, EventArgs e)
        {

        }
    }
}