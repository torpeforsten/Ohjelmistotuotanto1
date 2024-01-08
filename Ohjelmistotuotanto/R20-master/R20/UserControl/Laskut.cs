using MySql.Data.MySqlClient;
using R20.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20
{
    public partial class Laskut : UserControl
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public Laskut()
        {
            InitializeComponent();
        }

        private void Laskut_Load(object sender, EventArgs e)
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
                paivitysdgv();
                connection.Close(); // Sulje yhteys tässä
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
                    } else
                {
                    s.Text = "";
                    MessageBox.Show("Virheellinen varaus id");
                    textBox_summa.Text = "";
                }
                connection.Close();
            }
        }
    }
}
