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
        public SelectionMenu(string str_value)
        {
            InitializeComponent();
            TBnameNourriture.Text = str_value;
        }
    }
}