
namespace Mokkivarausjarjestelma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUusi = new System.Windows.Forms.TabPage();
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
            this.tabAsiakkaat = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbAsiakkaat = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnPeru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabUusi.SuspendLayout();
            this.tabAsiakkaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 429);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUusi);
            this.tabControl1.Controls.Add(this.tabAsiakkaat);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 407);
            this.tabControl1.TabIndex = 3;
            // 
            // tabUusi
            // 
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
            this.tabUusi.Location = new System.Drawing.Point(4, 24);
            this.tabUusi.Name = "tabUusi";
            this.tabUusi.Padding = new System.Windows.Forms.Padding(3);
            this.tabUusi.Size = new System.Drawing.Size(822, 379);
            this.tabUusi.TabIndex = 0;
            this.tabUusi.Text = "Uusi asiakas";
            this.tabUusi.UseVisualStyleBackColor = true;
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Location = new System.Drawing.Point(121, 191);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(182, 23);
            this.tbPuhnro.TabIndex = 9;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(121, 152);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(182, 23);
            this.tbSahkoposti.TabIndex = 8;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(121, 112);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(182, 23);
            this.tbLahiosoite.TabIndex = 7;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(121, 68);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(182, 23);
            this.tbSukunimi.TabIndex = 6;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(121, 33);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(182, 23);
            this.tbEtunimi.TabIndex = 5;
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(21, 79);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(57, 15);
            this.lbSukunimi.TabIndex = 1;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbAsiakas
            // 
            this.lbAsiakas.AutoSize = true;
            this.lbAsiakas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAsiakas.Location = new System.Drawing.Point(3, 3);
            this.lbAsiakas.Name = "lbAsiakas";
            this.lbAsiakas.Size = new System.Drawing.Size(164, 20);
            this.lbAsiakas.TabIndex = 0;
            this.lbAsiakas.Text = "Uuden asiakkaan tiedot";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(21, 118);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(61, 15);
            this.lbLahiosoite.TabIndex = 2;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(21, 39);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(48, 15);
            this.lbEtunimi.TabIndex = 0;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lbSahkoposti
            // 
            this.lbSahkoposti.AutoSize = true;
            this.lbSahkoposti.Location = new System.Drawing.Point(21, 158);
            this.lbSahkoposti.Name = "lbSahkoposti";
            this.lbSahkoposti.Size = new System.Drawing.Size(97, 15);
            this.lbSahkoposti.TabIndex = 3;
            this.lbSahkoposti.Text = "Sähköpostiosoite";
            // 
            // lbPuhelin
            // 
            this.lbPuhelin.AutoSize = true;
            this.lbPuhelin.Location = new System.Drawing.Point(21, 194);
            this.lbPuhelin.Name = "lbPuhelin";
            this.lbPuhelin.Size = new System.Drawing.Size(89, 15);
            this.lbPuhelin.TabIndex = 4;
            this.lbPuhelin.Text = "Puhelinnumero";
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.dataGridView1);
            this.tabAsiakkaat.Controls.Add(this.lbAsiakkaat);
            this.tabAsiakkaat.Location = new System.Drawing.Point(4, 24);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsiakkaat.Size = new System.Drawing.Size(822, 379);
            this.tabAsiakkaat.TabIndex = 1;
            this.tabAsiakkaat.Text = "Asiakkaat";
            this.tabAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(819, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbAsiakkaat
            // 
            this.lbAsiakkaat.AutoSize = true;
            this.lbAsiakkaat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAsiakkaat.Location = new System.Drawing.Point(6, 15);
            this.lbAsiakkaat.Name = "lbAsiakkaat";
            this.lbAsiakkaat.Size = new System.Drawing.Size(72, 20);
            this.lbAsiakkaat.TabIndex = 0;
            this.lbAsiakkaat.Text = "Asiakkaat";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(21, 244);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(105, 42);
            this.btnTallenna.TabIndex = 10;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // btnPeru
            // 
            this.btnPeru.Location = new System.Drawing.Point(198, 244);
            this.btnPeru.Name = "btnPeru";
            this.btnPeru.Size = new System.Drawing.Size(105, 42);
            this.btnPeru.TabIndex = 11;
            this.btnPeru.Text = "Peruuta";
            this.btnPeru.UseVisualStyleBackColor = true;
            // 
            // Asiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 598);
            this.Controls.Add(this.groupBox1);
            this.Name = "Asiakashallinta";
            this.Text = "Asiakashallinta";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabUusi.ResumeLayout(false);
            this.tabUusi.PerformLayout();
            this.tabAsiakkaat.ResumeLayout(false);
            this.tabAsiakkaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUusi;
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
        private System.Windows.Forms.TabPage tabAsiakkaat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbAsiakkaat;
        private System.Windows.Forms.Button btnPeru;
        private System.Windows.Forms.Button btnTallenna;
    }
}