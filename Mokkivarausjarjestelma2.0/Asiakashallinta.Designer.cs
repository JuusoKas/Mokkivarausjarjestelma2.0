
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
            this.lbAsiakkaat = new System.Windows.Forms.Label();
            this.tabAsiakkaat = new System.Windows.Forms.TabPage();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
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
            this.tabUusi = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AsiakkaatdataSet = new Mokkivarausjarjestelma2._0.DataSet1();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mokkivarausjarjestelma2._0.DataSet1TableAdapters.asiakasTableAdapter();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPostinro = new System.Windows.Forms.Label();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postiTableAdapter = new Mokkivarausjarjestelma2._0.DataSet1TableAdapters.postiTableAdapter();
            this.tabAsiakkaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabUusi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAsiakkaat
            // 
            this.lbAsiakkaat.AutoSize = true;
            this.lbAsiakkaat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbAsiakkaat.Location = new System.Drawing.Point(5, 13);
            this.lbAsiakkaat.Name = "lbAsiakkaat";
            this.lbAsiakkaat.Size = new System.Drawing.Size(72, 20);
            this.lbAsiakkaat.TabIndex = 0;
            this.lbAsiakkaat.Text = "Asiakkaat";
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.dgvAsiakkaat);
            this.tabAsiakkaat.Controls.Add(this.lbAsiakkaat);
            this.tabAsiakkaat.Location = new System.Drawing.Point(4, 22);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsiakkaat.Size = new System.Drawing.Size(703, 327);
            this.tabAsiakkaat.TabIndex = 1;
            this.tabAsiakkaat.Text = "Asiakkaat";
            this.tabAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AutoGenerateColumns = false;
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
            this.dgvAsiakkaat.Location = new System.Drawing.Point(1, 48);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowTemplate.Height = 25;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(702, 283);
            this.dgvAsiakkaat.TabIndex = 1;
            // 
            // btnPeru
            // 
            this.btnPeru.Location = new System.Drawing.Point(171, 243);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(90, 36);
            this.btnPeru.TabIndex = 11;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            this.btnPeru.Click += new System.EventHandler(this.btnPeru_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(21, 243);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(90, 36);
            this.btnTallenna.TabIndex = 10;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Location = new System.Drawing.Point(104, 203);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(157, 20);
            this.tbPuhnro.TabIndex = 9;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(104, 172);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(157, 20);
            this.tbSahkoposti.TabIndex = 8;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(104, 112);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(157, 20);
            this.tbLahiosoite.TabIndex = 7;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(104, 86);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(157, 20);
            this.tbSukunimi.TabIndex = 6;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(104, 56);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(157, 20);
            this.tbEtunimi.TabIndex = 5;
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(18, 89);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lbSukunimi.TabIndex = 1;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbAsiakas
            // 
            this.lbAsiakas.AutoSize = true;
            this.lbAsiakas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbAsiakas.Location = new System.Drawing.Point(3, 3);
            this.lbAsiakas.Name = "lbAsiakas";
            this.lbAsiakas.Size = new System.Drawing.Size(164, 20);
            this.lbAsiakas.TabIndex = 0;
            this.lbAsiakas.Text = "Uuden asiakkaan tiedot";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(18, 115);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lbLahiosoite.TabIndex = 2;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(18, 59);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lbEtunimi.TabIndex = 0;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lbSahkoposti
            // 
            this.lbSahkoposti.AutoSize = true;
            this.lbSahkoposti.Location = new System.Drawing.Point(18, 175);
            this.lbSahkoposti.Name = "lbSahkoposti";
            this.lbSahkoposti.Size = new System.Drawing.Size(88, 13);
            this.lbSahkoposti.TabIndex = 3;
            this.lbSahkoposti.Text = "Sähköpostiosoite";
            // 
            // lbPuhelin
            // 
            this.lbPuhelin.AutoSize = true;
            this.lbPuhelin.Location = new System.Drawing.Point(18, 206);
            this.lbPuhelin.Name = "lbPuhelin";
            this.lbPuhelin.Size = new System.Drawing.Size(77, 13);
            this.lbPuhelin.TabIndex = 4;
            this.lbPuhelin.Text = "Puhelinnumero";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUusi);
            this.tabControl1.Controls.Add(this.tabAsiakkaat);
            this.tabControl1.Location = new System.Drawing.Point(5, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 353);
            this.tabControl1.TabIndex = 3;
            // 
            // tabUusi
            // 
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
            this.tabUusi.Size = new System.Drawing.Size(703, 327);
            this.tabUusi.TabIndex = 0;
            this.tabUusi.Text = "Uusi asiakas";
            this.tabUusi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AsiakkaatdataSet
            // 
            this.AsiakkaatdataSet.DataSetName = "DataSet1";
            this.AsiakkaatdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.AsiakkaatdataSet;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            // 
            // lbPostinro
            // 
            this.lbPostinro.AutoSize = true;
            this.lbPostinro.Location = new System.Drawing.Point(18, 145);
            this.lbPostinro.Name = "lbPostinro";
            this.lbPostinro.Size = new System.Drawing.Size(65, 13);
            this.lbPostinro.TabIndex = 12;
            this.lbPostinro.Text = "Postinumero";
            // 
            // cbPostinro
            // 
            this.cbPostinro.DataSource = this.postiBindingSource;
            this.cbPostinro.DisplayMember = "postinro";
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(104, 138);
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(157, 21);
            this.cbPostinro.TabIndex = 13;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.AsiakkaatdataSet;
            this.bindingSource1.Position = 0;
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.AsiakkaatdataSet;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // Asiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Asiakashallinta";
            this.Text = "Asiakashallinta";
            this.Load += new System.EventHandler(this.Asiakashallinta_Load);
            this.tabAsiakkaat.ResumeLayout(false);
            this.tabAsiakkaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabUusi.ResumeLayout(false);
            this.tabUusi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAsiakkaat;
        private System.Windows.Forms.TabPage tabAsiakkaat;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUusi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 AsiakkaatdataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbPostinro;
        private System.Windows.Forms.ComboBox cbPostinro;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private DataSet1TableAdapters.postiTableAdapter postiTableAdapter;
    }
}