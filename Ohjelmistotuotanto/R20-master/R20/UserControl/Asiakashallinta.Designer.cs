namespace R20
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tmplbl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPostinrot = new System.Windows.Forms.ComboBox();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            this.btnPaivitaHlo = new System.Windows.Forms.Button();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.postitoimipaikka = new System.Windows.Forms.Label();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbSposti = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(88, 37);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(228, 36);
            this.tmplbl1.TabIndex = 0;
            this.tmplbl1.Text = "ASIAKASHALLINTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "tbPostinro -->";
            // 
            // cbPostinrot
            // 
            this.cbPostinrot.FormattingEnabled = true;
            this.cbPostinrot.Location = new System.Drawing.Point(171, 241);
            this.cbPostinrot.Name = "cbPostinrot";
            this.cbPostinrot.Size = new System.Drawing.Size(100, 21);
            this.cbPostinrot.TabIndex = 44;
            this.cbPostinrot.Leave += new System.EventHandler(this.cbPostinrot_Leave);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.Location = new System.Drawing.Point(217, 445);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(127, 23);
            this.btnTyhjaa.TabIndex = 43;
            this.btnTyhjaa.Text = "tyhjennä tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // btnPaivitaHlo
            // 
            this.btnPaivitaHlo.Location = new System.Drawing.Point(61, 507);
            this.btnPaivitaHlo.Name = "btnPaivitaHlo";
            this.btnPaivitaHlo.Size = new System.Drawing.Size(143, 23);
            this.btnPaivitaHlo.TabIndex = 42;
            this.btnPaivitaHlo.Text = "päivitä_henkilö";
            this.btnPaivitaHlo.UseVisualStyleBackColor = true;
            this.btnPaivitaHlo.Click += new System.EventHandler(this.btnPaivitaHlo_Click);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(171, 273);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.ReadOnly = true;
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(100, 20);
            this.tbPostitoimipaikka.TabIndex = 41;
            // 
            // postitoimipaikka
            // 
            this.postitoimipaikka.AutoSize = true;
            this.postitoimipaikka.Location = new System.Drawing.Point(61, 280);
            this.postitoimipaikka.Name = "postitoimipaikka";
            this.postitoimipaikka.Size = new System.Drawing.Size(82, 13);
            this.postitoimipaikka.TabIndex = 40;
            this.postitoimipaikka.Text = "postitoimipaikka";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(241, 507);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 39;
            this.btnPaivita.Text = "päivitä lista";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(64, 464);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(140, 23);
            this.btnPoista.TabIndex = 38;
            this.btnPoista.Text = "poista_henkilö";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(64, 422);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(140, 23);
            this.btnLisaa.TabIndex = 37;
            this.btnLisaa.Text = "lisää_henkilö";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Location = new System.Drawing.Point(171, 367);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(100, 20);
            this.tbPuhnro.TabIndex = 36;
            // 
            // tbSposti
            // 
            this.tbSposti.Location = new System.Drawing.Point(171, 332);
            this.tbSposti.Name = "tbSposti";
            this.tbSposti.Size = new System.Drawing.Size(100, 20);
            this.tbSposti.TabIndex = 35;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(171, 306);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(100, 20);
            this.tbLahiosoite.TabIndex = 34;
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(940, 618);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(100, 20);
            this.tbPostinro.TabIndex = 33;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(171, 207);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 20);
            this.tbSukunimi.TabIndex = 32;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(171, 177);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 20);
            this.tbEtunimi.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "puhnro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "sposti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "lähiosoite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "postinro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "etunimi";
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(350, 117);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(785, 470);
            this.dgvAsiakkaat.TabIndex = 24;
            this.dgvAsiakkaat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsiakkaat_CellClick);
            // 
            // Asiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPostinrot);
            this.Controls.Add(this.btnTyhjaa);
            this.Controls.Add(this.btnPaivitaHlo);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Controls.Add(this.postitoimipaikka);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbPuhnro);
            this.Controls.Add(this.tbSposti);
            this.Controls.Add(this.tbLahiosoite);
            this.Controls.Add(this.tbPostinro);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Asiakashallinta";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Asiakashallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPostinrot;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.Button btnPaivitaHlo;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.Label postitoimipaikka;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbSposti;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
    }
}
