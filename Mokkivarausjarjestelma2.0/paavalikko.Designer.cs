
namespace Mokkivarausjarjestelma2._0
{
    partial class paavalikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paavalikko));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_toimintaalue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_toimintaalue_uusi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_toimintaalue_poista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_toimintaalue_muokkaa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_palvelu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_palvelu_uusi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_palvelu_poista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_palvelu_muokkaa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mokki = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mokki_uusi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_mokki_poista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mokki_muokkaa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRaportti = new System.Windows.Forms.Button();
            this.btnVaraus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1194, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_toimintaalue,
            this.tsmi_palvelu,
            this.tsmi_mokki});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 34);
            this.fileToolStripMenuItem.Text = "Lisää";
            // 
            // tsmi_toimintaalue
            // 
            this.tsmi_toimintaalue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_toimintaalue_uusi,
            this.toolStripSeparator3,
            this.tsmi_toimintaalue_poista,
            this.tsmi_toimintaalue_muokkaa});
            this.tsmi_toimintaalue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_toimintaalue.Name = "tsmi_toimintaalue";
            this.tsmi_toimintaalue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_toimintaalue.Size = new System.Drawing.Size(212, 24);
            this.tsmi_toimintaalue.Text = "Toiminta-alue";
            this.tsmi_toimintaalue.Click += new System.EventHandler(this.tsmi_toimintaalue_Click);
            // 
            // tsmi_toimintaalue_uusi
            // 
            this.tsmi_toimintaalue_uusi.Name = "tsmi_toimintaalue_uusi";
            this.tsmi_toimintaalue_uusi.Size = new System.Drawing.Size(239, 24);
            this.tsmi_toimintaalue_uusi.Text = "Uusi Toiminta-alue";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmi_toimintaalue_poista
            // 
            this.tsmi_toimintaalue_poista.Name = "tsmi_toimintaalue_poista";
            this.tsmi_toimintaalue_poista.Size = new System.Drawing.Size(239, 24);
            this.tsmi_toimintaalue_poista.Text = "Poista Toiminta-alue";
            // 
            // tsmi_toimintaalue_muokkaa
            // 
            this.tsmi_toimintaalue_muokkaa.Name = "tsmi_toimintaalue_muokkaa";
            this.tsmi_toimintaalue_muokkaa.Size = new System.Drawing.Size(239, 24);
            this.tsmi_toimintaalue_muokkaa.Text = "Muokkaa Toiminta-aluetta";
            // 
            // tsmi_palvelu
            // 
            this.tsmi_palvelu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_palvelu_uusi,
            this.toolStripSeparator1,
            this.tsmi_palvelu_poista,
            this.tsmi_palvelu_muokkaa});
            this.tsmi_palvelu.Name = "tsmi_palvelu";
            this.tsmi_palvelu.Size = new System.Drawing.Size(212, 24);
            this.tsmi_palvelu.Text = "Palvelu";
            this.tsmi_palvelu.Click += new System.EventHandler(this.tsmi_palvelu_Click);
            // 
            // tsmi_palvelu_uusi
            // 
            this.tsmi_palvelu_uusi.Name = "tsmi_palvelu_uusi";
            this.tsmi_palvelu_uusi.Size = new System.Drawing.Size(189, 24);
            this.tsmi_palvelu_uusi.Text = "Uusi Palvelu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmi_palvelu_poista
            // 
            this.tsmi_palvelu_poista.Name = "tsmi_palvelu_poista";
            this.tsmi_palvelu_poista.Size = new System.Drawing.Size(189, 24);
            this.tsmi_palvelu_poista.Text = "Poista Palvelu";
            // 
            // tsmi_palvelu_muokkaa
            // 
            this.tsmi_palvelu_muokkaa.Name = "tsmi_palvelu_muokkaa";
            this.tsmi_palvelu_muokkaa.Size = new System.Drawing.Size(189, 24);
            this.tsmi_palvelu_muokkaa.Text = "Muokkaa Palvelua";
            // 
            // tsmi_mokki
            // 
            this.tsmi_mokki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mokki_uusi,
            this.toolStripSeparator2,
            this.tsmi_mokki_poista,
            this.tsmi_mokki_muokkaa});
            this.tsmi_mokki.Name = "tsmi_mokki";
            this.tsmi_mokki.Size = new System.Drawing.Size(212, 24);
            this.tsmi_mokki.Text = "Mökki";
            this.tsmi_mokki.Click += new System.EventHandler(this.tsmi_mokki_Click);
            // 
            // tsmi_mokki_uusi
            // 
            this.tsmi_mokki_uusi.Name = "tsmi_mokki_uusi";
            this.tsmi_mokki_uusi.Size = new System.Drawing.Size(184, 24);
            this.tsmi_mokki_uusi.Text = "Uusi Mökki";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmi_mokki_poista
            // 
            this.tsmi_mokki_poista.Name = "tsmi_mokki_poista";
            this.tsmi_mokki_poista.Size = new System.Drawing.Size(184, 24);
            this.tsmi_mokki_poista.Text = "Poista Mökki";
            // 
            // tsmi_mokki_muokkaa
            // 
            this.tsmi_mokki_muokkaa.Name = "tsmi_mokki_muokkaa";
            this.tsmi_mokki_muokkaa.Size = new System.Drawing.Size(184, 24);
            this.tsmi_mokki_muokkaa.Text = "Muokkaa Mökkiä";
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAsiakas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsiakas.Image = ((System.Drawing.Image)(resources.GetObject("btnAsiakas.Image")));
            this.btnAsiakas.Location = new System.Drawing.Point(485, 185);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(237, 367);
            this.btnAsiakas.TabIndex = 5;
            this.btnAsiakas.UseVisualStyleBackColor = true;
            this.btnAsiakas.Click += new System.EventHandler(this.btnAsiakas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnRaportti);
            this.panel1.Controls.Add(this.btnVaraus);
            this.panel1.Controls.Add(this.btnAsiakas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 654);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 127);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(485, 564);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 42);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(229, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 42);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRaportti
            // 
            this.btnRaportti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRaportti.Image = ((System.Drawing.Image)(resources.GetObject("btnRaportti.Image")));
            this.btnRaportti.Location = new System.Drawing.Point(741, 185);
            this.btnRaportti.Name = "btnRaportti";
            this.btnRaportti.Size = new System.Drawing.Size(237, 367);
            this.btnRaportti.TabIndex = 7;
            this.btnRaportti.UseVisualStyleBackColor = true;
            this.btnRaportti.Click += new System.EventHandler(this.btnRaportti_Click);
            // 
            // btnVaraus
            // 
            this.btnVaraus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVaraus.Image = ((System.Drawing.Image)(resources.GetObject("btnVaraus.Image")));
            this.btnVaraus.Location = new System.Drawing.Point(229, 185);
            this.btnVaraus.Name = "btnVaraus";
            this.btnVaraus.Size = new System.Drawing.Size(237, 367);
            this.btnVaraus.TabIndex = 6;
            this.btnVaraus.UseVisualStyleBackColor = true;
            this.btnVaraus.Click += new System.EventHandler(this.btnVaraus_Click);
            // 
            // paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "paavalikko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Newbies - Mökkivarausjärjestelmä";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_toimintaalue;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mokki;
        private System.Windows.Forms.Button btnAsiakas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRaportti;
        private System.Windows.Forms.Button btnVaraus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_palvelu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_toimintaalue_uusi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_toimintaalue_poista;
        private System.Windows.Forms.ToolStripMenuItem tsmi_toimintaalue_muokkaa;
        private System.Windows.Forms.ToolStripMenuItem tsmi_palvelu_uusi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_palvelu_poista;
        private System.Windows.Forms.ToolStripMenuItem tsmi_palvelu_muokkaa;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mokki_uusi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mokki_poista;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mokki_muokkaa;
    }
}

