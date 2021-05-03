
using MySql.Data.MySqlClient;

namespace Mokkivarausjarjestelma
{
    partial class Mokinluonti
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHenkilo = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbOsoite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbMokki = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbMokki);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökin luonti / muokkaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPeruuta);
            this.panel1.Controls.Add(this.btnTallenna);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbHenkilo);
            this.panel1.Controls.Add(this.lbKuvaus);
            this.panel1.Controls.Add(this.lbOsoite);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNimi);
            this.panel1.Location = new System.Drawing.Point(15, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 257);
            this.panel1.TabIndex = 1;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(376, 211);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(94, 35);
            this.btnPeruuta.TabIndex = 13;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(266, 211);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(94, 35);
            this.btnTallenna.TabIndex = 12;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Varustelu";
            // 
            // lbHenkilo
            // 
            this.lbHenkilo.AutoSize = true;
            this.lbHenkilo.Location = new System.Drawing.Point(12, 139);
            this.lbHenkilo.Name = "lbHenkilo";
            this.lbHenkilo.Size = new System.Drawing.Size(81, 15);
            this.lbHenkilo.TabIndex = 4;
            this.lbHenkilo.Text = "Henkilömäärä";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(12, 108);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(81, 15);
            this.lbKuvaus.TabIndex = 3;
            this.lbKuvaus.Text = "Mökin kuvaus";
            // 
            // lbOsoite
            // 
            this.lbOsoite.AutoSize = true;
            this.lbOsoite.Location = new System.Drawing.Point(12, 80);
            this.lbOsoite.Name = "lbOsoite";
            this.lbOsoite.Size = new System.Drawing.Size(63, 15);
            this.lbOsoite.TabIndex = 2;
            this.lbOsoite.Text = "Katuosoite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toimialue";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(12, 17);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(68, 15);
            this.lbNimi.TabIndex = 0;
            this.lbNimi.Text = "Mökin nimi";
            // 
            // lbMokki
            // 
            this.lbMokki.AutoSize = true;
            this.lbMokki.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMokki.Location = new System.Drawing.Point(15, 28);
            this.lbMokki.Name = "lbMokki";
            this.lbMokki.Size = new System.Drawing.Size(81, 20);
            this.lbMokki.TabIndex = 0;
            this.lbMokki.Text = "Uusi mökki";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.dgvMokit);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mökit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(703, 313);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(114, 27);
            this.btnPoista.TabIndex = 2;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // dgvMokit
            // 
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(3, 3);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowTemplate.Height = 25;
            this.dgvMokit.Size = new System.Drawing.Size(823, 304);
            this.dgvMokit.TabIndex = 0;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(572, 313);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(114, 27);
            this.btnMuokkaa.TabIndex = 1;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // Mokinluonti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mokinluonti";
            this.Text = "Mokinluonti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbOsoite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbMokki;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHenkilo;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;



    }
}