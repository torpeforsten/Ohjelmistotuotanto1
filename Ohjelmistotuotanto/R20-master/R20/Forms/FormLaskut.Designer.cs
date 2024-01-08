namespace R20.Forms
{
    partial class FormLaskut
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
            this.dgvLasku = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblSposti = new System.Windows.Forms.Label();
            this.lblPuhNro = new System.Windows.Forms.Label();
            this.textBox_laskuid = new System.Windows.Forms.TextBox();
            this.textBox_varausid = new System.Windows.Forms.TextBox();
            this.textBox_alv = new System.Windows.Forms.TextBox();
            this.textBox_summa = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPaivitaHlo = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_sposti = new System.Windows.Forms.TextBox();
            this.lblSpostivast = new System.Windows.Forms.Label();
            this.lblErapva = new System.Windows.Forms.Label();
            this.dtp_erapva = new System.Windows.Forms.DateTimePicker();
            this.textBox_tilinumero = new System.Windows.Forms.TextBox();
            this.lblTilinumero = new System.Windows.Forms.Label();
            this.textBox_saaja = new System.Windows.Forms.TextBox();
            this.lblSaaja = new System.Windows.Forms.Label();
            this.textBox_viitenumero = new System.Windows.Forms.TextBox();
            this.lblViitenumero = new System.Windows.Forms.Label();
            this.btnLahetaLasku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLasku
            // 
            this.dgvLasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku.Location = new System.Drawing.Point(391, 54);
            this.dgvLasku.Name = "dgvLasku";
            this.dgvLasku.Size = new System.Drawing.Size(744, 521);
            this.dgvLasku.TabIndex = 71;
            this.dgvLasku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLasku_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEtunimi);
            this.panel2.Controls.Add(this.lblSukunimi);
            this.panel2.Controls.Add(this.lblSposti);
            this.panel2.Controls.Add(this.lblPuhNro);
            this.panel2.Controls.Add(this.textBox_laskuid);
            this.panel2.Controls.Add(this.textBox_varausid);
            this.panel2.Controls.Add(this.textBox_alv);
            this.panel2.Controls.Add(this.textBox_summa);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 185);
            this.panel2.TabIndex = 78;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(28, 29);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(69, 20);
            this.lblEtunimi.TabIndex = 48;
            this.lblEtunimi.Text = "Lasku ID";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(28, 63);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(80, 20);
            this.lblSukunimi.TabIndex = 49;
            this.lblSukunimi.Text = "Varaus ID";
            // 
            // lblSposti
            // 
            this.lblSposti.AutoSize = true;
            this.lblSposti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposti.Location = new System.Drawing.Point(28, 132);
            this.lblSposti.Name = "lblSposti";
            this.lblSposti.Size = new System.Drawing.Size(38, 20);
            this.lblSposti.TabIndex = 52;
            this.lblSposti.Text = "ALV";
            // 
            // lblPuhNro
            // 
            this.lblPuhNro.AutoSize = true;
            this.lblPuhNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuhNro.Location = new System.Drawing.Point(28, 101);
            this.lblPuhNro.Name = "lblPuhNro";
            this.lblPuhNro.Size = new System.Drawing.Size(61, 20);
            this.lblPuhNro.TabIndex = 53;
            this.lblPuhNro.Text = "Summa";
            // 
            // textBox_laskuid
            // 
            this.textBox_laskuid.Enabled = false;
            this.textBox_laskuid.Location = new System.Drawing.Point(194, 29);
            this.textBox_laskuid.Name = "textBox_laskuid";
            this.textBox_laskuid.Size = new System.Drawing.Size(168, 20);
            this.textBox_laskuid.TabIndex = 54;
            // 
            // textBox_varausid
            // 
            this.textBox_varausid.Location = new System.Drawing.Point(194, 63);
            this.textBox_varausid.Name = "textBox_varausid";
            this.textBox_varausid.Size = new System.Drawing.Size(168, 20);
            this.textBox_varausid.TabIndex = 55;
            this.textBox_varausid.Leave += new System.EventHandler(this.textBox_varausid_Leave);
            // 
            // textBox_alv
            // 
            this.textBox_alv.Location = new System.Drawing.Point(194, 132);
            this.textBox_alv.Name = "textBox_alv";
            this.textBox_alv.Size = new System.Drawing.Size(168, 20);
            this.textBox_alv.TabIndex = 58;
            // 
            // textBox_summa
            // 
            this.textBox_summa.Enabled = false;
            this.textBox_summa.Location = new System.Drawing.Point(194, 101);
            this.textBox_summa.Name = "textBox_summa";
            this.textBox_summa.Size = new System.Drawing.Size(168, 20);
            this.textBox_summa.TabIndex = 59;
            // 
            // btnLisaa
            // 
            this.btnLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaa.Location = new System.Drawing.Point(32, 257);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(140, 30);
            this.btnLisaa.TabIndex = 72;
            this.btnLisaa.Text = "Lisää lasku";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPaivitaHlo
            // 
            this.btnPaivitaHlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivitaHlo.Location = new System.Drawing.Point(127, 304);
            this.btnPaivitaHlo.Name = "btnPaivitaHlo";
            this.btnPaivitaHlo.Size = new System.Drawing.Size(143, 30);
            this.btnPaivitaHlo.TabIndex = 75;
            this.btnPaivitaHlo.Text = "Päivitä lasku";
            this.btnPaivitaHlo.UseVisualStyleBackColor = true;
            this.btnPaivitaHlo.Click += new System.EventHandler(this.btnPaivitaHlo_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.Location = new System.Drawing.Point(218, 257);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(140, 30);
            this.btnPoista.TabIndex = 73;
            this.btnPoista.Text = "Poista lasku";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_sposti);
            this.panel1.Controls.Add(this.lblSpostivast);
            this.panel1.Controls.Add(this.lblErapva);
            this.panel1.Controls.Add(this.dtp_erapva);
            this.panel1.Controls.Add(this.textBox_tilinumero);
            this.panel1.Controls.Add(this.lblTilinumero);
            this.panel1.Controls.Add(this.textBox_saaja);
            this.panel1.Controls.Add(this.lblSaaja);
            this.panel1.Controls.Add(this.textBox_viitenumero);
            this.panel1.Controls.Add(this.lblViitenumero);
            this.panel1.Location = new System.Drawing.Point(12, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 214);
            this.panel1.TabIndex = 79;
            // 
            // textBox_sposti
            // 
            this.textBox_sposti.Location = new System.Drawing.Point(161, 169);
            this.textBox_sposti.Name = "textBox_sposti";
            this.textBox_sposti.Size = new System.Drawing.Size(189, 20);
            this.textBox_sposti.TabIndex = 10;
            // 
            // lblSpostivast
            // 
            this.lblSpostivast.AutoSize = true;
            this.lblSpostivast.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpostivast.Location = new System.Drawing.Point(16, 167);
            this.lblSpostivast.Name = "lblSpostivast";
            this.lblSpostivast.Size = new System.Drawing.Size(112, 40);
            this.lblSpostivast.TabIndex = 9;
            this.lblSpostivast.Text = "Sposti,\r\nvastaanottaja";
            // 
            // lblErapva
            // 
            this.lblErapva.AutoSize = true;
            this.lblErapva.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErapva.Location = new System.Drawing.Point(17, 137);
            this.lblErapva.Name = "lblErapva";
            this.lblErapva.Size = new System.Drawing.Size(75, 20);
            this.lblErapva.TabIndex = 8;
            this.lblErapva.Text = "Eräpäivä";
            // 
            // dtp_erapva
            // 
            this.dtp_erapva.Location = new System.Drawing.Point(161, 136);
            this.dtp_erapva.Name = "dtp_erapva";
            this.dtp_erapva.Size = new System.Drawing.Size(189, 20);
            this.dtp_erapva.TabIndex = 7;
            // 
            // textBox_tilinumero
            // 
            this.textBox_tilinumero.Location = new System.Drawing.Point(182, 100);
            this.textBox_tilinumero.Name = "textBox_tilinumero";
            this.textBox_tilinumero.Size = new System.Drawing.Size(168, 20);
            this.textBox_tilinumero.TabIndex = 6;
            // 
            // lblTilinumero
            // 
            this.lblTilinumero.AutoSize = true;
            this.lblTilinumero.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilinumero.Location = new System.Drawing.Point(17, 100);
            this.lblTilinumero.Name = "lblTilinumero";
            this.lblTilinumero.Size = new System.Drawing.Size(79, 20);
            this.lblTilinumero.TabIndex = 5;
            this.lblTilinumero.Text = "Tilinumero";
            // 
            // textBox_saaja
            // 
            this.textBox_saaja.Location = new System.Drawing.Point(182, 62);
            this.textBox_saaja.Name = "textBox_saaja";
            this.textBox_saaja.Size = new System.Drawing.Size(168, 20);
            this.textBox_saaja.TabIndex = 4;
            this.textBox_saaja.Text = "Village Newbies Oy";
            // 
            // lblSaaja
            // 
            this.lblSaaja.AutoSize = true;
            this.lblSaaja.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaaja.Location = new System.Drawing.Point(17, 60);
            this.lblSaaja.Name = "lblSaaja";
            this.lblSaaja.Size = new System.Drawing.Size(49, 20);
            this.lblSaaja.TabIndex = 3;
            this.lblSaaja.Text = "Saaja";
            // 
            // textBox_viitenumero
            // 
            this.textBox_viitenumero.Location = new System.Drawing.Point(182, 21);
            this.textBox_viitenumero.Name = "textBox_viitenumero";
            this.textBox_viitenumero.Size = new System.Drawing.Size(168, 20);
            this.textBox_viitenumero.TabIndex = 2;
            // 
            // lblViitenumero
            // 
            this.lblViitenumero.AutoSize = true;
            this.lblViitenumero.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViitenumero.Location = new System.Drawing.Point(17, 21);
            this.lblViitenumero.Name = "lblViitenumero";
            this.lblViitenumero.Size = new System.Drawing.Size(97, 20);
            this.lblViitenumero.TabIndex = 1;
            this.lblViitenumero.Text = "Viitenumero";
            // 
            // btnLahetaLasku
            // 
            this.btnLahetaLasku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLahetaLasku.Location = new System.Drawing.Point(130, 560);
            this.btnLahetaLasku.Name = "btnLahetaLasku";
            this.btnLahetaLasku.Size = new System.Drawing.Size(140, 43);
            this.btnLahetaLasku.TabIndex = 0;
            this.btnLahetaLasku.Text = "Lähetä lasku\r\nS- posti";
            this.btnLahetaLasku.UseVisualStyleBackColor = true;
            this.btnLahetaLasku.Click += new System.EventHandler(this.btnLahetaLasku_Click);
            // 
            // FormLaskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLasku);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnPaivitaHlo);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLahetaLasku);
            this.Name = "FormLaskut";
            this.Text = "LASKUT";
            this.Load += new System.EventHandler(this.FormLaskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLasku; 
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblSposti;
        private System.Windows.Forms.Label lblPuhNro;
        private System.Windows.Forms.TextBox textBox_laskuid;
        private System.Windows.Forms.TextBox textBox_varausid;
        private System.Windows.Forms.TextBox textBox_alv;
        private System.Windows.Forms.TextBox textBox_summa;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPaivitaHlo;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblViitenumero;
        private System.Windows.Forms.Button btnLahetaLasku;
        private System.Windows.Forms.TextBox textBox_saaja;
        private System.Windows.Forms.Label lblSaaja;
        private System.Windows.Forms.TextBox textBox_viitenumero;
        private System.Windows.Forms.TextBox textBox_tilinumero;
        private System.Windows.Forms.Label lblTilinumero;
        private System.Windows.Forms.Label lblErapva;
        private System.Windows.Forms.DateTimePicker dtp_erapva;
        private System.Windows.Forms.TextBox textBox_sposti;
        private System.Windows.Forms.Label lblSpostivast;
    }
}