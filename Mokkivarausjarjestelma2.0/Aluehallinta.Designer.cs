﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aluedata1 = new Mokkivarausjarjestelma2._0.Aluedata1();
            this.aluedata1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueTableAdapter = new Mokkivarausjarjestelma2._0.Aluedata1TableAdapters.toimintaalueTableAdapter();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAlueet = new System.Windows.Forms.TabPage();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.tabLisaa = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlueNimi = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbIDnro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toimintaalueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAlueet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            this.tabAlueet.SuspendLayout();
            this.tabLisaa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridAlueet
            // 
            this.dgridAlueet.AutoGenerateColumns = false;
            this.dgridAlueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAlueet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn});
            this.dgridAlueet.DataSource = this.toimintaalueBindingSource;
            this.dgridAlueet.Location = new System.Drawing.Point(10, 16);
            this.dgridAlueet.Margin = new System.Windows.Forms.Padding(2);
            this.dgridAlueet.Name = "dgridAlueet";
            this.dgridAlueet.RowTemplate.Height = 28;
            this.dgridAlueet.Size = new System.Drawing.Size(398, 309);
            this.dgridAlueet.TabIndex = 20;
            this.dgridAlueet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridAlueet_CellContentClick);
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
            // aluedata1
            // 
            this.aluedata1.DataSetName = "Aluedata1";
            this.aluedata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aluedata1BindingSource
            // 
            this.aluedata1BindingSource.DataSource = this.aluedata1;
            this.aluedata1BindingSource.Position = 0;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.aluedata1BindingSource;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.aluedata1;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
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
            // tabAlueet
            // 
            this.tabAlueet.Controls.Add(this.btnMuokkaa);
            this.tabAlueet.Controls.Add(this.btnPoista);
            this.tabAlueet.Controls.Add(this.btnLisaa);
            this.tabAlueet.Controls.Add(this.dgridAlueet);
            this.tabAlueet.Location = new System.Drawing.Point(4, 22);
            this.tabAlueet.Name = "tabAlueet";
            this.tabAlueet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlueet.Size = new System.Drawing.Size(413, 370);
            this.tabAlueet.TabIndex = 0;
            this.tabAlueet.Text = "Toiminta-alueet";
            this.tabAlueet.UseVisualStyleBackColor = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(177, 329);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(74, 25);
            this.btnLisaa.TabIndex = 21;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(333, 329);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(74, 25);
            this.btnPoista.TabIndex = 22;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(255, 329);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(74, 25);
            this.btnMuokkaa.TabIndex = 23;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // tabLisaa
            // 
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
            // tbAlueNimi
            // 
            this.tbAlueNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource1, "nimi", true));
            this.tbAlueNimi.Location = new System.Drawing.Point(109, 123);
            this.tbAlueNimi.Name = "tbAlueNimi";
            this.tbAlueNimi.Size = new System.Drawing.Size(130, 20);
            this.tbAlueNimi.TabIndex = 2;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(156, 235);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(83, 25);
            this.btnTallenna.TabIndex = 24;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // tbIDnro
            // 
            this.tbIDnro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource2, "toimintaalue_id", true));
            this.tbIDnro.Location = new System.Drawing.Point(109, 175);
            this.tbIDnro.Name = "tbIDnro";
            this.tbIDnro.Size = new System.Drawing.Size(130, 20);
            this.tbIDnro.TabIndex = 25;
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
            // toimintaalueBindingSource1
            // 
            this.toimintaalueBindingSource1.DataMember = "toimintaalue";
            this.toimintaalueBindingSource1.DataSource = this.aluedata1;
            // 
            // toimintaalueBindingSource2
            // 
            this.toimintaalueBindingSource2.DataMember = "toimintaalue";
            this.toimintaalueBindingSource2.DataSource = this.aluedata1;
            // 
            // Aluehallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aluehallinta";
            this.Text = "Aluehallinta";
            this.Load += new System.EventHandler(this.Aluehallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAlueet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluedata1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            this.tabAlueet.ResumeLayout(false);
            this.tabLisaa.ResumeLayout(false);
            this.tabLisaa.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLisaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbAlueNimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAlueet;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDnro;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource2;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource1;
    }
}