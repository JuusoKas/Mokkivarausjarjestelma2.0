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

        /////////////////////
        //      VARAUS     //
        /////////////////////
        private void btnVaraus_Click(object sender, EventArgs e)
        {
            varaukset varaus = new varaukset();
            varaus.Show();
        }

        private void btnVaraus_varaukset_Click(object sender, EventArgs e)
        {
            varaukset varaus_varaukset = new varaukset();
            varaus_varaukset.tabControl1.SelectTab(1);
            varaus_varaukset.Show();
        }

        private void btvVaraus_palvelut_Click(object sender, EventArgs e)
        {
            palveluhallinta palvelut = new palveluhallinta();
            palvelut.Show();
        }

        /////////////////////
        //     ASIAKAS     //
        /////////////////////
        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            Asiakashallinta asiakas_lisaa = new Asiakashallinta();
            asiakas_lisaa.Show();
        }

        private void btnAsiakas_asiakkaat_Click(object sender, EventArgs e)
        {
            Asiakashallinta asiakas_asiakkaat = new Asiakashallinta();
            asiakas_asiakkaat.tabControl1.SelectTab(1);
            asiakas_asiakkaat.Show();
        }

        /////////////////////
        //      MÖKKI      //
        /////////////////////

        private void btnMokki_Click(object sender, EventArgs e)
        {
            Mokinluominen mokki_lisaa = new Mokinluominen();
            mokki_lisaa.Show();
        }

        private void btnMokki_muokkaa_Click(object sender, EventArgs e)
        {
            Mokinluominen mokki_muokkaa = new Mokinluominen();
            mokki_muokkaa.tabControl1.SelectTab(1);
            mokki_muokkaa.Show();
        }

        private void btnMokki_toimialueet_Click(object sender, EventArgs e)
        {
            Aluehallinta toimialue = new Aluehallinta();
            toimialue.Show();
        }

        ////////////////////////
        //      RAPORTTI      //
        ////////////////////////
        private void btnRaportti_Click(object sender, EventArgs e)
        {
            raportti raporttiform = new raportti();
            raporttiform.Show();
        }
    }
}
