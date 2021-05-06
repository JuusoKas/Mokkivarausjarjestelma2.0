
namespace Mokkivarausjarjestelma2._0
{
    partial class palveluhallinta
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
            this.lblHinta = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.cbTyyppi = new System.Windows.Forms.ComboBox();
            this.palveluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.cbToimAlue = new System.Windows.Forms.ComboBox();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgridPalvelut = new System.Windows.Forms.DataGridView();
            this.kaikkidataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPalID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.palveluTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.palveluTableAdapter();
            this.lblToimAlue = new System.Windows.Forms.Label();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.toimintaalueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(559, 115);
            this.lblHinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(62, 13);
            this.lblHinta.TabIndex = 18;
            this.lblHinta.Text = "Hinta tähän";
            this.lblHinta.Visible = false;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(579, 222);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(74, 25);
            this.btnPeruuta.TabIndex = 17;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(489, 222);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(74, 25);
            this.btnTallenna.TabIndex = 16;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // cbTyyppi
            // 
            this.cbTyyppi.DataSource = this.palveluBindingSource1;
            this.cbTyyppi.DisplayMember = "tyyppi";
            this.cbTyyppi.FormattingEnabled = true;
            this.cbTyyppi.Location = new System.Drawing.Point(164, 107);
            this.cbTyyppi.Margin = new System.Windows.Forms.Padding(2);
            this.cbTyyppi.Name = "cbTyyppi";
            this.cbTyyppi.Size = new System.Drawing.Size(77, 21);
            this.cbTyyppi.TabIndex = 15;
            this.cbTyyppi.ValueMember = "tyyppi";
            // 
            // palveluBindingSource1
            // 
            this.palveluBindingSource1.DataMember = "palvelu";
            this.palveluBindingSource1.DataSource = this.kaikkidata;
            // 
            // kaikkidata
            // 
            this.kaikkidata.DataSetName = "Kaikkidata";
            this.kaikkidata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbToimAlue
            // 
            this.cbToimAlue.DataSource = this.palveluBindingSource;
            this.cbToimAlue.DisplayMember = "toimintaalue_id";
            this.cbToimAlue.FormattingEnabled = true;
            this.cbToimAlue.Location = new System.Drawing.Point(164, 49);
            this.cbToimAlue.Margin = new System.Windows.Forms.Padding(2);
            this.cbToimAlue.Name = "cbToimAlue";
            this.cbToimAlue.Size = new System.Drawing.Size(77, 21);
            this.cbToimAlue.TabIndex = 14;
            this.cbToimAlue.ValueMember = "toimintaalue_id";
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.kaikkidata;
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(562, 78);
            this.tbAlv.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(59, 20);
            this.tbAlv.TabIndex = 12;
            this.tbAlv.TextChanged += new System.EventHandler(this.lblHinta_TextChanged);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(562, 49);
            this.tbHinta.Margin = new System.Windows.Forms.Padding(2);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(72, 20);
            this.tbHinta.TabIndex = 11;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(164, 140);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(2);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(286, 107);
            this.tbKuvaus.TabIndex = 10;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(164, 78);
            this.tbNimi.Margin = new System.Windows.Forms.Padding(2);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(142, 20);
            this.tbNimi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Palvelut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alv %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kuvaus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hinta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tyyppi";
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(601, 239);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(74, 25);
            this.btnMuokkaa.TabIndex = 19;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(679, 239);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(74, 25);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.dgridPalvelut);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(765, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palvelut";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgridPalvelut
            // 
            this.dgridPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridPalvelut.Location = new System.Drawing.Point(2, 2);
            this.dgridPalvelut.Margin = new System.Windows.Forms.Padding(2);
            this.dgridPalvelut.Name = "dgridPalvelut";
            this.dgridPalvelut.RowTemplate.Height = 28;
            this.dgridPalvelut.Size = new System.Drawing.Size(751, 221);
            this.dgridPalvelut.TabIndex = 0;
            this.dgridPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgridPalvelut_MouseClick);
            // 
            // kaikkidataBindingSource
            // 
            this.kaikkidataBindingSource.DataSource = this.kaikkidata;
            this.kaikkidataBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toiminta-alue";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblToimAlue);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblPalID);
            this.tabPage1.Controls.Add(this.lblHinta);
            this.tabPage1.Controls.Add(this.btnPeruuta);
            this.tabPage1.Controls.Add(this.btnTallenna);
            this.tabPage1.Controls.Add(this.cbTyyppi);
            this.tabPage1.Controls.Add(this.cbToimAlue);
            this.tabPage1.Controls.Add(this.tbAlv);
            this.tabPage1.Controls.Add(this.tbHinta);
            this.tabPage1.Controls.Add(this.tbKuvaus);
            this.tabPage1.Controls.Add(this.tbNimi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(765, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lisää Palvelu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "PalveluID:";
            // 
            // lblPalID
            // 
            this.lblPalID.AutoSize = true;
            this.lblPalID.Location = new System.Drawing.Point(385, 110);
            this.lblPalID.Name = "lblPalID";
            this.lblPalID.Size = new System.Drawing.Size(18, 13);
            this.lblPalID.TabIndex = 3;
            this.lblPalID.Text = "ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(779, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // lblToimAlue
            // 
            this.lblToimAlue.AutoSize = true;
            this.lblToimAlue.Location = new System.Drawing.Point(259, 52);
            this.lblToimAlue.Name = "lblToimAlue";
            this.lblToimAlue.Size = new System.Drawing.Size(98, 13);
            this.lblToimAlue.TabIndex = 20;
            this.lblToimAlue.Text = "ToimintaAlue tähän";
            this.lblToimAlue.Visible = false;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.kaikkidata;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // palveluhallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "palveluhallinta";
            this.Text = "Palveluhallinta";
            this.Load += new System.EventHandler(this.palveluhallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidataBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.ComboBox cbTyyppi;
        private System.Windows.Forms.ComboBox cbToimAlue;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgridPalvelut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kaikkidataBindingSource;
        private Kaikkidata kaikkidata;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private KaikkidataTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.BindingSource palveluBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPalID;
        private System.Windows.Forms.Label lblToimAlue;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private KaikkidataTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
    }
}