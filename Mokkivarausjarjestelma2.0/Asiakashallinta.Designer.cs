
namespace Mokkivarausjarjestelma2._0
{
    partial class Asiakashallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asiakashallinta));
            this.lbPostinro = new System.Windows.Forms.Label();
            this.btnPaivitaasiakas = new System.Windows.Forms.Button();
            this.tbAsiakasID = new System.Windows.Forms.TextBox();
            this.lbAsiakasID = new System.Windows.Forms.Label();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.tabUusi = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPeru = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lbSukunimi = new System.Windows.Forms.Label();
            this.lbAsiakas = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbEtunimi = new System.Windows.Forms.Label();
            this.lbSahkoposti = new System.Windows.Forms.Label();
            this.lbPuhelin = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAsiakkaat = new System.Windows.Forms.TabPage();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.asiakasTableAdapter();
            this.postiTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.postiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            this.tabUusi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAsiakkaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPostinro
            // 
            this.lbPostinro.AutoSize = true;
            this.lbPostinro.Location = new System.Drawing.Point(53, 193);
            this.lbPostinro.Name = "lbPostinro";
            this.lbPostinro.Size = new System.Drawing.Size(65, 13);
            this.lbPostinro.TabIndex = 12;
            this.lbPostinro.Text = "Postinumero";
            // 
            // btnPaivitaasiakas
            // 
            this.btnPaivitaasiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaivitaasiakas.Location = new System.Drawing.Point(547, 283);
            this.btnPaivitaasiakas.Name = "btnPaivitaasiakas";
            this.btnPaivitaasiakas.Size = new System.Drawing.Size(72, 28);
            this.btnPaivitaasiakas.TabIndex = 8;
            this.btnPaivitaasiakas.Text = "Päivitä";
            this.btnPaivitaasiakas.UseVisualStyleBackColor = true;
            this.btnPaivitaasiakas.Click += new System.EventHandler(this.btnPaivitaasiakas_Click);
            // 
            // tbAsiakasID
            // 
            this.tbAsiakasID.Location = new System.Drawing.Point(124, 56);
            this.tbAsiakasID.Name = "tbAsiakasID";
            this.tbAsiakasID.ReadOnly = true;
            this.tbAsiakasID.Size = new System.Drawing.Size(51, 20);
            this.tbAsiakasID.TabIndex = 15;
            // 
            // lbAsiakasID
            // 
            this.lbAsiakasID.AutoSize = true;
            this.lbAsiakasID.Location = new System.Drawing.Point(60, 59);
            this.lbAsiakasID.Name = "lbAsiakasID";
            this.lbAsiakasID.Size = new System.Drawing.Size(58, 13);
            this.lbAsiakasID.TabIndex = 14;
            this.lbAsiakasID.Text = "Asiakas ID";
            // 
            // cbPostinro
            // 
            this.cbPostinro.DataSource = this.postiBindingSource;
            this.cbPostinro.DisplayMember = "postinro";
            this.cbPostinro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(124, 190);
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(157, 21);
            this.cbPostinro.TabIndex = 4;
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.kaikkidataBindingSource;
            // 
            // kaikkidataBindingSource
            // 
            this.kaikkidataBindingSource.DataSource = this.kaikkidata;
            this.kaikkidataBindingSource.Position = 0;
            // 
            // kaikkidata
            // 
            this.kaikkidata.DataSetName = "Kaikkidata";
            this.kaikkidata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUusi
            // 
            this.tabUusi.Controls.Add(this.pictureBox1);
            this.tabUusi.Controls.Add(this.btnPaivitaasiakas);
            this.tabUusi.Controls.Add(this.tbAsiakasID);
            this.tabUusi.Controls.Add(this.lbAsiakasID);
            this.tabUusi.Controls.Add(this.cbPostinro);
            this.tabUusi.Controls.Add(this.lbPostinro);
            this.tabUusi.Controls.Add(this.btnPeru);
            this.tabUusi.Controls.Add(this.btnTallenna);
            this.tabUusi.Controls.Add(this.tbPuhnro);
            this.tabUusi.Controls.Add(this.tbSahkoposti);
            this.tabUusi.Controls.Add(this.tbLahiosoite);
            this.tabUusi.Controls.Add(this.tbSukunimi);
            this.tabUusi.Controls.Add(this.tbEtunimi);
            this.tabUusi.Controls.Add(this.lbSukunimi);
            this.tabUusi.Controls.Add(this.lbAsiakas);
            this.tabUusi.Controls.Add(this.lbLahiosoite);
            this.tabUusi.Controls.Add(this.lbEtunimi);
            this.tabUusi.Controls.Add(this.lbSahkoposti);
            this.tabUusi.Controls.Add(this.lbPuhelin);
            this.tabUusi.Location = new System.Drawing.Point(4, 22);
            this.tabUusi.Name = "tabUusi";
            this.tabUusi.Padding = new System.Windows.Forms.Padding(3);
            this.tabUusi.Size = new System.Drawing.Size(744, 331);
            this.tabUusi.TabIndex = 0;
            this.tabUusi.Text = "Lisää Asiakas";
            this.tabUusi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 240);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnPeru
            // 
            this.btnPeru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeru.Location = new System.Drawing.Point(625, 283);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(72, 28);
            this.btnPeru.TabIndex = 9;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Click += new System.EventHandler(this.btnPeru_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTallenna.Location = new System.Drawing.Point(469, 283);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(72, 28);
            this.btnTallenna.TabIndex = 7;
            this.btnTallenna.Text = "Uusi";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Location = new System.Drawing.Point(124, 256);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(157, 20);
            this.tbPuhnro.TabIndex = 6;
            this.tbPuhnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhnro_KeyPress);
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(124, 223);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(157, 20);
            this.tbSahkoposti.TabIndex = 5;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(124, 154);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(157, 20);
            this.tbLahiosoite.TabIndex = 3;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(124, 122);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(157, 20);
            this.tbSukunimi.TabIndex = 2;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(124, 88);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(157, 20);
            this.tbEtunimi.TabIndex = 1;
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(68, 125);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lbSukunimi.TabIndex = 1;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbAsiakas
            // 
            this.lbAsiakas.AutoSize = true;
            this.lbAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsiakas.Location = new System.Drawing.Point(8, 19);
            this.lbAsiakas.Name = "lbAsiakas";
            this.lbAsiakas.Size = new System.Drawing.Size(111, 20);
            this.lbAsiakas.TabIndex = 0;
            this.lbAsiakas.Text = "Uusi asiakas";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(63, 157);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lbLahiosoite.TabIndex = 2;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(77, 91);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lbEtunimi.TabIndex = 0;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lbSahkoposti
            // 
            this.lbSahkoposti.AutoSize = true;
            this.lbSahkoposti.Location = new System.Drawing.Point(30, 226);
            this.lbSahkoposti.Name = "lbSahkoposti";
            this.lbSahkoposti.Size = new System.Drawing.Size(88, 13);
            this.lbSahkoposti.TabIndex = 3;
            this.lbSahkoposti.Text = "Sähköpostiosoite";
            // 
            // lbPuhelin
            // 
            this.lbPuhelin.AutoSize = true;
            this.lbPuhelin.Location = new System.Drawing.Point(41, 259);
            this.lbPuhelin.Name = "lbPuhelin";
            this.lbPuhelin.Size = new System.Drawing.Size(77, 13);
            this.lbPuhelin.TabIndex = 4;
            this.lbPuhelin.Text = "Puhelinnumero";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUusi);
            this.tabControl1.Controls.Add(this.tabAsiakkaat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 357);
            this.tabControl1.TabIndex = 3;
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.btnPoista);
            this.tabAsiakkaat.Controls.Add(this.btnMuokkaa);
            this.tabAsiakkaat.Controls.Add(this.dgvAsiakkaat);
            this.tabAsiakkaat.Location = new System.Drawing.Point(4, 22);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsiakkaat.Size = new System.Drawing.Size(744, 331);
            this.tabAsiakkaat.TabIndex = 1;
            this.tabAsiakkaat.Text = "Asiakkaat";
            this.tabAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(640, 295);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(98, 30);
            this.btnPoista.TabIndex = 5;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaa.Location = new System.Drawing.Point(536, 295);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(98, 30);
            this.btnMuokkaa.TabIndex = 6;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoGenerateColumns = false;
            this.dgvAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvAsiakkaat.DataSource = this.asiakasBindingSource;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(0, 0);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.ReadOnly = true;
            this.dgvAsiakkaat.RowTemplate.Height = 25;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(741, 287);
            this.dgvAsiakkaat.TabIndex = 1;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.kaikkidataBindingSource;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // Asiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 357);
            this.Controls.Add(this.tabControl1);
            this.Name = "Asiakashallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Newbies - Asiakashallinta";
            this.Load += new System.EventHandler(this.Asiakashallinta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            this.tabUusi.ResumeLayout(false);
            this.tabUusi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAsiakkaat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPostinro;
        private System.Windows.Forms.Button btnPaivitaasiakas;
        private System.Windows.Forms.TextBox tbAsiakasID;
        private System.Windows.Forms.Label lbAsiakasID;
        private System.Windows.Forms.ComboBox cbPostinro;
        private System.Windows.Forms.TabPage tabUusi;
        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lbSukunimi;
        private System.Windows.Forms.Label lbAsiakas;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbEtunimi;
        private System.Windows.Forms.Label lbSahkoposti;
        private System.Windows.Forms.Label lbPuhelin;
        private System.Windows.Forms.TabPage tabAsiakkaat;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.BindingSource kaikkidataBindingSource;
        private Kaikkidata kaikkidata;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private KaikkidataTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private KaikkidataTableAdapters.postiTableAdapter postiTableAdapter;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}