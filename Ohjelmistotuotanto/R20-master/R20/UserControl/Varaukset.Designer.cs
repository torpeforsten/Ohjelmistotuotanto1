namespace R20
{
    partial class Varaukset
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
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dtpVahvistettu = new System.Windows.Forms.DateTimePicker();
            this.dtpVarattu = new System.Windows.Forms.DateTimePicker();
            this.dtpPaattyy = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkaa = new System.Windows.Forms.DateTimePicker();
            this.cbMokit = new System.Windows.Forms.ComboBox();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.varattu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            this.dgvVarauksenpalvelut = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVaraus = new System.Windows.Forms.ComboBox();
            this.cbPalvelu = new System.Windows.Forms.ComboBox();
            this.btnVarausPalveluLisaa = new System.Windows.Forms.Button();
            this.btnVarausPalveluPoista = new System.Windows.Forms.Button();
            this.btnVarausPalveluPaivita = new System.Windows.Forms.Button();
            this.lblmaara = new System.Windows.Forms.Label();
            this.tbLkm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(15, 18);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(155, 36);
            this.tmplbl1.TabIndex = 5;
            this.tmplbl1.Text = "VARAUKSET";
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(435, 18);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(832, 380);
            this.dgvVaraukset.TabIndex = 6;
            this.dgvVaraukset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVaraukset_CellClick);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(26, 303);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(99, 23);
            this.btnLisaa.TabIndex = 25;
            this.btnLisaa.Text = "uusi varaus";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // dtpVahvistettu
            // 
            this.dtpVahvistettu.Location = new System.Drawing.Point(92, 262);
            this.dtpVahvistettu.Name = "dtpVahvistettu";
            this.dtpVahvistettu.Size = new System.Drawing.Size(200, 20);
            this.dtpVahvistettu.TabIndex = 24;
            // 
            // dtpVarattu
            // 
            this.dtpVarattu.Location = new System.Drawing.Point(93, 228);
            this.dtpVarattu.Name = "dtpVarattu";
            this.dtpVarattu.Size = new System.Drawing.Size(200, 20);
            this.dtpVarattu.TabIndex = 23;
            // 
            // dtpPaattyy
            // 
            this.dtpPaattyy.Location = new System.Drawing.Point(93, 193);
            this.dtpPaattyy.Name = "dtpPaattyy";
            this.dtpPaattyy.Size = new System.Drawing.Size(200, 20);
            this.dtpPaattyy.TabIndex = 22;
            // 
            // dtpAlkaa
            // 
            this.dtpAlkaa.Location = new System.Drawing.Point(93, 155);
            this.dtpAlkaa.Name = "dtpAlkaa";
            this.dtpAlkaa.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkaa.TabIndex = 21;
            // 
            // cbMokit
            // 
            this.cbMokit.FormattingEnabled = true;
            this.cbMokit.Location = new System.Drawing.Point(96, 115);
            this.cbMokit.Name = "cbMokit";
            this.cbMokit.Size = new System.Drawing.Size(121, 21);
            this.cbMokit.TabIndex = 20;
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(96, 78);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(121, 21);
            this.cbAsiakas.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "vahvistettu";
            // 
            // varattu
            // 
            this.varattu.AutoSize = true;
            this.varattu.Location = new System.Drawing.Point(27, 228);
            this.varattu.Name = "varattu";
            this.varattu.Size = new System.Drawing.Size(40, 13);
            this.varattu.TabIndex = 17;
            this.varattu.Text = "varattu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "päättyy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alkaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mökki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Asiakas";
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(26, 332);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(99, 23);
            this.btnPoista.TabIndex = 26;
            this.btnPoista.Text = "poista varaus";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(26, 361);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(99, 23);
            this.btnPaivita.TabIndex = 27;
            this.btnPaivita.Text = "päivitä varaus";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.Location = new System.Drawing.Point(152, 303);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(120, 23);
            this.btnTyhjaa.TabIndex = 28;
            this.btnTyhjaa.Text = "tyhjennä tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // dgvVarauksenpalvelut
            // 
            this.dgvVarauksenpalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenpalvelut.Location = new System.Drawing.Point(435, 420);
            this.dgvVarauksenpalvelut.Name = "dgvVarauksenpalvelut";
            this.dgvVarauksenpalvelut.Size = new System.Drawing.Size(337, 285);
            this.dgvVarauksenpalvelut.TabIndex = 29;
            this.dgvVarauksenpalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVarauksenpalvelut_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Varaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Palvelu";
            // 
            // cbVaraus
            // 
            this.cbVaraus.FormattingEnabled = true;
            this.cbVaraus.Location = new System.Drawing.Point(96, 457);
            this.cbVaraus.Name = "cbVaraus";
            this.cbVaraus.Size = new System.Drawing.Size(121, 21);
            this.cbVaraus.TabIndex = 32;
            // 
            // cbPalvelu
            // 
            this.cbPalvelu.FormattingEnabled = true;
            this.cbPalvelu.Location = new System.Drawing.Point(96, 489);
            this.cbPalvelu.Name = "cbPalvelu";
            this.cbPalvelu.Size = new System.Drawing.Size(121, 21);
            this.cbPalvelu.TabIndex = 33;
            // 
            // btnVarausPalveluLisaa
            // 
            this.btnVarausPalveluLisaa.Location = new System.Drawing.Point(21, 568);
            this.btnVarausPalveluLisaa.Name = "btnVarausPalveluLisaa";
            this.btnVarausPalveluLisaa.Size = new System.Drawing.Size(173, 23);
            this.btnVarausPalveluLisaa.TabIndex = 34;
            this.btnVarausPalveluLisaa.Text = "Lisää varaukseen palvelu";
            this.btnVarausPalveluLisaa.UseVisualStyleBackColor = true;
            this.btnVarausPalveluLisaa.Click += new System.EventHandler(this.btnVarausPalveluLisaa_Click);
            // 
            // btnVarausPalveluPoista
            // 
            this.btnVarausPalveluPoista.Location = new System.Drawing.Point(21, 597);
            this.btnVarausPalveluPoista.Name = "btnVarausPalveluPoista";
            this.btnVarausPalveluPoista.Size = new System.Drawing.Size(173, 23);
            this.btnVarausPalveluPoista.TabIndex = 35;
            this.btnVarausPalveluPoista.Text = "Poista varauksesta palvelu";
            this.btnVarausPalveluPoista.UseVisualStyleBackColor = true;
            this.btnVarausPalveluPoista.Click += new System.EventHandler(this.btnVarausPalveluPoista_Click);
            // 
            // btnVarausPalveluPaivita
            // 
            this.btnVarausPalveluPaivita.Location = new System.Drawing.Point(21, 626);
            this.btnVarausPalveluPaivita.Name = "btnVarausPalveluPaivita";
            this.btnVarausPalveluPaivita.Size = new System.Drawing.Size(173, 23);
            this.btnVarausPalveluPaivita.TabIndex = 36;
            this.btnVarausPalveluPaivita.Text = "Päivitä varaukseen palvelu";
            this.btnVarausPalveluPaivita.UseVisualStyleBackColor = true;
            this.btnVarausPalveluPaivita.Click += new System.EventHandler(this.btnVarausPalveluPaivita_Click);
            // 
            // lblmaara
            // 
            this.lblmaara.AutoSize = true;
            this.lblmaara.Location = new System.Drawing.Point(18, 528);
            this.lblmaara.Name = "lblmaara";
            this.lblmaara.Size = new System.Drawing.Size(60, 13);
            this.lblmaara.TabIndex = 37;
            this.lblmaara.Text = "Lukumäärä";
            // 
            // tbLkm
            // 
            this.tbLkm.Location = new System.Drawing.Point(96, 525);
            this.tbLkm.Name = "tbLkm";
            this.tbLkm.Size = new System.Drawing.Size(121, 20);
            this.tbLkm.TabIndex = 38;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLkm);
            this.Controls.Add(this.lblmaara);
            this.Controls.Add(this.btnVarausPalveluPaivita);
            this.Controls.Add(this.btnVarausPalveluPoista);
            this.Controls.Add(this.btnVarausPalveluLisaa);
            this.Controls.Add(this.cbPalvelu);
            this.Controls.Add(this.cbVaraus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvVarauksenpalvelut);
            this.Controls.Add(this.btnTyhjaa);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dtpVahvistettu);
            this.Controls.Add(this.dtpVarattu);
            this.Controls.Add(this.dtpPaattyy);
            this.Controls.Add(this.dtpAlkaa);
            this.Controls.Add(this.cbMokit);
            this.Controls.Add(this.cbAsiakas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.varattu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Varaukset";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.DateTimePicker dtpVahvistettu;
        private System.Windows.Forms.DateTimePicker dtpVarattu;
        private System.Windows.Forms.DateTimePicker dtpPaattyy;
        private System.Windows.Forms.DateTimePicker dtpAlkaa;
        private System.Windows.Forms.ComboBox cbMokit;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label varattu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.DataGridView dgvVarauksenpalvelut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVaraus;
        private System.Windows.Forms.ComboBox cbPalvelu;
        private System.Windows.Forms.Button btnVarausPalveluLisaa;
        private System.Windows.Forms.Button btnVarausPalveluPoista;
        private System.Windows.Forms.Button btnVarausPalveluPaivita;
        private System.Windows.Forms.Label lblmaara;
        private System.Windows.Forms.TextBox tbLkm;
    }
}
