
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

        //SQL yhteyden avaus ja sulkeminen
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


        //clearataan valinnat
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            try
            {
                palveluTableAdapter.Delete(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                        int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(numHinta.Value.ToString()), double.Parse(numAlv.Value.ToString()));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //vaihdetaan sivulle Lisää
            tabControl1.SelectedIndex = 0;
            lblPalID.Visible = true;
        }

        private void dgridPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            //rivivalinta tallennetaan textboxeihin
            lblPalID.Text = dgridPalvelut.CurrentRow.Cells[0].Value.ToString();
            cbToimAlue.Text = dgridPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbNimi.Text = dgridPalvelut.CurrentRow.Cells[2].Value.ToString();
            cbTyyppi.Text = dgridPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgridPalvelut.CurrentRow.Cells[4].Value.ToString();
            numHinta.Text = dgridPalvelut.CurrentRow.Cells[5].Value.ToString();
            numAlv.Text = dgridPalvelut.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //uuden rivin lisäys
            Validate();
            kaikkidataBindingSource.EndEdit();
            int rivimaara = dgridPalvelut.Rows.Count;
            
            try
            {
                for (int i = 0; i < rivimaara; i++)
                {
                    lblPalID.Visible = true;
                    lblPalID.Text = rivimaara.ToString();
                }

                palveluTableAdapter.Insert(long.Parse(lblPalID.Text), long.Parse(cbToimAlue.Text), tbNimi.Text,
                    int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(numHinta.Value.ToString()), double.Parse(numAlv.Value.ToString()));
                palveluTableAdapter.Update(this.kaikkidata);
                populateDGV();
                MessageBox.Show("Lisäys onnistui", "Palvelut");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            RecursiveClearTextBoxes(this.Controls);
        }

        //päivitetään koko hinta samalla kun arvoja muutetaan
        private void numHinta_ValueChanged(object sender, EventArgs e)
        {
            
                if (numHinta.Text.Length > 0 && numAlv.Text.Length > 0)
                {
                    lblHinta.Visible = true;
                    double hinta = (double.Parse(numHinta.Text) * (1 + (double.Parse(numAlv.Text) / 100)));
                    lblHinta.Text = hinta.ToString() + " euroa";
                    hinta = 0;
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
