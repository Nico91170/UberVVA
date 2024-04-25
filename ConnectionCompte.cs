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

namespace UberVVA
{
    public partial class FormConn : System.Windows.Forms.Form
    {
        public FormConn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("server=localhost; database=foodmaps; user id=root; pwd=");

            try
            {
                connexion.Open();
                string Query = "SELECT * FROM user WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(Query, connexion);
                cmd.Parameters.AddWithValue("@username", txtuser.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtpwd.Text.Trim());

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["role"].ToString();

                    if (role == "Administrateur")
                    {
                        AcceuilG AG = new AcceuilG();
                        AG.Show();
                        this.Hide();
                    }
                    if (role == "Vacancier")
                    {
                        SelectionMenu SM = new SelectionMenu();
                        SM.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Les identifiants sont incorrects.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreationCompte CC = new CreationCompte();
            CC.Show();
            this.Hide();
        }
    }
}
