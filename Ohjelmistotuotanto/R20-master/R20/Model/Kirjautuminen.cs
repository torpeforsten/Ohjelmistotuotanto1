using MySql.Data.MySqlClient;
using R20.Design;
using R20.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20
{
    public partial class Kirjautuminen : Form
    {
        
        public Kirjautuminen()
        {
            InitializeComponent();
        }
        public bool kirjautuminenonnistunut = false;
        
        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            Sqlyhteys.Server = tbIp.Text;
            Sqlyhteys.Port = tbPort.Text;
            Sqlyhteys.UserID = tbKayttaja.Text;
            Sqlyhteys.Password = tbSalasana.Text;
            Sqlyhteys.Database = tbTietokantanimi.Text;

            try
            {
                if (Kirjaudu())
                {
                    /*
                    MenuValikko frm = new MenuValikko();
                    frm.Show();
                    */
                    var t = new Thread(() => Application.Run(new MenuValikko()));
                    t.Start();                                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                if (!Directory.Exists(@"C:\temp"))
                {
                    Directory.CreateDirectory(@"C:\temp");
                }

                string filePath = @"C:\temp\kirjautuminen.txt";

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(tbIp.Text);
                    sw.WriteLine(tbPort.Text);
                    sw.WriteLine(tbKayttaja.Text);
                    sw.WriteLine(tbSalasana.Text);
                    sw.WriteLine(tbTietokantanimi.Text);
                }
                if (kirjautuminenonnistunut == true)
                {
                    this.Close();
                }               
            }
        }
        public bool Kirjaudu()
        {
            try
            {
                MySqlConnection connection = Sqlyhteys.connection();
                connection.Open();
                connection.Close();
                kirjautuminenonnistunut = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Kirjautuminen_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\temp\kirjautuminen.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    tbIp.Text = sr.ReadLine();
                    tbPort.Text = sr.ReadLine();
                    tbKayttaja.Text = sr.ReadLine();
                    tbSalasana.Text = sr.ReadLine();                  
                    tbTietokantanimi.Text = sr.ReadLine();
                }
            }
        }      
    }
}
