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
    public partial class FormAlueet : Form
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public FormAlueet()
        {
            InitializeComponent();
        }

        private void FormAlueet_Load(object sender, EventArgs e)
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
            string query = "SELECT * FROM alue ORDER BY alue_id ASC";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvAlueet.DataSource = table;
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
                    //MessageBox.Show("Kysely ei suoritettu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvAlueet.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAlueet.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAlueet.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["alue_id"].Value);
            }
            rivi = int.Parse(cellValue);

            MessageBox.Show(cellValue);
            if (MessageBox.Show($"Haluatko varmasti poistaa alueen id={cellValue}", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string s1 = $"DELETE FROM alue WHERE alue_id = '{rivi.ToString()}'";
                ExecuteMyQuery(s1);
                paivitysdgv();
                tyhjenna();
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvAlueet.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAlueet.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAlueet.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["alue_id"].Value);
            }
            rivi = int.Parse(cellValue);

            MessageBox.Show(cellValue);

            if (tbAluenimi.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                if (MessageBox.Show($"Haluatko varmasti päivittää alueen id={cellValue}", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s1 = $"UPDATE alue SET" +
                            $" nimi = '{tbAluenimi.Text}'" +
                            $"WHERE alue_id = '{rivi.ToString()}'";
                    ExecuteMyQuery(s1);
                    tyhjenna();
                    paivitysdgv();
                }
            }
        }
        public void tyhjenna()
        {
            tbAluenimi.Text = "";
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {

            if (tbAluenimi.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO alue(nimi)" +
                                   $"VALUES ('{tbAluenimi.Text}')";
                    ExecuteMyQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tyhjenna();
                paivitysdgv();
            }
        }

        private void dgvAlueet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rivi = dgvAlueet.Rows[e.RowIndex];
                tbAluenimi.Text = rivi.Cells["nimi"].Value.ToString();
            }
        }
    }
}
