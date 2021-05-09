
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
    public partial class Mokinluominen : Form
    {
        public Mokinluominen()
        {
            InitializeComponent();

            populateDGV();
            populateComboboxes();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=root");
        MySqlCommand command;

        public void populateDGV()
        {
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvMokit.DataSource = table;

        }

        public void populateComboboxes()
        {

            string queryToiminta = "SELECT * FROM toimintaalue";

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(queryToiminta, connection);
            DataSet dsCombobox = new DataSet();
            adapter2.Fill(dsCombobox,"toimintaalue");
            cbToiminta.DisplayMember = "toimintaalue_id";
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

        private void btnPeruuta_MouseClick(object sender, MouseEventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            Validate();

            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.dataSet1);
            mokkiTableAdapter.Insert(long.Parse(cbToiminta.Text), cbPosti.Text, tbMokinnimi.Text, tbKatuosoite.Text, tbKuvaus.Text, int.Parse(tbHenkilomaara.Text), tbVarustelu.Text);
            populateDGV();
            RecursiveClearTextBoxes(this.Controls);

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

            tbMokkiID.ReadOnly = false;
            tbMokkiID.Text = dgvMokit.CurrentRow.Cells[0].Value.ToString();
            cbToiminta.Text = dgvMokit.CurrentRow.Cells[1].Value.ToString();
            cbPosti.Text = dgvMokit.CurrentRow.Cells[2].Value.ToString();
            tbMokinnimi.Text = dgvMokit.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvMokit.CurrentRow.Cells[4].Value.ToString();
            tbKuvaus.Text = dgvMokit.CurrentRow.Cells[5].Value.ToString();
            tbHenkilomaara.Text = dgvMokit.CurrentRow.Cells[6].Value.ToString();
            tbVarustelu.Text = dgvMokit.CurrentRow.Cells[7].Value.ToString();

            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.dataSet1);
            mokkiTableAdapter.Delete(long.Parse(tbMokkiID.Text), long.Parse(cbToiminta.Text), cbPosti.Text, tbMokinnimi.Text, tbKatuosoite.Text, tbKuvaus.Text, int.Parse(tbHenkilomaara.Text), tbVarustelu.Text);
            populateDGV();


        }


        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            tbMokkiID.ReadOnly = false;

            tbMokkiID.Text = dgvMokit.CurrentRow.Cells[0].Value.ToString();
            cbToiminta.Text = dgvMokit.CurrentRow.Cells[1].Value.ToString();
            cbPosti.Text = dgvMokit.CurrentRow.Cells[2].Value.ToString();
            tbMokinnimi.Text = dgvMokit.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvMokit.CurrentRow.Cells[4].Value.ToString();
            tbKuvaus.Text = dgvMokit.CurrentRow.Cells[5].Value.ToString();
            tbHenkilomaara.Text = dgvMokit.CurrentRow.Cells[6].Value.ToString();
            tbVarustelu.Text = dgvMokit.CurrentRow.Cells[7].Value.ToString();

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabPage1;


        }

        private void dgvMokit_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabPage1;

            tbMokkiID.Text = dgvMokit.CurrentRow.Cells[0].Value.ToString();
            cbToiminta.Text = dgvMokit.CurrentRow.Cells[1].Value.ToString();
            cbPosti.Text = dgvMokit.CurrentRow.Cells[2].Value.ToString();
            tbMokinnimi.Text = dgvMokit.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvMokit.CurrentRow.Cells[4].Value.ToString();
            tbKuvaus.Text = dgvMokit.CurrentRow.Cells[5].Value.ToString();
            tbHenkilomaara.Text = dgvMokit.CurrentRow.Cells[6].Value.ToString();
            tbVarustelu.Text = dgvMokit.CurrentRow.Cells[7].Value.ToString();

        }



        private void btnPeruuta_Click(object sender, EventArgs e)
        {


            RecursiveClearTextBoxes(this.Controls);
        }

        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


