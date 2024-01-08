namespace R20.Forms
{
    partial class FormAlueet
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
            this.dgvAlueet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.tbAluenimi = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlueet
            // 
            this.dgvAlueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueet.Location = new System.Drawing.Point(391, 54);
            this.dgvAlueet.Name = "dgvAlueet";
            this.dgvAlueet.Size = new System.Drawing.Size(744, 521);
            this.dgvAlueet.TabIndex = 71;
            this.dgvAlueet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlueet_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEtunimi);
            this.panel2.Controls.Add(this.tbAluenimi);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 100);
            this.panel2.TabIndex = 78;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(28, 29);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(95, 20);
            this.lblEtunimi.TabIndex = 48;
            this.lblEtunimi.Text = "Alueen Nimi";
            // 
            // tbAluenimi
            // 
            this.tbAluenimi.Location = new System.Drawing.Point(194, 29);
            this.tbAluenimi.Name = "tbAluenimi";
            this.tbAluenimi.Size = new System.Drawing.Size(171, 20);
            this.tbAluenimi.TabIndex = 54;
            // 
            // btnLisaa
            // 
            this.btnLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaa.Location = new System.Drawing.Point(42, 183);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(140, 30);
            this.btnLisaa.TabIndex = 72;
            this.btnLisaa.Text = "Lisää Alue";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaivita.Location = new System.Drawing.Point(129, 241);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(143, 30);
            this.btnPaivita.TabIndex = 75;
            this.btnPaivita.Text = "Päivitä Alue";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoista.Location = new System.Drawing.Point(228, 183);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(140, 30);
            this.btnPoista.TabIndex = 73;
            this.btnPoista.Text = "Poista Alue";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // FormAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 676);
            this.Controls.Add(this.dgvAlueet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Name = "FormAlueet";
            this.Text = "ALUEET";
            this.Load += new System.EventHandler(this.FormAlueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlueet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.TextBox tbAluenimi;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
    }
}