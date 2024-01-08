namespace R20
{
    partial class Laskut
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
            this.dgvLasku = new System.Windows.Forms.DataGridView();
            this.textBox_laskuid = new System.Windows.Forms.TextBox();
            this.label_laskuid = new System.Windows.Forms.Label();
            this.label_varausid = new System.Windows.Forms.Label();
            this.textBox_varausid = new System.Windows.Forms.TextBox();
            this.label_summa = new System.Windows.Forms.Label();
            this.textBox_summa = new System.Windows.Forms.TextBox();
            this.label_alv = new System.Windows.Forms.Label();
            this.textBox_alv = new System.Windows.Forms.TextBox();
            this.button_lisaa = new System.Windows.Forms.Button();
            this.button_poista = new System.Windows.Forms.Button();
            this.button_paivita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(57, 47);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(126, 42);
            this.tmplbl1.TabIndex = 4;
            this.tmplbl1.Text = "LASKUT";
            // 
            // dgvLasku
            // 
            this.dgvLasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku.Location = new System.Drawing.Point(448, 75);
            this.dgvLasku.Name = "dgvLasku";
            this.dgvLasku.Size = new System.Drawing.Size(583, 477);
            this.dgvLasku.TabIndex = 5;
            // 
            // textBox_laskuid
            // 
            this.textBox_laskuid.Location = new System.Drawing.Point(118, 144);
            this.textBox_laskuid.Name = "textBox_laskuid";
            this.textBox_laskuid.ReadOnly = true;
            this.textBox_laskuid.Size = new System.Drawing.Size(77, 20);
            this.textBox_laskuid.TabIndex = 6;
            // 
            // label_laskuid
            // 
            this.label_laskuid.AutoSize = true;
            this.label_laskuid.Location = new System.Drawing.Point(58, 147);
            this.label_laskuid.Name = "label_laskuid";
            this.label_laskuid.Size = new System.Drawing.Size(50, 13);
            this.label_laskuid.TabIndex = 7;
            this.label_laskuid.Text = "Lasku ID";
            // 
            // label_varausid
            // 
            this.label_varausid.AutoSize = true;
            this.label_varausid.Location = new System.Drawing.Point(58, 184);
            this.label_varausid.Name = "label_varausid";
            this.label_varausid.Size = new System.Drawing.Size(54, 13);
            this.label_varausid.TabIndex = 8;
            this.label_varausid.Text = "Varaus ID";
            // 
            // textBox_varausid
            // 
            this.textBox_varausid.Location = new System.Drawing.Point(118, 177);
            this.textBox_varausid.Name = "textBox_varausid";
            this.textBox_varausid.Size = new System.Drawing.Size(77, 20);
            this.textBox_varausid.TabIndex = 9;
            this.textBox_varausid.Leave += new System.EventHandler(this.textBox_varausid_Leave);
            // 
            // label_summa
            // 
            this.label_summa.AutoSize = true;
            this.label_summa.Location = new System.Drawing.Point(58, 216);
            this.label_summa.Name = "label_summa";
            this.label_summa.Size = new System.Drawing.Size(42, 13);
            this.label_summa.TabIndex = 10;
            this.label_summa.Text = "Summa";
            // 
            // textBox_summa
            // 
            this.textBox_summa.Location = new System.Drawing.Point(118, 213);
            this.textBox_summa.Name = "textBox_summa";
            this.textBox_summa.ReadOnly = true;
            this.textBox_summa.Size = new System.Drawing.Size(77, 20);
            this.textBox_summa.TabIndex = 11;
            // 
            // label_alv
            // 
            this.label_alv.AutoSize = true;
            this.label_alv.Location = new System.Drawing.Point(58, 248);
            this.label_alv.Name = "label_alv";
            this.label_alv.Size = new System.Drawing.Size(27, 13);
            this.label_alv.TabIndex = 12;
            this.label_alv.Text = "ALV";
            // 
            // textBox_alv
            // 
            this.textBox_alv.Location = new System.Drawing.Point(118, 245);
            this.textBox_alv.Name = "textBox_alv";
            this.textBox_alv.Size = new System.Drawing.Size(77, 20);
            this.textBox_alv.TabIndex = 13;
            // 
            // button_lisaa
            // 
            this.button_lisaa.Location = new System.Drawing.Point(37, 283);
            this.button_lisaa.Name = "button_lisaa";
            this.button_lisaa.Size = new System.Drawing.Size(75, 23);
            this.button_lisaa.TabIndex = 14;
            this.button_lisaa.Text = "Lisää";
            this.button_lisaa.UseVisualStyleBackColor = true;
            // 
            // button_poista
            // 
            this.button_poista.Location = new System.Drawing.Point(120, 283);
            this.button_poista.Name = "button_poista";
            this.button_poista.Size = new System.Drawing.Size(75, 23);
            this.button_poista.TabIndex = 15;
            this.button_poista.Text = "Poista";
            this.button_poista.UseVisualStyleBackColor = true;
            // 
            // button_paivita
            // 
            this.button_paivita.Location = new System.Drawing.Point(201, 283);
            this.button_paivita.Name = "button_paivita";
            this.button_paivita.Size = new System.Drawing.Size(72, 23);
            this.button_paivita.TabIndex = 16;
            this.button_paivita.Text = "Päivitä";
            this.button_paivita.UseVisualStyleBackColor = true;
            // 
            // Laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_paivita);
            this.Controls.Add(this.button_poista);
            this.Controls.Add(this.button_lisaa);
            this.Controls.Add(this.textBox_alv);
            this.Controls.Add(this.label_alv);
            this.Controls.Add(this.textBox_summa);
            this.Controls.Add(this.label_summa);
            this.Controls.Add(this.textBox_varausid);
            this.Controls.Add(this.label_varausid);
            this.Controls.Add(this.label_laskuid);
            this.Controls.Add(this.textBox_laskuid);
            this.Controls.Add(this.dgvLasku);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Laskut";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Laskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.DataGridView dgvLasku;
        private System.Windows.Forms.TextBox textBox_laskuid;
        private System.Windows.Forms.Label label_laskuid;
        private System.Windows.Forms.Label label_varausid;
        private System.Windows.Forms.TextBox textBox_varausid;
        private System.Windows.Forms.Label label_summa;
        private System.Windows.Forms.TextBox textBox_summa;
        private System.Windows.Forms.Label label_alv;
        private System.Windows.Forms.TextBox textBox_alv;
        private System.Windows.Forms.Button button_lisaa;
        private System.Windows.Forms.Button button_poista;
        private System.Windows.Forms.Button button_paivita;
    }
}
