
namespace Mokkivarausjarjestelma2._0
{
    partial class Aluehallinta
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
            this.dgridAlueet = new System.Windows.Forms.DataGridView();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluedata1 = new Mokkivarausjarjestelma2._0.Aluedata1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLisaa = new System.Windows.Forms.TabPage();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDnro = new System.Windows.Forms.TextBox();
            this.toimintaalueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbAlueNimi = new System.Windows.Forms.TextBox();
            this.toimintaalueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAlueet = new System.Windows.Forms.TabPage();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluedata1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueTableAdapter = new Mokkivarausjarjestelma2._0.Aluedata1TableAdapters.toimintaalueTableAdapter();
            this.toimintaalueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAlueet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLisaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource3)).BeginInit();
            this.tabAlueet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridAlueet
            // 
            this.dgridAlueet.AllowUserToAddRows = false;
            this.dgridAlueet.AllowUserToOrderColumns = true;
            this.dgridAlueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAlueet.Location = new System.Drawing.Point(10, 16);
            this.dgridAlueet.Margin = new System.Windows.Forms.Padding(2);
            this.dgridAlueet.Name = "dgridAlueet";
            this.dgridAlueet.ReadOnly = true;
            this.dgridAlueet.RowTemplate.Height = 28;
            this.dgridAlueet.Size = new System.Drawing.Size(398, 309);
            this.dgridAlueet.TabIndex = 20;
            this.dgridAlueet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgridAlueet_MouseClick);
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.aluedata1;
            // 
            // aluedata1
            // 
            this.aluedata1.DataSetName = "Aluedata1";
            this.aluedata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 438);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLisaa);
            this.tabControl1.Controls.Add(this.tabAlueet);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 396);
            this.tabControl1.TabIndex = 25;
            // 
            // tabLisaa
            // 
            this.tabLisaa.Controls.Add(this.btnPeruuta);
            this.tabLisaa.Controls.Add(this.label3);
            this.tabLisaa.Controls.Add(this.tbIDnro);
            this.tabLisaa.Controls.Add(this.btnTallenna);
            this.tabLisaa.Controls.Add(this.tbAlueNimi);
            this.tabLisaa.Controls.Add(this.label2);
            this.tabLisaa.Controls.Add(this.label1);
            this.tabLisaa.Location = new System.Drawing.Point(4, 22);
            this.tabLisaa.Name = "tabLisaa";
            this.tabLisaa.Padding = new System.Windows.Forms.Padding(3);
            this.tabLisaa.Size = new System.Drawing.Size(413, 370);
            this.tabLisaa.TabIndex = 1;
            this.tabLisaa.Text = "Lisää alue";
            this.tabLisaa.UseVisualStyleBackColor = true;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(252, 275);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(83, 25);
            this.btnPeruuta.TabIndex = 4;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID numero:";
            // 
            // tbIDnro
            // 
            this.tbIDnro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource2, "toimintaalue_id", true));
            this.tbIDnro.Location = new System.Drawing.Point(109, 175);
            this.tbIDnro.Name = "tbIDnro";
            this.tbIDnro.ReadOnly = true;
            this.tbIDnro.Size = new System.Drawing.Size(130, 20);
            this.tbIDnro.TabIndex = 2;
            // 
            // toimintaalueBindingSource2
            // 
            this.toimintaalueBindingSource2.DataMember = "toimintaalue";
            this.toimintaalueBindingSource2.DataSource = this.aluedata1;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(156, 275);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(83, 25);
            this.btnTallenna.TabIndex = 3;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbAlueNimi
            // 
            this.tbAlueNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource3, "nimi", true));
            this.tbAlueNimi.Location = new System.Drawing.Point(109, 123);
            this.tbAlueNimi.Name = "tbAlueNimi";
            this.tbAlueNimi.Size = new System.Drawing.Size(130, 20);
            this.tbAlueNimi.TabIndex = 1;
            // 
            // toimintaalueBindingSource3
            // 
            this.toimintaalueBindingSource3.DataMember = "toimintaalue";
            this.toimintaalueBindingSource3.DataSource = this.aluedata1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toiminta-alue";
            // 
            // tabAlueet
            // 
            this.tabAlueet.Controls.Add(this.btnMuokkaa);
            this.tabAlueet.Controls.Add(this.btnPoista);
            this.tabAlueet.Controls.Add(this.dgridAlueet);
            this.tabAlueet.Location = new System.Drawing.Point(4, 22);
            this.tabAlueet.Name = "tabAlueet";
            this.tabAlueet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlueet.Size = new System.Drawing.Size(413, 370);
            this.tabAlueet.TabIndex = 0;
            this.tabAlueet.Text = "Toiminta-alueet";
            this.tabAlueet.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(255, 329);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(74, 25);
            this.btnMuokkaa.TabIndex = 5;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(333, 329);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(74, 25);
            this.btnPoista.TabIndex = 6;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.aluedata1BindingSource;
            // 
            // aluedata1BindingSource
            // 
            this.aluedata1BindingSource.DataSource = this.aluedata1;
            this.aluedata1BindingSource.Position = 0;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueBindingSource1
            // 
            this.toimintaalueBindingSource1.DataMember = "toimintaalue";
            this.toimintaalueBindingSource1.DataSource = this.aluedata1;
            // 
            // Aluehallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aluehallinta";
            this.Text = "Aluehallinta";
            this.Load += new System.EventHandler(this.Aluehallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAlueet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLisaa.ResumeLayout(false);
            this.tabLisaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource3)).EndInit();
            this.tabAlueet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgridAlueet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource aluedata1BindingSource;
        private Aluedata1 aluedata1;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private Aluedata1TableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLisaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbAlueNimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAlueet;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDnro;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource2;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource1;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource3;
        private System.Windows.Forms.Button btnPeruuta;
    }
}