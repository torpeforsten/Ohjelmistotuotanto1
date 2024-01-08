using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class FormPalvelut : Form
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public FormPalvelut()
        {
            InitializeComponent();
        }

        private void FormPalvelut_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                comboboxtiedotalue();
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
            string query = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvPalvelut.DataSource = table;
        }
        public void comboboxtiedotalue()
        {
            string query = "SELECT nimi FROM alue";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbAlue.DataSource = table;
            cbAlue.DisplayMember = "nimi";
            cbAlue.ValueMember = "nimi";
        }
        public void ExecuteMyQuery(string query)
        {
            //tarkastetaan onko kysely mennyt läpi
            try
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void tyhjenna()
        {
            // tyhjennetään tekstikentät
            cbAlue.Text = "";
            tbHinta.Text = "";
            tbKuvaus.Text = "";
            tbNimi.Text = "";
            tbAlv.Text = "";
            tbTyyppi.Text = "";

        }
        public string alueidhaku(string alue)
        {
            connection.Open();
            string query = $"SELECT alue_id FROM alue WHERE nimi = '{alue}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string alue_id = reader.GetString("alue_id");
                connection.Close();
                return alue_id;
            }
            else
            {
                connection.Close();
                return null;
            }
        }
        public string aluennimi(string alue)
        {
            connection.Open();
            string query = $"SELECT nimi FROM alue WHERE alue_id = '{alue}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string aluenimi = reader.GetString(0);
                connection.Close();
                return aluenimi;
            }
            else
            {
                connection.Close();
                return null;
            }
        }
        public string lisaapalveluid()
        {
            // tämä koska palvelu_id ei ole auto increment
            connection.Open();
            string id = "1";
            string query = $"SELECT COALESCE(MAX(palvelu_id), 0) FROM palvelu";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                int increment = int.Parse(id) + 1;
                connection.Close();
                return increment.ToString();
            }
            else
            {
                connection.Close();
                return id;
            }
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (cbAlue.Text == "" || tbHinta.Text == "" || tbKuvaus.Text == "" || tbNimi.Text == "" || tbAlv.Text == "" || tbTyyppi.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                try
                {
                    string s2 = $"INSERT INTO palvelu(palvelu_id, alue_id, nimi, tyyppi, kuvaus, hinta, alv)" +
                                $"VALUES('{lisaapalveluid()}', '{alueidhaku(cbAlue.Text)}', '{tbNimi.Text}', '{tbTyyppi.Text}', '{tbKuvaus.Text}', " +
                                $" '{tbHinta.Text}','{tbAlv.Text}')";
                    ExecuteMyQuery(s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("virhe");
                    MessageBox.Show(ex.Message);
                }
                tyhjenna();
                paivitysdgv();

                //MessageBox.Show(lisaapalveluid());
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvPalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPalvelut.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
            }
            rivi = int.Parse(cellValue);

            //MessageBox.Show(cellValue);

            if (MessageBox.Show($"Haluatko varmasti poistaa palvelun id={cellValue}", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Poista toiminto tässä
                string s1 = $"DELETE FROM palvelu WHERE palvelu_id = '{rivi.ToString()}'";
                ExecuteMyQuery(s1);
                tyhjenna();
                paivitysdgv();
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvPalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPalvelut.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
            }
            rivi = int.Parse(cellValue);
            //MessageBox.Show(cellValue);

            if (cbAlue.Text == "" || tbHinta.Text == "" || tbKuvaus.Text == "" || tbNimi.Text == "" || tbAlv.Text == "" || tbTyyppi.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                if (MessageBox.Show($"Haluatko varmasti päivittää palvelun id={cellValue}", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s1 = $"UPDATE palvelu SET" +
                            $" alue_id = '{alueidhaku(cbAlue.Text)}', nimi = '{tbNimi.Text}', tyyppi = '{tbTyyppi.Text}', kuvaus = '{tbKuvaus.Text}'," +
                            $"hinta = '{tbHinta.Text}', alv = '{tbAlv.Text}'" +
                            $" WHERE palvelu_id = '{rivi}'";
                    ExecuteMyQuery(s1);
                    tyhjenna();
                    paivitysdgv();
                }
            }
        }

        private void btnTyhjaa_Click(object sender, EventArgs e)
        {
            tyhjenna();
        }
        private void dgvPalvelut_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPalvelut.Rows[e.RowIndex];
                tbNimi.Text = row.Cells["nimi"].Value.ToString();
                tbTyyppi.Text = row.Cells["tyyppi"].Value.ToString();
                tbKuvaus.Text = row.Cells["kuvaus"].Value.ToString();
                tbHinta.Text = row.Cells["hinta"].Value.ToString();
                tbAlv.Text = row.Cells["alv"].Value.ToString();
                cbAlue.Text = aluennimi(row.Cells["alue_id"].Value.ToString());
            }
        }

        private void tbHinta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, onko syötetty merkki numero, desimaalierotin tai ohjausmerkki
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Estetään merkin syöttö
            }

            // Estetään desimaalierottimen syöttö, jos se on jo syötetty
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbAlv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan, onko syötetty merkki numero, desimaalierotin tai ohjausmerkki
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Estetään merkin syöttö
            }

            // Estetään desimaalierottimen syöttö, jos se on jo syötetty
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbTyyppi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // estetään merkin syöttö
            }
        }
    }
}
