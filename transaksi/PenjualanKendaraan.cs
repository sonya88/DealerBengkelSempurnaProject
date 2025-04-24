using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Configuration;

namespace Dealer_BengkelSempurna.transaksi
{
    public partial class PenjualanKendaraan : Form
    {
        Universal_Class uv = new Universal_Class();
        String kodeTranPenj;
        String kodeBarang;
        String jenisMember, namaBarang;
        int poin = 0;
        Double kembali = 0.0;
        Double tb = 0.0;
        int hitungan = 0;
        Timer timer = new Timer();
        string username1;
        public PenjualanKendaraan()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = uv.GetConnectionDB();
            SqlConnection com = new SqlConnection(connectionString);

            com.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = com;
            cmd.CommandText = "unf_CariKendaraan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cari", BtnCariIdKdr.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvStok.DataSource = dt;
            com.Close();
        }

        private void PenjualanKendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.sp_kendaraanTersedia' table. You can move, or remove it, as needed.
            this.sp_kendaraanTersediaTableAdapter.Fill(this.pROJEK8.sp_kendaraanTersedia);
            //  this.sp_TampilBarangTersediaTableAdapter.Fill(this..sp_TampilBarangTersedia);

            dgvStok.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            dgvKeranjang.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            dgvKeranjang.Columns[4].DefaultCellStyle.Format = "Rp #,###";
       
            txtJumlahBayar.ReadOnly = true;
            txtUangKembali.ReadOnly = true;
            txtUangBayar.Enabled = true;
        }
        public void saveToKeranjang(int rowTable)
        {
            Object[] obj = new Object[4];
            obj[0] = dgvStok[0, rowTable].Value;
            obj[1] = dgvStok[1, rowTable].Value;
            obj[2] = dgvStok[3, rowTable].Value;
            obj[3] = jumlah;
            dgvKeranjang.Rows.Add(obj);
        }

        public void setTotalBayar()
        {
            Double harga = 0.0;
            Double jumlah = 0.0;
            Double totalBayar = 0.0;
            Double subTotal = 0.0;

            for (hitungan = 0; hitungan < dgvKeranjang.Rows.Count; hitungan++)
            {
                try
                {
                    harga = Convert.ToDouble(dgvKeranjang[2, hitungan].Value.ToString());
                    jumlah = Convert.ToDouble(dgvKeranjang[3, hitungan].Value.ToString());
                    subTotal = harga * jumlah;
                    dgvKeranjang[4, hitungan].Value = subTotal;
                    totalBayar = totalBayar + Convert.ToDouble(dgvKeranjang[4, hitungan].Value.ToString());
                    txtJumlahBayar.Text = totalBayar.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error set total bayar : " + ex.Message);
                }
            }
            tb = totalBayar;
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
        public void saveTransaksi()
        {
            if (!txtJumlahBayar.Text.Equals("0"))
            {
               // string pegawai = uv.cariSalahSatuData("sp_", "Username", username1);
                string tglTranPenj = DateTime.UtcNow.ToShortDateString();
                string query = "select top 1 id_pelanggan from Pelanggan order by id_pelanggan desc";
                string id = idotomatis("TSP", query);
                string connectionstring = uv.GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputPenjualan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Penjualan", kodeTranPenj);
                insert.Parameters.AddWithValue("Tanggal_Penjualan", tglTranPenj);
                insert.Parameters.AddWithValue("Kode_Member", txtIdCus.Text);
                insert.Parameters.AddWithValue("Total_Harga_Penjualan", txtJumlahBayar.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    createDtlTransBrg(kodeTranPenj);
                    updateJumlahBarang();
                    
                    MessageBox.Show($"Data berhasil disimpan \nKode Transaksi {kodeTranPenj}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uv.ClearTextBoxes(this.Controls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi error saat save transaksi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Jumlah barang harus lebih dari 0", "Validasi jumlah barang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        public void createDtlTransBrg(String kodeTrans)
        {
            string namaBarang = "";
            string jumlah = "";

            for (hitungan = 0; hitungan < dgvKeranjang.Rows.Count; hitungan++)
            {
                try
                {
                    string connectionstring = uv.GetConnectionDB();
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand insert = new SqlCommand("sp_InputDetailPenjualan", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("Kode_Penjualan", kodeTrans);
                    namaBarang = dgvKeranjang[0, hitungan].Value.ToString();
                    insert.Parameters.AddWithValue("id_kdr", namaBarang);
                    jumlah = dgvKeranjang[3, hitungan].Value.ToString();
                    insert.Parameters.AddWithValue("Jumlah", jumlah);

                    connection.Open();
                    insert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi error saat insert data detail pembelian: " + ex.Message);
                }
            }
        }

        private void btnCariNama_Click(object sender, EventArgs e)
        {

        }

        public void updateJumlahBarang()
        {
            string namaBarang = "";
            for (hitungan = 0; hitungan < dgvKeranjang.Rows.Count; hitungan++)
            {
                try
                {
                    string connectionstring = uv.GetConnectionDB();
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand update = new SqlCommand("sp_UpdateJumlahBarang", connection);
                    update.CommandType = CommandType.StoredProcedure;
                    namaBarang = dgvKeranjang[0, hitungan].Value.ToString();
                    update.Parameters.AddWithValue("id_kdr", namaBarang);
                    int jmlBarangBaru = Int32.Parse(uv.cariSalahSatuData("sp_JumlahBarang", "id_kdr", namaBarang))
                        - Int32.Parse(dgvKeranjang[3, hitungan].Value.ToString());
                    update.Parameters.AddWithValue("Jumlah", jmlBarangBaru.ToString());

                    connection.Open();
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi error saat update data jumlah barang: " + ex.Message);
                }
            }
        }

    }
}
