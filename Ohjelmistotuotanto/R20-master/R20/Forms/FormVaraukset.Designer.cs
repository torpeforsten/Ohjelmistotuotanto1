namespace R20.Forms
{
    partial class FormVaraukset
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpVahvistettu = new System.Windows.Forms.DateTimePicker();
            this.dtpVarattu = new System.Windows.Forms.DateTimePicker();
            this.dtpPaattyy = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkaa = new System.Windows.Forms.DateTimePicker();
            this.cbMokit = new System.Windows.Forms.ComboBox();
            this.lblAsiakas = new System.Windows.Forms.Label();
            this.lblMokki = new System.Windows.Forms.Label();
            this.lblVahvistettu = new System.Windows.Forms.Label();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.lblVarattu = new System.Windows.Forms.Label();
            this.lblPaattyy = new System.Windows.Forms.Label();
            this.lblAlkaa = new System.Windows.Forms.Label();
            this.cbPalvelu = new System.Windows.Forms.ComboBox();
            this.cbVaraus = new System.Windows.Forms.ComboBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPaivitaHlo = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            this.dgvVarauksenpalvelut = new System.Windows.Forms.DataGridView();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLkm = new System.Windows.Forms.TextBox();
            this.btnVarausPalveluLisaa = new System.Windows.Forms.Button();
            this.btnVarausPalveluPoista = new System.Windows.Forms.Button();
            this.btnVarausPalveluPaivita = new System.Windows.Forms.Button();
            this.btnTyhjennaVarausPalvelu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpVahvistettu);
            this.panel2.Controls.Add(this.dtpVarattu);
            this.panel2.Controls.Add(this.dtpPaattyy);
            this.panel2.Controls.Add(this.dtpAlkaa);
            this.panel2.Controls.Add(this.cbMokit);
            this.panel2.Controls.Add(this.lblAsiakas);
            this.panel2.Controls.Add(this.lblMokki);
            this.panel2.Controls.Add(this.lblVahvistettu);
            this.panel2.Controls.Add(this.cbAsiakas);
            this.panel2.Controls.Add(this.lblVarattu);
            this.panel2.Controls.Add(this.lblPaattyy);
            this.panel2.Controls.Add(this.lblAlkaa);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 258);
            this.panel2.TabIndex = 78;
            // 
            // dtpVahvistettu
            // 
            this.dtpVahvistettu.Location = new System.Drawing.Point(195, 205);
            this.dtpVahvistettu.Name = "dtpVahvistettu";
            this.dtpVahvistettu.Size = new System.Drawing.Size(167, 20);
            this.dtpVahvistettu.TabIndex = 75;
            // 
            // dtpVarattu
            // 
            this.dtpVarattu.Location = new System.Drawing.Point(195, 171);
            this.dtpVarattu.Name = "dtpVarattu";
            this.dtpVarattu.Size = new System.Drawing.Size(167, 20);
            this.dtpVarattu.TabIndex = 74;
            // 
            // dtpPaattyy
            // 
            this.dtpPaattyy.Location = new System.Drawing.Point(195, 136);
            this.dtpPaattyy.Name = "dtpPaattyy";
            this.dtpPaattyy.Size = new System.Drawing.Size(167, 20);
            this.dtpPaattyy.TabIndex = 73;
            // 
            // dtpAlkaa
            // 
            this.dtpAlkaa.Location = new System.Drawing.Point(195, 104);
            this.dtpAlkaa.Name = "dtpAlkaa";
            this.dtpAlkaa.Size = new System.Drawing.Size(167, 20);
            this.dtpAlkaa.TabIndex = 72;
            // 
            // cbMokit
            // 
            this.cbMokit.FormattingEnabled = true;
            this.cbMokit.Location = new System.Drawing.Point(195, 63);
            this.cbMokit.Name = "cbMokit";
            this.cbMokit.Size = new System.Drawing.Size(167, 21);
            this.cbMokit.TabIndex = 69;
            // 
            // lblAsiakas
            // 
            this.lblAsiakas.AutoSize = true;
            this.lblAsiakas.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakas.Location = new System.Drawing.Point(28, 29);
            this.lblAsiakas.Name = "lblAsiakas";
            this.lblAsiakas.Size = new System.Drawing.Size(63, 20);
            this.lblAsiakas.TabIndex = 48;
            this.lblAsiakas.Text = "Asiakas";
            // 
            // lblMokki
            // 
            this.lblMokki.AutoSize = true;
            this.lblMokki.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokki.Location = new System.Drawing.Point(28, 61);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(53, 20);
            this.lblMokki.TabIndex = 49;
            this.lblMokki.Text = "Mökki";
            // 
            // lblVahvistettu
            // 
            this.lblVahvistettu.AutoSize = true;
            this.lblVahvistettu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVahvistettu.Location = new System.Drawing.Point(28, 206);
            this.lblVahvistettu.Name = "lblVahvistettu";
            this.lblVahvistettu.Size = new System.Drawing.Size(92, 20);
            this.lblVahvistettu.TabIndex = 50;
            this.lblVahvistettu.Text = "Vahvistettu";
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(195, 28);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(167, 21);
            this.cbAsiakas.TabIndex = 67;
            // 
            // lblVarattu
            // 
            this.lblVarattu.AutoSize = true;
            this.lblVarattu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarattu.Location = new System.Drawing.Point(27, 171);
            this.lblVarattu.Name = "lblVarattu";
            this.lblVarattu.Size = new System.Drawing.Size(64, 20);
            this.lblVarattu.TabIndex = 51;
            this.lblVarattu.Text = "Varattu";
            // 
            // lblPaattyy
            // 
            this.lblPaattyy.AutoSize = true;
            this.lblPaattyy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaattyy.Location = new System.Drawing.Point(28, 136);
            this.lblPaattyy.Name = "lblPaattyy";
            this.lblPaattyy.Size = new System.Drawing.Size(64, 20);
            this.lblPaattyy.TabIndex = 52;
            this.lblPaattyy.Text = "Päättyy";
            // 
            // lblAlkaa
            // 
            this.lblAlkaa.AutoSize = true;
            this.lblAlkaa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlkaa.Location = new System.Drawing.Point(28, 105);
            this.lblAlkaa.Name = "lblAlkaa";
            this.lblAlkaa.Size = new System.Drawing.Size(51, 20);
            this.lblAlkaa.TabIndex = 53;
            this.lblAlkaa.Text = "Alkaa";
            // 
            // cbPalvelu
            // 
            this.cbPalvelu.FormattingEnabled = true;
            this.cbPalvelu.Location = new System.Drawing.Point(195, 430);
            this.cbPalvelu.Name = "cbPalvelu";
            this.cbPalvelu.Size = new System.Drawing.Size(167, 21);
            this.cbPalvelu.TabIndex = 71;
            // 
            // cbVaraus
            // 
            this.cbVaraus.FormattingEnabled = true;
            this.cbVaraus.Location = new System.Drawing.Point(195, 392);
            this.cbVaraus.Name = "cbVaraus";
            this.cbVaraus.Size = new System.Drawing.Size(167, 21);
            this.cbVaraus.TabIndex = 70;
            // 
            // btnLisaa
            // 
            this.btnLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaa.Location = new System.Drawing.Point(9, 276);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(143, 30);
            this.btnLisaa.TabIndex = 72;
            this.btnLisaa.Text = "Lisää Varaus";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPaivitaHlo
            // 
            this.btnPaivitaHlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivitaHlo.Location = new System.Drawing.Point(9, 323);
            this.btnPaivitaHlo.Name = "btnPaivitaHlo";
            this.btnPaivitaHlo.Size = new System.Drawing.Size(143, 30);
            this.btnPaivitaHlo.TabIndex = 75;
            this.btnPaivitaHlo.Text = "Päivitä Varaus";
            this.btnPaivitaHlo.UseVisualStyleBackColor = true;
            this.btnPaivitaHlo.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.Location = new System.Drawing.Point(219, 276);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(143, 30);
            this.btnPoista.TabIndex = 73;
            this.btnPoista.Text = "Poista Varaus";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyhjaa.Location = new System.Drawing.Point(219, 323);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(143, 30);
            this.btnTyhjaa.TabIndex = 76;
            this.btnTyhjaa.Text = "Tyhjennä Tiedot";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // dgvVarauksenpalvelut
            // 
            this.dgvVarauksenpalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenpalvelut.Location = new System.Drawing.Point(397, 392);
            this.dgvVarauksenpalvelut.Name = "dgvVarauksenpalvelut";
            this.dgvVarauksenpalvelut.Size = new System.Drawing.Size(785, 258);
            this.dgvVarauksenpalvelut.TabIndex = 80;
            this.dgvVarauksenpalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVarauksenpalvelut_CellClick);
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(397, 12);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(785, 327);
            this.dgvVaraukset.TabIndex = 79;
            this.dgvVaraukset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVaraukset_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Varaus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Palvelu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Lukumäärä";
            // 
            // tbLkm
            // 
            this.tbLkm.Location = new System.Drawing.Point(195, 472);
            this.tbLkm.Name = "tbLkm";
            this.tbLkm.Size = new System.Drawing.Size(167, 20);
            this.tbLkm.TabIndex = 39;
            this.tbLkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLkm_KeyPress);
            // 
            // btnVarausPalveluLisaa
            // 
            this.btnVarausPalveluLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVarausPalveluLisaa.Location = new System.Drawing.Point(9, 529);
            this.btnVarausPalveluLisaa.Name = "btnVarausPalveluLisaa";
            this.btnVarausPalveluLisaa.Size = new System.Drawing.Size(152, 30);
            this.btnVarausPalveluLisaa.TabIndex = 85;
            this.btnVarausPalveluLisaa.Text = "Lisää varaukseen palvelu";
            this.btnVarausPalveluLisaa.UseVisualStyleBackColor = true;
            this.btnVarausPalveluLisaa.Click += new System.EventHandler(this.btnVarausPalveluLisaa_Click);
            // 
            // btnVarausPalveluPoista
            // 
            this.btnVarausPalveluPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVarausPalveluPoista.Location = new System.Drawing.Point(210, 529);
            this.btnVarausPalveluPoista.Name = "btnVarausPalveluPoista";
            this.btnVarausPalveluPoista.Size = new System.Drawing.Size(152, 30);
            this.btnVarausPalveluPoista.TabIndex = 86;
            this.btnVarausPalveluPoista.Text = "Poista varauksesta palvelu";
            this.btnVarausPalveluPoista.UseVisualStyleBackColor = true;
            this.btnVarausPalveluPoista.Click += new System.EventHandler(this.btnVarausPalveluPoista_Click);
            // 
            // btnVarausPalveluPaivita
            // 
            this.btnVarausPalveluPaivita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVarausPalveluPaivita.Location = new System.Drawing.Point(9, 587);
            this.btnVarausPalveluPaivita.Name = "btnVarausPalveluPaivita";
            this.btnVarausPalveluPaivita.Size = new System.Drawing.Size(152, 30);
            this.btnVarausPalveluPaivita.TabIndex = 87;
            this.btnVarausPalveluPaivita.Text = "Päivitä varauskeen palvelu";
            this.btnVarausPalveluPaivita.UseVisualStyleBackColor = true;
            this.btnVarausPalveluPaivita.Click += new System.EventHandler(this.btnVarausPalveluPaivita_Click);
            // 
            // btnTyhjennaVarausPalvelu
            // 
            this.btnTyhjennaVarausPalvelu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTyhjennaVarausPalvelu.Location = new System.Drawing.Point(210, 587);
            this.btnTyhjennaVarausPalvelu.Name = "btnTyhjennaVarausPalvelu";
            this.btnTyhjennaVarausPalvelu.Size = new System.Drawing.Size(152, 30);
            this.btnTyhjennaVarausPalvelu.TabIndex = 88;
            this.btnTyhjennaVarausPalvelu.Text = "Tyhjennä Tiedot";
            this.btnTyhjennaVarausPalvelu.UseVisualStyleBackColor = true;
            this.btnTyhjennaVarausPalvelu.Click += new System.EventHandler(this.btnTyhjennaVarausPalvelu_Click);
            // 
            // FormVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.btnTyhjennaVarausPalvelu);
            this.Controls.Add(this.btnVarausPalveluPaivita);
            this.Controls.Add(this.btnVarausPalveluPoista);
            this.Controls.Add(this.btnVarausPalveluLisaa);
            this.Controls.Add(this.tbLkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPalvelu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVaraus);
            this.Controls.Add(this.dgvVarauksenpalvelut);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnPaivitaHlo);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTyhjaa);
            this.Name = "FormVaraukset";
            this.Text = "VARAUKSET";
            this.Load += new System.EventHandler(this.FormVaraukset_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAsiakas;
        private System.Windows.Forms.Label lblMokki;
        private System.Windows.Forms.Label lblVahvistettu;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.Label lblVarattu;
        private System.Windows.Forms.Label lblPaattyy;
        private System.Windows.Forms.Label lblAlkaa;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPaivitaHlo;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.DateTimePicker dtpVahvistettu;
        private System.Windows.Forms.DateTimePicker dtpVarattu;
        private System.Windows.Forms.DateTimePicker dtpPaattyy;
        private System.Windows.Forms.DateTimePicker dtpAlkaa;
        private System.Windows.Forms.ComboBox cbPalvelu;
        private System.Windows.Forms.ComboBox cbVaraus;
        private System.Windows.Forms.ComboBox cbMokit;
        private System.Windows.Forms.DataGridView dgvVarauksenpalvelut;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLkm;
        private System.Windows.Forms.Button btnVarausPalveluLisaa;
        private System.Windows.Forms.Button btnVarausPalveluPoista;
        private System.Windows.Forms.Button btnVarausPalveluPaivita;
        private System.Windows.Forms.Button btnTyhjennaVarausPalvelu;
    }
}