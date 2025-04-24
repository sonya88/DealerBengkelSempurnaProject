using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Dealer_BengkelSempurna.Master.Supplier
{
    public partial class supplier : Form
    {
        String user = "";
        String pass = "";
        String id = "";

        Timer timer = new Timer();
        public supplier()
        {
            InitializeComponent();
            BtnTambah.FlatStyle = FlatStyle.Flat;
            BtnTambah.FlatAppearance.BorderSize = 0;
            BtnUbah.FlatStyle = FlatStyle.Flat;
            BtnUbah.FlatAppearance.BorderSize = 0;
            BtnKembali.FlatStyle = FlatStyle.Flat;
            BtnKembali.FlatAppearance.BorderSize = 0;

            timer.Tick += new EventHandler(timer_Tick);
            //1000 = 1 detik
            timer.Interval = (1000) * (1);
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbWaktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void supplier_Load(object sender, EventArgs e)
        {
            RefreshDg();
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }

        private void Clear()
        {
            TxtCompName.Text = "";
            TxtAlamat.Text = "";
            TxtEmail.Text = "";
            TxtNoTelp.Text = "";

            if (lbJudul.Text == "TAMBAH SUPPLIER")
            {

            }
            else
            {
                TxtAlamat.Enabled = false;
                TxtEmail.Enabled = false;
                TxtNoTelp.Enabled = false;
            }
        }
        public bool ValidateEmail()
        {
            string regexPattern = @"[\w-]+@([\w-]+\.)+[\w-]+";

            Regex regex = new Regex(regexPattern);

            if (regex.IsMatch(TxtEmail.Text))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtAlamat.Enabled = true;
            TxtEmail.Enabled = true;
            TxtNoTelp.Enabled = true;
            CbStatus.Enabled = false;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            lbJudul.Text = "TAMBAH SUPPLIER";
            BtnHapus.Visible = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtAlamat.Enabled = false;
            TxtEmail.Enabled = false;
            TxtNoTelp.Enabled = false;
            CbStatus.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            lbJudul.Text = "UBAH SUPPLIER";
            BtnHapus.Visible = true;
        }

        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_dgvSup", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter(view);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            DataColumn col = dt.Columns.Add("No", typeof(System.Int32));
            col.SetOrdinal(0);
            int a = 1;
            foreach (DataRow r in dt.Rows)
            {
                r["No"] = a;
                a++;
            }

            dgvSupplier.DataSource = dt;
            dgvSupplier.Columns[1].HeaderText = "ID";
            dgvSupplier.Columns[2].HeaderText = "Nama Supplier";
            dgvSupplier.Columns[3].HeaderText = "Alamat";
            dgvSupplier.Columns[4].HeaderText = "Email";
            dgvSupplier.Columns[5].HeaderText = "No Telepon";
            dgvSupplier.Columns[6].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvSupplier.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvSupplier.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSupplier.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            connection.Close();

            dgvSupplier.BorderStyle = BorderStyle.None;
            dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSupplier.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSupplier.BackgroundColor = Color.White;

            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void TxtNoTelp_TextChanged(object sender, EventArgs e)
        {

        }
        public string autogenerateID(string firstText, string query)
        {
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(Program.koneksi());
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(2, '0');
            return result;
        }

        private void TxtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtCompName.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Information!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool validateEmail = ValidateEmail();

                if (validateEmail == true)
                {
                    var hasil = MessageBox.Show("Yakin ingin menghapus data? ", "Information",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand delete = new SqlCommand("[sp_DeleteSupplier]", connection);
                        delete.CommandType = CommandType.StoredProcedure;

                        delete.Parameters.AddWithValue("id_supplier", id);

                        try
                        {
                            delete.ExecuteNonQuery();
                            MessageBox.Show("Delete data succesfully", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshDg();
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unable to update: " + ex.Message);
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Format email salah !", "Pemberitahuan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (lbJudul.Text == "TAMBAH SUPPLIER")
            {
                if (TxtCompName.Text == "" || TxtEmail.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Pemberitahuan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtNoTelp.Text.Length > 13 || TxtNoTelp.Text.Length < 12)
                {
                    MessageBox.Show("No. Telepon maksimal 13 digit!!", "Pemberitahuan",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "select top 1 id_supplier from tSupplier order by id_supplier desc";
                    id = autogenerateID("SUP-", query);

                    bool validateEmail = ValidateEmail();

                    if (validateEmail == true)
                    {
                        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("sp_InputSupplier", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("id_supplier", id);
                        insert.Parameters.AddWithValue("company_name", TxtCompName.Text);
                        insert.Parameters.AddWithValue("address", TxtAlamat.Text);
                        insert.Parameters.AddWithValue("email", TxtEmail.Text);
                        insert.Parameters.AddWithValue("no_telp", TxtNoTelp.Text);
                        insert.Parameters.AddWithValue("status", "Aktif");

                        try
                        {
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Data saved succesfully", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDg();
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unable to update: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format email salah !", "Pemberitahuan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (TxtCompName.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Information!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtNoTelp.Text.Length > 13 || TxtNoTelp.Text.Length < 12)
                {
                    MessageBox.Show("No. Telepon maksimal 13 digit!!", "Pemberitahuan",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool validateEmail = ValidateEmail();

                    if (validateEmail == true)
                    {
                        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("[sp_UpdateSupplier]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("id_supplier", id);
                        insert.Parameters.AddWithValue("company_name", TxtCompName.Text);
                        insert.Parameters.AddWithValue("address", TxtAlamat.Text);
                        insert.Parameters.AddWithValue("email", TxtEmail.Text);
                        insert.Parameters.AddWithValue("no_telp", TxtNoTelp.Text);
                        insert.Parameters.AddWithValue("status", CbStatus.SelectedItem);

                        try
                        {
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Data saved succesfully", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDg();
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unable to update: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format email salah !", "Pemberitahuan!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH SUPPLIER")
            {

            }
            else
            {
                try
                {
                    CultureInfo culture = new CultureInfo("id-ID");

                    TxtAlamat.Enabled = true;
                    TxtEmail.Enabled = true;
                    TxtNoTelp.Enabled = true;
                    CbStatus.Enabled = true;

                    DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];
                    id = row.Cells[1].Value.ToString();
                    TxtCompName.Text = row.Cells[2].Value.ToString();
                    TxtAlamat.Text = row.Cells[3].Value.ToString();
                    TxtEmail.Text = row.Cells[4].Value.ToString();
                    TxtNoTelp.Text = row.Cells[5].Value.ToString();
                    CbStatus.Text = row.Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_SupAktif", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter(view);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            DataColumn col = dt.Columns.Add("No", typeof(System.Int32));
            col.SetOrdinal(0);
            int a = 1;
            foreach (DataRow r in dt.Rows)
            {
                r["No"] = a;
                a++;
            }

            dgvSupplier.DataSource = dt;
            dgvSupplier.Columns[1].HeaderText = "ID";
            dgvSupplier.Columns[2].HeaderText = "Nama Supplier";
            dgvSupplier.Columns[3].HeaderText = "Alamat";
            dgvSupplier.Columns[4].HeaderText = "Email";
            dgvSupplier.Columns[5].HeaderText = "No Telepon";
            dgvSupplier.Columns[6].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvSupplier.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvSupplier.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSupplier.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            connection.Close();

            dgvSupplier.BorderStyle = BorderStyle.None;
            dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSupplier.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSupplier.BackgroundColor = Color.White;

            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbTidakAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_SupTidakAktif", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter(view);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            DataColumn col = dt.Columns.Add("No", typeof(System.Int32));
            col.SetOrdinal(0);
            int a = 1;
            foreach (DataRow r in dt.Rows)
            {
                r["No"] = a;
                a++;
            }

            dgvSupplier.DataSource = dt;
            dgvSupplier.Columns[1].HeaderText = "ID";
            dgvSupplier.Columns[2].HeaderText = "Nama Supplier";
            dgvSupplier.Columns[3].HeaderText = "Alamat";
            dgvSupplier.Columns[4].HeaderText = "Email";
            dgvSupplier.Columns[5].HeaderText = "No Telepon";
            dgvSupplier.Columns[6].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvSupplier.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvSupplier.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSupplier.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            connection.Close();

            dgvSupplier.BorderStyle = BorderStyle.None;
            dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSupplier.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSupplier.BackgroundColor = Color.White;

            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
