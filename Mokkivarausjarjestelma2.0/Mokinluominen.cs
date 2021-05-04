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
        }

        private void Mokinluominen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.dataSet1.posti);
            // TODO: This line of code loads data into the 'dataSet1.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.dataSet1.toimintaalue);
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);

        }

        private void dgvMokit_MouseClick(object sender, MouseEventArgs e)
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

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }

        }
    }
}