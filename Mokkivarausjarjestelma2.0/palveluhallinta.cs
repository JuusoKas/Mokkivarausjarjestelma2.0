using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace Mokkivarausjarjestelma
{
    public partial class palvelu2 : Form
    {
        public palvelu2()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new
            MySqlConnection("datasource=localhost;Initial Catalog=vp;" +
            "username=root;Password=root");

        private void palvelu2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'palvelut.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.palvelut.palvelu);
            lisaaTiedot();
        }

        public void lisaaTiedot()
        {

            string query = "SELECT * FROM palvelu ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter(query, connection);
            adapteri.Fill(table);
            dgridPalvelut.DataSource = table;




        }

        private void btnLisaaUusi2_Click(object sender, EventArgs e)
        {

        }
    }
}
