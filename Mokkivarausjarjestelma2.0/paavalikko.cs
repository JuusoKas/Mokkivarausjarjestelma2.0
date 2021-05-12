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
    public partial class paavalikko : Form
    {
        public paavalikko()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_toimintaalue_Click(object sender, EventArgs e)
        {
            Aluehallinta alueform = new Aluehallinta();
            alueform.Show();
        }

        private void tsmi_palvelu_Click(object sender, EventArgs e)
        {
            palveluhallinta palveluform = new palveluhallinta();
            palveluform.Show();
        }

        private void tsmi_mokki_Click(object sender, EventArgs e)
        {

        }

        private void btnVaraus_Click(object sender, EventArgs e)
        {
            //tänne Varausikkunan formi
        }

        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            //asiakkasmuokkauksen formi
        }

        private void btnRaportti_Click(object sender, EventArgs e)
        {
            //raportointi formi
            raportti raporttiform = new raportti();
            raporttiform.Show();
        }
    }
}
