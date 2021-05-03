using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma
{
    public partial class Mokinluonti : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog=vn;username=root;Password=root");
        MySqlCommand command;

        public Mokinluonti()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);
            populateDGV();
        }
        public void populateDGV()
        {
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvMokit.DataSource = table;
        }



    }
}
