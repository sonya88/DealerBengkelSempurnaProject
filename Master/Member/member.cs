using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Configuration;
using Dealer_BengkelSempurna.Master.Services;
using Dealer_BengkelSempurna.Master.Member;
using Dealer_BengkelSempurna.Master.Kendaraan;
using Dealer_BengkelSempurna.Master.JenisSukuCadang;
using Dealer_BengkelSempurna.Master.JenisKendaraan;
using Dealer_BengkelSempurna.Master.Karyawan;
using Dealer_BengkelSempurna.Master.Supplier;
//using Dealer_BengkelSempurna.Master.SukuCadang;
using Dealer_BengkelSempurna.Master.Bus;
using Dealer_BengkelSempurna.Master.Kendaraan;

namespace Dealer_BengkelSempurna.Master.Member
{
    public partial class member : Form
    {
        // public static class ConfigurationManager;
        String id;
        //  SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);

        Timer timer = new Timer();
        public member()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Clear()
        {
            TxtNama.Text = "";
            TxtNoKTP.Text = "";
            TxtAlamat.Text = "";

            TxtNoTelp.Text = "";
            CbStatus.Text = " - PILIH STATUS -";

           
            {
                TxtNoKTP.Enabled = false;
                TxtAlamat.Enabled = false;

                TxtNoTelp.Enabled = false;
                CbStatus.Enabled = false;
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
           
        }



        private void member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.viewPelanggan' table. You can move, or remove it, as needed.
            this.viewPelangganTableAdapter.Fill(this.pROJEK8.viewPelanggan);
            
            RefreshDg();
            CbStatus.Text = " - PILIH STATUS -";
            BtnHapus.Enabled = false;
            BtnUbah.Enabled = false;
            CbStatus.Visible = false;
            lbStatus.Visible = false;

        }
        public void RefreshDg()
        {

            this.viewPelangganTableAdapter.Fill(this.pROJEK8.viewPelanggan);
            foreach (DataGridViewColumn colm in dgvMember.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


            dgvMember.BorderStyle = BorderStyle.None;
            dgvMember.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMember.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMember.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMember.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMember.BackgroundColor = Color.White;

            dgvMember.EnableHeadersVisualStyles = false;
            dgvMember.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMember.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMember.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void TxtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNoKTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
        }
        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection sqlCon = new SqlConnection(connectionstring);
                sqlCon.Open();
                SqlCommand sqlCmd;
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

            result = firstText + num.ToString().PadLeft(4, '0');
            return result;
        }
        public string idotomatis(string firstID, string query)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlCommand MyCommand;
            SqlConnection MyConnection;
            string result = "";
            int num = 0;


            try
            {
                MyConnection = new SqlConnection(connectionString);
                MyConnection.Open();
                MyCommand = new SqlCommand(query, MyConnection);

                SqlDataReader reader = MyCommand.ExecuteReader();

                if (reader.Read())
                {
                    string lastID = reader[0].ToString();
                    num = Convert.ToInt32(lastID.Remove(0, firstID.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstID + num.ToString().PadLeft(4, '0');
            return result;
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {

            if (TxtNama.Text == "" || TxtNoKTP.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtNoTelp.Text.Length > 13 || TxtNoTelp.Text.Length < 12)
            {
                MessageBox.Show("No. Telepon maksimal 13 digit!!", "Pemberitahuan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtNoKTP.Text.Length != 16)
            {
                MessageBox.Show("No. KTP harus 16 digit!!", "Pemberitahuan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "select top 1 id_pelanggan from Pelanggan order by id_pelanggan desc";
                id = idotomatis("PLG", query);
                //id = Program.autogenerateID("KRY-", "sp_IdKa");

                //IdOtomatis a = new IdOtomatis();
                // string sp = "sp_IdMember";
                // a.setID("PLG", sp);
                // string id = a.getID();


                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("[sp_InputPelanggan]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_pelanggan", id);
                insert.Parameters.AddWithValue("nama_pelanggan", TxtNama.Text);
                insert.Parameters.AddWithValue("no_KTP", TxtNoKTP.Text);
                insert.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                insert.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                insert.Parameters.AddWithValue("status", "Aktif");

                try
                {
                    //transaction.Commit();
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
                connection.Close();

            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnHapus.Enabled = true;
            BtnUbah.Enabled = true;
            CbStatus.Visible = true;
            lbStatus.Visible = true;
            try
            {
                TxtNoKTP.Enabled = true;
                TxtAlamat.Enabled = true;

                TxtNoTelp.Enabled = true;
                CbStatus.Enabled = true;

                DataGridViewRow row = this.dgvMember.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                TxtNama.Text = row.Cells[1].Value.ToString();
                TxtNoKTP.Text = row.Cells[2].Value.ToString();
                TxtAlamat.Text = row.Cells[3].Value.ToString();

                TxtNoTelp.Text = row.Cells[4].Value.ToString();
                CbStatus.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUbah_Click_1(object sender, EventArgs e)
        {
            if (TxtNama.Text == "" || TxtNoKTP.Text == "" || TxtAlamat.Text == "" || TxtNoTelp.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtNoTelp.Text.Length > 13 || TxtNoTelp.Text.Length < 12)
            {
                MessageBox.Show("No. Telepon maksimal 13 digit!!", "Pemberitahuan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtNoKTP.Text.Length != 16)
            {
                MessageBox.Show("No. KTP harus 16 digit!!", "Pemberitahuan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();


                SqlCommand update = new SqlCommand("[sp_UpdatePelanggan]", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("id_pelanggan", id);
                update.Parameters.AddWithValue("nama_pelanggan", TxtNama.Text);
                update.Parameters.AddWithValue("no_KTP", TxtNoKTP.Text);
                update.Parameters.AddWithValue("alamat", TxtAlamat.Text);
                update.Parameters.AddWithValue("no_telepon", TxtNoTelp.Text);
                update.Parameters.AddWithValue("status", "Aktif");

                try
                {
                    //transaction.Commit();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil diperbarui", "Information",
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        

        private void BtnServices_Click_1(object sender, EventArgs e)
        {
            services services = new services();
            services.Show();
            this.Hide();
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
            member member = new member();
            member.Show();
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

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin_master adm = new admin_master();
            adm.Show();
            this.Hide();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            try
            {
                // string query = "select * from Pelanggan where id_pelanggan='" + txtCariMember.Text + "'";
                BindingSource bindingSource1 = new BindingSource();
                DataTable st = new DataTable();
                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand search = new SqlCommand("sp_CariPelanggan", connection);
                search.CommandType = CommandType.StoredProcedure;
                connection.Open();
                search.Parameters.AddWithValue("@cari", txtCari.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dgvMember.DataSource = bindingSource1;



                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            dgvMember.Columns[0].HeaderCell.Value = "ID Pelanggan";
            dgvMember.Columns[1].HeaderCell.Value = "Nama";
            dgvMember.Columns[2].HeaderCell.Value = "No KTP";
            dgvMember.Columns[3].HeaderCell.Value = "Alamat";
            dgvMember.Columns[4].HeaderCell.Value = "No Telepon";
            dgvMember.Columns[5].HeaderCell.Value = "Status";
            dgvMember.Columns[0].Width = 150;
            dgvMember.Columns[1].Width = 150;
            dgvMember.Columns[2].Width = 175;
            dgvMember.Columns[3].Width = 170;
            dgvMember.Columns[4].Width = 150;
            dgvMember.Columns[5].Width = 150;
            
        

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHapus_Click_1(object sender, EventArgs e)
        {
            if (TxtNama.Text == "" || TxtNoKTP.Text == "" ||
                TxtAlamat.Text == "" || TxtNoTelp.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Pemberitahuan",
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

                    SqlCommand delete = new SqlCommand("[sp_DeletePelanggan]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_pelanggan", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }

                    RefreshDg();
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }
    }
}
