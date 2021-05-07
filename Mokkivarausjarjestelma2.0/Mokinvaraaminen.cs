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

        public void PassValue(string strValue, string strvalue2) // Tässä tuodaan label ID ja Asiakkaan nimi asiakaslistasta
        {
            lbAsiakasID.Text = "ID: " + strValue;
            tbAsiakas.Text = strvalue2;
        }

        public void PassValue2(string strValue, string strvalue2) // Tässä tuodaan label ID ja mökin nimi nimi mökkilistasta
        {
            lbMokkiID.Text = "ID: " + strValue;
            tbMokki.Text = strvalue2;
        }

        private void Mokinvaraaminen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.dataSet1.varaus);

        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            Asiakaslista form2 = new Asiakaslista(this);
            form2.ShowDialog();
        }

        private void btnMokki_Click(object sender, EventArgs e)
        {
            Mokkilista form3 = new Mokkilista(this);
            form3.ShowDialog();
        }


    }
}
