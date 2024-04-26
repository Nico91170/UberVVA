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
    public partial class GestionCompte : Form
    {
        public GestionCompte()
        {
            InitializeComponent();


        }
        String cs = @"server=localhost;userid=root;pwd=;database=foodmaps";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string reqI;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxuser_SelectedIndexChanged(object sender, EventArgs e)
        {



            user u = (user)listBoxuser.SelectedItem;
            if (u != null)
            {
                textBox1.Text = u.Getnom();
                textBox2.Text = u.Getprenom();
                textBox3.Text = u.Getrole();
                textBox4.Text = u.Getusername();
                textBox5.Text = u.Getpwd();


            }




        }

        private void FormLaPatisserie_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AcceuilG().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nom = Convert.ToString(textBox1.Text);
            string prenom = Convert.ToString(textBox2.Text);
            string role = Convert.ToString(textBox3.Text);
            string username = Convert.ToString(textBox4.Text);
            string pwd = Convert.ToString(textBox5.Text);
            user u = new user(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            ClassMenu.AjoutUser(u);
            listBoxuser.Items.Add(u);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void buttonSuppr_Click(object sender, EventArgs e)
        {
            user u = (user)listBoxuser.SelectedItem;
            ClassMenu.supprimeruser(u);
            listBoxuser.Items.Remove(u);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            user u = (user)listBoxuser.SelectedItem;
            ClassMenu.supprimeruser(u);
            listBoxuser.Items.Remove(u);
            ClassMenu.AjoutUser(u);
            listBoxuser.Items.Add(u);
            u.Setnom(textBox1.Text);
            u.Setprenom(textBox2.Text);
            u.Setrole(textBox3.Text);
            u.Setusername(textBox4.Text);
            u.Setpwd(textBox5.Text);

        }

        private void buttonReafficher_Click(object sender, EventArgs e)
        {



            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            string role = textBox3.Text;
            string username = textBox4.Text;
            string pwd = textBox5.Text;





            user u = new user(nom, prenom, role, username, pwd);
            listBoxuser.Items.Remove(u);
            listBoxuser.Items.Add(u);



        }

        private void Affichage_Click(object sender, EventArgs e)
        {
            listBoxuser.Items.Clear();
            List<user> listeU = ClassMenu.GetTousLesuser();
            listBoxuser.Items.AddRange(listeU.ToArray());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listboxMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=foodmaps; user id=root; pwd=";
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();
                string selectQuery = "SELECT * FROM user";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connexion))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxuser.Items.Add(reader["nom"].ToString() + " / " + reader["prenom"].ToString() + " / " + reader["role"].ToString() + " / " + reader["username"].ToString() + "/" + reader["password"].ToString());
                        }
                    }
                }
            }
        }
    }
}
