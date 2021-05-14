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
    public partial class Asiakaslista : Form
    {
        varaukset isantaForm = null;

        public Asiakaslista(varaukset isantaForm)
        {
            InitializeComponent();
            this.isantaForm = isantaForm;
        }

        private void Asiakaslista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.kaikkidata.asiakas);

        }

        private void dgvAsiakaslista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.isantaForm.PassValue(dgvAsiakaslista.CurrentRow.Cells[0].Value.ToString(), dgvAsiakaslista.CurrentRow.Cells[2].Value.ToString() + " " + dgvAsiakaslista.CurrentRow.Cells[3].Value.ToString());
            this.Close();

        }
    }
}
