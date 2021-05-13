
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
            this.kaikkidata = new Mokkivarausjarjestelma2._0.Kaikkidata();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mokkivarausjarjestelma2._0.KaikkidataTableAdapters.asiakasTableAdapter();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakaslista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsiakaslista
            // 
            this.dgvAsiakaslista.AllowUserToAddRows = false;
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
            this.dgvAsiakaslista.Location = new System.Drawing.Point(27, 27);
            this.dgvAsiakaslista.Name = "dgvAsiakaslista";
            this.dgvAsiakaslista.ReadOnly = true;
            this.dgvAsiakaslista.Size = new System.Drawing.Size(747, 396);
            this.dgvAsiakaslista.TabIndex = 1;
            this.dgvAsiakaslista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAsiakaslista_MouseDoubleClick);
            // 
            // kaikkidata
            // 
            this.kaikkidata.DataSetName = "Kaikkidata";
            this.kaikkidata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.kaikkidata;
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
            ((System.ComponentModel.ISupportInitialize)(this.kaikkidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsiakaslista;
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
    }
}