﻿using System;
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
    public partial class palveluhallinta : Form
    {
        public palveluhallinta()
        {
            InitializeComponent();
        }

        private void btnLisaaUusi_Click(object sender, EventArgs e)
        {

        }

        private void palveluhallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaikkidata.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter1.Fill(this.kaikkidata.palvelu);

        }
    }
}