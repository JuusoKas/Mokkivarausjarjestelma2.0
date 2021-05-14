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
    public partial class Mokkilista : Form
    {
        varaukset isantaForm = null;

        public Mokkilista(varaukset isantaForm)
        {
            InitializeComponent();
            this.isantaForm = isantaForm;
        }

        private void Mokkilista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.kaikkidata.mokki);

        }

        private void dgvMokkilista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.isantaForm.PassValue2(dgvMokkilista.CurrentRow.Cells[0].Value.ToString(), dgvMokkilista.CurrentRow.Cells[3].Value.ToString());
            this.Close();
        }
    }
}