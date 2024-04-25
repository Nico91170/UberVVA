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
            MySqlConnection connexion = new MySqlConnection("database = foodmaps; server=localhost; user id=root; pwd=");


            try
            {
                connexion.Open();
                string Query = "select * FROM user WHERE username='" + txtuser.Text.Trim() + "'AND password='" + txtpwd.Text.Trim() + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, connexion);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SelectionMenu dr = new SelectionMenu();
                    dr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les identifiants sont faux");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
