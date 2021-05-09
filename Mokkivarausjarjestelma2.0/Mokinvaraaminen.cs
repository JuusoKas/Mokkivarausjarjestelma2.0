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
    public partial class Mokinvaraaminen : Form
    {
        public Mokinvaraaminen()
        {
            InitializeComponent();

            populateDGV();

        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=root");
        MySqlCommand command;

        public void populateDGV()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraukset.DataSource = table;

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

        public void PassValue(string strValue, string strvalue2) // Tässä tuodaan label ID ja Asiakkaan nimi asiakaslistasta
        {
            lbAsiakasID.Text = strValue;
            tbAsiakas.Text = strvalue2;
        }

        public void PassValue2(string strValue, string strvalue2) // Tässä tuodaan label ID ja mökin nimi nimi mökkilistasta
        {
            lbMokkiID.Text = strValue;
            tbMokki.Text = strvalue2;
        }

        private void Mokinvaraaminen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);

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

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Validate();

            varausBindingSource.EndEdit();
            varausTableAdapter.Update(this.dataSet1);
            varausTableAdapter.Insert(long.Parse(lbAsiakasID.Text), long.Parse(lbMokkiID.Text), dtpVarauspaiva.Value, DateTime.Now, dtpSisaankirjautuminen.Value, dtpUloskirjautuminen.Value);
            populateDGV();
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            Asiakaslista form2 = new Asiakaslista(this);
            form2.ShowDialog();
        }

        private void btnMokki_Click(object sender, EventArgs e)
        {
            Mokkilista form3 = new Mokkilista(this);
            form3.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            dtpSisaankirjautuminen.Value = DateTime.Now.Date;
            dtpUloskirjautuminen.Value = DateTime.Now.Date;
        }

        private void dtpSisaankirjautuminen_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today.Date;
            if (dtpSisaankirjautuminen.Value < today)
            {
                MessageBox.Show("Päivä ei voi olla menneisyydessä!");
                dtpSisaankirjautuminen.Value = DateTime.Today.Date;
            }
            if (dtpUloskirjautuminen.Value < today)
            {
                MessageBox.Show("Päivä ei voi olla menneisyydessä!");
                dtpUloskirjautuminen.Value = DateTime.Today.Date;

            }
            if(dtpUloskirjautuminen.Value < dtpSisaankirjautuminen.Value)
            {
                MessageBox.Show("Uloskirjautuminen ei voi olla aiemmin, kuin sisäänkirjautuminen!");
                dtpSisaankirjautuminen.Value = DateTime.Today.Date;
                dtpUloskirjautuminen.Value = DateTime.Today.Date;
            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {

            tbVarausID.Text = dgvVaraukset.CurrentRow.Cells[0].Value.ToString();
            lbAsiakasID.Text = dgvVaraukset.CurrentRow.Cells[1].Value.ToString();
            lbMokkiID.Text = dgvVaraukset.CurrentRow.Cells[2].Value.ToString();
            dtpVarauspaiva.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[3].Value.ToString());
            dtpSisaankirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[5].Value.ToString());
            dtpUloskirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[6].Value.ToString());

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabPage1;

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

        }
    }
}