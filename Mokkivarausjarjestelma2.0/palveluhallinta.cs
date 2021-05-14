
using MySql.Data.MySqlClient;
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
             "datasource=localhost;port=3308;Initial Catalog='vn';username=root;Password=asdlol");

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
            string queryPalvelu = "SELECT * FROM palvelu";
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
            lblHinta.Text = "";
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            kaikkidataBindingSource.EndEdit();
            palveluTableAdapter.Update(this.kaikkidata);
            try
            {
                palveluTableAdapter.Delete(long.Parse(lblPalID.Text), long.Parse(lblToimalue.Text), tbNimi.Text,
                        int.Parse(cbTyyppi.Text), tbKuvaus.Text, double.Parse(numHinta.Value.ToString()), double.Parse(numAlv.Value.ToString()));
                populateDGV();
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
            lblToimalue.Text = dgridPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbNimi.Text = dgridPalvelut.CurrentRow.Cells[2].Value.ToString();
            cbTyyppi.Text = dgridPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgridPalvelut.CurrentRow.Cells[4].Value.ToString();
            numHinta.Text = dgridPalvelut.CurrentRow.Cells[5].Value.ToString();
            numAlv.Text = dgridPalvelut.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //uuden rivin
            Validate();
            kaikkidataBindingSource.EndEdit();
            int rivimaara = dgridPalvelut.Rows.Count;
            rivimaara++;
            lblPalID.Text = rivimaara.ToString();
            rivimaara = 0;
            try
            {

                palveluTableAdapter.Insert(long.Parse(lblPalID.Text), long.Parse(lblToimalue.Text), tbNimi.Text,
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

        //Päivitetään olemassa olevat tiedot
        private void Paivita_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = @"UPDATE palvelu
                 SET toimintaalue_id = @toimintaalue_id,
                     nimi = @nimi,
                     tyyppi = @tyyppi,
                     kuvaus = @kuvaus,
                     hinta = @hinta,
                     alv = @alv
                 WHERE palvelu_id = @palvelu_id";

                using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@toimintaalue_id", int.Parse(cbToimAlue.Text));
                    cmd.Parameters.AddWithValue("@nimi", tbNimi.Text);
                    cmd.Parameters.AddWithValue("@tyyppi", int.Parse(cbTyyppi.Text));
                    cmd.Parameters.AddWithValue("@kuvaus", tbKuvaus.Text);
                    cmd.Parameters.AddWithValue("@hinta", double.Parse(numHinta.Text));
                    cmd.Parameters.AddWithValue("@alv", double.Parse(numAlv.Text));
                    cmd.Parameters.AddWithValue("@palvelu_id", int.Parse(lblPalID.Text));

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        populateDGV();
                    }
                }
                populateDGV();
                MessageBox.Show("Päivitys onnistui", "Palvelut");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void numHinta_Leave(object sender, EventArgs e)
        {
            numHinta_ValueChanged(sender, e);
        }
    }
}
