﻿
namespace Mokkivarausjarjestelma2._0
{
    partial class Asiakaslista
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
            this.dgvAsiakaslista = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Mokkivarausjarjestelma2._0.DataSet1();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mokkivarausjarjestelma2._0.DataSet1TableAdapters.asiakasTableAdapter();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakaslista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsiakaslista
            // 
            this.dgvAsiakaslista.AutoGenerateColumns = false;
            this.dgvAsiakaslista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakaslista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvAsiakaslista.DataSource = this.asiakasBindingSource;
            this.dgvAsiakaslista.Location = new System.Drawing.Point(12, 42);
            this.dgvAsiakaslista.Name = "dgvAsiakaslista";
            this.dgvAsiakaslista.Size = new System.Drawing.Size(747, 396);
            this.dgvAsiakaslista.TabIndex = 0;
            this.dgvAsiakaslista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAsiakaslista_MouseDoubleClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
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
            // Asiakaslista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAsiakaslista);
            this.Name = "Asiakaslista";
            this.Text = "Asiakaslista";
            this.Load += new System.EventHandler(this.Asiakaslista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakaslista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsiakaslista;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
    }
}