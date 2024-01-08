namespace R20
{
    partial class Alueet
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
            this.dgvAlueet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAluenimi = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).BeginInit();
            this.SuspendLayout();
            // 
            // tmplbl1
            // 
            this.tmplbl1.AutoSize = true;
            this.tmplbl1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplbl1.Location = new System.Drawing.Point(48, 70);
            this.tmplbl1.Name = "tmplbl1";
            this.tmplbl1.Size = new System.Drawing.Size(104, 36);
            this.tmplbl1.TabIndex = 2;
            this.tmplbl1.Text = "ALUEET";
            // 
            // dgvAlueet
            // 
            this.dgvAlueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueet.Location = new System.Drawing.Point(290, 70);
            this.dgvAlueet.Name = "dgvAlueet";
            this.dgvAlueet.Size = new System.Drawing.Size(327, 479);
            this.dgvAlueet.TabIndex = 3;
            this.dgvAlueet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlueet_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alueen nimi";
            // 
            // tbAluenimi
            // 
            this.tbAluenimi.Location = new System.Drawing.Point(135, 149);
            this.tbAluenimi.Name = "tbAluenimi";
            this.tbAluenimi.Size = new System.Drawing.Size(100, 20);
            this.tbAluenimi.TabIndex = 5;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(37, 213);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 6;
            this.btnLisaa.Text = "Lisää_alue";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(37, 258);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 7;
            this.btnPoista.Text = "Poista_alue";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(37, 305);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 8;
            this.btnPaivita.Text = "Päivitä_alue";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // Alueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbAluenimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlueet);
            this.Controls.Add(this.tmplbl1);
            this.Name = "Alueet";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.Alueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tmplbl1;
        private System.Windows.Forms.DataGridView dgvAlueet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAluenimi;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPaivita;
    }
}
