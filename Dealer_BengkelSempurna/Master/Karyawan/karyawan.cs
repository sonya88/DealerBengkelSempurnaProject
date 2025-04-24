using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using Timer = System.Windows.Forms.Timer;


namespace Dealer_BengkelSempurna.Master.Karyawan
{
    public partial class karyawan : Form
    {

        String user = "";
        String pass = "";
        String id = "";

        Timer timer = new Timer();

        public karyawan()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }
        private void Clear()
        {
            TxtNamaEmp.Text = "";
            TxtAlamat.Text = "";
            TxtEmail.Text = "";
            TxtNoTelp.Text = "";
            CbPosisi.Text = " - PILIH POSISI -";
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword2.Text = "";
            CbStatus.Text = " - PILIH STATUS -";

            if (lbJudul.Text == "TAMBAH KARYAWAN")
            {

            }
            else
            {
                TxtAlamat.Enabled = false;
                TxtEmail.Enabled = false;
                TxtNoTelp.Enabled = false;
                CbPosisi.Enabled = false;
                TxtUsername.Enabled = false;
                TxtPassword.Enabled = false;
                TxtPassword2.Enabled = false;
                CbStatus.Enabled = false;
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtAlamat.Enabled = true;
            TxtEmail.Enabled = true;
            TxtNoTelp.Enabled = true;
            CbPosisi.Enabled = true;
            TxtUsername.Enabled = true;
            TxtPassword.Enabled = true;
            TxtPassword2.Enabled = true;
            CbStatus.Enabled = false;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            lbJudul.Text = "TAMBAH KARYAWAN";
            BtnHapus.Visible = false;
            lbStatus.Visible = false;
            CbStatus.Visible = false;
            lbMataBuka.Visible = true;
            lbMataTutup.Visible = true;
            CbPosisi.Text = " - PILIH POSISI -";
        }

        private void karyawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dealerBengkelSempurna.tPosisi' table. You can move, or remove it, as needed.
            this.tPosisiTableAdapter.Fill(this.dealerBengkelSempurna.tPosisi);

            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;

            RefreshDg();
            CbPosisi.Text = " - PILIH POSISI -";
            CbStatus.Text = " - PILIH STATUS -";
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword2.UseSystemPasswordChar = true;
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand view = new SqlCommand("sp_dgvKaryawan", connection);
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

            dgvKaryawan.DataSource = dt;
            dgvKaryawan.Columns[1].HeaderText = "ID";
            dgvKaryawan.Columns[2].HeaderText = "Nama Karyawan";
            dgvKaryawan.Columns[3].HeaderText = "Alamat";
            dgvKaryawan.Columns[4].HeaderText = "Email";
            dgvKaryawan.Columns[5].HeaderText = "No Telepon";
            dgvKaryawan.Columns[6].HeaderText = "Posisi";
            dgvKaryawan.Columns[7].HeaderText = "Username";
            dgvKaryawan.Columns[8].HeaderText = "Status";


            this.dgvKaryawan.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKaryawan.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connection.Close();

            dgvKaryawan.BorderStyle = BorderStyle.None;
            dgvKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKaryawan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKaryawan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKaryawan.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvKaryawan.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvKaryawan.EnableHeadersVisualStyles = false;
            dgvKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKaryawan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKaryawan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void TxtNamaEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNamaEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtNamaEmp.Text == "" || CbPosisi.Text == "" || TxtUsername.Text == "" ||
               TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Pemberitahuan",
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
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection Connection = new SqlConnection(connectionstring);
                        Connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand delete = new SqlCommand("[sp_DeleteKaryawan]", Connection);
                        delete.CommandType = CommandType.StoredProcedure;

                        delete.Parameters.AddWithValue("id_karyawan", id);

                        try
                        {
                            delete.ExecuteNonQuery();
                            MessageBox.Show("Hapus data berhasil", "Information",
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
                    MessageBox.Show("Format email salah !", "Pemberitahuan!",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                SqlConnection sqlCon = new SqlConnection(connectionstring); SqlCommand sqlCmd;
                int num = 0;
                try
                {
                    sqlCmd = new SqlCommand(sp, sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCon.Open();
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    dr.Read();
                    if (dr["idReturn"].ToString() == "")
                    {
                        num = 1;
                    }
                    else
                    {
                        num = Int32.Parse(dr["idReturn"].ToString());
                    }
                    if (num < 10)
                    {
                        result = firstText + "000" + num;
                    }
                    else if (num < 100)
                    {
                        result = firstText + "00" + num;
                    }
                    else if (num < 1000)
                    {
                        result = firstText + "0" + num;
                    }
                    else
                    {
                        result = firstText + num;
                    }
                    dr.Close();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
            public string getID()
            {
                return result;
            }
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
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (lbJudul.Text == "TAMBAH KARYAWAN")
            {
                if (CbPosisi.Text == "Manager" || CbPosisi.Text == "Kasir" || CbPosisi.Text == "Admin")
                {
                    if (TxtNamaEmp.Text == "" || CbPosisi.Text == "" || TxtUsername.Text == "" ||
                    TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "" || TxtPassword.Text == "")
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
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);
                        SqlCommand CekUser = new SqlCommand("[sp_CekUsername]", connection);

                        if (!string.IsNullOrEmpty(TxtUsername.Text.Trim()))
                        {
                            connection.Open();
                            CekUser.CommandType = System.Data.CommandType.StoredProcedure;
                            CekUser.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());

                            SqlDataReader reader = CekUser.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Username sudah ada!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                            }
                            else
                            {
                                SqlConnection Connection = new SqlConnection(connectionstring); SqlCommand CekPass = new SqlCommand("[sp_CekPass]", Connection);

                                if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                                {
                                    Connection.Open();
                                    CekPass.CommandType = System.Data.CommandType.StoredProcedure;
                                    CekPass.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());

                                    SqlDataReader Reader = CekPass.ExecuteReader();
                                    if (Reader.HasRows)
                                    {
                                        Reader.Read();
                                        MessageBox.Show("Password sudah ada!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Connection.Close();
                                        Reader.Close();
                                    }
                                    else
                                    {
                                        if (TxtPassword.Text == TxtPassword2.Text)
                                        {
                                            // string query = "select top 1 id_karyawan from tKaryawan order by id_karyawan desc";
                                            //id = autogenerateID("KRY-", query);
                                            //id = Program.autogenerateID("KRY-", "sp_IdKa");
                                            IdOtomatis a = new IdOtomatis();
                                            string sp = "sp_IdKaryawan";
                                            a.setID("KRY-", sp);
                                            string id = a.getID();
                                            bool validateEmail = ValidateEmail();

                                            if (validateEmail == true)
                                            {
                                                SqlDataAdapter adapter = new SqlDataAdapter();
                                                SqlParameter param = new SqlParameter();

                                                SqlCommand insert = new SqlCommand("[sp_InputKaryawan]", Connection);
                                                insert.CommandType = CommandType.StoredProcedure;

                                                insert.Parameters.AddWithValue("id_karyawan", id);
                                                insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                                                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                                                insert.Parameters.AddWithValue("email", TxtEmail.Text);
                                                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                                                insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                                                insert.Parameters.AddWithValue("username", TxtUsername.Text);
                                                insert.Parameters.AddWithValue("password", TxtPassword.Text);
                                                insert.Parameters.AddWithValue("status", "Aktif");

                                                Reader.Close();
                                                try
                                                {
                                                    insert.ExecuteNonQuery();
                                                    MessageBox.Show("Data berhasil disimpan", "Information",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    RefreshDg();
                                                    Clear();
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Unable to saved: " + ex.Message);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Format email salah !", "Pemberitahuan!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kata sandi tidak cocok !", "Pemberitahuan!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (TxtNamaEmp.Text == "" || CbPosisi.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "")
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
                        id = Program.autogenerateID("KRY-", "sp_IdKaryawan");

                        bool validateEmail = ValidateEmail();

                        if (validateEmail == true)
                        {
                            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                            SqlConnection connection = new SqlConnection(connectionstring);
                            connection.Open();

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            SqlParameter param = new SqlParameter();

                            SqlCommand insert = new SqlCommand("[sp_InputKaryawan]", connection);
                            insert.CommandType = CommandType.StoredProcedure;

                            insert.Parameters.AddWithValue("id_karyawan", id);
                            insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                            insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                            insert.Parameters.AddWithValue("email", TxtEmail.Text);
                            insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                            insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                            insert.Parameters.AddWithValue("username", DBNull.Value);
                            insert.Parameters.AddWithValue("password", DBNull.Value);
                            insert.Parameters.AddWithValue("status", "Aktif");

                            try
                            {
                                insert.ExecuteNonQuery();
                                MessageBox.Show("Data berhasil disimpan", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RefreshDg();
                                Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unable to saved: " + ex.Message);
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
            else
            {
                if (CbPosisi.Text == "Manager" || CbPosisi.Text == "Kasir" || CbPosisi.Text == "Admin")
                {
                    if (TxtNamaEmp.Text == "" || CbPosisi.Text == "" || TxtUsername.Text == "" ||
                    TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "" || TxtPassword.Text == "")
                    {
                        MessageBox.Show("Data ada yang kosong!!");
                    }
                    else if (TxtNoTelp.Text.Length > 13 || TxtNoTelp.Text.Length < 12)
                    {
                        MessageBox.Show("No. Telepon maksimal 13 digit!!", "Pemberitahuan",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring); SqlCommand CekUser = new SqlCommand("[sp_CekUsername]", connection);

                        if (!string.IsNullOrEmpty(TxtUsername.Text.Trim()))
                        {
                            connection.Open();
                            CekUser.CommandType = System.Data.CommandType.StoredProcedure;
                            CekUser.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());

                            SqlDataReader reader = CekUser.ExecuteReader();
                            //--- USER NAME SAMA SEPERTI SEBELUMNYA ---
                            if (user == TxtUsername.Text)
                            {
                                reader.Close();
                                SqlConnection Connection = new SqlConnection(connectionstring);
                                SqlCommand CekPass = new SqlCommand("[sp_CekPass]", Connection);

                                if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                                {
                                    Connection.Open();
                                    CekPass.CommandType = System.Data.CommandType.StoredProcedure;
                                    CekPass.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());

                                    SqlDataReader Reader = CekPass.ExecuteReader();
                                    //--- PASS NAME SAMA KAYA SEBELUMNYA ---
                                    if (pass == TxtPassword.Text)
                                    {
                                        if (TxtPassword.Text == TxtPassword2.Text)
                                        {
                                            Reader.Close();
                                            bool validateEmail = ValidateEmail();

                                            if (validateEmail == true)
                                            {

                                                SqlDataAdapter adapter = new SqlDataAdapter();
                                                SqlParameter param = new SqlParameter();

                                                SqlCommand insert = new SqlCommand("[sp_UpdateKaryawan]", connection);
                                                insert.CommandType = CommandType.StoredProcedure;

                                                insert.Parameters.AddWithValue("id_karyawan", id);
                                                insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                                                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                                                insert.Parameters.AddWithValue("email", TxtEmail.Text);
                                                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                                                insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                                                insert.Parameters.AddWithValue("username", TxtUsername.Text);
                                                insert.Parameters.AddWithValue("password", TxtPassword.Text);
                                                insert.Parameters.AddWithValue("status", CbStatus.Text);

                                                try
                                                {
                                                    insert.ExecuteNonQuery();
                                                    MessageBox.Show("Data berhasil diupdate", "Information",
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
                                                MessageBox.Show("Format email salah !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kata sandi tidak cocok !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if (Reader.HasRows)
                                    {
                                        Reader.Read();
                                        MessageBox.Show("Password sudah ada!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Connection.Close();
                                        Reader.Close();
                                    }
                                    else
                                    {
                                        Reader.Close();
                                        bool validateEmail = ValidateEmail();

                                        if (TxtPassword.Text == TxtPassword2.Text)
                                        {
                                            if (validateEmail == true)
                                            {
                                                SqlDataAdapter adapter = new SqlDataAdapter();
                                                SqlParameter param = new SqlParameter();

                                                SqlCommand insert = new SqlCommand("[sp_UpdateKaryawan]", connection);
                                                insert.CommandType = CommandType.StoredProcedure;

                                                insert.Parameters.AddWithValue("id_karyawan", id);
                                                insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                                                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                                                insert.Parameters.AddWithValue("email", TxtEmail.Text);
                                                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                                                insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                                                insert.Parameters.AddWithValue("username", TxtUsername.Text);
                                                insert.Parameters.AddWithValue("password", TxtPassword.Text);
                                                insert.Parameters.AddWithValue("status", CbStatus.Text);

                                                try
                                                {
                                                    insert.ExecuteNonQuery();
                                                    MessageBox.Show("Data berhasil disimpan", "Information",
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
                                                MessageBox.Show("Format email salah !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kata sandi tidak cocok !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                            }
                            else if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Username tidak tersedia!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                            }
                            else
                            {
                                reader.Close();
                                SqlConnection Connection = new SqlConnection(connectionstring); SqlCommand CekPass = new SqlCommand("[sp_CekPass]", Connection);

                                if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                                {
                                    Connection.Open();
                                    CekPass.CommandType = System.Data.CommandType.StoredProcedure;
                                    CekPass.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());

                                    SqlDataReader Reader = CekPass.ExecuteReader();
                                    if (pass == TxtPassword.Text)
                                    {
                                        Reader.Close();
                                        bool validateEmail = ValidateEmail();

                                        if (TxtPassword.Text == TxtPassword2.Text)
                                        {
                                            if (validateEmail == true)
                                            {
                                                SqlDataAdapter adapter = new SqlDataAdapter();
                                                SqlParameter param = new SqlParameter();

                                                SqlCommand insert = new SqlCommand("[sp_UpdateKaryawan]", connection);
                                                insert.CommandType = CommandType.StoredProcedure;

                                                insert.Parameters.AddWithValue("id_karyawan", id);
                                                insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                                                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                                                insert.Parameters.AddWithValue("email", TxtEmail.Text);
                                                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                                                insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                                                insert.Parameters.AddWithValue("username", TxtUsername.Text);
                                                insert.Parameters.AddWithValue("password", TxtPassword.Text);
                                                insert.Parameters.AddWithValue("status", CbStatus.Text);

                                                try
                                                {
                                                    insert.ExecuteNonQuery();
                                                    MessageBox.Show("Data berhasil disimpan", "Information",
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
                                                MessageBox.Show("Format email salah !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kata sandi tidak cocok !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if (Reader.HasRows)
                                    {
                                        Reader.Read();
                                        MessageBox.Show("Password sudah ada!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Connection.Close();
                                        Reader.Close();
                                    }
                                    else
                                    {
                                        Reader.Close();
                                        bool validateEmail = ValidateEmail();

                                        if (TxtPassword.Text == TxtPassword2.Text)
                                        {
                                            if (validateEmail == true)
                                            {

                                                SqlDataAdapter adapter = new SqlDataAdapter();
                                                SqlParameter param = new SqlParameter();

                                                SqlCommand insert = new SqlCommand("[sp_UpdateKaryawan]", connection);
                                                insert.CommandType = CommandType.StoredProcedure;

                                                insert.Parameters.AddWithValue("id_karyawan", id);
                                                insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                                                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                                                insert.Parameters.AddWithValue("email", TxtEmail.Text);
                                                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                                                insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                                                insert.Parameters.AddWithValue("username", TxtUsername.Text);
                                                insert.Parameters.AddWithValue("password", TxtPassword.Text);
                                                insert.Parameters.AddWithValue("status", CbStatus.Text);

                                                try
                                                {
                                                    insert.ExecuteNonQuery();
                                                    MessageBox.Show("Data berhasil disimpan", "Warning",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                                                MessageBox.Show("Format email salah !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kata sandi tidak cocok !", "Warning!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (TxtNamaEmp.Text == "" || CbPosisi.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "" || TxtEmail.Text == "")
                    {
                        MessageBox.Show("Data ada yang kosong!!");
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
                            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                            SqlConnection connection = new SqlConnection(connectionstring);
                            connection.Open();

                            SqlDataAdapter adapter = new SqlDataAdapter();
                            SqlParameter param = new SqlParameter();

                            SqlCommand insert = new SqlCommand("[sp_UpdateKaryawan]", connection);
                            insert.CommandType = CommandType.StoredProcedure;

                            insert.Parameters.AddWithValue("id_karyawan", id);
                            insert.Parameters.AddWithValue("nama_karyawan", TxtNamaEmp.Text);
                            insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                            insert.Parameters.AddWithValue("email", TxtEmail.Text);
                            insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                            insert.Parameters.AddWithValue("id_posisi", CbPosisi.SelectedValue);
                            insert.Parameters.AddWithValue("username", DBNull.Value);
                            insert.Parameters.AddWithValue("password", DBNull.Value);
                            insert.Parameters.AddWithValue("status", CbStatus.Text);

                            try
                            {
                                insert.ExecuteNonQuery();
                                MessageBox.Show("Data berhasil disimpan", "Information",
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
                            MessageBox.Show("Format email salah !", "Warning!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH KARYAWAN")
            {

            }
            else
            {
                if (e.ColumnIndex == 1)
                {
                    TxtAlamat.Enabled = true;
                    TxtEmail.Enabled = true;
                    TxtNoTelp.Enabled = true;
                    CbPosisi.Enabled = true;
                    TxtUsername.Enabled = true;
                    TxtPassword.Enabled = true;
                    TxtPassword2.Enabled = true;
                    CbStatus.Enabled = true;
                    lbMataTutup.Visible = true;

                    try
                    {
                        //int n = dgvKaryawan.CurrentCell.RowIndex;
                        DataGridViewRow row = this.dgvKaryawan.Rows[e.RowIndex];

                        id = row.Cells[1].Value.ToString();
                        TxtNamaEmp.Text = row.Cells[2].Value.ToString();
                        TxtAlamat.Text = row.Cells[3].Value.ToString();
                        TxtEmail.Text = row.Cells[4].Value.ToString();
                        TxtNoTelp.Text = row.Cells[5].Value.ToString();
                        CbPosisi.Text = row.Cells[6].Value.ToString();
                        TxtUsername.Text = row.Cells[7].Value.ToString();
                        user = row.Cells[7].Value.ToString();
                        CariKar(id);
                        TxtPassword.Text = pass;
                        TxtPassword2.Text = pass;
                        CbStatus.Text = row.Cells[8].Value.ToString();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        private void CariKar(string id)
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand search = new SqlCommand("sp_CariKaryawan", connection);
            search.CommandType = CommandType.StoredProcedure;

            search.Parameters.AddWithValue("id_karyawan", id);

            connection.Open();

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                pass = Convert.ToString(reader["password"]);
            }
            else
                MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_KaryawanAktif", connection);
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

            dgvKaryawan.DataSource = dt;
            dgvKaryawan.Columns[1].HeaderText = "ID";
            dgvKaryawan.Columns[2].HeaderText = "Nama Karyawan";
            dgvKaryawan.Columns[3].HeaderText = "Alamat";
            dgvKaryawan.Columns[4].HeaderText = "Email";
            dgvKaryawan.Columns[5].HeaderText = "No Telepon";
            dgvKaryawan.Columns[6].HeaderText = "Posisi";
            dgvKaryawan.Columns[7].HeaderText = "Username";
            dgvKaryawan.Columns[8].HeaderText = "Status";


            this.dgvKaryawan.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKaryawan.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connection.Close();

            dgvKaryawan.BorderStyle = BorderStyle.None;
            dgvKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKaryawan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKaryawan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKaryawan.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvKaryawan.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvKaryawan.EnableHeadersVisualStyles = false;
            dgvKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKaryawan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKaryawan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbTidakAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand view = new SqlCommand("sp_KaryawanTidakAktif", connection);
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

            dgvKaryawan.DataSource = dt;
            dgvKaryawan.Columns[1].HeaderText = "ID";
            dgvKaryawan.Columns[2].HeaderText = "Nama Karyawan";
            dgvKaryawan.Columns[3].HeaderText = "Alamat";
            dgvKaryawan.Columns[4].HeaderText = "Email";
            dgvKaryawan.Columns[5].HeaderText = "No Telepon";
            dgvKaryawan.Columns[6].HeaderText = "Posisi";
            dgvKaryawan.Columns[7].HeaderText = "Username";
            dgvKaryawan.Columns[8].HeaderText = "Status";


            this.dgvKaryawan.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKaryawan.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connection.Close();

            dgvKaryawan.BorderStyle = BorderStyle.None;
            dgvKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKaryawan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKaryawan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKaryawan.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvKaryawan.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvKaryawan.EnableHeadersVisualStyles = false;
            dgvKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKaryawan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKaryawan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void lbMataBuka_Click(object sender, EventArgs e)
        {
            lbMataBuka.Visible = false;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword2.UseSystemPasswordChar = true;
        }

        private void lbMataTutup_Click(object sender, EventArgs e)
        {
            lbMataBuka.Visible = true;
            TxtPassword.UseSystemPasswordChar = false;
            TxtPassword2.UseSystemPasswordChar = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtAlamat.Enabled = false;
            TxtEmail.Enabled = false;
            TxtNoTelp.Enabled = false;
            CbPosisi.Enabled = false;
            TxtUsername.Enabled = false;
            TxtPassword.Enabled = false;
            TxtPassword2.Enabled = false;
            CbStatus.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            lbJudul.Text = "UBAH KARYAWAN";
            BtnHapus.Visible = true;
            lbStatus.Visible = true;
            CbStatus.Visible = true;
            lbMataBuka.Visible = false;
            lbMataTutup.Visible = false;
            CbStatus.Text = " - PILIH STATUS -";
            CbPosisi.Text = " - PILIH POSISI -";
        }

        private void CbPosisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPosisi.Text == "Manager" || CbPosisi.Text == "Kasir" || CbPosisi.Text == "Admin")
            {
                TxtPassword.Enabled = true;
                TxtPassword2.Enabled = true;
                TxtUsername.Enabled = true;
            }
            else
            {
                TxtPassword.Enabled = false;
                TxtPassword2.Enabled = false;
                TxtUsername.Enabled = false;
            }
        }
    }
}