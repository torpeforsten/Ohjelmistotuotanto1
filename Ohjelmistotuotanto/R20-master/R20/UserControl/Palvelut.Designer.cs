namespace R20
{
    partial class Palvelut
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
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbTyyppi = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(66, 93);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(129, 36);
            this.tmplbl1.TabIndex = 3;
            this.tmplbl1.Text = "PALVELUT";
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(404, 93);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(745, 532);
            this.dgvPalvelut.TabIndex = 4;
            this.dgvPalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalvelut_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "alue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "tyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "kuvaus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "hinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "alv";
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(140, 180);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(121, 21);
            this.cbAlue.TabIndex = 11;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(140, 213);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(100, 20);
            this.tbNimi.TabIndex = 12;
            // 
            // tbTyyppi
            // 
            this.tbTyyppi.Location = new System.Drawing.Point(140, 244);
            this.tbTyyppi.Name = "tbTyyppi";
            this.tbTyyppi.Size = new System.Drawing.Size(100, 20);
            this.tbTyyppi.TabIndex = 13;
            this.tbTyyppi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTyyppi_KeyPress);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(140, 281);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbKuvaus.TabIndex = 14;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(140, 316);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 15;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(140, 347);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(100, 20);
            this.tbAlv.TabIndex = 16;
            this.tbAlv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlv_KeyPress);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(70, 405);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(90, 23);
            this.btnLisaa.TabIndex = 17;
            this.btnLisaa.Text = "Lisää_palvelu";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(70, 448);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(90, 23);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista_palvelu";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(70, 491);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(90, 23);
            this.btnPaivita.TabIndex = 19;
            this.btnPaivita.Text = "Päivitä_palvelu";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(207, 405);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(95, 23);
            this.btnTyhjenna.TabIndex = 20;
            this.btnTyhjenna.Text = "tyhjennä_tiedot";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // Palvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbAlv);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbTyyppi);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.cbAlue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPalvelut);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Palvelut";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Palvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbTyyppi;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnTyhjenna;
    }
}
