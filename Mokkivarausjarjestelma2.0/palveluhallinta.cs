
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma2._0
{
    public partial class palveluhallinta : Form
    {
        public palveluhallinta()
        {
            InitializeComponent();
            populateDGV();
        }

        MySqlConnection connection = new MySqlConnection(
            "datasource=localhost;port=3307;Initial Catalog='vn';username=root;Password=root");

        private void palveluhallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaikkidata.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.kaikkidata.toimintaalue);
            tbAlv.Clear();
            tbHinta.Clear();
            tbKuvaus.Clear();
            tbNimi.Clear();
            
        }

        public void populateDGV()
        {
            //täytetään datagrid datalla
            string query = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgridPalvelut.DataSource = table;

        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }


        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            tbAlv.Clear();
            tbHinta.Clear();
            tbKuvaus.Clear();
            tbNimi.Clear();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            palveluTableAdapter.Delete(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                    int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(tbHinta.Text), double.Parse(tbAlv.Text));
            populateDGV();

            tbAlv.Clear();
            tbHinta.Clear();
            tbKuvaus.Clear();
            tbNimi.Clear();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //vaihdetaan sivulle Lisää
            tabControl1.SelectedIndex = 0;
        }

        private void dgridPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            // palveluID(long), toimalueID(long), Nimi, Tyyppi(int), kuvaus, hinta(double), alv(double)
            //rivivalinta
            lblPalID.Text = dgridPalvelut.CurrentRow.Cells[0].Value.ToString();
            cbToimAlue.Text = dgridPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbNimi.Text = dgridPalvelut.CurrentRow.Cells[2].Value.ToString();
            cbTyyppi.Text = dgridPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgridPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbHinta.Text = dgridPalvelut.CurrentRow.Cells[5].Value.ToString();
            tbAlv.Text = dgridPalvelut.CurrentRow.Cells[6].Value.ToString();
        }

        private void lblHinta_TextChanged(object sender, EventArgs e)
        {
            //TODO tarkista toimiiko oikein
            if (tbHinta.Text != null && tbAlv.Text != null)
            {
                double hinta = double.Parse(tbHinta.Text) * (1 + (int.Parse(tbAlv.Text) / 100));
                lblHinta.Text = hinta.ToString("F");
                lblHinta.Visible = true;
            }
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //uuden rivin lisäys
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            palveluTableAdapter.Insert(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                    int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(tbHinta.Text), double.Parse(tbAlv.Text));
            populateDGV();

            tbAlv.Clear();
            tbHinta.Clear();
            tbKuvaus.Clear();
            tbNimi.Clear();
            lblPalID.Text = "";
            // palveluID(long), toimalueID(long), Nimi, Tyyppi(int), kuvaus, hinta(double), alv(double)
        }
    }
}
