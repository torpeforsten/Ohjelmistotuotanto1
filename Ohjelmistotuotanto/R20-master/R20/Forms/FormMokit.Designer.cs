namespace R20.Forms
{
    partial class FormMokit
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
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.lblMokkiAlue = new System.Windows.Forms.Label();
            this.lblMokkiKuvaus = new System.Windows.Forms.Label();
            this.lblPostipaikka = new System.Windows.Forms.Label();
            this.lblVarusteet = new System.Windows.Forms.Label();
            this.lblMokkiHlo = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.lblMokkiNimi = new System.Windows.Forms.Label();
            this.lblSMokkiHinta = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.lblAlue = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.btnPaivitaMokki = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMokit
            // 
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(394, 54);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.Size = new System.Drawing.Size(744, 521);
            this.dgvMokit.TabIndex = 71;
            this.dgvMokit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokit_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPostitoimipaikka);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbPostinro);
            this.panel2.Controls.Add(this.cbAlue);
            this.panel2.Controls.Add(this.lblMokkiAlue);
            this.panel2.Controls.Add(this.lblMokkiKuvaus);
            this.panel2.Controls.Add(this.lblPostipaikka);
            this.panel2.Controls.Add(this.lblVarusteet);
            this.panel2.Controls.Add(this.lblMokkiHlo);
            this.panel2.Controls.Add(this.lblKuvaus);
            this.panel2.Controls.Add(this.tbKuvaus);
            this.panel2.Controls.Add(this.lblMokkiNimi);
            this.panel2.Controls.Add(this.lblSMokkiHinta);
            this.panel2.Controls.Add(this.lblOsoite);
            this.panel2.Controls.Add(this.lblVarustelu);
            this.panel2.Controls.Add(this.lblHenkilomaara);
            this.panel2.Controls.Add(this.tbMokkinimi);
            this.panel2.Controls.Add(this.lblAlue);
            this.panel2.Controls.Add(this.tbHinta);
            this.panel2.Controls.Add(this.tbKatuosoite);
            this.panel2.Controls.Add(this.tbVarustelu);
            this.panel2.Controls.Add(this.tbHenkilomaara);
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 337);
            this.panel2.TabIndex = 78;
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(193, 254);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.ReadOnly = true;
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(168, 20);
            this.tbPostitoimipaikka.TabIndex = 77;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Postinro";
            // 
            // cbPostinro
            // 
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(193, 221);
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(167, 21);
            this.cbPostinro.TabIndex = 76;
            this.cbPostinro.SelectedIndexChanged += new System.EventHandler(this.cbPostinro_SelectedIndexChanged);
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(193, 285);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(167, 21);
            this.cbAlue.TabIndex = 74;
            // 
            // lblMokkiAlue
            // 
            this.lblMokkiAlue.AutoSize = true;
            this.lblMokkiAlue.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiAlue.Location = new System.Drawing.Point(29, 283);
            this.lblMokkiAlue.Name = "lblMokkiAlue";
            this.lblMokkiAlue.Size = new System.Drawing.Size(42, 20);
            this.lblMokkiAlue.TabIndex = 73;
            this.lblMokkiAlue.Text = "Alue";
            // 
            // lblMokkiKuvaus
            // 
            this.lblMokkiKuvaus.AutoSize = true;
            this.lblMokkiKuvaus.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiKuvaus.Location = new System.Drawing.Point(29, 154);
            this.lblMokkiKuvaus.Name = "lblMokkiKuvaus";
            this.lblMokkiKuvaus.Size = new System.Drawing.Size(62, 20);
            this.lblMokkiKuvaus.TabIndex = 72;
            this.lblMokkiKuvaus.Text = "Kuvaus";
            // 
            // lblPostipaikka
            // 
            this.lblPostipaikka.AutoSize = true;
            this.lblPostipaikka.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostipaikka.Location = new System.Drawing.Point(29, 254);
            this.lblPostipaikka.Name = "lblPostipaikka";
            this.lblPostipaikka.Size = new System.Drawing.Size(125, 20);
            this.lblPostipaikka.TabIndex = 50;
            this.lblPostipaikka.Text = "Postitoimipaikka";

            // 
            // lblVarusteet
            // 
            this.lblVarusteet.AutoSize = true;
            this.lblVarusteet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarusteet.Location = new System.Drawing.Point(28, 124);
            this.lblVarusteet.Name = "lblVarusteet";
            this.lblVarusteet.Size = new System.Drawing.Size(77, 20);
            this.lblVarusteet.TabIndex = 71;
            this.lblVarusteet.Text = "Varustelu";
            // 
            // lblMokkiHlo
            // 
            this.lblMokkiHlo.AutoSize = true;
            this.lblMokkiHlo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiHlo.Location = new System.Drawing.Point(28, 94);
            this.lblMokkiHlo.Name = "lblMokkiHlo";
            this.lblMokkiHlo.Size = new System.Drawing.Size(110, 20);
            this.lblMokkiHlo.TabIndex = 70;
            this.lblMokkiHlo.Text = "Henkilömäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuvaus.Location = new System.Drawing.Point(28, 155);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(0, 20);
            this.lblKuvaus.TabIndex = 68;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(194, 156);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(168, 20);
            this.tbKuvaus.TabIndex = 69;
            // 
            // lblMokkiNimi
            // 
            this.lblMokkiNimi.AutoSize = true;
            this.lblMokkiNimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiNimi.Location = new System.Drawing.Point(28, 29);
            this.lblMokkiNimi.Name = "lblMokkiNimi";
            this.lblMokkiNimi.Size = new System.Drawing.Size(86, 20);
            this.lblMokkiNimi.TabIndex = 48;
            this.lblMokkiNimi.Text = "Mökin nimi";
            // 
            // lblSMokkiHinta
            // 
            this.lblSMokkiHinta.AutoSize = true;
            this.lblSMokkiHinta.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMokkiHinta.Location = new System.Drawing.Point(28, 63);
            this.lblSMokkiHinta.Name = "lblSMokkiHinta";
            this.lblSMokkiHinta.Size = new System.Drawing.Size(46, 20);
            this.lblSMokkiHinta.TabIndex = 49;
            this.lblSMokkiHinta.Text = "Hinta";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(28, 188);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(82, 20);
            this.lblOsoite.TabIndex = 51;
            this.lblOsoite.Text = "Lähiosoite";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarustelu.Location = new System.Drawing.Point(28, 127);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(0, 20);
            this.lblVarustelu.TabIndex = 52;
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHenkilomaara.Location = new System.Drawing.Point(28, 96);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(0, 20);
            this.lblHenkilomaara.TabIndex = 53;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(194, 29);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(171, 20);
            this.tbMokkinimi.TabIndex = 54;
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlue.Location = new System.Drawing.Point(29, 259);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(0, 20);
            this.lblAlue.TabIndex = 63;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(194, 63);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(171, 20);
            this.tbHinta.TabIndex = 55;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress_1);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(194, 188);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(168, 20);
            this.tbKatuosoite.TabIndex = 57;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(194, 126);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(168, 20);
            this.tbVarustelu.TabIndex = 58;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(194, 96);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(168, 20);
            this.tbHenkilomaara.TabIndex = 59;
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaaMokki.Location = new System.Drawing.Point(42, 443);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(140, 30);
            this.btnLisaaMokki.TabIndex = 72;
            this.btnLisaaMokki.Text = "Lisää Mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // btnPaivitaMokki
            // 
            this.btnPaivitaMokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivitaMokki.Location = new System.Drawing.Point(39, 518);
            this.btnPaivitaMokki.Name = "btnPaivitaMokki";
            this.btnPaivitaMokki.Size = new System.Drawing.Size(143, 30);
            this.btnPaivitaMokki.TabIndex = 75;
            this.btnPaivitaMokki.Text = "Päivitä Mökki";
            this.btnPaivitaMokki.UseVisualStyleBackColor = true;
            this.btnPaivitaMokki.Click += new System.EventHandler(this.btnPaivitaMokki_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistaMokki.Location = new System.Drawing.Point(228, 443);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(140, 30);
            this.btnPoistaMokki.TabIndex = 73;
            this.btnPoistaMokki.Text = "Poista Mökki";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyhjaa.Location = new System.Drawing.Point(228, 518);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(143, 30);
            this.btnTyhjaa.TabIndex = 76;
            this.btnTyhjaa.Text = "Tyhjennä tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // FormMokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaaMokki);
            this.Controls.Add(this.btnPaivitaMokki);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.btnTyhjaa);
            this.Name = "FormMokit";
            this.Text = "MÖKIT";
            this.Load += new System.EventHandler(this.FormMokit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMokkiNimi;
        private System.Windows.Forms.Label lblSMokkiHinta;
        private System.Windows.Forms.Label lblPostipaikka;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.Button btnPaivitaMokki;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label lblMokkiAlue;
        private System.Windows.Forms.Label lblMokkiKuvaus;
        private System.Windows.Forms.Label lblVarusteet;
        private System.Windows.Forms.Label lblMokkiHlo;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPostinro;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
    }
}