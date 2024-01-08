using Google.Protobuf.WellKnownTypes;
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
    public partial class FormMokit : Form
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public FormMokit()
        {
            InitializeComponent();
        }

        private void FormMokit_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                comboboxtiedotposti();
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
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvMokit.DataSource = table;
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
        public void comboboxtiedotposti()
        {
            string query = "SELECT postinro FROM posti";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbPostinro.DataSource = table;
            cbPostinro.DisplayMember = "postinro";
            cbPostinro.ValueMember = "postinro";
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
        public void tyhjenna()
        {
            cbAlue.Text = "";
            cbPostinro.Text = "";
            tbMokkinimi.Text = "";
            tbKatuosoite.Text = "";
            tbHinta.Text = "";
            tbKuvaus.Text = "";
            tbHenkilomaara.Text = "";
            tbVarustelu.Text = "";
            tbPostitoimipaikka.Text = "";
        }
        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            if (tbHenkilomaara.Text == "" || tbHinta.Text == "" || tbKatuosoite.Text == "" ||
                tbKuvaus.Text == "" || tbMokkinimi.Text == "" || tbVarustelu.Text == "" || cbAlue.Text == "" || cbPostinro.Text == "" || tbPostitoimipaikka.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                MessageBox.Show(alueidhaku(cbAlue.Text));
                try
                {
                    string s2 = $"INSERT INTO mokki(alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu)" +
                                $"VALUES('{alueidhaku(cbAlue.Text)}', '{cbPostinro.Text}', '{tbMokkinimi.Text}', '{tbKatuosoite.Text}', " +
                                $" '{tbHinta.Text}','{tbKuvaus.Text}', '{tbHenkilomaara.Text}','{tbVarustelu.Text}')";
                    ExecuteMyQuery(s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("virhe");
                    MessageBox.Show(ex.Message);
                }
                tyhjenna();
                paivitysdgv();
            }
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

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvMokit.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMokit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMokit.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["mokki_id"].Value);
            }
            rivi = int.Parse(cellValue);

            //MessageBox.Show(cellValue);

            if (MessageBox.Show($"Haluatko varmasti poistaa mökin id={cellValue} ?", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string s1 = $"DELETE FROM mokki WHERE mokki_id = '{rivi.ToString()}'";
                ExecuteMyQuery(s1);
                tyhjenna();
                paivitysdgv();
            }
        }

        private void btnPaivitaMokki_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvMokit.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMokit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMokit.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["mokki_id"].Value);
            }
            rivi = int.Parse(cellValue);

           //MessageBox.Show(cellValue);

            if (tbHenkilomaara.Text == "" || tbHinta.Text == "" || tbKatuosoite.Text == "" ||
                tbKuvaus.Text == "" || tbMokkinimi.Text == "" || tbVarustelu.Text == "" || cbAlue.Text == "" || cbPostinro.Text == "" || tbPostitoimipaikka.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                if (MessageBox.Show($"Haluatko varmasti päivittää mökin id={cellValue} ?", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s1 = $"UPDATE mokki SET" +
                        $" alue_id = '{alueidhaku(cbAlue.Text)}', postinro = '{cbPostinro.Text}', mokkinimi = '{tbMokkinimi.Text}', katuosoite = '{tbKatuosoite.Text}'," +
                        $"hinta = '{tbHinta.Text}', kuvaus = '{tbKuvaus.Text}', henkilomaara = '{tbHenkilomaara.Text}', varustelu = '{tbVarustelu.Text}'" +
                        $" WHERE mokki_id = '{rivi}'";
                    ExecuteMyQuery(s1);
                    tyhjenna();
                    paivitysdgv();
                }
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
        public string postitoimipaikanhaku(string postinro)
        {

            connection.Open();
            string query = $"SELECT toimipaikka FROM posti WHERE postinro = '{postinro}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string postitoimipaikka = reader.GetString(0);
                connection.Close();
                return postitoimipaikka;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        private void cbPostinro_Leave(object sender, EventArgs e)
        {
            tbPostitoimipaikka.Text = postitoimipaikanhaku(cbPostinro.Text);
        }

        private void btnTyhjaa_Click(object sender, EventArgs e)
        {
            tyhjenna();
        }

        private void dgvMokit_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMokit.Rows[e.RowIndex];
                cbAlue.Text = aluennimi(row.Cells["alue_id"].Value.ToString());
                cbPostinro.Text = row.Cells["postinro"].Value.ToString();
                tbPostitoimipaikka.Text = postitoimipaikanhaku(row.Cells["postinro"].Value.ToString());
                tbMokkinimi.Text = row.Cells["mokkinimi"].Value.ToString();
                tbKatuosoite.Text = row.Cells["katuosoite"].Value.ToString();
                tbHinta.Text = row.Cells["hinta"].Value.ToString();
                tbKuvaus.Text = row.Cells["kuvaus"].Value.ToString();
                tbHenkilomaara.Text = row.Cells["henkilomaara"].Value.ToString();
                tbVarustelu.Text = row.Cells["varustelu"].Value.ToString();

            }
        }

        private void cbPostinro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                tbPostitoimipaikka.Text = postitoimipaikanhaku(cbPostinro.Text);
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
    }
}
