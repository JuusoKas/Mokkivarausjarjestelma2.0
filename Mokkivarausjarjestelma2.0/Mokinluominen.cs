using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mokkivarausjarjestelma2._0
{
    public partial class Mokinluominen : Form
    {
        public Mokinluominen()
        {
            InitializeComponent();

            populateDGV();
            populateComboboxes();


        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307 ;Initial Catalog='vn'; username=root; Password=root");
        MySqlCommand command;

        public void populateDGV() // täytetään datagrid
        {
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvMokit.DataSource = table;

        }

        public void populateComboboxes() // Täytetään comboboxit tietokannasta
        {

            string queryToiminta = "SELECT * FROM toimintaalue";

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(queryToiminta, connection);
            DataSet dsCombobox = new DataSet();
            adapter2.Fill(dsCombobox, "toimintaalue");
            cbToiminta.DisplayMember = "nimi";
            cbToiminta.DataSource = dsCombobox.Tables["toimintaalue"];

            string queryPosti = "SELECT * FROM posti";

            MySqlDataAdapter adapter3 = new MySqlDataAdapter(queryPosti, connection);
            DataSet dsComboboxPosti = new DataSet();
            adapter3.Fill(dsComboboxPosti, "posti");
            cbPosti.DisplayMember = "postinro";
            cbPosti.DataSource = dsComboboxPosti.Tables["posti"];




        }


        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        private void RecursiveClearTextBoxes(Control.ControlCollection cc) // Tyhjennetään tekstilaatikot

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

        private void btnPeruuta_MouseClick(object sender, MouseEventArgs e) // Tyhjennetään kaavake
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnTallenna_Click(object sender, EventArgs e) // Tallennetaan mökki
        {
            Validate();

            mokkiBindingSource.EndEdit();

            try
            {
                mokkiTableAdapter.Update(this.kaikkidata);
                mokkiTableAdapter.Insert(long.Parse(lbToimintanimi.Text), cbPosti.Text, tbMokinnimi.Text, tbKatuosoite.Text, tbKuvaus.Text, int.Parse(tbHenkilomaara.Text), tbVarustelu.Text);

                populateDGV();
                MessageBox.Show("Tallennus onnistui!", "Mökit");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Tallennus epäonnistui!");
                throw;
            }
            RecursiveClearTextBoxes(this.Controls);

        }

        private void btnPoista_Click(object sender, EventArgs e) // Poistetaan asiakas
        {

            try
            {
                tbMokkiID.ReadOnly = false;
                tbMokkiID.Text = dgvMokit.CurrentRow.Cells[0].Value.ToString();
                lbToimintanimi.Text = dgvMokit.CurrentRow.Cells[1].Value.ToString();
                cbPosti.Text = dgvMokit.CurrentRow.Cells[2].Value.ToString();
                tbMokinnimi.Text = dgvMokit.CurrentRow.Cells[3].Value.ToString();
                tbKatuosoite.Text = dgvMokit.CurrentRow.Cells[4].Value.ToString();
                tbKuvaus.Text = dgvMokit.CurrentRow.Cells[5].Value.ToString();
                tbHenkilomaara.Text = dgvMokit.CurrentRow.Cells[6].Value.ToString();
                tbVarustelu.Text = dgvMokit.CurrentRow.Cells[7].Value.ToString();

                Validate();
                mokkiBindingSource.EndEdit();
                mokkiTableAdapter.Update(this.kaikkidata);
                mokkiTableAdapter.Delete(long.Parse(tbMokkiID.Text), long.Parse(lbToimintanimi.Text), cbPosti.Text, tbMokinnimi.Text, tbKatuosoite.Text, tbKuvaus.Text, int.Parse(tbHenkilomaara.Text), tbVarustelu.Text);
                populateDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Poistaminen epäonnistui! \nPoista mökkiin kuuluvat varaukset." , "Mökit");
                throw;
            }


        }


        private void btnMuokkaa_Click(object sender, EventArgs e) // Tuodaan datagridistä valitun asiakkaan tiedot kaavakkeelle muokkausta varten
        {

            tbMokkiID.Text = dgvMokit.CurrentRow.Cells[0].Value.ToString();
            lbToimintanimi.Text = dgvMokit.CurrentRow.Cells[1].Value.ToString();
            cbPosti.Text = dgvMokit.CurrentRow.Cells[2].Value.ToString();
            tbMokinnimi.Text = dgvMokit.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvMokit.CurrentRow.Cells[4].Value.ToString();
            tbKuvaus.Text = dgvMokit.CurrentRow.Cells[5].Value.ToString();
            tbHenkilomaara.Text = dgvMokit.CurrentRow.Cells[6].Value.ToString();
            tbVarustelu.Text = dgvMokit.CurrentRow.Cells[7].Value.ToString();

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabPage1;


        }

        private void btnPeruuta_Click(object sender, EventArgs e) // Peruutetaan luonti, eli tyhjennetään kentät
        {


            RecursiveClearTextBoxes(this.Controls);
        }

        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e) // Tällä varmistetaan, että henkilömäärään syötetään vain numeroita
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbToiminta_TextChanged(object sender, EventArgs e) // Päivitetään ID label vastaamaan nimikenttää
        {
            lbToimintanimi.Text = cbToiminta.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // Päivitetään mökki
        {
            string cmdText = @"UPDATE mokki
                 SET toimintaalue_id = @toimintaalue_id,
                     postinro = @postinro,
                     mokkinimi = @mokkinimi,
                     katuosoite = @katuosoite,
                    kuvaus = @kuvaus,
                    henkilomaara = @henkilomaara,
                    varustelu = @varustelu
                 WHERE mokki_id = @mokki_id";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@toimintaalue_id", int.Parse(lbToimintanimi.Text));
                    cmd.Parameters.AddWithValue("@postinro", cbPosti.Text);
                    cmd.Parameters.AddWithValue("@mokkinimi", tbMokinnimi.Text);
                    cmd.Parameters.AddWithValue("@katuosoite", tbKatuosoite.Text);
                    cmd.Parameters.AddWithValue("@kuvaus", tbKuvaus.Text);
                    cmd.Parameters.AddWithValue("@henkilomaara", int.Parse(tbHenkilomaara.Text));
                    cmd.Parameters.AddWithValue("@varustelu", tbKuvaus.Text);
                    cmd.Parameters.AddWithValue("@mokki_id", int.Parse(tbMokkiID.Text));

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {

                        populateDGV();
                        MessageBox.Show("Muokkaus onnistui!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Päivitys epäonnistui");
                throw;
            }
        }

        private void Mokinluominen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaikkidata.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.kaikkidata.mokki);

        }
    }


}

