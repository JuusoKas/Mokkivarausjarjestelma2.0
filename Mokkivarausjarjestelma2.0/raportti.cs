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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Mokkivarausjarjestelma2._0
{
    public partial class raportti : Form
    {
        public raportti()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void raportointi_Load(object sender, EventArgs e)
        {
            populateComboboxes();
            btnLataa.PerformClick(); //TODO
        }

        // Yhteys käytettävään MYSQL tietokantaan
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3307 ;Initial Catalog='vn'; username=root; Password=root");
        
        // Alustetaan dropdownmenun toiminta-alueet
        public void populateComboboxes()
        {
            string queryToiminta = "SELECT * FROM toimintaalue";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(queryToiminta, connection);
            DataSet dsCombobox = new DataSet();
            adapter2.Fill(dsCombobox, "toimintaalue");
            cbToimialueet.DisplayMember = "nimi";
            cbToimialueet.DataSource = dsCombobox.Tables["toimintaalue"];
        }

        private void btnLataa_Click(object sender, EventArgs e)
        {
            // Jos Majoitus nappi on valittuna, suoritetaan seuraava SQL query
            if (!rbMajoitukset.Checked)
            {
                string  palvelu_query =  "SELECT varauksen_palvelut.palvelu_id AS ID, toimintaalue.nimi AS 'Toiminta-alue',palvelu.nimi AS Nimi,SUM(lkm) AS Asiakkaita,SUM(lkm * palvelu.hinta) AS 'Yhteensa' FROM varauksen_palvelut ";
                        palvelu_query += "INNER JOIN varaus ON varauksen_palvelut.varaus_id = varaus.varaus_id ";
                        palvelu_query += "INNER JOIN palvelu ON varauksen_palvelut.palvelu_id = palvelu.palvelu_id ";
                        palvelu_query += "INNER JOIN toimintaalue ON toimintaalue.toimintaalue_id = palvelu.toimintaalue_id ";
                        palvelu_query += "INNER JOIN asiakas ON asiakas.asiakas_id = varaus.asiakas_id ";
                        palvelu_query += "WHERE toimintaalue.nimi = '" + cbToimialueet.Text + "' AND MONTH(varattu_alkupvm) = '" + dateTimePicker1.Value.Month + "' AND YEAR(varattu_alkupvm) = '" + dateTimePicker1.Value.Year + "' GROUP BY varauksen_palvelut.palvelu_id";

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(palvelu_query, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                chart1.Series.Clear();

                Series S = chart1.Series.Add(dataGridView1.Columns[3].HeaderText);
                S.ChartType = SeriesChartType.Column;
                S.IsValueShownAsLabel = true;

                Series A = chart1.Series.Add(dataGridView1.Columns[4].HeaderText);
                A.ChartType = SeriesChartType.Column;
                A.IsValueShownAsLabel = true;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    A.Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString());
                    A.ChartType = SeriesChartType.Column;
                    A.IsValueShownAsLabel = true;
                    S.Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                    S.ChartType = SeriesChartType.Column;
                    S.IsValueShownAsLabel = true;
                }
            }

            // Jos Majoitus nappi ei ole valittuna, suoritetaan seuraava SQL query
            else
            {
                string  majoitus_query = "SELECT mokki_mokki_id AS ID, nimi AS 'Toiminta-alue',mokki.mokkinimi as Nimi,COUNT(mokki.mokki_id) AS Varauksia,SUM(mokki.mokki_id * mokki.hinta) AS Tuotto FROM varaus ";
                        majoitus_query += "INNER JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id ";
                        majoitus_query += "INNER JOIN toimintaalue ON toimintaalue.toimintaalue_id = mokki.toimintaalue_id ";
                        majoitus_query += "INNER JOIN asiakas ON asiakas.asiakas_id = varaus.asiakas_id ";
                        majoitus_query += "WHERE toimintaalue.nimi = '" + cbToimialueet.Text + "' AND MONTH(varattu_alkupvm) = '" + dateTimePicker1.Value.Month + "' AND YEAR(varattu_alkupvm) = '" + dateTimePicker1.Value.Year + "' GROUP BY varaus.mokki_mokki_id";
                
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(majoitus_query, connection);
                adapter.Fill(table); //TODO
                dataGridView1.DataSource = table;
                chart1.Series.Clear();

                Series S = chart1.Series.Add(dataGridView1.Columns[3].HeaderText);
                S.ChartType = SeriesChartType.Column;
                S.IsValueShownAsLabel = true;

                Series A = chart1.Series.Add(dataGridView1.Columns[4].HeaderText);
                A.ChartType = SeriesChartType.Column;
                A.IsValueShownAsLabel = true;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    A.Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString());
                    A.ChartType = SeriesChartType.Column;
                    A.IsValueShownAsLabel = true;
                    S.Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                    S.ChartType = SeriesChartType.Column;
                    S.IsValueShownAsLabel = true;
                }
            }

            // Jos valitulle aikajaksolle ei löydy tuloksia, annetaan tieto käyttäjälle
            if (dataGridView1.Rows.Count == 0)
            {
                if (!rbMajoitukset.Checked)
                    toolStripStatusLabel1.Text = "Virhe: Palveluita ei löytynyt valitulla ajankohdalla.";
                else
                    toolStripStatusLabel1.Text = "Virhe: Majoituksia ei löytynyt valitulla ajankohdalla.";
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                if (!rbMajoitukset.Checked)
                    toolStripStatusLabel1.Text = "Varattuja palveluita löydettiin " + dataGridView1.Rows.Count + " kpl";
                else
                    toolStripStatusLabel1.Text = "Varattuja majoituksia löydettiin " + dataGridView1.Rows.Count + " kpl";
            }
        }
    }
}
