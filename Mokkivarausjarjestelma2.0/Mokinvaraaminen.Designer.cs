
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAikuiset = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbPaivat = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbCheckin = new System.Windows.Forms.Label();
            this.lbHinta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMokki = new System.Windows.Forms.Button();
            this.tbMokki = new System.Windows.Forms.TextBox();
            this.lbMokki = new System.Windows.Forms.Label();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.tbAsiakas = new System.Windows.Forms.TextBox();
            this.lbAsiakas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new Mokkivarausjarjestelma2._0.DataSet1();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new Mokkivarausjarjestelma2._0.DataSet1TableAdapters.varausTableAdapter();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Varaukset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.varausBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 248);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lapsien määrä";
            // 
            // lbAikuiset
            // 
            this.lbAikuiset.AutoSize = true;
            this.lbAikuiset.Location = new System.Drawing.Point(8, 224);
            this.lbAikuiset.Name = "lbAikuiset";
            this.lbAikuiset.Size = new System.Drawing.Size(81, 13);
            this.lbAikuiset.TabIndex = 17;
            this.lbAikuiset.Text = "Aikuisien määrä";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 16;
            // 
            // lbPaivat
            // 
            this.lbPaivat.AutoSize = true;
            this.lbPaivat.Location = new System.Drawing.Point(8, 192);
            this.lbPaivat.Name = "lbPaivat";
            this.lbPaivat.Size = new System.Drawing.Size(74, 13);
            this.lbPaivat.TabIndex = 15;
            this.lbPaivat.Text = "Päivien määrä";
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(540, 277);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(79, 32);
            this.btnPeruuta.TabIndex = 14;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(448, 277);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(79, 32);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Sisäänkirjaa";
            this.btnCheckin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker2.TabIndex = 12;
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
            this.tabControl1.Size = new System.Drawing.Size(653, 336);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbAikuiset);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.lbPaivat);
            this.tabPage1.Controls.Add(this.btnPeruuta);
            this.tabPage1.Controls.Add(this.btnCheckin);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.lbCheckout);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.lbCheckin);
            this.tabPage1.Controls.Add(this.lbHinta);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnMokki);
            this.tabPage1.Controls.Add(this.tbMokki);
            this.tabPage1.Controls.Add(this.lbMokki);
            this.tabPage1.Controls.Add(this.btnAsiakas);
            this.tabPage1.Controls.Add(this.tbAsiakas);
            this.tabPage1.Controls.Add(this.lbAsiakas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökin varaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 10;
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
            this.lbHinta.Size = new System.Drawing.Size(32, 13);
            this.lbHinta.TabIndex = 8;
            this.lbHinta.Text = "Hinta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnMokki
            // 
            this.btnMokki.Location = new System.Drawing.Point(280, 82);
            this.btnMokki.Name = "btnMokki";
            this.btnMokki.Size = new System.Drawing.Size(34, 20);
            this.btnMokki.TabIndex = 6;
            this.btnMokki.Text = "...";
            this.btnMokki.UseVisualStyleBackColor = true;
            // 
            // tbMokki
            // 
            this.tbMokki.Location = new System.Drawing.Point(103, 82);
            this.tbMokki.Name = "tbMokki";
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
            // btnAsiakas
            // 
            this.btnAsiakas.Location = new System.Drawing.Point(280, 54);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(34, 20);
            this.btnAsiakas.TabIndex = 3;
            this.btnAsiakas.Text = "...";
            this.btnAsiakas.UseVisualStyleBackColor = true;
            // 
            // tbAsiakas
            // 
            this.tbAsiakas.Location = new System.Drawing.Point(103, 54);
            this.tbAsiakas.Name = "tbAsiakas";
            this.tbAsiakas.Size = new System.Drawing.Size(173, 20);
            this.tbAsiakas.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varauskaavake";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
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
            // Mokinvaraaminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mokinvaraaminen";
            this.Text = "Mokinvaraaminen";
            this.Load += new System.EventHandler(this.Mokinvaraaminen_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAikuiset;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbPaivat;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbCheckin;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMokki;
        private System.Windows.Forms.TextBox tbMokki;
        private System.Windows.Forms.Label lbMokki;
        private System.Windows.Forms.Button btnAsiakas;
        private System.Windows.Forms.TextBox tbAsiakas;
        private System.Windows.Forms.Label lbAsiakas;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
    }
}