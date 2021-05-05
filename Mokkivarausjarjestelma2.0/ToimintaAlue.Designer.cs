
namespace Mokkivarausjarjestelma2._0
{
    partial class ToimintaAlue
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgridPalvelut = new System.Windows.Forms.DataGridView();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.btnLisaaUusi2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnLisaaUusi = new System.Windows.Forms.Button();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.palveluTableAdapter1 = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.palveluTableAdapter();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palvelut = new Mokkivarausjarjestelma2._0.Palvelut();
            this.palveluTableAdapter = new Mokkivarausjarjestelma2._0.PalvelutTableAdapters.palveluTableAdapter();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbToimAlue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aluedata = new Mokkivarausjarjestelma2._0.aluedata();
            this.aluedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.dgridPalvelut);
            this.tabPage2.Controls.Add(this.btnLisaaUusi2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(352, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toiminta-alue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Muokkaa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(258, 218);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(74, 25);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // dgridPalvelut
            // 
            this.dgridPalvelut.AutoGenerateColumns = false;
            this.dgridPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn});
            this.dgridPalvelut.DataSource = this.toimintaalueBindingSource;
            this.dgridPalvelut.Location = new System.Drawing.Point(2, 2);
            this.dgridPalvelut.Margin = new System.Windows.Forms.Padding(2);
            this.dgridPalvelut.Name = "dgridPalvelut";
            this.dgridPalvelut.RowTemplate.Height = 28;
            this.dgridPalvelut.Size = new System.Drawing.Size(252, 239);
            this.dgridPalvelut.TabIndex = 0;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // palveluBindingSource1
            // 
            this.palveluBindingSource1.DataMember = "palvelu";
            this.palveluBindingSource1.DataSource = this.kaikkidataBindingSource;
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
            // btnLisaaUusi2
            // 
            this.btnLisaaUusi2.Location = new System.Drawing.Point(258, 160);
            this.btnLisaaUusi2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaUusi2.Name = "btnLisaaUusi2";
            this.btnLisaaUusi2.Size = new System.Drawing.Size(74, 25);
            this.btnLisaaUusi2.TabIndex = 17;
            this.btnLisaaUusi2.Text = "Lisää";
            this.btnLisaaUusi2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toiminta-alue";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPeruuta);
            this.tabPage1.Controls.Add(this.btnLisaaUusi);
            this.tabPage1.Controls.Add(this.cbToimAlue);
            this.tabPage1.Controls.Add(this.tbNimi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(352, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lisää Toiminta-alue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(264, 218);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(74, 25);
            this.btnPeruuta.TabIndex = 17;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            // 
            // btnLisaaUusi
            // 
            this.btnLisaaUusi.Location = new System.Drawing.Point(171, 218);
            this.btnLisaaUusi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaUusi.Name = "btnLisaaUusi";
            this.btnLisaaUusi.Size = new System.Drawing.Size(74, 25);
            this.btnLisaaUusi.TabIndex = 16;
            this.btnLisaaUusi.Text = "Lisää";
            this.btnLisaaUusi.UseVisualStyleBackColor = true;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(164, 111);
            this.tbNimi.Margin = new System.Windows.Forms.Padding(2);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(112, 20);
            this.tbNimi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toiminta-alue";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(376, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // palveluTableAdapter1
            // 
            this.palveluTableAdapter1.ClearBeforeFill = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.palvelut;
            // 
            // palvelut
            // 
            this.palvelut.DataSetName = "Palvelut";
            this.palvelut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.kaikkidataBindingSource;
            // 
            // toimintaalueBindingSource1
            // 
            this.toimintaalueBindingSource1.DataMember = "toimintaalue";
            this.toimintaalueBindingSource1.DataSource = this.kaikkidataBindingSource;
            // 
            // cbToimAlue
            // 
            this.cbToimAlue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "nimi", true));
            this.cbToimAlue.DataSource = this.toimintaalueBindingSource;
            this.cbToimAlue.DisplayMember = "nimi";
            this.cbToimAlue.FormattingEnabled = true;
            this.cbToimAlue.Location = new System.Drawing.Point(164, 74);
            this.cbToimAlue.Margin = new System.Windows.Forms.Padding(2);
            this.cbToimAlue.Name = "cbToimAlue";
            this.cbToimAlue.Size = new System.Drawing.Size(112, 21);
            this.cbToimAlue.TabIndex = 14;
            this.cbToimAlue.ValueMember = "toimintaalue_id";
            // 
            // toimintaalueBindingSource2
            // 
            this.toimintaalueBindingSource2.DataMember = "toimintaalue";
            this.toimintaalueBindingSource2.DataSource = this.kaikkidataBindingSource;
            // 
            // aluedata
            // 
            this.aluedata.DataSetName = "aluedata";
            this.aluedata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aluedataBindingSource
            // 
            this.aluedataBindingSource.DataSource = this.aluedata;
            this.aluedataBindingSource.Position = 0;
            // 
            // ToimintaAlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "ToimintaAlue";
            this.Text = "ToimintaAlue";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgridPalvelut;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource palveluBindingSource1;
        private System.Windows.Forms.BindingSource kaikkidataBindingSource;
        private System.Windows.Forms.Button btnLisaaUusi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnLisaaUusi;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.ComboBox cbToimAlue;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource2;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource1;
        private aluedata aluedata;
        private System.Windows.Forms.BindingSource aluedataBindingSource;
    }
}