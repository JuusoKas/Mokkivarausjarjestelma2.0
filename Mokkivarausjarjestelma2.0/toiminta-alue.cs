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
    public partial class toiminta_alue : Form
    {
        public toiminta_alue()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toiminta_alue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kokoData.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.kokoData.toimintaalue);

        }
    }
}
