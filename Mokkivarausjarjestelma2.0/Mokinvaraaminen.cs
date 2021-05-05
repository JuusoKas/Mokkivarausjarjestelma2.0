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
        }

        private void Mokinvaraaminen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);

        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
          
        }
    }
}
