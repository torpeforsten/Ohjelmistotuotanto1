namespace R20
{
    partial class Mokit
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
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.postinro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(53, 56);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(106, 39);
            this.tmplbl1.TabIndex = 1;
            this.tmplbl1.Text = "MÖKIT";
            // 
            // dgvMokit
            // 
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(318, 56);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.Size = new System.Drawing.Size(960, 521);
            this.dgvMokit.TabIndex = 2;
            this.dgvMokit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokit_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alue";
            // 
            // postinro
            // 
            this.postinro.AutoSize = true;
            this.postinro.Location = new System.Drawing.Point(33, 165);
            this.postinro.Name = "postinro";
            this.postinro.Size = new System.Drawing.Size(44, 13);
            this.postinro.TabIndex = 4;
            this.postinro.Text = "postinro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "mokkinimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "katuosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "kuvaus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "henkilömäärä";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "varustelu";
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(136, 125);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(121, 21);
            this.cbAlue.TabIndex = 11;
            // 
            // cbPostinro
            // 
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(136, 162);
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(121, 21);
            this.cbPostinro.TabIndex = 12;
            this.cbPostinro.Leave += new System.EventHandler(this.cbPostinro_Leave);
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(136, 224);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(100, 20);
            this.tbMokkinimi.TabIndex = 13;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(137, 250);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(99, 20);
            this.tbKatuosoite.TabIndex = 14;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(135, 282);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 15;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(136, 317);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbKuvaus.TabIndex = 16;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(135, 352);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(101, 20);
            this.tbHenkilomaara.TabIndex = 17;
            this.tbHenkilomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHenkilomaara_KeyPress);
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(135, 389);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(108, 20);
            this.tbVarustelu.TabIndex = 18;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(36, 441);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(123, 23);
            this.btnLisaa.TabIndex = 19;
            this.btnLisaa.Text = "Lisää_mökki";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(36, 483);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(123, 23);
            this.btnPoista.TabIndex = 20;
            this.btnPoista.Text = "Poista_mökki";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(36, 525);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(123, 23);
            this.btnPaivita.TabIndex = 21;
            this.btnPaivita.Text = "Päivitä_mökki";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Postitoimipaikka";
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(135, 194);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.ReadOnly = true;
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(100, 20);
            this.tbPostitoimipaikka.TabIndex = 23;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(36, 565);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(123, 23);
            this.btnTyhjenna.TabIndex = 24;
            this.btnTyhjenna.Text = "Tyhjennätiedot";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // Mokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbHenkilomaara);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokkinimi);
            this.Controls.Add(this.cbPostinro);
            this.Controls.Add(this.cbAlue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postinro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Mokit";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Mokit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label postinro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.ComboBox cbPostinro;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.Button btnTyhjenna;
    }
}
