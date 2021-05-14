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
    public partial class varaukset : Form
    {

        public varaukset()
        {
            InitializeComponent();

            populateDGV();

        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307 ;Initial Catalog='vn'; username=root; Password=root");
        MySqlCommand command;

        public void populateDGV()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraukset.DataSource = table;
            cbVarausID.DataSource = table;

            string query2 = "SELECT * FROM varauksen_palvelut";
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvVarauksenpalvelut.DataSource = table2;

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
            // TODO: This line of code loads data into the 'kaikkidata.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.kaikkidata.palvelu);
            // TODO: This line of code loads data into the 'kaikkidata.varauksen_palvelut' table. You can move, or remove it, as needed.
            this.varauksen_palvelutTableAdapter.Fill(this.kaikkidata.varauksen_palvelut);

            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.kaikkidata.varaus);

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

        private void btnCheckin_Click(object sender, EventArgs e) // Tässä tehdään varaus
        {
            connection.Open();//TODO

            string cmdText2 = "SELECT COUNT(*) FROM varaus WHERE varattu_alkupvm BETWEEN '" + dtpSisaankirjautuminen.Value.ToString("yyyy'/'MM'/'dd") + "' AND '" + dtpUloskirjautuminen.Value.ToString("yyyy'/'MM'/'dd") + "' AND mokki_mokki_id = " + lbMokkiID.Text;


            MySqlCommand mySqlCmd = connection.CreateCommand();
            mySqlCmd.CommandText = cmdText2;

            int returnValue = Convert.ToInt32(mySqlCmd.ExecuteScalar());

            connection.Close();

            if (returnValue == 0)
            {

                Validate();

                varausBindingSource.EndEdit();
                varausTableAdapter.Update(this.kaikkidata);
                varausTableAdapter.Insert(long.Parse(lbAsiakasID.Text), long.Parse(lbMokkiID.Text), dtpVarauspaiva.Value, DateTime.Now, dtpSisaankirjautuminen.Value, dtpUloskirjautuminen.Value);
                populateDGV();
                RecursiveClearTextBoxes(this.Controls);
                dtpSisaankirjautuminen.Value = DateTime.Today.Date;
                dtpUloskirjautuminen.Value = DateTime.Today.Date;
                lbMokkiID.Text = "";
                lbAsiakasID.Text = "";
                MessageBox.Show("Varaus lisätty", "Varaukset");
            }
            else
                MessageBox.Show("Varaus tälle mökille, ja tälle päivälle on jo olemassa! Vaihda mökki tai päivämäärä!");
        }

        private void btnAsiakas_Click(object sender, EventArgs e) // avataan uusi asiakas välilehti, josta tehdään valinta varaukselle
        {
            Asiakaslista form2 = new Asiakaslista(this);
            form2.ShowDialog();
        }

        private void btnMokki_Click(object sender, EventArgs e) // avataan uusi mökki välilehti, josta tehdään valinta varaukselle
        {
            Mokkilista form3 = new Mokkilista(this);
            form3.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // tässä estetään muut kuin numeroiden syötöt, käytetään mm. hinta kenttään
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e) // peruutetaan varaus, eli tyhjennetään kentät
        {
            dtpSisaankirjautuminen.Value = DateTime.Now.Date;
            dtpUloskirjautuminen.Value = DateTime.Now.Date;
            RecursiveClearTextBoxes(this.Controls);
            dtpSisaankirjautuminen.Value = DateTime.Today.Date;
            dtpUloskirjautuminen.Value = DateTime.Today.Date;
            lbMokkiID.Text = "";
            lbAsiakasID.Text = "";
        }

        private void dtpSisaankirjautuminen_ValueChanged(object sender, EventArgs e) // Tarkistetaan, että päivämääriin ei syötetä virheellisiä valintoja
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
            if (dtpUloskirjautuminen.Value < dtpSisaankirjautuminen.Value)
            {
                MessageBox.Show("Uloskirjautuminen ei voi olla aiemmin, kuin sisäänkirjautuminen!");
                dtpSisaankirjautuminen.Value = DateTime.Today.Date;
                dtpUloskirjautuminen.Value = DateTime.Today.Date;
            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e) // Muokkausnappi varaukselle. Vie tiedot datagridistä kenttiin.
        {

            tbVarausID.Text = dgvVaraukset.CurrentRow.Cells[0].Value.ToString();
            lbAsiakasID.Text = dgvVaraukset.CurrentRow.Cells[1].Value.ToString();
            lbMokkiID.Text = dgvVaraukset.CurrentRow.Cells[2].Value.ToString();
            dtpVarauspaiva.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[3].Value.ToString());
            dtpSisaankirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[5].Value.ToString());
            dtpVahvistuspaiva.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[4].Value.ToString());
            dtpUloskirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[6].Value.ToString());

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabPage1;


        }

        private void btnPoista_Click(object sender, EventArgs e) // Poistonappi varaukselle. Poistaa tiedot valitun rivin tiedot datagridistä ja databasesta.
        {

            tbVarausID.Text = dgvVaraukset.CurrentRow.Cells[0].Value.ToString(); 
            lbAsiakasID.Text = dgvVaraukset.CurrentRow.Cells[1].Value.ToString();
            lbMokkiID.Text = dgvVaraukset.CurrentRow.Cells[2].Value.ToString();
            dtpVarauspaiva.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[3].Value.ToString());
            dtpSisaankirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[5].Value.ToString());
            dtpVahvistuspaiva.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[4].Value.ToString());
            dtpUloskirjautuminen.Value = Convert.ToDateTime(dgvVaraukset.CurrentRow.Cells[6].Value.ToString());

            Validate();
            varausBindingSource.EndEdit();
            varausTableAdapter.Update(this.kaikkidata);
            varausTableAdapter.Delete(long.Parse(tbVarausID.Text), long.Parse(lbAsiakasID.Text), long.Parse(lbMokkiID.Text), dtpVarauspaiva.Value, dtpVahvistuspaiva.Value, dtpSisaankirjautuminen.Value, dtpUloskirjautuminen.Value);
            populateDGV();



        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {

            Validate();
            varauksenpalvelutBindingSource.EndEdit();
            varauksen_palvelutTableAdapter.Update(this.kaikkidata);
            varauksen_palvelutTableAdapter.Insert(long.Parse(cbVarausID.Text), long.Parse(lbPalvelu.Text), int.Parse(tbLukumaara.Text));
            populateDGV();
            RecursiveClearTextBoxes(this.Controls);
        }

        private void btnPoistapalvelu_Click(object sender, EventArgs e)
        {
            cbVarausID.Text = dgvVarauksenpalvelut.CurrentRow.Cells[0].Value.ToString();
            lbPalvelu.Text = dgvVarauksenpalvelut.CurrentRow.Cells[1].Value.ToString();
            tbLukumaara.Text = dgvVarauksenpalvelut.CurrentRow.Cells[2].Value.ToString();

            Validate();
            varauksenpalvelutBindingSource.EndEdit();
            varauksen_palvelutTableAdapter.Update(this.kaikkidata);
            varauksen_palvelutTableAdapter.Delete(long.Parse(cbVarausID.Text), long.Parse(lbPalvelu.Text), int.Parse(tbLukumaara.Text));
            populateDGV();
        }

        private void btnMuokkaavarausta_Click(object sender, EventArgs e) // varauksen muutosten päivitys
        {
            string cmdText = @"UPDATE varaus
                 SET asiakas_id = @asiakas_id,
                     mokki_mokki_id = @mokki_mokki_id,
                     varattu_pvm = @varattu_pvm,
                     vahvistus_pvm = @vahvistus_pvm,
                    varattu_alkupvm = @varattu_alkupvm,
                    varattu_loppupvm = @varattu_loppupvm
                 WHERE varaus_id = @varaus_id";

            using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@asiakas_id", lbAsiakasID.Text);
                cmd.Parameters.AddWithValue("@mokki_mokki_id", lbMokkiID.Text);
                cmd.Parameters.AddWithValue("@varattu_pvm", dtpVarauspaiva.Value);
                cmd.Parameters.AddWithValue("@vahvistus_pvm", dtpVahvistuspaiva.Value);
                cmd.Parameters.AddWithValue("@varattu_alkupvm", dtpSisaankirjautuminen.Value);
                cmd.Parameters.AddWithValue("@varattu_loppupvm", dtpUloskirjautuminen.Value);
                cmd.Parameters.AddWithValue("@varaus_id", int.Parse(tbVarausID.Text));

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {

                    populateDGV();

                }
            }
        }

        private void cbSuodata_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuodata.Checked == true)
            {


                varausBindingSource.Filter = string.Format("varattu_pvm >= #{0:yyyy/MM/dd}# And varattu_pvm <= #{1:yyyy/MM/dd}#", dtpSuodataaloitus.Value, dtpSuodatalopetus.Value);
                dgvVaraukset.DataSource = varausBindingSource;
            }
            else
            this.varausBindingSource.Filter = null;
            
        }
    }
}