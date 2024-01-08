namespace R20
{
    partial class Kirjautuminen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbKayttaja = new System.Windows.Forms.TextBox();
            this.tbSalasana = new System.Windows.Forms.TextBox();
            this.tbTietokantanimi = new System.Windows.Forms.TextBox();
            this.btnKirjaudu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KÄYTTÄJÄ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SALASANA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIETOKANNAN NIMI";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(268, 63);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 20);
            this.tbIp.TabIndex = 5;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(268, 91);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 6;
            // 
            // tbKayttaja
            // 
            this.tbKayttaja.Location = new System.Drawing.Point(268, 117);
            this.tbKayttaja.Name = "tbKayttaja";
            this.tbKayttaja.Size = new System.Drawing.Size(100, 20);
            this.tbKayttaja.TabIndex = 7;
            // 
            // tbSalasana
            // 
            this.tbSalasana.Location = new System.Drawing.Point(268, 143);
            this.tbSalasana.Name = "tbSalasana";
            this.tbSalasana.Size = new System.Drawing.Size(100, 20);
            this.tbSalasana.TabIndex = 8;
            // 
            // tbTietokantanimi
            // 
            this.tbTietokantanimi.Location = new System.Drawing.Point(268, 169);
            this.tbTietokantanimi.Name = "tbTietokantanimi";
            this.tbTietokantanimi.Size = new System.Drawing.Size(100, 20);
            this.tbTietokantanimi.TabIndex = 9;
            // 
            // btnKirjaudu
            // 
            this.btnKirjaudu.Location = new System.Drawing.Point(268, 238);
            this.btnKirjaudu.Name = "btnKirjaudu";
            this.btnKirjaudu.Size = new System.Drawing.Size(71, 27);
            this.btnKirjaudu.TabIndex = 10;
            this.btnKirjaudu.Text = "kirjaudu";
            this.btnKirjaudu.UseVisualStyleBackColor = true;
            this.btnKirjaudu.Click += new System.EventHandler(this.btnKirjaudu_Click);
            // 
            // Kirjautuminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKirjaudu);
            this.Controls.Add(this.tbTietokantanimi);
            this.Controls.Add(this.tbSalasana);
            this.Controls.Add(this.tbKayttaja);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kirjautuminen";
            this.Text = "Kirjautuminen";
            this.Load += new System.EventHandler(this.Kirjautuminen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbKayttaja;
        private System.Windows.Forms.TextBox tbSalasana;
        private System.Windows.Forms.TextBox tbTietokantanimi;
        private System.Windows.Forms.Button btnKirjaudu;
    }
}