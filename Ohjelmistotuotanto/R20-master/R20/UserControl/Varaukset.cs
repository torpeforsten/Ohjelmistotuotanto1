using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Varaukset : UserControl
    {
        private static MySqlConnection connection = Sqlyhteys.connection();
        private static MySqlCommand cmd = null;
        public Varaukset()
        {
            InitializeComponent();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                comboboxtiedotmokit();
                comboboxtiedotasiakas();
                comboboxtiedotvaraus();
                comboboxtiedotpalvelu();
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
        public void comboboxtiedotmokit()
        {
            string query = "SELECT mokkinimi FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbMokit.DataSource = table;
            cbMokit.DisplayMember = "mokkinimi";
            cbMokit.ValueMember = "mokkinimi";
        }
        public void comboboxtiedotasiakas()
        {
            string query = "SELECT CONCAT('ID:',asiakas_id, ', ', etunimi, ' ', sukunimi) AS asiakas FROM asiakas";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbAsiakas.DataSource = table;
            cbAsiakas.DisplayMember = "asiakas";
            cbAsiakas.ValueMember = "asiakas";
        }
        public void comboboxtiedotvaraus()
        {
            string query = "SELECT varaus_id FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbVaraus.DataSource = table;
            cbVaraus.DisplayMember = "varaus_id";
            cbVaraus.ValueMember = "varaus_id";
        }
        public void comboboxtiedotpalvelu()
        {
            string query = "SELECT CONCAT('ID:',palvelu_id, ', ', nimi) AS palvelu FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbPalvelu.DataSource = table;
            cbPalvelu.DisplayMember = "palvelu";
            cbPalvelu.ValueMember = "palvelu";
        }

        public void paivitysdgv()
        {
            //MessageBox.Show("Yritetään täyttää DataGridView taulun tiedoilla.");
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraukset.DataSource = table;

            string query2 = "SELECT * FROM varauksen_palvelut ORDER BY varaus_id ASC";
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvVarauksenpalvelut.DataSource = table2;
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
            if (cbAsiakas.Text == "" || cbMokit.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                try
                {
                    string s2 = $"INSERT INTO varaus(asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)" +
                                $"VALUES('{asiakasidhaku(cbAsiakas.Text)}', '{mokkiidhaku(cbMokit.Text)}', '{dtpVarattu.Value.ToString("yyyy-MM-dd")}', '{dtpVahvistettu.Value.ToString("yyyy-MM-dd")}'" +
                                $", '{dtpAlkaa.Value.ToString("yyyy-MM-dd")}', " +
                                $" '{dtpPaattyy.Value.ToString("yyyy-MM-dd")}')";
                    ExecuteMyQuery(s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("virhe");
                    MessageBox.Show(ex.Message);
                }
                tyhjaa();
                paivitysdgv();
                comboboxtiedotvaraus();
            }
        }
        public string asiakasidhaku(string nimi)
        {
            string id = new string(nimi.Where(Char.IsDigit).ToArray());
            return id;
        }
        public string mokkiidhaku(string nimi)
        {
            connection.Open();
            string query = $"SELECT mokki_id FROM mokki WHERE mokkinimi = '{nimi}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string alue_id = reader.GetString("mokki_id");
                connection.Close();
                return alue_id;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvVaraukset.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVaraukset.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVaraukset.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["varaus_id"].Value);
            }
            rivi = int.Parse(cellValue);

            MessageBox.Show(cellValue);

            if (MessageBox.Show($"Haluatko varmasti poistaa varauksen id={cellValue} ?", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string s1 = $"DELETE FROM varaus WHERE varaus_id = '{rivi.ToString()}'";
                ExecuteMyQuery(s1);
                tyhjaa();
                paivitysdgv();
            }

            comboboxtiedotvaraus();
        }

        private void dgvVaraukset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvVaraukset.Rows[e.RowIndex];
                cbAsiakas.Text = asiakasnimi(row.Cells["asiakas_id"].Value.ToString());
                cbMokit.Text = mokkinimi(row.Cells["mokki_mokki_id"].Value.ToString());
                dtpVarattu.Text = row.Cells["varattu_pvm"].Value.ToString();
                dtpVahvistettu.Text = row.Cells["vahvistus_pvm"].Value.ToString();
                dtpAlkaa.Text = row.Cells["varattu_alkupvm"].Value.ToString();
                dtpPaattyy.Text = row.Cells["varattu_loppupvm"].Value.ToString();               
            }
        }
        public string mokkinimi(string id) 
        {
            connection.Open();
            string query = $"SELECT mokkinimi FROM mokki WHERE mokki_id = '{id}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string mokkinimi = reader.GetString(0);
                connection.Close();
                return mokkinimi;
            }
            else
            {
                connection.Close();
                return null;
            }
        }
        public string asiakasnimi(string id)
        {
            connection.Open();
            string query = $"SELECT CONCAT('ID:',asiakas_id, ', ', etunimi, ' ', sukunimi) AS asiakas FROM asiakas WHERE asiakas_id = '{id}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string asiakas = reader.GetString(0);
                connection.Close();
                return asiakas;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            int rivi;
            string cellValue = "";
            if (dgvVaraukset.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVaraukset.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVaraukset.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["varaus_id"].Value);
            }
            rivi = int.Parse(cellValue);
            MessageBox.Show(cellValue);

            if (cbAsiakas.Text == "" || cbMokit.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                if (MessageBox.Show($"Haluatko varmasti päivittää varauksen id={cellValue}", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s1 = $"UPDATE varaus SET" +
                            $" asiakas_id = '{asiakasidhaku(cbAsiakas.Text)}', mokki_mokki_id = '{mokkiidhaku(cbMokit.Text)}', varattu_pvm = '{dtpVarattu.Value.ToString("yyyy-MM-dd")}'," +
                            $" vahvistus_pvm = '{dtpVahvistettu.Value.ToString("yyyy-MM-dd")}'," +
                            $" varattu_alkupvm = '{dtpVarattu.Value.ToString("yyyy-MM-dd")}',varattu_loppupvm = '{dtpPaattyy.Value.ToString("yyyy-MM-dd")}'" +
                            $" WHERE varaus_id = '{rivi}'";
                    ExecuteMyQuery(s1);
                    tyhjaa();
                    paivitysdgv();
                    comboboxtiedotvaraus();
                }
            }
        }

        private void btnTyhjaa_Click(object sender, EventArgs e)
        {
            tyhjaa();
        }
        public void tyhjaa()
        {
            cbAsiakas.Text = "";
            cbMokit.Text = "";
            dtpVarattu.Value = DateTime.Now;
            dtpVahvistettu.Value = DateTime.Now;
            dtpAlkaa.Value = DateTime.Now;
            dtpPaattyy.Value = DateTime.Now;
        }

        private void btnVarausPalveluLisaa_Click(object sender, EventArgs e)
        {
            string palveluid = palveluidhaku(cbPalvelu.Text);

            if (cbPalvelu.Text == "" || cbVaraus.Text == "" || tbLkm.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else
            {
                try
                {                   
                    string s2 = $"INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm)" +
                                $"VALUES('{cbVaraus.Text}', '{palveluid}', '{tbLkm.Text}')";
                    ExecuteMyQuery(s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("virhe");
                    MessageBox.Show(ex.Message);
                }
                tyhjennapalvelu();
                paivitysdgv();
            }
        }
        public string palveluidhaku(string aid)
        {
            string[] osat = aid.Split(':', ',');
            string id = osat[1].Trim();
            return id;
        }

        private void btnVarausPalveluPoista_Click(object sender, EventArgs e)
        {
            string varaus_id = "";
            if (dgvVarauksenpalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVarauksenpalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVarauksenpalvelut.Rows[selectedrowindex];
                varaus_id = Convert.ToString(selectedRow.Cells["varaus_id"].Value);
            }

            string palvelu_id = "";
            if (dgvVarauksenpalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVarauksenpalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVarauksenpalvelut.Rows[selectedrowindex];
                palvelu_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
            }
            //MessageBox.Show("varaus id =" + varaus_id + " palvelu id="+ palvelu_id);

            if (MessageBox.Show($"Haluatko varmasti poistaa varauksen palvelun varaus_id={varaus_id} ja palvelu_id={palvelu_id}", "Vahvista poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string s3 = $"DELETE FROM varauksen_palvelut WHERE varaus_id = '{varaus_id}' AND palvelu_id = '{palvelu_id}'";
                ExecuteMyQuery(s3);
                tyhjennapalvelu();
                paivitysdgv();
            }
        }
        public void tyhjennapalvelu()
        {
            cbVaraus.Text = "";
            cbPalvelu.Text = "";
            tbLkm.Text = "";
        }

        private void btnVarausPalveluPaivita_Click(object sender, EventArgs e)
        {
            string varaus_id = "";
            if (dgvVarauksenpalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVarauksenpalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVarauksenpalvelut.Rows[selectedrowindex];
                varaus_id = Convert.ToString(selectedRow.Cells["varaus_id"].Value);
            }

            string palvelu_id = "";
            if (dgvVarauksenpalvelut.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvVarauksenpalvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVarauksenpalvelut.Rows[selectedrowindex];
                palvelu_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
            }
            
            if (MessageBox.Show($"Haluatko varmasti päivittää varauksen palvelun varaus_id={varaus_id} ja palvelu_id={palvelu_id}", "Vahvista päivitys", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string s = $"UPDATE varauksen_palvelut SET" +
                    $" varaus_id = '{cbVaraus.Text}', palvelu_id = '{palveluidhaku(cbPalvelu.Text)}', lkm = '{tbLkm.Text}' WHERE varaus_id = '{varaus_id}' AND palvelu_id = '{palvelu_id}'";
                ExecuteMyQuery(s);
                tyhjennapalvelu();
                paivitysdgv();
            }
            
        }

        private void dgvVarauksenpalvelut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvVarauksenpalvelut.Rows[e.RowIndex];
                cbVaraus.Text = row.Cells["varaus_id"].Value.ToString();
                cbPalvelu.Text = palvelunimi(row.Cells["palvelu_id"].Value.ToString());
                tbLkm.Text = row.Cells["lkm"].Value.ToString();
            }
        }
        public string palvelunimi(string id)
        {
            connection.Open();
            string query = $"SELECT CONCAT('ID:',palvelu_id, ', ', nimi) AS palvelu FROM palvelu WHERE palvelu_id = '{id}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string asiakas = reader.GetString(0);
                connection.Close();
                return asiakas;
            }
            else
            {
                connection.Close();
                return null;
            }           
        }
    }
}
