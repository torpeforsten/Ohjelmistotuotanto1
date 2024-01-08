using MySql.Data.MySqlClient;
using R20.Design;
using R20.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20.Forms
{
    public partial class FormLaskut : Form
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public FormLaskut()
        {
            InitializeComponent();
        }

        private void FormLaskut_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox_laskuid.Text = UusiLaskuId().ToString();
                paivitysdgv();
                connection.Close(); // Sulje yhteys tässä
            }
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        public void paivitysdgv()
        {
            //MessageBox.Show("Yritetään täyttää DataGridView taulun tiedoilla.");
            string query = "SELECT * FROM lasku";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvLasku.DataSource = table;
        }
        public int UusiLaskuId() // Palauttaa suurimman käyttämättömän lasku_id:n
        {
            int returnValue = 0;
            cmd = new MySqlCommand("SELECT lasku_id FROM lasku ORDER BY lasku_id DESC;", connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                if (!int.TryParse(reader.GetString(0), out returnValue))
                {
                    returnValue = 0;
                }
            } else
            {
                returnValue = 0;
            }
            
            reader.Close();
            returnValue++;
            return returnValue;

        }

        private void textBox_varausid_Leave(object sender, EventArgs e)
        {
            TextBox s = (TextBox)sender;
            if (!String.IsNullOrEmpty(s.Text))
            {
                connection.Open();
                cmd = new MySqlCommand("SELECT mokki_mokki_id FROM varaus WHERE varaus_id = " + s.Text, connection);
                decimal totalHinta = 0;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string mokki_id = reader.GetString(0);
                    reader.Close();
                    cmd.CommandText = "SELECT hinta FROM vn.mokki WHERE mokki_id = " + mokki_id;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        totalHinta += reader.GetDecimal(0);
                    }
                    reader.Close();
                    cmd.CommandText = "SELECT hinta FROM palvelu WHERE palvelu_id = (SELECT palvelu_id FROM varauksen_palvelut WHERE varaus_id = " + s.Text + ");";
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        totalHinta += reader.GetDecimal(0);
                    }
                    textBox_summa.Text = totalHinta.ToString();
                    connection.Close();
                }
                else
                {
                    s.Text = "";
                    MessageBox.Show("Virheellinen varaus id");
                    textBox_summa.Text = "";
                }
                connection.Close();
            }
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            } catch  (Exception exc)
            {
                MessageBox.Show(exc.Message);
            } finally
            {
                if (textBox_laskuid.Text != "" && textBox_alv.Text != "" && textBox_summa.Text != "" && textBox_varausid.Text != "")
                {


                    cmd = new MySqlCommand("INSERT INTO lasku (lasku_id,varaus_id,summa,alv) VALUES (" + textBox_laskuid.Text + "," + textBox_varausid.Text + "," + textBox_summa.Text + "," + textBox_alv.Text + ");");
                    cmd.Connection = connection;
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Tietojen lisäys tietokantaan epäonnistui");
                    }
                    paivitysdgv();
                } else
                {
                    MessageBox.Show("Kaikki kentät täytyy täyttää");
                }
                connection.Close();
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
            finally
            {
                if (textBox_laskuid.Text != "" && textBox_alv.Text != "" && textBox_summa.Text != "" && textBox_varausid.Text != "")
                {


                    cmd = new MySqlCommand("DELETE FROM lasku WHERE lasku_id = '" + textBox_laskuid.Text + "' AND varaus_id = '" + textBox_varausid.Text + "' AND summa = '" + textBox_summa.Text + "' AND alv = '" + textBox_alv.Text + "';");
                    cmd.Connection = connection;
                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Laskun poisto epäonnistui");
                    }
                } else
                {
                    MessageBox.Show("Kaikki kentät täytyy täyttää");
                }
                paivitysdgv();
                connection.Close();
            }
        }

        private void dgvLasku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLaskuCellValue("lasku_id",e) == "") // jos valitaan tyhjä rivi, asetetaan laskuid kenttään käyttämätön laskuid arvo
            {
                try
                {
                    connection.Open();
                } catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                } finally
                {
                    textBox_laskuid.Text = UusiLaskuId().ToString();
                    connection.Close();
                }
            } else
            {
                textBox_laskuid.Text = dgvLaskuCellValue("lasku_id", e);
            }
            textBox_summa.Text = dgvLaskuCellValue("summa", e);
            textBox_alv.Text = dgvLaskuCellValue("alv", e);
            textBox_varausid.Text = dgvLaskuCellValue("varaus_id", e);
        }
        public string dgvLaskuCellValue(string cellName, DataGridViewCellEventArgs e)
        {
            return dgvLasku.Rows[e.RowIndex].Cells[cellName].Value.ToString();
        }

        private void btnPaivitaHlo_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            } catch (Exception except)
            {
                MessageBox.Show(except.Message);
            } finally
            {
                if (textBox_laskuid.Text != "" && textBox_alv.Text != "" && textBox_summa.Text != "" && textBox_varausid.Text != "")
                {
                    cmd = new MySqlCommand("UPDATE lasku SET varaus_id = " + textBox_varausid.Text + ", summa = " + textBox_summa.Text + ", alv = " + textBox_alv.Text + " WHERE lasku_id = " + textBox_laskuid.Text + ";");
                    cmd.Connection = connection;
                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Päivitys epäonnistui");
                    }
                } else
                {
                    MessageBox.Show("Kaikki kentät täytyy täyttää");
                }
                paivitysdgv();
                connection.Close();
            }
        }

        private void btnLahetaLasku_Click(object sender, EventArgs e)
        {
            if (textBox_laskuid.Text != "" && textBox_alv.Text != "" && textBox_summa.Text != "" && textBox_varausid.Text != "" && textBox_viitenumero.Text != "" && textBox_saaja.Text != "" && textBox_tilinumero.Text != "" && lblSpostivast.Text != "")
            {
                Sposti posti = new Sposti();
                string viesti = "Village Newbies Oy Lasku\nSaajan tilinumero: " + textBox_tilinumero.Text+"\nSaaja: "+textBox_saaja.Text + "\nViitenumero: " + textBox_viitenumero.Text + "\nEräpäivä: " + dtp_erapva.Text;
                posti.Spostilahetys(textBox_sposti.Text, "Village Newbies Oy Lasku", viesti);
            }
            else
            {
                MessageBox.Show("Kaikki kentät täytyy täyttää");
            }
        }
    }
}
