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
    public partial class Aluehallinta : Form
    {
        public Aluehallinta()
        {
            InitializeComponent();
        }

        private void Aluehallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aluedata1.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.aluedata1.toimintaalue);
            

        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //Valmiista esimerkistä muutoksen tekeminen
            Validate();
            aluedata1BindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.aluedata1);
            toimintaalueTableAdapter.Insert(tbAlueNimi.Text);


        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {

        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //vaihdetaan sivulle Lisää
            tabControl1.SelectedIndex = 0;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

        }

        private void dgridAlueet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
