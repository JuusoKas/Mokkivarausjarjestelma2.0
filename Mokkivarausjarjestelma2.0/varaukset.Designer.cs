﻿
namespace Mokkivarausjarjestelma2._0
{
    partial class varaukset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(varaukset));
            this.btnMuokkaavarausta = new System.Windows.Forms.Button();
            this.dtpVahvistuspaiva = new System.Windows.Forms.DateTimePicker();
            this.lbVahvistus = new System.Windows.Forms.Label();
            this.dtpVarauspaiva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAsiakasID = new System.Windows.Forms.Label();
            this.lbPalvelut = new System.Windows.Forms.Label();
            this.tabPalvelut = new System.Windows.Forms.TabPage();
            this.btnPoistapalvelu = new System.Windows.Forms.Button();
            this.dgvVarauksenpalvelut = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.tbLukumaara = new System.Windows.Forms.TextBox();
            this.lbLukumaara = new System.Windows.Forms.Label();
            this.lbPalvelu = new System.Windows.Forms.Label();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPalveluID = new System.Windows.Forms.ComboBox();
            this.lbPalveluID = new System.Windows.Forms.Label();
            this.cbVarausID = new System.Windows.Forms.ComboBox();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbVaraus = new System.Windows.Forms.Label();
            this.lbMokkiID = new System.Windows.Forms.Label();
            this.tbAsiakas = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbID2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dtpUloskirjautuminen = new System.Windows.Forms.DateTimePicker();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.dtpSisaankirjautuminen = new System.Windows.Forms.DateTimePicker();
            this.lbCheckin = new System.Windows.Forms.Label();
            this.btnMokki = new System.Windows.Forms.Button();
            this.tbMokki = new System.Windows.Forms.TextBox();
            this.lbMokki = new System.Windows.Forms.Label();
            this.btnAsiakaslista = new System.Windows.Forms.Button();
            this.lbAsiakas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSuodatalopetus = new System.Windows.Forms.DateTimePicker();
            this.dtpSuodataaloitus = new System.Windows.Forms.DateTimePicker();
            this.cbSuodata = new System.Windows.Forms.CheckBox();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.varausTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.varausTableAdapter();
            this.aluedata1 = new Mokkivarausjarjestelma2._0.Aluedata1();
            this.varauksen_palvelutTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.varauksen_palvelutTableAdapter();
            this.palveluTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.palveluTableAdapter();
            this.tabPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMuokkaavarausta
            // 
            this.btnMuokkaavarausta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaavarausta.Location = new System.Drawing.Point(596, 289);
            this.btnMuokkaavarausta.Name = "btnMuokkaavarausta";
            this.btnMuokkaavarausta.Size = new System.Drawing.Size(74, 28);
            this.btnMuokkaavarausta.TabIndex = 45;
            this.btnMuokkaavarausta.Text = "Päivitä";
            this.btnMuokkaavarausta.UseVisualStyleBackColor = true;
            this.btnMuokkaavarausta.Click += new System.EventHandler(this.btnMuokkaavarausta_Click);
            // 
            // dtpVahvistuspaiva
            // 
            this.dtpVahvistuspaiva.Enabled = false;
            this.dtpVahvistuspaiva.Location = new System.Drawing.Point(128, 163);
            this.dtpVahvistuspaiva.Name = "dtpVahvistuspaiva";
            this.dtpVahvistuspaiva.Size = new System.Drawing.Size(211, 20);
            this.dtpVahvistuspaiva.TabIndex = 3;
            // 
            // lbVahvistus
            // 
            this.lbVahvistus.AutoSize = true;
            this.lbVahvistus.Location = new System.Drawing.Point(38, 163);
            this.lbVahvistus.Name = "lbVahvistus";
            this.lbVahvistus.Size = new System.Drawing.Size(79, 13);
            this.lbVahvistus.TabIndex = 43;
            this.lbVahvistus.Text = "Vahvistuspäivä";
            // 
            // dtpVarauspaiva
            // 
            this.dtpVarauspaiva.Location = new System.Drawing.Point(128, 193);
            this.dtpVarauspaiva.Name = "dtpVarauspaiva";
            this.dtpVarauspaiva.Size = new System.Drawing.Size(211, 20);
            this.dtpVarauspaiva.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Varauspäivä";
            // 
            // tbVarausID
            // 
            this.tbVarausID.Location = new System.Drawing.Point(128, 53);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.ReadOnly = true;
            this.tbVarausID.Size = new System.Drawing.Size(37, 20);
            this.tbVarausID.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Varaus ID";
            // 
            // lbAsiakasID
            // 
            this.lbAsiakasID.AutoSize = true;
            this.lbAsiakasID.Location = new System.Drawing.Point(378, 88);
            this.lbAsiakasID.Name = "lbAsiakasID";
            this.lbAsiakasID.Size = new System.Drawing.Size(34, 13);
            this.lbAsiakasID.TabIndex = 37;
            this.lbAsiakasID.Text = "         ";
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.AutoSize = true;
            this.lbPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbPalvelut.Location = new System.Drawing.Point(3, 17);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.Size = new System.Drawing.Size(198, 20);
            this.lbPalvelut.TabIndex = 1;
            this.lbPalvelut.Text = "Lisää palvelu tilaukselle";
            // 
            // tabPalvelut
            // 
            this.tabPalvelut.Controls.Add(this.btnPoistapalvelu);
            this.tabPalvelut.Controls.Add(this.dgvVarauksenpalvelut);
            this.tabPalvelut.Controls.Add(this.btnLisaa);
            this.tabPalvelut.Controls.Add(this.lb);
            this.tabPalvelut.Controls.Add(this.tbLukumaara);
            this.tabPalvelut.Controls.Add(this.lbLukumaara);
            this.tabPalvelut.Controls.Add(this.cbPalveluID);
            this.tabPalvelut.Controls.Add(this.lbPalveluID);
            this.tabPalvelut.Controls.Add(this.cbVarausID);
            this.tabPalvelut.Controls.Add(this.lbVaraus);
            this.tabPalvelut.Controls.Add(this.lbPalvelut);
            this.tabPalvelut.Controls.Add(this.lbPalvelu);
            this.tabPalvelut.Location = new System.Drawing.Point(4, 22);
            this.tabPalvelut.Name = "tabPalvelut";
            this.tabPalvelut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPalvelut.Size = new System.Drawing.Size(777, 329);
            this.tabPalvelut.TabIndex = 2;
            this.tabPalvelut.Text = "Palvelut";
            this.tabPalvelut.UseVisualStyleBackColor = true;
            // 
            // btnPoistapalvelu
            // 
            this.btnPoistapalvelu.Location = new System.Drawing.Point(137, 169);
            this.btnPoistapalvelu.Name = "btnPoistapalvelu";
            this.btnPoistapalvelu.Size = new System.Drawing.Size(65, 26);
            this.btnPoistapalvelu.TabIndex = 48;
            this.btnPoistapalvelu.Text = "Poista";
            this.btnPoistapalvelu.UseVisualStyleBackColor = true;
            this.btnPoistapalvelu.Click += new System.EventHandler(this.btnPoistapalvelu_Click);
            // 
            // dgvVarauksenpalvelut
            // 
            this.dgvVarauksenpalvelut.AllowUserToAddRows = false;
            this.dgvVarauksenpalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarauksenpalvelut.AutoGenerateColumns = false;
            this.dgvVarauksenpalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarauksenpalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenpalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn1,
            this.palveluidDataGridViewTextBoxColumn,
            this.lkmDataGridViewTextBoxColumn});
            this.dgvVarauksenpalvelut.DataSource = this.varauksenpalvelutBindingSource;
            this.dgvVarauksenpalvelut.Location = new System.Drawing.Point(222, 0);
            this.dgvVarauksenpalvelut.Name = "dgvVarauksenpalvelut";
            this.dgvVarauksenpalvelut.ReadOnly = true;
            this.dgvVarauksenpalvelut.Size = new System.Drawing.Size(555, 329);
            this.dgvVarauksenpalvelut.TabIndex = 47;
            // 
            // varausidDataGridViewTextBoxColumn1
            // 
            this.varausidDataGridViewTextBoxColumn1.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn1.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn1.Name = "varausidDataGridViewTextBoxColumn1";
            this.varausidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            this.palveluidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lkmDataGridViewTextBoxColumn
            // 
            this.lkmDataGridViewTextBoxColumn.DataPropertyName = "lkm";
            this.lkmDataGridViewTextBoxColumn.HeaderText = "lkm";
            this.lkmDataGridViewTextBoxColumn.Name = "lkmDataGridViewTextBoxColumn";
            this.lkmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varauksenpalvelutBindingSource
            // 
            this.varauksenpalvelutBindingSource.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource.DataSource = this.kaikkidata;
            // 
            // kaikkidata
            // 
            this.kaikkidata.DataSetName = "Kaikkidata";
            this.kaikkidata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(66, 169);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(65, 26);
            this.btnLisaa.TabIndex = 46;
            this.btnLisaa.Text = "Lisää ";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(147, 45);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(21, 13);
            this.lb.TabIndex = 45;
            this.lb.Text = "ID:";
            this.lb.Visible = false;
            // 
            // tbLukumaara
            // 
            this.tbLukumaara.Location = new System.Drawing.Point(73, 131);
            this.tbLukumaara.Name = "tbLukumaara";
            this.tbLukumaara.Size = new System.Drawing.Size(129, 20);
            this.tbLukumaara.TabIndex = 44;
            this.tbLukumaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // lbLukumaara
            // 
            this.lbLukumaara.AutoSize = true;
            this.lbLukumaara.Location = new System.Drawing.Point(13, 134);
            this.lbLukumaara.Name = "lbLukumaara";
            this.lbLukumaara.Size = new System.Drawing.Size(37, 13);
            this.lbLukumaara.TabIndex = 43;
            this.lbLukumaara.Text = "Määrä";
            // 
            // lbPalvelu
            // 
            this.lbPalvelu.AutoSize = true;
            this.lbPalvelu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.palveluBindingSource, "palvelu_id", true));
            this.lbPalvelu.Location = new System.Drawing.Point(94, 176);
            this.lbPalvelu.Name = "lbPalvelu";
            this.lbPalvelu.Size = new System.Drawing.Size(34, 13);
            this.lbPalvelu.TabIndex = 42;
            this.lbPalvelu.Text = "         ";
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.kaikkidata;
            // 
            // cbPalveluID
            // 
            this.cbPalveluID.DataSource = this.palveluBindingSource;
            this.cbPalveluID.DisplayMember = "nimi";
            this.cbPalveluID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalveluID.FormattingEnabled = true;
            this.cbPalveluID.Location = new System.Drawing.Point(73, 101);
            this.cbPalveluID.Name = "cbPalveluID";
            this.cbPalveluID.Size = new System.Drawing.Size(129, 21);
            this.cbPalveluID.TabIndex = 41;
            // 
            // lbPalveluID
            // 
            this.lbPalveluID.AutoSize = true;
            this.lbPalveluID.Location = new System.Drawing.Point(13, 104);
            this.lbPalveluID.Name = "lbPalveluID";
            this.lbPalveluID.Size = new System.Drawing.Size(56, 13);
            this.lbPalveluID.TabIndex = 40;
            this.lbPalveluID.Text = "Palvelu ID";
            // 
            // cbVarausID
            // 
            this.cbVarausID.DataSource = this.varausBindingSource;
            this.cbVarausID.DisplayMember = "varaus_id";
            this.cbVarausID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarausID.FormattingEnabled = true;
            this.cbVarausID.Location = new System.Drawing.Point(73, 68);
            this.cbVarausID.Name = "cbVarausID";
            this.cbVarausID.Size = new System.Drawing.Size(129, 21);
            this.cbVarausID.TabIndex = 39;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.kaikkidata;
            // 
            // lbVaraus
            // 
            this.lbVaraus.AutoSize = true;
            this.lbVaraus.Location = new System.Drawing.Point(13, 71);
            this.lbVaraus.Name = "lbVaraus";
            this.lbVaraus.Size = new System.Drawing.Size(54, 13);
            this.lbVaraus.TabIndex = 38;
            this.lbVaraus.Text = "Varaus ID";
            // 
            // lbMokkiID
            // 
            this.lbMokkiID.AutoSize = true;
            this.lbMokkiID.Location = new System.Drawing.Point(378, 117);
            this.lbMokkiID.Name = "lbMokkiID";
            this.lbMokkiID.Size = new System.Drawing.Size(34, 13);
            this.lbMokkiID.TabIndex = 38;
            this.lbMokkiID.Text = "         ";
            // 
            // tbAsiakas
            // 
            this.tbAsiakas.BackColor = System.Drawing.SystemColors.Control;
            this.tbAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAsiakas.Location = new System.Drawing.Point(128, 83);
            this.tbAsiakas.Multiline = true;
            this.tbAsiakas.Name = "tbAsiakas";
            this.tbAsiakas.ReadOnly = true;
            this.tbAsiakas.Size = new System.Drawing.Size(188, 20);
            this.tbAsiakas.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnMuokkaavarausta);
            this.tabPage1.Controls.Add(this.dtpVahvistuspaiva);
            this.tabPage1.Controls.Add(this.lbVahvistus);
            this.tabPage1.Controls.Add(this.dtpVarauspaiva);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbVarausID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbMokkiID);
            this.tabPage1.Controls.Add(this.lbAsiakasID);
            this.tabPage1.Controls.Add(this.tbAsiakas);
            this.tabPage1.Controls.Add(this.lbID2);
            this.tabPage1.Controls.Add(this.lbID);
            this.tabPage1.Controls.Add(this.btnPeruuta);
            this.tabPage1.Controls.Add(this.btnCheckin);
            this.tabPage1.Controls.Add(this.dtpUloskirjautuminen);
            this.tabPage1.Controls.Add(this.lbCheckout);
            this.tabPage1.Controls.Add(this.dtpSisaankirjautuminen);
            this.tabPage1.Controls.Add(this.lbCheckin);
            this.tabPage1.Controls.Add(this.btnMokki);
            this.tabPage1.Controls.Add(this.tbMokki);
            this.tabPage1.Controls.Add(this.lbMokki);
            this.tabPage1.Controls.Add(this.btnAsiakaslista);
            this.tabPage1.Controls.Add(this.lbAsiakas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Varaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 240);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lbID2
            // 
            this.lbID2.AutoSize = true;
            this.lbID2.Location = new System.Drawing.Point(360, 116);
            this.lbID2.Name = "lbID2";
            this.lbID2.Size = new System.Drawing.Size(24, 13);
            this.lbID2.TabIndex = 22;
            this.lbID2.Text = "ID: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(361, 88);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 21;
            this.lbID.Text = "ID: ";
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeruuta.Location = new System.Drawing.Point(676, 289);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(74, 28);
            this.btnPeruuta.TabIndex = 14;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckin.Location = new System.Drawing.Point(516, 289);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(74, 28);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Varaa";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // dtpUloskirjautuminen
            // 
            this.dtpUloskirjautuminen.CustomFormat = "dddd dd MMMM yyyy";
            this.dtpUloskirjautuminen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUloskirjautuminen.Location = new System.Drawing.Point(128, 253);
            this.dtpUloskirjautuminen.Name = "dtpUloskirjautuminen";
            this.dtpUloskirjautuminen.Size = new System.Drawing.Size(211, 20);
            this.dtpUloskirjautuminen.TabIndex = 6;
            this.dtpUloskirjautuminen.Leave += new System.EventHandler(this.dtpSisaankirjautuminen_ValueChanged);
            // 
            // lbCheckout
            // 
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Location = new System.Drawing.Point(27, 253);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(90, 13);
            this.lbCheckout.TabIndex = 11;
            this.lbCheckout.Text = "Uloskirjautuminen";
            // 
            // dtpSisaankirjautuminen
            // 
            this.dtpSisaankirjautuminen.CustomFormat = "dddd dd MMMM yyyy";
            this.dtpSisaankirjautuminen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSisaankirjautuminen.Location = new System.Drawing.Point(128, 223);
            this.dtpSisaankirjautuminen.Name = "dtpSisaankirjautuminen";
            this.dtpSisaankirjautuminen.Size = new System.Drawing.Size(211, 20);
            this.dtpSisaankirjautuminen.TabIndex = 5;
            // 
            // lbCheckin
            // 
            this.lbCheckin.AutoSize = true;
            this.lbCheckin.Location = new System.Drawing.Point(21, 225);
            this.lbCheckin.Name = "lbCheckin";
            this.lbCheckin.Size = new System.Drawing.Size(101, 13);
            this.lbCheckin.TabIndex = 9;
            this.lbCheckin.Text = "Sisäänkirjautuminen";
            // 
            // btnMokki
            // 
            this.btnMokki.Location = new System.Drawing.Point(322, 113);
            this.btnMokki.Name = "btnMokki";
            this.btnMokki.Size = new System.Drawing.Size(34, 20);
            this.btnMokki.TabIndex = 6;
            this.btnMokki.Text = "...";
            this.btnMokki.UseVisualStyleBackColor = true;
            this.btnMokki.Click += new System.EventHandler(this.btnMokki_Click);
            // 
            // tbMokki
            // 
            this.tbMokki.Location = new System.Drawing.Point(128, 113);
            this.tbMokki.Name = "tbMokki";
            this.tbMokki.ReadOnly = true;
            this.tbMokki.Size = new System.Drawing.Size(188, 20);
            this.tbMokki.TabIndex = 2;
            // 
            // lbMokki
            // 
            this.lbMokki.AutoSize = true;
            this.lbMokki.Location = new System.Drawing.Point(81, 116);
            this.lbMokki.Name = "lbMokki";
            this.lbMokki.Size = new System.Drawing.Size(36, 13);
            this.lbMokki.TabIndex = 4;
            this.lbMokki.Text = "Mökki";
            // 
            // btnAsiakaslista
            // 
            this.btnAsiakaslista.Location = new System.Drawing.Point(322, 83);
            this.btnAsiakaslista.Name = "btnAsiakaslista";
            this.btnAsiakaslista.Size = new System.Drawing.Size(34, 22);
            this.btnAsiakaslista.TabIndex = 3;
            this.btnAsiakaslista.Text = "...";
            this.btnAsiakaslista.UseVisualStyleBackColor = true;
            this.btnAsiakaslista.Click += new System.EventHandler(this.btnAsiakas_Click);
            // 
            // lbAsiakas
            // 
            this.lbAsiakas.AutoSize = true;
            this.lbAsiakas.Location = new System.Drawing.Point(73, 84);
            this.lbAsiakas.Name = "lbAsiakas";
            this.lbAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lbAsiakas.TabIndex = 1;
            this.lbAsiakas.Text = "Asiakas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uusi varaus";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpSuodatalopetus);
            this.tabPage2.Controls.Add(this.dtpSuodataaloitus);
            this.tabPage2.Controls.Add(this.cbSuodata);
            this.tabPage2.Controls.Add(this.dgvVaraukset);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Varaukset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Suodata välillä (varauspäivämäärä):";
            // 
            // dtpSuodatalopetus
            // 
            this.dtpSuodatalopetus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpSuodatalopetus.Location = new System.Drawing.Point(215, 295);
            this.dtpSuodatalopetus.Name = "dtpSuodatalopetus";
            this.dtpSuodatalopetus.Size = new System.Drawing.Size(200, 20);
            this.dtpSuodatalopetus.TabIndex = 9;
            this.dtpSuodatalopetus.CloseUp += new System.EventHandler(this.cbSuodata_CheckedChanged);
            // 
            // dtpSuodataaloitus
            // 
            this.dtpSuodataaloitus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpSuodataaloitus.Checked = false;
            this.dtpSuodataaloitus.Location = new System.Drawing.Point(9, 295);
            this.dtpSuodataaloitus.Name = "dtpSuodataaloitus";
            this.dtpSuodataaloitus.Size = new System.Drawing.Size(200, 20);
            this.dtpSuodataaloitus.TabIndex = 8;
            this.dtpSuodataaloitus.CloseUp += new System.EventHandler(this.cbSuodata_CheckedChanged);
            // 
            // cbSuodata
            // 
            this.cbSuodata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSuodata.AutoSize = true;
            this.cbSuodata.Checked = true;
            this.cbSuodata.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSuodata.Location = new System.Drawing.Point(421, 298);
            this.cbSuodata.Name = "cbSuodata";
            this.cbSuodata.Size = new System.Drawing.Size(66, 17);
            this.cbSuodata.TabIndex = 7;
            this.cbSuodata.Text = "Suodata";
            this.cbSuodata.UseVisualStyleBackColor = true;
            this.cbSuodata.CheckedChanged += new System.EventHandler(this.cbSuodata_CheckedChanged);
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AllowUserToAddRows = false;
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(-4, 0);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.ReadOnly = true;
            this.dgvVaraukset.Size = new System.Drawing.Size(785, 261);
            this.dgvVaraukset.TabIndex = 5;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaa.Location = new System.Drawing.Point(569, 291);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(98, 32);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(673, 291);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(98, 32);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPalvelut);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 355);
            this.tabControl1.TabIndex = 2;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // aluedata1
            // 
            this.aluedata1.DataSetName = "Aluedata1";
            this.aluedata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "varaukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Newbies - Varaukset";
            this.Load += new System.EventHandler(this.Mokinvaraaminen_Load);
            this.tabPalvelut.ResumeLayout(false);
            this.tabPalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuokkaavarausta;
        private System.Windows.Forms.DateTimePicker dtpVahvistuspaiva;
        private System.Windows.Forms.Label lbVahvistus;
        private System.Windows.Forms.DateTimePicker dtpVarauspaiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAsiakasID;
        private System.Windows.Forms.Label lbPalvelut;
        private System.Windows.Forms.TabPage tabPalvelut;
        private System.Windows.Forms.Button btnPoistapalvelu;
        private System.Windows.Forms.DataGridView dgvVarauksenpalvelut;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbLukumaara;
        private System.Windows.Forms.Label lbLukumaara;
        private System.Windows.Forms.Label lbPalvelu;
        private System.Windows.Forms.ComboBox cbPalveluID;
        private System.Windows.Forms.Label lbPalveluID;
        private System.Windows.Forms.ComboBox cbVarausID;
        private System.Windows.Forms.Label lbVaraus;
        private System.Windows.Forms.Label lbMokkiID;
        private System.Windows.Forms.TextBox tbAsiakas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbID2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.DateTimePicker dtpUloskirjautuminen;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.DateTimePicker dtpSisaankirjautuminen;
        private System.Windows.Forms.Label lbCheckin;
        private System.Windows.Forms.Button btnMokki;
        private System.Windows.Forms.TextBox tbMokki;
        private System.Windows.Forms.Label lbMokki;
        private System.Windows.Forms.Button btnAsiakaslista;
        private System.Windows.Forms.Label lbAsiakas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private Kaikkidata kaikkidata;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private KaikkidataTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private Aluedata1 aluedata1;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private KaikkidataTableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private KaikkidataTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.CheckBox cbSuodata;
        private System.Windows.Forms.DateTimePicker dtpSuodatalopetus;
        private System.Windows.Forms.DateTimePicker dtpSuodataaloitus;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}