
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

       private MySqlConnection connection = new MySqlConnection(
            "datasource=localhost;port=3307;Initial Catalog='vn';username=root;Password=root");

        private string queryPalvelu = "SELECT * FROM palvelu";

        
        private void palveluhallinta_Load(object sender, EventArgs e)
        {
            // toiminta-alueen datan tuonti
            this.toimintaalueTableAdapter.Fill(this.kaikkidata.toimintaalue);
            numAlv.ResetText();
            numHinta.ResetText();
            tbKuvaus.Clear();
            tbNimi.Clear();
            lblPalID.Text = cbTyyppi.Text;
            lblPalID.Visible = true;

            //täytetään tyyppi-combobox
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(queryPalvelu, connection);
            DataSet dscombo = new DataSet();
            adapter2.Fill(dscombo, "palvelu");
            cbTyyppi.DisplayMember = "tyyppi";
            cbTyyppi.DataSource = dscombo.Tables["palvelu"];

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
            numAlv.ResetText();
            numHinta.ResetText();
            tbKuvaus.Clear();
            tbNimi.Clear();
            lblHinta.Text = "";
            lblPalID.Text = "";
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            palveluTableAdapter.Delete(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                    int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(numHinta.Text), double.Parse(numAlv.Text));
            populateDGV();

            numAlv.ResetText();
            numHinta.ResetText();
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
            numHinta.Text = dgridPalvelut.CurrentRow.Cells[5].Value.ToString();
            numAlv.Text = dgridPalvelut.CurrentRow.Cells[6].Value.ToString();
        }
        /*
        private void lblHinta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (numHinta.Text.Length > 0 && numAlv.Text.Length > 0)
                {
                    double hinta = (double.Parse(numHinta.Text) * (1 + (int.Parse(numAlv.Text) / 100)));
                    lblHinta.Text = hinta.ToString();
                    lblHinta.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            //TODO tarkista toimiiko oikein
            
        }
        */

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //uuden rivin lisäys
            
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            //TODO: tämä on ongelma---------------------
            palveluTableAdapter.Insert(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                    int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(numHinta.Text), double.Parse(numAlv.Text));
            populateDGV();

            //RecursiveClearTextBoxes(this.Controls); 
            // palveluID(long), toimalueID(long), Nimi, Tyyppi(int), kuvaus, hinta(double), alv(double)
        }

        private void numHinta_ValueChanged(object sender, EventArgs e)
        {
            lblPalID.Text = cbTyyppi.Text;
            lblPalID.Visible = true;
            try
            {
                if (numHinta.Text.Length > 0 && numAlv.Text.Length > 0)
                {
                    lblHinta.Visible = true;
                    double hinta = (double.Parse(numHinta.Text) * (1 + (double.Parse(numAlv.Text) / 100)));
                    lblHinta.Text = hinta.ToString() + " euroa";
                    hinta = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        //tyhjennetään formi
        private void RecursiveClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;

                if (tb != null)

                    tb.Clear();
                else

                    RecursiveClearTextBoxes(ctrl.Controls);
            }
        }

    }
}
