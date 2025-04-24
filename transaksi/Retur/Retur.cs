using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Microsoft.SqlServer.Server;
using Dealer_BengkelSempurna.transaksi.PEMBELIAN;
using Dealer_BengkelSempurna.laporan.RDLC
    ;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;
namespace Dealer_BengkelSempurna.transaksi.Retur
{
    public partial class Retur : Form
    {
        int i;
        String id;

        Timer timer = new Timer();
        //  String Kode_Jenis_SukuCadang = "";

        public Retur()
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
            lbWaktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void BtnPembelian_Click(object sender, EventArgs e)
        {
            pembelian p = new pembelian();
            p.Show();
            this.Hide();
        }

        private void BtnPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void BtnRetur_Click(object sender, EventArgs e)
        {
            Retur retur = new Retur();
            retur.Show();
            this.Hide();
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            // Service.Services ser = new Service.Services();
            //ser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi kasir = new Kasir_Transaksi();
            kasir.Show();
            this.Hide();
        }
        private void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Penjualan", connection);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            //DataColumn col = dt.Columns.Add("Check", typeof(bool));
            //col.SetOrdinal(0);
            //foreach (DataRow r in dt.Rows)
            //{
            //    r["Check"] = 0;
            //}

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Kode_Penjualan";
            dataGridView1.Columns[1].HeaderText = "Tanggal_Penjualan";
            dataGridView1.Columns[2].HeaderText = "id_pelanggan";
            dataGridView1.Columns[3].HeaderText = "Total_Harga_Penjualan";


            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();
        }
        private void tampilNamaMember()
        {
            try
            {
                string query1 = "SELECT * FROM Pelanggan WHERE id_pelanggan = '" + txtIdCus.Text + "'";

                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection1 = new SqlConnection(connectionstring);
                SqlCommand search1 = new SqlCommand(query1, connection1);

                connection1.Open();
                search1.Parameters.AddWithValue("@id_pelanggan", txtIdCus.Text.Trim());

                SqlDataReader read1 = search1.ExecuteReader();
                if (read1.Read())
                {
                    txtNamaCus.Text = Convert.ToString(read1["nama_pelanggan"]);
                }
                else
                {

                }

                connection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Clear()
        {
            txtIdCus.Text = "";

            txtKet.Text = "";
            txtTanggal.Text = "";
            txtTrans.Text = "";
            txtHarga.Text = "";
            txtNamaCus.Text = "";

            txtKet.Enabled = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Penjualan WHERE Kode_Penjualan= '" + txtTrans.Text + "'";


            string connectionstring = "integrated security = true; data source =DESKTOP-LHDNPFD; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@Kode_Penjualan", txtTrans.Text.Trim());

            SqlDataReader read = search.ExecuteReader();
            if (read.Read())
            {
                string tanggal = Convert.ToString(read["Tanggal_Penjualan"]);
                DateTime Date = DateTime.Parse(tanggal);
                txtTanggal.Text = Date.ToString("yyyy-MM-dd");
                txtHarga.Text = Convert.ToString(read["Total_Harga_Penjualan"]);
                txtIdCus.Text = Convert.ToString(read["id_pelanggan"]);


                txtKet.Enabled = true;
            }

            else
            {
                MessageBox.Show("Data tidak ditemukan!", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tampilNamaMember();
            connection.Close();

        }




        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection sqlCon = new SqlConnection(connectionstring);
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
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            cekRetur();
            if (txtKet.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (i == 1)
            {
                MessageBox.Show("Data sudah ada!", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String id, status;
                string query = "select top 1 id_retur from ReturPembelian order by id_retur desc";
                id = idotomatis("TRT", query);

                //id = Program.autogenerateID("RTR-", "sp_IdRetur");
                //IdOtomatis a = new IdOtomatis();
                //string sp = "sp_IdRetur";
                //a.setID("TRT", sp);
                //id = a.getID();

                status = "Menunggu";

                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("sp_InputReturPembelian", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_retur", id);
                insert.Parameters.AddWithValue("tanggal_retur", txtTglRetur.Text);
                insert.Parameters.AddWithValue("keterangan", txtKet.Text);

                insert.Parameters.AddWithValue("id_member", txtIdCus.Text);
                insert.Parameters.AddWithValue("status", status);
                insert.Parameters.AddWithValue("id_penjualan", txtTrans.Text);



                try
                {
                    var hasil = MessageBox.Show("Apakah anda yakin?", "Information",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data retur berhasil disimpan", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.Message);
                }
            }
        }
        private void cekRetur()
        {
            string query = "SELECT * FROM ReturPembelian WHERE Kode_Penjualan= '" + txtTrans.Text + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@Kode_Penjualan", txtTrans.Text.Trim());

            SqlDataReader read = search.ExecuteReader();
            if (read.Read())
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
        }

        private void btnCariNama_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Pelanggan WHERE id_pelanggan = '" + txtIdCus.Text + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@id_pelanggan", txtIdCus.Text.Trim());

            SqlDataReader read = search.ExecuteReader();
            if (read.Read())
            {
                txtNamaCus.Text = Convert.ToString(read["nama_pelanggan"]);
            }

            connection.Close();
        }

        private void Retur_Load(object sender, EventArgs e)
        {
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            RefreshDg();
            txtTglRetur.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Refreshre();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnCariTransaksi_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Penjualan WHERE Kode_Penjualan= '" + txtTrans.Text + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@Kode_Penjualan", txtTrans.Text.Trim());

            SqlDataReader read = search.ExecuteReader();
            if (read.Read())
            {
                string tanggal = Convert.ToString(read["Tanggal_Penjualan"]);
                DateTime Date = DateTime.Parse(tanggal);
                txtTanggal.Text = Date.ToString("yyyy-MM-dd");
                txtHarga.Text = Convert.ToString(read["Total_Harga_Penjualan"]);
                txtIdCus.Text = Convert.ToString(read["id_pelanggan"]);


                txtKet.Enabled = true;
            }


            tampilNamaMember();
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi Form = new Kasir_Transaksi();
            Form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btnSimpan.Enabled = true;
            try
            {

                CultureInfo culture = new CultureInfo("id-ID");

                txtTrans.Enabled = true;

                txtTanggal.Enabled = true;
                txtNamaCus.Enabled = true;
                txtHarga.Enabled = true;


                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtTrans.Text = row.Cells[0].Value.ToString();

                txtTanggal.Text = row.Cells[1].Value.ToString();
                txtNamaCus.Text = row.Cells[2].Value.ToString();
                String harga = row.Cells[3].Value.ToString();
                harga = Convert.ToDecimal(harga).ToString("c", culture);
                txtHarga.Text = harga.Replace("Rp", "");

                tampilNamaMember();
                txtKet.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
            }

        }
        public void Refreshre()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM ReturPembelian", connection);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            // DataColumn col = dt.Columns.Add("Check", typeof(bool));
            //  col.SetOrdinal(0);
            // foreach (DataRow r in dt.Rows)
            //{
            //  r["Check"] = 0;
            //}

            //            dgvReturn.DataSource = dt;

            dgvReturn.DataSource = dt;
            dgvReturn.Columns[0].HeaderText = "ID Return";
            dgvReturn.Columns[1].HeaderText = "Tanggal Return";
            dgvReturn.Columns[2].HeaderText = "Keterangan";
            dgvReturn.Columns[3].HeaderText = "ID Pelanggan";
            dgvReturn.Columns[4].HeaderText = "Status";
            dgvReturn.Columns[5].HeaderText = "Kode Penjualan";

            //   this.dgvReturn.Columns["Total_Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

           // dgvReturn.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            // dgvReturn.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            foreach (DataGridViewColumn colm in dgvReturn.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            DataGridViewColumn column = dgvReturn.Columns[2];
            column.Width = 180;
            dgvReturn.BorderStyle = BorderStyle.None;
            dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvReturn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReturn.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvReturn.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvReturn.BackgroundColor = Color.White;

            dgvReturn.EnableHeadersVisualStyles = false;
            dgvReturn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // dgvReturn.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

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
    }
}
    


