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
            "datasource=localhost;port=3307 ;Initial Catalog='vn'; username=root; Password=root");


        public Aluehallinta()
        {
            InitializeComponent();
            populateDGV();
        }

        public void populateDGV()
        {
            //täytetään datagrid datalla
            string query = "SELECT * FROM toimintaalue";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgridAlueet.DataSource = table;
            dgridAlueet.Sort(dgridAlueet.Columns[0], ListSortDirection.Ascending);
        }


        private void Aluehallinta_Load(object sender, EventArgs e)
        {
            tbIDnro.Clear();
            tbAlueNimi.Clear();
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

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //Valmiista esimerkistä muutoksen tekeminen
            Validate();
            try
            {
                aluedata1BindingSource.EndEdit();
                toimintaalueTableAdapter.Update(this.aluedata1);
                toimintaalueTableAdapter.Insert(tbAlueNimi.Text);
                MessageBox.Show("Päivitys onnistui", "Toiminta-alue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            

            //päivityksenä toimii uudelleentäyttäminen
            populateDGV();
            tbAlueNimi.Clear();
            tbIDnro.Clear();
        }


        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //vaihdetaan sivulle Lisää
            tabControl1.SelectedIndex = 0;
            tbIDnro.ReadOnly = false;
        }
        
        private void btnPoista_Click(object sender, EventArgs e)
        {
            //rivin poisto
            Validate();
            try
            {
                aluedata1BindingSource.EndEdit();
                toimintaalueTableAdapter.Update(this.aluedata1);
                toimintaalueTableAdapter.Delete(long.Parse(tbIDnro.Text), tbAlueNimi.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            populateDGV();
            tbAlueNimi.Clear();
            tbIDnro.Clear();
        }


        private void dgridAlueet_MouseClick(object sender, MouseEventArgs e)
        {
            //rivivalinta
            tbAlueNimi.Text = dgridAlueet.CurrentRow.Cells[1].Value.ToString();
            tbIDnro.Text = dgridAlueet.CurrentRow.Cells[0].Value.ToString();
            
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

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
        }
    }
}
