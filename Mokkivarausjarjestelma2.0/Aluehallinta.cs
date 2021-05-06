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
    public partial class Aluehallinta : Form
    {
        
        MySqlConnection connection = new MySqlConnection(
            "datasource=localhost;port=3307;Initial Catalog='vn';username=root;Password=root");

        
        private List<Aluedata1> asiakkaat = new List<Aluedata1>();
        public Aluehallinta()
        {
            InitializeComponent();
            populateDGV();
        }

        public void populateDGV()
        {
            string query = "SELECT * FROM toimintaalue";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgridtesti.DataSource = table;

        }


        private void Aluehallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aluedata1.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.aluedata1.toimintaalue);
            tbIDnro.Clear();
            tbAlueNimi.Clear();
            asiakkaat.Add(aluedata1);
            
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

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //Valmiista esimerkistä muutoksen tekeminen
            Validate();
            aluedata1BindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.aluedata1);
            toimintaalueTableAdapter.Insert(tbAlueNimi.Text);
            toimintaalueTableAdapter.Delete(long.Parse(tbIDnro.Text), tbAlueNimi.Text);
            toimintaalueTableAdapter.Fill(aluedata1.toimintaalue);

        }


        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //vaihdetaan sivulle Lisää
            tabControl1.SelectedIndex = 0;
            
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            aluedata1BindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.aluedata1);
            toimintaalueTableAdapter.Delete(long.Parse(tbIDnro.Text), tbAlueNimi.Text);
            toimintaalueTableAdapter.Fill(aluedata1.toimintaalue);

        }


        private void dgridAlueet_MouseClick(object sender, MouseEventArgs e)
        {
            //rivivalinta
            tbAlueNimi.Text = dgridAlueet.CurrentRow.Cells[1].Value.ToString();
            tbIDnro.Text = dgridAlueet.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //uuden rivin lisäys
            Validate();
            aluedata1BindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.aluedata1);
            toimintaalueTableAdapter.Insert(tbAlueNimi.Text);
            toimintaalueTableAdapter.Fill(aluedata1.toimintaalue);
        }
    }
}
