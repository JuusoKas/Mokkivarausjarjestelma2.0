
namespace Mokkivarausjarjestelma2._0
{
    partial class Mokinvaraaminen
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Mokkivarausjarjestelma2._0.DataSet1();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAikuiset = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dtpUloskirjautuminen = new System.Windows.Forms.DateTimePicker();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMokkiID = new System.Windows.Forms.Label();
            this.lbAsiakasID = new System.Windows.Forms.Label();
            this.tbAsiakas = new System.Windows.Forms.TextBox();
            this.lbID2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dtpSisaankirjautuminen = new System.Windows.Forms.DateTimePicker();
            this.lbCheckin = new System.Windows.Forms.Label();
            this.lbHinta = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.btnMokki = new System.Windows.Forms.Button();
            this.tbMokki = new System.Windows.Forms.TextBox();
            this.lbMokki = new System.Windows.Forms.Label();
            this.btnAsiakaslista = new System.Windows.Forms.Button();
            this.lbAsiakas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.varausTableAdapter = new Mokkivarausjarjestelma2._0.DataSet1TableAdapters.varausTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpVarauspaiva = new System.Windows.Forms.DateTimePicker();
            this.varausBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AsiakasbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvVaraukset);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Varaukset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.DataSource = this.varausBindingSource1;
            this.dgvVaraukset.Location = new System.Drawing.Point(3, 3);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(746, 272);
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
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(530, 281);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(98, 23);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(634, 281);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(98, 23);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lapsien määrä";
            // 
            // lbAikuiset
            // 
            this.lbAikuiset.AutoSize = true;
            this.lbAikuiset.Location = new System.Drawing.Point(8, 221);
            this.lbAikuiset.Name = "lbAikuiset";
            this.lbAikuiset.Size = new System.Drawing.Size(81, 13);
            this.lbAikuiset.TabIndex = 17;
            this.lbAikuiset.Text = "Aikuisien määrä";
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(540, 277);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(79, 32);
            this.btnPeruuta.TabIndex = 14;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(448, 277);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(79, 32);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Varaa";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // dtpUloskirjautuminen
            // 
            this.dtpUloskirjautuminen.Location = new System.Drawing.Point(103, 160);
            this.dtpUloskirjautuminen.Name = "dtpUloskirjautuminen";
            this.dtpUloskirjautuminen.Size = new System.Drawing.Size(172, 20);
            this.dtpUloskirjautuminen.TabIndex = 12;
            this.dtpUloskirjautuminen.Leave += new System.EventHandler(this.dtpSisaankirjautuminen_ValueChanged);
            // 
            // lbCheckout
            // 
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Location = new System.Drawing.Point(8, 166);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(90, 13);
            this.lbCheckout.TabIndex = 11;
            this.lbCheckout.Text = "Uloskirjautuminen";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 336);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpVarauspaiva);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbVarausID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbMokkiID);
            this.tabPage1.Controls.Add(this.lbAsiakasID);
            this.tabPage1.Controls.Add(this.tbAsiakas);
            this.tabPage1.Controls.Add(this.lbID2);
            this.tabPage1.Controls.Add(this.lbID);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbAikuiset);
            this.tabPage1.Controls.Add(this.btnPeruuta);
            this.tabPage1.Controls.Add(this.btnCheckin);
            this.tabPage1.Controls.Add(this.dtpUloskirjautuminen);
            this.tabPage1.Controls.Add(this.lbCheckout);
            this.tabPage1.Controls.Add(this.dtpSisaankirjautuminen);
            this.tabPage1.Controls.Add(this.lbCheckin);
            this.tabPage1.Controls.Add(this.lbHinta);
            this.tabPage1.Controls.Add(this.tbHinta);
            this.tabPage1.Controls.Add(this.btnMokki);
            this.tabPage1.Controls.Add(this.tbMokki);
            this.tabPage1.Controls.Add(this.lbMokki);
            this.tabPage1.Controls.Add(this.btnAsiakaslista);
            this.tabPage1.Controls.Add(this.lbAsiakas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökin varaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbVarausID
            // 
            this.tbVarausID.Location = new System.Drawing.Point(103, 28);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.ReadOnly = true;
            this.tbVarausID.Size = new System.Drawing.Size(37, 20);
            this.tbVarausID.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Varaus ID";
            // 
            // lbMokkiID
            // 
            this.lbMokkiID.AutoSize = true;
            this.lbMokkiID.Location = new System.Drawing.Point(297, 86);
            this.lbMokkiID.Name = "lbMokkiID";
            this.lbMokkiID.Size = new System.Drawing.Size(34, 13);
            this.lbMokkiID.TabIndex = 38;
            this.lbMokkiID.Text = "         ";
            // 
            // lbAsiakasID
            // 
            this.lbAsiakasID.AutoSize = true;
            this.lbAsiakasID.Location = new System.Drawing.Point(296, 58);
            this.lbAsiakasID.Name = "lbAsiakasID";
            this.lbAsiakasID.Size = new System.Drawing.Size(34, 13);
            this.lbAsiakasID.TabIndex = 37;
            this.lbAsiakasID.Text = "         ";
            // 
            // tbAsiakas
            // 
            this.tbAsiakas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAsiakas.Location = new System.Drawing.Point(103, 54);
            this.tbAsiakas.Multiline = true;
            this.tbAsiakas.Name = "tbAsiakas";
            this.tbAsiakas.ReadOnly = true;
            this.tbAsiakas.Size = new System.Drawing.Size(170, 25);
            this.tbAsiakas.TabIndex = 36;
            this.tbAsiakas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbID2
            // 
            this.lbID2.AutoSize = true;
            this.lbID2.Location = new System.Drawing.Point(279, 85);
            this.lbID2.Name = "lbID2";
            this.lbID2.Size = new System.Drawing.Size(24, 13);
            this.lbID2.TabIndex = 22;
            this.lbID2.Text = "ID: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(279, 58);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 21;
            this.lbID.Text = "ID: ";
            // 
            // dtpSisaankirjautuminen
            // 
            this.dtpSisaankirjautuminen.Location = new System.Drawing.Point(103, 133);
            this.dtpSisaankirjautuminen.Name = "dtpSisaankirjautuminen";
            this.dtpSisaankirjautuminen.Size = new System.Drawing.Size(172, 20);
            this.dtpSisaankirjautuminen.TabIndex = 10;
            this.dtpSisaankirjautuminen.Leave += new System.EventHandler(this.dtpSisaankirjautuminen_ValueChanged);
            // 
            // lbCheckin
            // 
            this.lbCheckin.AutoSize = true;
            this.lbCheckin.Location = new System.Drawing.Point(8, 139);
            this.lbCheckin.Name = "lbCheckin";
            this.lbCheckin.Size = new System.Drawing.Size(101, 13);
            this.lbCheckin.TabIndex = 9;
            this.lbCheckin.Text = "Sisäänkirjautuminen";
            // 
            // lbHinta
            // 
            this.lbHinta.AutoSize = true;
            this.lbHinta.Location = new System.Drawing.Point(8, 110);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(47, 13);
            this.lbHinta.TabIndex = 8;
            this.lbHinta.Text = "Hinta (€)";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(103, 107);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(172, 20);
            this.tbHinta.TabIndex = 7;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnMokki
            // 
            this.btnMokki.Location = new System.Drawing.Point(337, 82);
            this.btnMokki.Name = "btnMokki";
            this.btnMokki.Size = new System.Drawing.Size(34, 20);
            this.btnMokki.TabIndex = 6;
            this.btnMokki.Text = "...";
            this.btnMokki.UseVisualStyleBackColor = true;
            this.btnMokki.Click += new System.EventHandler(this.btnMokki_Click);
            // 
            // tbMokki
            // 
            this.tbMokki.Location = new System.Drawing.Point(103, 82);
            this.tbMokki.Name = "tbMokki";
            this.tbMokki.ReadOnly = true;
            this.tbMokki.Size = new System.Drawing.Size(172, 20);
            this.tbMokki.TabIndex = 5;
            // 
            // lbMokki
            // 
            this.lbMokki.AutoSize = true;
            this.lbMokki.Location = new System.Drawing.Point(8, 82);
            this.lbMokki.Name = "lbMokki";
            this.lbMokki.Size = new System.Drawing.Size(36, 13);
            this.lbMokki.TabIndex = 4;
            this.lbMokki.Text = "Mökki";
            // 
            // btnAsiakaslista
            // 
            this.btnAsiakaslista.Location = new System.Drawing.Point(337, 54);
            this.btnAsiakaslista.Name = "btnAsiakaslista";
            this.btnAsiakaslista.Size = new System.Drawing.Size(34, 20);
            this.btnAsiakaslista.TabIndex = 3;
            this.btnAsiakaslista.Text = "...";
            this.btnAsiakaslista.UseVisualStyleBackColor = true;
            this.btnAsiakaslista.Click += new System.EventHandler(this.btnAsiakas_Click);
            // 
            // lbAsiakas
            // 
            this.lbAsiakas.AutoSize = true;
            this.lbAsiakas.Location = new System.Drawing.Point(8, 53);
            this.lbAsiakas.Name = "lbAsiakas";
            this.lbAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lbAsiakas.TabIndex = 1;
            this.lbAsiakas.Text = "Asiakas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varauskaavake";
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Varauspäivä";
            // 
            // dtpVarauspaiva
            // 
            this.dtpVarauspaiva.Location = new System.Drawing.Point(103, 186);
            this.dtpVarauspaiva.Name = "dtpVarauspaiva";
            this.dtpVarauspaiva.Size = new System.Drawing.Size(172, 20);
            this.dtpVarauspaiva.TabIndex = 42;
            // 
            // varausBindingSource1
            // 
            this.varausBindingSource1.DataMember = "varaus";
            this.varausBindingSource1.DataSource = this.dataSet1;
            // 
            // Mokinvaraaminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mokinvaraaminen";
            this.Text = "Mokinvaraaminen";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasbindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAikuiset;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.DateTimePicker dtpUloskirjautuminen;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpSisaankirjautuminen;
        private System.Windows.Forms.Label lbCheckin;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Button btnMokki;
        private System.Windows.Forms.TextBox tbMokki;
        private System.Windows.Forms.Label lbMokki;
        private System.Windows.Forms.Button btnAsiakaslista;
        private System.Windows.Forms.Label lbAsiakas;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label lbID2;
        private System.Windows.Forms.TextBox tbAsiakas;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbMokkiID;
        private System.Windows.Forms.Label lbAsiakasID;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpVarauspaiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource varausBindingSource1;
        private System.Windows.Forms.BindingSource AsiakasbindingSource1;
    }
}