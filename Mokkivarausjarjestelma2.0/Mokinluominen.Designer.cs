
namespace Mokkivarausjarjestelma2._0
{
    partial class Mokinluominen
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
            this.pnMokki = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbToimintanimi = new System.Windows.Forms.Label();
            this.lbToimintaAlue = new System.Windows.Forms.Label();
            this.lbAlue = new System.Windows.Forms.Label();
            this.cbPosti = new System.Windows.Forms.ComboBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.lbPostinumero = new System.Windows.Forms.Label();
            this.cbToiminta = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbToiminta = new System.Windows.Forms.Label();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.lbMokkiID = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokinnimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHenkilo = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbOsoite = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbMokki = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.toimintaalueTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.toimintaalueTableAdapter();
            this.postiTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.postiTableAdapter();
            this.mokkiTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.mokkiTableAdapter();
            this.pnMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMokki
            // 
            this.pnMokki.Controls.Add(this.button1);
            this.pnMokki.Controls.Add(this.label1);
            this.pnMokki.Controls.Add(this.lbToimintanimi);
            this.pnMokki.Controls.Add(this.lbToimintaAlue);
            this.pnMokki.Controls.Add(this.lbAlue);
            this.pnMokki.Controls.Add(this.cbPosti);
            this.pnMokki.Controls.Add(this.lbPostinumero);
            this.pnMokki.Controls.Add(this.cbToiminta);
            this.pnMokki.Controls.Add(this.lbToiminta);
            this.pnMokki.Controls.Add(this.tbMokkiID);
            this.pnMokki.Controls.Add(this.lbMokkiID);
            this.pnMokki.Controls.Add(this.btnPeruuta);
            this.pnMokki.Controls.Add(this.btnTallenna);
            this.pnMokki.Controls.Add(this.tbVarustelu);
            this.pnMokki.Controls.Add(this.tbHenkilomaara);
            this.pnMokki.Controls.Add(this.tbKuvaus);
            this.pnMokki.Controls.Add(this.tbKatuosoite);
            this.pnMokki.Controls.Add(this.tbMokinnimi);
            this.pnMokki.Controls.Add(this.label2);
            this.pnMokki.Controls.Add(this.lbHenkilo);
            this.pnMokki.Controls.Add(this.lbKuvaus);
            this.pnMokki.Controls.Add(this.lbOsoite);
            this.pnMokki.Controls.Add(this.lbNimi);
            this.pnMokki.Location = new System.Drawing.Point(13, 56);
            this.pnMokki.Name = "pnMokki";
            this.pnMokki.Size = new System.Drawing.Size(421, 284);
            this.pnMokki.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Päivitä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // lbToimintanimi
            // 
            this.lbToimintanimi.AutoSize = true;
            this.lbToimintanimi.Location = new System.Drawing.Point(214, 40);
            this.lbToimintanimi.Name = "lbToimintanimi";
            this.lbToimintanimi.Size = new System.Drawing.Size(25, 13);
            this.lbToimintanimi.TabIndex = 22;
            this.lbToimintanimi.Text = "      ";
            // 
            // lbToimintaAlue
            // 
            this.lbToimintaAlue.AutoSize = true;
            this.lbToimintaAlue.Location = new System.Drawing.Point(183, 40);
            this.lbToimintaAlue.Name = "lbToimintaAlue";
            this.lbToimintaAlue.Size = new System.Drawing.Size(34, 13);
            this.lbToimintaAlue.TabIndex = 21;
            this.lbToimintaAlue.Text = "         ";
            // 
            // lbAlue
            // 
            this.lbAlue.AutoSize = true;
            this.lbAlue.Location = new System.Drawing.Point(183, 40);
            this.lbAlue.Name = "lbAlue";
            this.lbAlue.Size = new System.Drawing.Size(25, 13);
            this.lbAlue.TabIndex = 20;
            this.lbAlue.Text = "      ";
            // 
            // cbPosti
            // 
            this.cbPosti.DataSource = this.postiBindingSource;
            this.cbPosti.DisplayMember = "postinro";
            this.cbPosti.FormattingEnabled = true;
            this.cbPosti.Location = new System.Drawing.Point(91, 120);
            this.cbPosti.Name = "cbPosti";
            this.cbPosti.Size = new System.Drawing.Size(86, 21);
            this.cbPosti.TabIndex = 19;
            this.cbPosti.ValueMember = "postinro";
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.kaikkidata;
            // 
            // kaikkidata
            // 
            this.kaikkidata.DataSetName = "Kaikkidata";
            this.kaikkidata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbPostinumero
            // 
            this.lbPostinumero.AutoSize = true;
            this.lbPostinumero.Location = new System.Drawing.Point(16, 120);
            this.lbPostinumero.Name = "lbPostinumero";
            this.lbPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lbPostinumero.TabIndex = 18;
            this.lbPostinumero.Text = "Postinumero";
            // 
            // cbToiminta
            // 
            this.cbToiminta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.cbToiminta.DataSource = this.toimintaalueBindingSource;
            this.cbToiminta.DisplayMember = "nimi";
            this.cbToiminta.FormattingEnabled = true;
            this.cbToiminta.Location = new System.Drawing.Point(91, 37);
            this.cbToiminta.Name = "cbToiminta";
            this.cbToiminta.Size = new System.Drawing.Size(86, 21);
            this.cbToiminta.TabIndex = 17;
            this.cbToiminta.ValueMember = "toimintaalue_id";
            this.cbToiminta.TextChanged += new System.EventHandler(this.cbToiminta_TextChanged);
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.kaikkidata;
            // 
            // lbToiminta
            // 
            this.lbToiminta.AutoSize = true;
            this.lbToiminta.Location = new System.Drawing.Point(15, 40);
            this.lbToiminta.Name = "lbToiminta";
            this.lbToiminta.Size = new System.Drawing.Size(70, 13);
            this.lbToiminta.TabIndex = 16;
            this.lbToiminta.Text = "Toiminta-alue";
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(91, 11);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.ReadOnly = true;
            this.tbMokkiID.Size = new System.Drawing.Size(86, 20);
            this.tbMokkiID.TabIndex = 15;
            // 
            // lbMokkiID
            // 
            this.lbMokkiID.AutoSize = true;
            this.lbMokkiID.Location = new System.Drawing.Point(15, 11);
            this.lbMokkiID.Name = "lbMokkiID";
            this.lbMokkiID.Size = new System.Drawing.Size(50, 13);
            this.lbMokkiID.TabIndex = 14;
            this.lbMokkiID.Text = "Mökki ID";
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(192, 251);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(81, 30);
            this.btnPeruuta.TabIndex = 13;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(18, 251);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(81, 30);
            this.btnTallenna.TabIndex = 12;
            this.btnTallenna.Text = "Uusi";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(91, 206);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(86, 20);
            this.tbVarustelu.TabIndex = 11;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(91, 180);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(86, 20);
            this.tbHenkilomaara.TabIndex = 10;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(91, 153);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(86, 20);
            this.tbKuvaus.TabIndex = 9;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(91, 93);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(86, 20);
            this.tbKatuosoite.TabIndex = 8;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Location = new System.Drawing.Point(91, 65);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(86, 20);
            this.tbMokinnimi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Varustelu";
            // 
            // lbHenkilo
            // 
            this.lbHenkilo.AutoSize = true;
            this.lbHenkilo.Location = new System.Drawing.Point(16, 180);
            this.lbHenkilo.Name = "lbHenkilo";
            this.lbHenkilo.Size = new System.Drawing.Size(72, 13);
            this.lbHenkilo.TabIndex = 4;
            this.lbHenkilo.Text = "Henkilömäärä";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(16, 153);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(74, 13);
            this.lbKuvaus.TabIndex = 3;
            this.lbKuvaus.Text = "Mökin kuvaus";
            // 
            // lbOsoite
            // 
            this.lbOsoite.AutoSize = true;
            this.lbOsoite.Location = new System.Drawing.Point(15, 93);
            this.lbOsoite.Name = "lbOsoite";
            this.lbOsoite.Size = new System.Drawing.Size(57, 13);
            this.lbOsoite.TabIndex = 2;
            this.lbOsoite.Text = "Katuosoite";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(13, 68);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(57, 13);
            this.lbNimi.TabIndex = 0;
            this.lbNimi.Text = "Mökin nimi";
            // 
            // lbMokki
            // 
            this.lbMokki.AutoSize = true;
            this.lbMokki.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbMokki.Location = new System.Drawing.Point(13, 24);
            this.lbMokki.Name = "lbMokki";
            this.lbMokki.Size = new System.Drawing.Size(81, 20);
            this.lbMokki.TabIndex = 0;
            this.lbMokki.Text = "Uusi mökki";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnMokki);
            this.tabPage1.Controls.Add(this.lbMokki);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökin luonti / muokkaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMokit);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mökit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMokit
            // 
            this.dgvMokit.AllowUserToAddRows = false;
            this.dgvMokit.AutoGenerateColumns = false;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokit.DataSource = this.mokkiBindingSource;
            this.dgvMokit.Location = new System.Drawing.Point(6, 0);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.Size = new System.Drawing.Size(858, 322);
            this.dgvMokit.TabIndex = 4;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            this.mokkiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            this.toimintaalueidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            this.mokkinimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            this.katuosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            this.henkilomaaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            this.varusteluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.kaikkidata;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(760, 328);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(98, 23);
            this.btnPoista.TabIndex = 2;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(649, 328);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(98, 23);
            this.btnMuokkaa.TabIndex = 1;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // Mokinluominen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mokinluominen";
            this.Text = "Mokinluominen";
            this.Load += new System.EventHandler(this.Mokinluominen_Load);
            this.pnMokki.ResumeLayout(false);
            this.pnMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMokki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbToimintanimi;
        private System.Windows.Forms.Label lbToimintaAlue;
        private System.Windows.Forms.Label lbAlue;
        private System.Windows.Forms.ComboBox cbPosti;
        private System.Windows.Forms.Label lbPostinumero;
        private System.Windows.Forms.ComboBox cbToiminta;
        private System.Windows.Forms.Label lbToiminta;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.Label lbMokkiID;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokinnimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHenkilo;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbOsoite;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbMokki;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private Kaikkidata kaikkidata;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private KaikkidataTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private KaikkidataTableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private KaikkidataTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
    }
}