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
using Dealer_BengkelSempurna.Master.JenisSukuCadang;
using Dealer_BengkelSempurna.Master.Services;
using Dealer_BengkelSempurna.Master.Karyawan;
using Dealer_BengkelSempurna.Master.Supplier;

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


            timer.Tick += new EventHandler(timer_Tick);
            //1000 = 1 detik
            timer.Interval = (1000) * (1);
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbWakt.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.ViewSupplier' table. You can move, or remove it, as needed.
            this.viewSupplierTableAdapter.Fill(this.pROJEK8.ViewSupplier);
            RefreshDg();
            CbStatus.Visible = false;
            lbStatus.Visible = false;
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
            CbStatus.Text = "--Pilih Supplier--";
            TxtNoTelp.Text = "";

        }

        public void RefreshDg()
        {
            this.viewSupplierTableAdapter.Fill(this.pROJEK8.ViewSupplier);


            foreach (DataGridViewColumn colm in dgvSupplier.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            //this.dgvSupplier.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgvSupplier.Columns["no_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            

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




        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CbStatus.Visible = true;
            lbStatus.Visible = true;
            try
            {
                CultureInfo culture = new CultureInfo("id-ID");

                TxtAlamat.Enabled = true;
                TxtNoTelp.Enabled = true;
                CbStatus.Enabled = true;

                DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                TxtCompName.Text = row.Cells[1].Value.ToString();
                TxtAlamat.Text = row.Cells[2].Value.ToString();
                TxtNoTelp.Text = row.Cells[3].Value.ToString();
                CbStatus.Text = row.Cells[4].Value.ToString();
                // CbStatus.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click_1(object sender, EventArgs e)
        {

            if (TxtCompName.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
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
                id = autogenerateID("SUP", query);


                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("sp_InputSupplier", connection);
                insert.CommandType = CommandType.StoredProcedure;
                CbStatus.Enabled = false;
                lbStatus.Enabled = false;
                insert.Parameters.AddWithValue("id_supplier", id);
                insert.Parameters.AddWithValue("Nama_Supplier", TxtCompName.Text);
                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
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

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtCompName.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
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
                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("[sp_UpdateSupplier]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_supplier", id);
                insert.Parameters.AddWithValue("Nama_Supplier", TxtCompName.Text);
                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
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
        }

        private void BtnKaryawan_Click(object sender, EventArgs e)
        {
            karyawan karyawan = new karyawan();
            karyawan.Show();
            this.Hide();
        }

        private void BtnPosisi_Click(object sender, EventArgs e)
        {
            KelolaJabatan jabatan = new KelolaJabatan();
            jabatan.Show();
            this.Hide();
        }

        private void BtnMember_Click(object sender, EventArgs e)
        {

        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            services services = new services();
            services.Show();
            this.Hide();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            supplier sup = new supplier();
            sup.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Jsc jns = new Jsc();
            jns.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin_master adm = new admin_master();
            adm.Show();
            this.Hide();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncari_Click(object sender, EventArgs e)
        {

        }

        private void btncari_Click_1(object sender, EventArgs e)
        {
            try
            {
                // string query = "select * from Pelanggan where id_pelanggan='" + txtCariMember.Text + "'";
                BindingSource bindingSource1 = new BindingSource();
                DataTable st = new DataTable();
                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand search = new SqlCommand("sp_CariSupplier", connection);
                search.CommandType = CommandType.StoredProcedure;
                connection.Open();
                search.Parameters.AddWithValue("@cari", txtCariSUP.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dgvSupplier.DataSource = bindingSource1;



                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            dgvSupplier.Columns[0].HeaderCell.Value = "ID";
            dgvSupplier.Columns[1].HeaderCell.Value = "Nama";
            dgvSupplier.Columns[2].HeaderCell.Value = "Alamat";
            dgvSupplier.Columns[3].HeaderCell.Value = "No Telp";
            dgvSupplier.Columns[4].HeaderCell.Value = "Status";
            dgvSupplier.Columns[0].Width = 100;
            dgvSupplier.Columns[1].Width = 100;
            dgvSupplier.Columns[2].Width = 125;
            dgvSupplier.Columns[3].Width = 125;
            dgvSupplier.Columns[4].Width = 150;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtCompName.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Information!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hasil = MessageBox.Show("Yakin ingin menghapus data? ", "Information",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
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
                        MessageBox.Show("Hapus data berhasil", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshDg();
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete: " + ex.Message);
                    }
                }
                else
                {

                }
            }

        }
    }
    }


