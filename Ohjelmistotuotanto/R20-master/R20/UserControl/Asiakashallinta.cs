using MySql.Data.MySqlClient;
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

namespace R20
{
    public partial class Asiakashallinta : UserControl
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public Asiakashallinta()
        {
            InitializeComponent();
        }

        private void Asiakashallinta_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                comboboxtiedot();
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
            string query = "SELECT * FROM asiakas";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvAsiakkaat.DataSource = table;
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
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbEtunimi.Text == "" || tbSukunimi.Text == "" || tbLahiosoite.Text == "" || cbPostinrot.Text == "" || tbSposti.Text == "" || tbPuhnro.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                try
                {
                    //string s1 = $"INSERT INTO posti(postinro, toimipaikka) VALUES('{tbPostinro.Text}', '{tbPostitoimipaikka.Text}')";
                    //ExecuteMyQuery(s1);

                    // HUOM TÄSSÄ cbPostinrot!! Muissa on tbPostinro!!!

                    string s2 = $"INSERT INTO asiakas(etunimi, sukunimi, lahiosoite, postinro, email, puhelinnro)" +
                        $" VALUES('{tbEtunimi.Text}', '{tbSukunimi.Text}', '{tbLahiosoite.Text}', '{cbPostinrot.Text}', '{tbSposti.Text}' ,'{tbPuhnro.Text}')";
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

        private void btnPaivitaHlo_Click(object sender, EventArgs e)
        {

            int rivi;
            string cellValue = "";
            if (dgvAsiakkaat.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAsiakkaat.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAsiakkaat.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["asiakas_id"].Value);
            }
            rivi = int.Parse(cellValue);

            MessageBox.Show(cellValue);

            if (tbEtunimi.Text == "" || tbSukunimi.Text == "" || tbLahiosoite.Text == "" || cbPostinrot.Text == "" || tbSposti.Text == "" || tbPuhnro.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                if (MessageBox.Show($"Haluatko varmasti päivittää henkilön id={cellValue}", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s1 = $"UPDATE asiakas SET" +
                             $" etunimi = '{tbEtunimi.Text}', sukunimi = '{tbSukunimi.Text}', lahiosoite = '{tbLahiosoite.Text}'," +
                             $" postinro = '{cbPostinrot.Text}', email = '{tbSposti.Text}', puhelinnro = '{tbPuhnro.Text}'" +
                             $" WHERE asiakas_id = '{rivi.ToString()}'";

                    ExecuteMyQuery(s1);
                }               
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvAsiakkaat.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAsiakkaat.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAsiakkaat.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["asiakas_id"].Value);
            }
            rivi = int.Parse(cellValue);

            MessageBox.Show(cellValue);
            if (MessageBox.Show($"Haluatko varmasti poistaa henkilön id={cellValue}", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Poista toiminto tässä
                string s1 = $"DELETE FROM asiakas WHERE asiakas_id = '{rivi.ToString()}'";
                ExecuteMyQuery(s1);
            }
        }
        public void comboboxtiedot()
        {
            string query = "SELECT postinro FROM posti";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbPostinrot.DataSource = table;
            cbPostinrot.DisplayMember = "postinro";
            cbPostinrot.ValueMember = "postinro";
        }
        public void tyhjenna()
        {
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbLahiosoite.Text = "";
            cbPostinrot.Text = "";
            tbPostitoimipaikka.Text = "";
            tbSposti.Text = "";
            tbPuhnro.Text = "";
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            paivitysdgv();
        }

        private void dgvAsiakkaat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rivi = dgvAsiakkaat.Rows[e.RowIndex];
                tbEtunimi.Text = rivi.Cells["etunimi"].Value.ToString();
                tbSukunimi.Text = rivi.Cells["sukunimi"].Value.ToString();
                cbPostinrot.Text = rivi.Cells["postinro"].Value.ToString();
                tbPostitoimipaikka.Text = postitoimipaikanhaku(rivi.Cells["postinro"].Value.ToString());
                tbLahiosoite.Text = rivi.Cells["lahiosoite"].Value.ToString();
                tbSposti.Text = rivi.Cells["email"].Value.ToString();
                tbPuhnro.Text = rivi.Cells["puhelinnro"].Value.ToString();
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

        private void btnTyhjaa_Click(object sender, EventArgs e)
        {
            tyhjenna();
        }

        private void cbPostinrot_Leave(object sender, EventArgs e)
        {
            tbPostitoimipaikka.Text = postitoimipaikanhaku(cbPostinrot.Text);
        }

    }
}
