using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void BTgogm_Click(object sender, EventArgs e)
        {
            Fromgm gm = new Fromgm();
            gm.Show();
            this.Hide();
        }
    }
}
