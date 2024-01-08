namespace R20.Forms
{
    partial class FormAsiakashallinta
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
            this.cbPostinrot = new System.Windows.Forms.ComboBox();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            this.btnPaivitaHlo = new System.Windows.Forms.Button();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbSposti = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblPuhNro = new System.Windows.Forms.Label();
            this.lblSposti = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblPostiNro = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPostinrot
            // 
            this.cbPostinrot.FormattingEnabled = true;
            this.cbPostinrot.Location = new System.Drawing.Point(195, 222);
            this.cbPostinrot.Name = "cbPostinrot";
            this.cbPostinrot.Size = new System.Drawing.Size(167, 21);
            this.cbPostinrot.TabIndex = 67;
            this.cbPostinrot.SelectedIndexChanged += new System.EventHandler(this.cbPostinrot_SelectedIndexChanged);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyhjaa.Location = new System.Drawing.Point(228, 472);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(143, 30);
            this.btnTyhjaa.TabIndex = 66;
            this.btnTyhjaa.Text = "Tyhjennä Tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // btnPaivitaHlo
            // 
            this.btnPaivitaHlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivitaHlo.Location = new System.Drawing.Point(39, 472);
            this.btnPaivitaHlo.Name = "btnPaivitaHlo";
            this.btnPaivitaHlo.Size = new System.Drawing.Size(143, 30);
            this.btnPaivitaHlo.TabIndex = 65;
            this.btnPaivitaHlo.Text = "Päivitä Asiakas";
            this.btnPaivitaHlo.UseVisualStyleBackColor = true;
            this.btnPaivitaHlo.Click += new System.EventHandler(this.btnPaivitaHlo_Click);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(195, 256);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.ReadOnly = true;
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(167, 20);
            this.tbPostitoimipaikka.TabIndex = 64;
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(29, 256);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(125, 20);
            this.lblPostitoimipaikka.TabIndex = 63;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // btnPaivita
            // 
            this.btnPaivita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivita.Location = new System.Drawing.Point(136, 545);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(140, 30);
            this.btnPaivita.TabIndex = 62;
            this.btnPaivita.Text = "Päivitä Lista";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.Location = new System.Drawing.Point(228, 397);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(140, 30);
            this.btnPoista.TabIndex = 61;
            this.btnPoista.Text = "Poista Asiakas";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaa.Location = new System.Drawing.Point(42, 397);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(140, 30);
            this.btnLisaa.TabIndex = 60;
            this.btnLisaa.Text = "Lisää Asiakas";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Location = new System.Drawing.Point(194, 101);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(168, 20);
            this.tbPuhnro.TabIndex = 59;
            this.tbPuhnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhnro_KeyPress);
            // 
            // tbSposti
            // 
            this.tbSposti.Location = new System.Drawing.Point(194, 132);
            this.tbSposti.Name = "tbSposti";
            this.tbSposti.Size = new System.Drawing.Size(168, 20);
            this.tbSposti.TabIndex = 58;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(194, 185);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(168, 20);
            this.tbLahiosoite.TabIndex = 57;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(194, 63);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(171, 20);
            this.tbSukunimi.TabIndex = 55;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(194, 29);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(171, 20);
            this.tbEtunimi.TabIndex = 54;
            // 
            // lblPuhNro
            // 
            this.lblPuhNro.AutoSize = true;
            this.lblPuhNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuhNro.Location = new System.Drawing.Point(28, 101);
            this.lblPuhNro.Name = "lblPuhNro";
            this.lblPuhNro.Size = new System.Drawing.Size(117, 20);
            this.lblPuhNro.TabIndex = 53;
            this.lblPuhNro.Text = "Puhelinnumero";
            // 
            // lblSposti
            // 
            this.lblSposti.AutoSize = true;
            this.lblSposti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposti.Location = new System.Drawing.Point(28, 132);
            this.lblSposti.Name = "lblSposti";
            this.lblSposti.Size = new System.Drawing.Size(87, 20);
            this.lblSposti.TabIndex = 52;
            this.lblSposti.Text = "Sähköposti";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(28, 185);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(82, 20);
            this.lblOsoite.TabIndex = 51;
            this.lblOsoite.Text = "Lähiosoite";
            // 
            // lblPostiNro
            // 
            this.lblPostiNro.AutoSize = true;
            this.lblPostiNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostiNro.Location = new System.Drawing.Point(29, 220);
            this.lblPostiNro.Name = "lblPostiNro";
            this.lblPostiNro.Size = new System.Drawing.Size(66, 20);
            this.lblPostiNro.TabIndex = 50;
            this.lblPostiNro.Text = "Postinro";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(28, 63);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(70, 20);
            this.lblSukunimi.TabIndex = 49;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(28, 29);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(59, 20);
            this.lblEtunimi.TabIndex = 48;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(391, 54);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(744, 521);
            this.dgvAsiakkaat.TabIndex = 47;
            this.dgvAsiakkaat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsiakkaat_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEtunimi);
            this.panel2.Controls.Add(this.lblSukunimi);
            this.panel2.Controls.Add(this.lblPostiNro);
            this.panel2.Controls.Add(this.cbPostinrot);
            this.panel2.Controls.Add(this.lblOsoite);
            this.panel2.Controls.Add(this.lblSposti);
            this.panel2.Controls.Add(this.lblPuhNro);
            this.panel2.Controls.Add(this.tbPostitoimipaikka);
            this.panel2.Controls.Add(this.tbEtunimi);
            this.panel2.Controls.Add(this.lblPostitoimipaikka);
            this.panel2.Controls.Add(this.tbSukunimi);
            this.panel2.Controls.Add(this.tbLahiosoite);
            this.panel2.Controls.Add(this.tbSposti);
            this.panel2.Controls.Add(this.tbPuhnro);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 312);
            this.panel2.TabIndex = 70;
            // 
            // FormAsiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnPaivitaHlo);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTyhjaa);
            this.Name = "FormAsiakashallinta";
            this.Text = "ASIAKASHALLINTA";
            this.Load += new System.EventHandler(this.FormAsiakashallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPostinrot;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.Button btnPaivitaHlo;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbSposti;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lblPuhNro;
        private System.Windows.Forms.Label lblSposti;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblPostiNro;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Panel panel2;
    }
}