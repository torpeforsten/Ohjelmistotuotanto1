namespace R20.Forms
{
    partial class FormPalvelut
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
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblSposti = new System.Windows.Forms.Label();
            this.lblPuhNro = new System.Windows.Forms.Label();
            this.tbTyyppi = new System.Windows.Forms.TextBox();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPaivitaHlo = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(391, 54);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(744, 521);
            this.dgvPalvelut.TabIndex = 71;
            this.dgvPalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalvelut_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbNimi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbAlue);
            this.panel2.Controls.Add(this.lblEtunimi);
            this.panel2.Controls.Add(this.lblSukunimi);
            this.panel2.Controls.Add(this.lblOsoite);
            this.panel2.Controls.Add(this.lblSposti);
            this.panel2.Controls.Add(this.lblPuhNro);
            this.panel2.Controls.Add(this.tbTyyppi);
            this.panel2.Controls.Add(this.tbAlv);
            this.panel2.Controls.Add(this.tbHinta);
            this.panel2.Controls.Add(this.tbKuvaus);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 248);
            this.panel2.TabIndex = 78;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(194, 77);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(171, 20);
            this.tbNimi.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Alue";
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(194, 37);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(167, 21);
            this.cbAlue.TabIndex = 69;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(28, 75);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(39, 20);
            this.lblEtunimi.TabIndex = 48;
            this.lblEtunimi.Text = "Nimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(28, 109);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(53, 20);
            this.lblSukunimi.TabIndex = 49;
            this.lblSukunimi.Text = "Tyyppi";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(28, 209);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(32, 20);
            this.lblOsoite.TabIndex = 51;
            this.lblOsoite.Text = "alv";
            // 
            // lblSposti
            // 
            this.lblSposti.AutoSize = true;
            this.lblSposti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposti.Location = new System.Drawing.Point(28, 174);
            this.lblSposti.Name = "lblSposti";
            this.lblSposti.Size = new System.Drawing.Size(46, 20);
            this.lblSposti.TabIndex = 52;
            this.lblSposti.Text = "Hinta";
            // 
            // lblPuhNro
            // 
            this.lblPuhNro.AutoSize = true;
            this.lblPuhNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuhNro.Location = new System.Drawing.Point(28, 143);
            this.lblPuhNro.Name = "lblPuhNro";
            this.lblPuhNro.Size = new System.Drawing.Size(62, 20);
            this.lblPuhNro.TabIndex = 53;
            this.lblPuhNro.Text = "Kuvaus";
            // 
            // tbTyyppi
            // 
            this.tbTyyppi.Location = new System.Drawing.Point(194, 109);
            this.tbTyyppi.Name = "tbTyyppi";
            this.tbTyyppi.Size = new System.Drawing.Size(171, 20);
            this.tbTyyppi.TabIndex = 55;
            this.tbTyyppi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTyyppi_KeyPress_1);
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(194, 209);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(168, 20);
            this.tbAlv.TabIndex = 57;
            this.tbAlv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlv_KeyPress_1);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(194, 174);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(168, 20);
            this.tbHinta.TabIndex = 58;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress_1);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(194, 143);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(168, 20);
            this.tbKuvaus.TabIndex = 59;
            // 
            // btnLisaa
            // 
            this.btnLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaa.Location = new System.Drawing.Point(42, 356);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(140, 30);
            this.btnLisaa.TabIndex = 72;
            this.btnLisaa.Text = "Lisää Palvelu";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPaivitaHlo
            // 
            this.btnPaivitaHlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivitaHlo.Location = new System.Drawing.Point(39, 431);
            this.btnPaivitaHlo.Name = "btnPaivitaHlo";
            this.btnPaivitaHlo.Size = new System.Drawing.Size(143, 30);
            this.btnPaivitaHlo.TabIndex = 75;
            this.btnPaivitaHlo.Text = "Päivitä Palvelu";
            this.btnPaivitaHlo.UseVisualStyleBackColor = true;
            this.btnPaivitaHlo.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivita.Location = new System.Drawing.Point(136, 504);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(140, 30);
            this.btnPaivita.TabIndex = 74;
            this.btnPaivita.Text = "Päivitä Lista";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.Location = new System.Drawing.Point(228, 356);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(140, 30);
            this.btnPoista.TabIndex = 73;
            this.btnPoista.Text = "Poista Palvelu";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyhjaa.Location = new System.Drawing.Point(228, 431);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(143, 30);
            this.btnTyhjaa.TabIndex = 76;
            this.btnTyhjaa.Text = "Tyhjennä Tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // FormPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.dgvPalvelut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnPaivitaHlo);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTyhjaa);
            this.Name = "FormPalvelut";
            this.Text = "PALVELUT";
            this.Load += new System.EventHandler(this.FormPalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblSposti;
        private System.Windows.Forms.Label lblPuhNro;
        private System.Windows.Forms.TextBox tbTyyppi;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPaivitaHlo;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlue;
    }
}