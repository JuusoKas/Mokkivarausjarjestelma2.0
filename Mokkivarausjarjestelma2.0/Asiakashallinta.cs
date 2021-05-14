using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mokkivarausjarjestelma2._0
{
    public partial class Asiakashallinta : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307 ;Initial Catalog='vn'; username=root; Password=root");
        MySqlCommand command2;

        public Asiakashallinta()
        {
            InitializeComponent();

            populateDGV();
        }

        public void populateDGV()
        {
            string query2 = "SELECT * FROM asiakas";
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvAsiakkaat.DataSource = table2;

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

        public void ExecuteMyQuery(string query2)
        {
            try
            {
                OpenConnection();
                command2 = new MySqlCommand(query2, connection);

                if (command2.ExecuteNonQuery() == 1)
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




        private void btnTallenna_Click(object sender, EventArgs e) // Tallennetaan asiakas
        {


            Validate();

            asiakasBindingSource.EndEdit();

            try
            {
                asiakasTableAdapter.Update(this.kaikkidata);
                asiakasTableAdapter.Insert(cbPostinro.Text, tbEtunimi.Text, tbSukunimi.Text, tbLahiosoite.Text, tbSahkoposti.Text, tbPuhnro.Text);
                populateDGV();

                MessageBox.Show("Asiakkaan lisäys onnistui!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tarkista syötteet!");
                throw;

            }
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnPeru_Click(object sender, EventArgs e) // Perutaan asiakkaan lisäys
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnPoista_Click(object sender, EventArgs e) // Poistetaan asiakas
        {
            tbAsiakasID.ReadOnly = false;
            tbAsiakasID.Text = dgvAsiakkaat.CurrentRow.Cells[0].Value.ToString();
            cbPostinro.Text = dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString();
            tbEtunimi.Text = dgvAsiakkaat.CurrentRow.Cells[2].Value.ToString();
            tbSukunimi.Text = dgvAsiakkaat.CurrentRow.Cells[3].Value.ToString();
            tbLahiosoite.Text = dgvAsiakkaat.CurrentRow.Cells[4].Value.ToString();
            tbSahkoposti.Text = dgvAsiakkaat.CurrentRow.Cells[5].Value.ToString();
            tbPuhnro.Text = dgvAsiakkaat.CurrentRow.Cells[6].Value.ToString();

            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.kaikkidata);
            asiakasTableAdapter.Delete(long.Parse(tbAsiakasID.Text), cbPostinro.Text, tbEtunimi.Text, tbSukunimi.Text, tbLahiosoite.Text, tbSahkoposti.Text, tbPuhnro.Text);
            populateDGV();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e) // muokataan asiakasta, eli datagridin kenttien tiedot tuodaan kaavakkeelle
        {
            tbAsiakasID.ReadOnly = false;
            tbAsiakasID.Text = dgvAsiakkaat.CurrentRow.Cells[0].Value.ToString();
            cbPostinro.Text = dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString();
            tbEtunimi.Text = dgvAsiakkaat.CurrentRow.Cells[2].Value.ToString();
            tbSukunimi.Text = dgvAsiakkaat.CurrentRow.Cells[3].Value.ToString();
            tbLahiosoite.Text = dgvAsiakkaat.CurrentRow.Cells[4].Value.ToString();
            tbSahkoposti.Text = dgvAsiakkaat.CurrentRow.Cells[5].Value.ToString();
            tbPuhnro.Text = dgvAsiakkaat.CurrentRow.Cells[6].Value.ToString();

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabUusi;
        }

        private void btnPaivitaasiakas_Click(object sender, EventArgs e) // asiakkaan muutosten päivitys
        {
            string cmdText = @"UPDATE asiakas
                 SET postinro = @postinro,
                     etunimi = @etunimi,
                     sukunimi = @sukunimi,
                     lahiosoite = @lahiosoite,
                    email = @email,
                    puhelinnro = @puhelinnro
                 WHERE asiakas_id = @asiakas_id";


            try
            {
                using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@postinro", cbPostinro.Text);
                    cmd.Parameters.AddWithValue("@etunimi", tbEtunimi.Text);
                    cmd.Parameters.AddWithValue("@sukunimi", tbSukunimi.Text);
                    cmd.Parameters.AddWithValue("@lahiosoite", tbLahiosoite.Text);
                    cmd.Parameters.AddWithValue("@email", tbSahkoposti.Text);
                    cmd.Parameters.AddWithValue("@puhelinnro", tbPuhnro.Text);
                    cmd.Parameters.AddWithValue("@asiakas_id", int.Parse(tbAsiakasID.Text));

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Päivitys onnistui!");
                        populateDGV();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tarkista syötteet");
                throw;
            }
            RecursiveClearTextBoxes(this.Controls);
        }

        private void Asiakashallinta_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaikkidata.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.kaikkidata.posti);
            // TODO: This line of code loads data into the 'kaikkidata.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.kaikkidata.asiakas);

        }

        private void tbPuhnro_KeyPress(object sender, KeyPressEventArgs e) // Tällä varmistetaan että puhelinnumeroon syötetään vain numeroita
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
    }
}