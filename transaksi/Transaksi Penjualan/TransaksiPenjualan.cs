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
using Dealer_BengkelSempurna.transaksi.Retur;
using Dealer_BengkelSempurna.transaksi.Retur;

namespace Dealer_BengkelSempurna.transaksi.Transaksi_Penjualan
{
    public partial class TransaksiPenjualan : Form
    {
        string jenis, idTran, id, idKat, kolom;
        string user, idKendaraan, Harga, Jumlah, hargaBeli;
        double total = 0;

        private void TransaksiPenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.ViewPenjualan' table. You can move, or remove it, as needed.
            this.viewPenjualanTableAdapter.Fill(this.pROJEK8.ViewPenjualan);

           

        }

        string Hargabeli;

        CultureInfo culture = new CultureInfo("id-ID");
        Timer timer = new Timer();
        private void cekBeli()
        {
            total = 0;
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                dgvKeranjang.Rows[i].Cells[3].Value = dgvKeranjang.Rows[i].Cells[3].Value.ToString().Replace(".", "");
                dgvKeranjang.Rows[i].Cells[3].Value = dgvKeranjang.Rows[i].Cells[3].Value.ToString().Replace("Rp ", "");

                total = total + (Int32.Parse(dgvKeranjang.Rows[i].Cells[3].Value.ToString()) * Int32.Parse(dgvKeranjang.Rows[i].Cells[4].Value.ToString()));

                dgvKeranjang.Rows[i].Cells[3].Value = Convert.ToDecimal(dgvKeranjang.Rows[i].Cells[3].Value).ToString("Rp #,###", culture);
                dgvKeranjang.Rows[i].Cells[3].Value = dgvKeranjang.Rows[i].Cells[3].Value;
            }
            txtJumlahBayar.Text = total.ToString();
           //total = Convert.ToInt64(txtJumlahBayar.Text);
            
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
        class autogenerateID
        {
            string result = "";
            public void setID(string firstText, string query)
            {
                SqlCommand sqlCmd;
                SqlConnection sqlCon;
               
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
            }
                public string getID()
                {
                    return result;
                }
            }
        
        public void isiTPenjualan()
        {
            //idTran = Program.autogenerateID("TJB-", "sp_IdPenjualan");
            IdOtomatis a = new IdOtomatis();
            string sp = "sp_IdPenjualan";
            a.setID("TSP", sp);
            string idTran = a.getID();
            string waktu = DateTime.Now.ToString("yyyy-MM-dd");
            object lbuse = null;
             //user = lbuse.Text.Replace("Hallo, kasir ", "");
            CariId(user);
            string idMember = txtIdCus.Text;

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            SqlCommand insert = new SqlCommand("[sp_InputPenjualan]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Kode_Penjualan", idTran);
            insert.Parameters.AddWithValue("Tanggal_Penjualan", waktu);
            insert.Parameters.AddWithValue("Total_Harga_Penjualan", Int64.Parse(total.ToString()));
            insert.Parameters.AddWithValue("id_pelanggan", idMember);

            try
            {
                //transaction.Commit();
                insert.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
            }
            connection.Close();
        }

        private void isiDetailJual()
        {
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                string idKat = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
                Harga = dgvKeranjang.Rows[i].Cells[4].Value.ToString();
                Jumlah = dgvKeranjang.Rows[i].Cells[4].Value.ToString();

                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                IdOtomatis a = new IdOtomatis();
                string sp = "sp_IdPenjualan";
                a.setID("TSP", sp);
                string idTran = a.getID();
                SqlCommand input = new SqlCommand("[sp_InputDetailPenjualan]", connection);
                input.CommandType = CommandType.StoredProcedure;
                Harga = Harga.Replace(".", "");
                Harga = Harga.Replace("Rp ", "");

                input.Parameters.AddWithValue("Kode_Penjualan", idTran);
                input.Parameters.AddWithValue("Jumlah", int.Parse(Jumlah));
                input.Parameters.AddWithValue("id_kdr", idKat);

                try
                {
                    //transaction.Commit();
                    input.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.Message);
                }
            }
        }

        private void penguranganBarang(string idKat, string jum, int i)
        {
            string kategori = idKat.Substring(0, 3);


            string query = "select * from tbKendaraan where id_kdr ='" + idKat + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring); 
            SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@id_kdr", idKat.Trim());

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string jumlah = Convert.ToString(reader["jumlah"]);
                int hasil = int.Parse(jumlah) - int.Parse(jum);
                updateBarangKendaraan(hasil, i);
            }
            else
                MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }
        private void updateBarangKendaraan(int hasil, int i)
        {
            string idkdr = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
            string merk = dgvKeranjang.Rows[i].Cells[1].Value.ToString();
            string tipe = dgvKeranjang.Rows[i].Cells[2].Value.ToString();
            string jenis = dgvKeranjang.Rows[i].Cells[3].Value.ToString();
            string hargaJual = dgvKeranjang.Rows[i].Cells[4].Value.ToString();
            //hasil;
            string sup = dgvKeranjang.Rows[i].Cells[6].Value.ToString();
            CariKendaraan(idkdr);
            hargaJual = hargaJual.Replace(".", "");
            hargaJual = hargaJual.Replace("Rp ", "");
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter param = new SqlParameter();

            SqlCommand insert = new SqlCommand("[sp_UpdateKendaraan]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_kdr", idkdr);
            insert.Parameters.AddWithValue("merek_kdr", merk);
            insert.Parameters.AddWithValue("warna", tipe);
            insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", jenis);
            insert.Parameters.AddWithValue("harga_beli", double.Parse(hargaBeli));
            insert.Parameters.AddWithValue("harga_jual", double.Parse(hargaJual));
            insert.Parameters.AddWithValue("jumlah", hasil);
            insert.Parameters.AddWithValue("id_supplier", sup);
            insert.Parameters.AddWithValue("status", "Tersedia");

            try
            {
                //transaction.Commit();
                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message, "UpdateBarang");
            }
        }
        Universal_Class uv = new Universal_Class();
        Double kembali = 0.0;
        private void txtJumlahBayar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUangBayar_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
        
        private void txtUangBayar_Click(object sender, EventArgs e)
        {
        }

        private void txtUangKembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUangBayar_TextChanged(object sender, EventArgs e)
        {

            if (txtUangBayar.Text == "")
            {
                return;
            }
            else
            {
              

                double bayar = Double.Parse(txtUangBayar.Text);
                double ganti = Double.Parse(txtJumlahBayar.Text);
                double kembali = bayar - ganti;
                string kembalian = kembali.ToString();
                txtUangKembali.Text = kembalian;

            }
        }

        private void txtNamaCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRetur_Click(object sender, EventArgs e)
        {
           
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi Form = new Kasir_Transaksi();
            Form.Show();
            this.Hide();
        }

        private void dgvStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
            int j;
            int i;
            int n = dgvStok.CurrentCell.RowIndex;
            int z = dgvKeranjang.Rows.Count;

            for (int a = 0; a < z; a++)
            {
                if (dgvKeranjang.Rows[a].Cells[0].Value.ToString() == dgvStok.Rows[n].Cells[0].Value.ToString())
                {
                    x = 1;
                    break;
                }
                else
                {
                    x = 0;
                }
            }
            if (x == 0)
            {
                j = 1;

                i = dgvKeranjang.Rows.Add();
                dgvKeranjang.Rows[i].Cells[0].Value = dgvStok.Rows[n].Cells[0].Value.ToString();
                dgvKeranjang.Rows[i].Cells[1].Value = dgvStok.Rows[n].Cells[1].Value.ToString();
                dgvKeranjang.Rows[i].Cells[2].Value = dgvStok.Rows[n].Cells[2].Value.ToString();
                //dgvKeranjang.Rows[i].Cells[3].Value = dgvStok.Rows[n].Cells[3].Value.ToString();
                Hargabeli = dgvStok.Rows[n].Cells[3].Value.ToString();
                Hargabeli = Convert.ToDecimal(Hargabeli).ToString("Rp #,###", culture);
                dgvKeranjang.Rows[i].Cells[3].Value = Hargabeli;
                dgvKeranjang.Rows[i].Cells[4].Value = j;
               // dgvKeranjang.Rows[i].Cells[6].Value = dgvStok.Rows[n].Cells[7].Value.ToString();

                cekBeli();
            }
        }

        private void txtUangBayar_TextChanged_1(object sender, EventArgs e)
        {

            if (txtUangBayar.Text == "")
            {
                return;
            }
            else
            {


                double bayar = Double.Parse(txtUangBayar.Text);
                double ganti = Double.Parse(txtJumlahBayar.Text);
                double kembali = bayar - ganti;
                string kembalian = kembali.ToString();
                txtUangKembali.Text = kembalian;

            }
        }

        private void TransaksiPenjualan_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.Penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.pROJEK8.Penjualan);
            // TODO: This line of code loads data into the 'pROJEK8.tbKendaraan' table. You can move, or remove it, as needed.
            this.tbKendaraanTableAdapter.Fill(this.pROJEK8.tbKendaraan);
            RefreshDg();
            RefreshPEN();
          
            //RefreshDg();

            foreach (DataGridViewColumn col in dgvKeranjang.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            dgvKeranjang.BorderStyle = BorderStyle.None;
            dgvKeranjang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKeranjang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKeranjang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKeranjang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKeranjang.BackgroundColor = Color.White;

            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKeranjang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnCariNama_Click_1(object sender, EventArgs e)
        {
            string query = "select * from Pelanggan where id_pelanggan='" + txtIdCus.Text + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand search = new SqlCommand(query, connection);

            connection.Open();
            search.Parameters.AddWithValue("@id_pelanggan", txtIdCus.Text.Trim());

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtNamaCus.Text = Convert.ToString(reader["nama_pelanggan"]);
            }
            else
                MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaCus.Text == "" || txtUangBayar.Text == "" || txtJumlahBayar.Text == "")
            {
                MessageBox.Show("Data masih ada yang kosong", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.Parse(txtJumlahBayar.Text) > Int32.Parse(txtJumlahBayar.Text))
            {
                MessageBox.Show("Uang anda kurang", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var hasil = MessageBox.Show("Apakah anda yakin?", "Information",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {

                    isiTPenjualan();
                    isiDetailJual();
                    MessageBox.Show("Data transaksi telah disimpan", "Pemberitahuan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.dgvKeranjang.Rows.Clear();
                    this.dgvStok.DataSource = null;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btkurang_Click(object sender, EventArgs e)
        {
            int jumlah;

            int n = dgvKeranjang.CurrentCell.RowIndex;
            jumlah = int.Parse(dgvKeranjang.Rows[n].Cells[4].Value.ToString());

            jumlah = jumlah - 1;

            if (jumlah < 1)
            {
                dgvKeranjang.Rows.RemoveAt(n);
                btntambah.Enabled = false;
                btnkurang.Enabled = false;
            }
            else
            {
                dgvKeranjang.Rows[n].Cells[5].Value = jumlah;
            }
            cekBeli();
        }

        private void CariKendaraan(string idMobil)
        {
            string query = "select * from tbKendaraan where id_kdr='" + idMobil + "'";

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand search = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                hargaBeli = Convert.ToString(reader["harga_beli"]);
            }
            else
                MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void lbUse_Click(object sender, EventArgs e)
    {

    }


        public TransaksiPenjualan()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            //1000 = 1 detik
            timer.Interval = (1000) * (1);
            timer.Enabled = true;
            timer.Start();
            txtUangKembali.Enabled = false;
            txtUangKembali.Text = "0;";

        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbWaktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM tbKendaraan WHERE status='Tersedia'", connection);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

           // DataColumn col = dt.Columns.Add("Check", typeof(bool));
          //  col.SetOrdinal(0);
           // foreach (DataRow r in dt.Rows)
            //{
              //  r["Check"] = 0;
            //}

//            dgvStok.DataSource = dt;

            dgvStok.DataSource = dt;
            dgvStok.Columns[0].HeaderText = "ID";
            dgvStok.Columns[1].HeaderText = "Merek";
            dgvStok.Columns[2].HeaderText = "Tipe/Warna";
            dgvStok.Columns[3].HeaderText = "Harga Beli";
            dgvStok.Columns[4].HeaderText = "Harga Jual";
            dgvStok.Columns[5].HeaderText = "Jumlah";
            dgvStok.Columns[6].HeaderText = "Id Supplier";
            dgvStok.Columns[7].HeaderText = "Status";
            dgvStok.Columns[8].HeaderText = "Jenis";
            this.dgvStok.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvStok.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvStok.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStok.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            dgvStok.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            foreach (DataGridViewColumn colm in dgvStok.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            DataGridViewColumn column = dgvStok.Columns[2];
            column.Width = 180;
            dgvStok.BorderStyle = BorderStyle.None;
            dgvStok.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvStok.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStok.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvStok.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvStok.BackgroundColor = Color.White;

            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStok.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvStok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

           // dgvPenjualan.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

        }
        public void RefreshPEN()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Penjualan ", connection);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            // DataColumn col = dt.Columns.Add("Check", typeof(bool));
            //  col.SetOrdinal(0);
            // foreach (DataRow r in dt.Rows)
            //{
            //  r["Check"] = 0;
            //}

            //            dgvPenjualan.DataSource = dt;

            dgvPenjualan.DataSource = dt;
            dgvPenjualan.Columns[0].HeaderText = "Kode Penjualan";
            dgvPenjualan.Columns[1].HeaderText = "Tanggal Penjualan";
            dgvPenjualan.Columns[2].HeaderText = "ID Pelanggan";
            dgvPenjualan.Columns[3].HeaderText = "Total Harga";
          
         //   this.dgvPenjualan.Columns["Total_Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
            dgvPenjualan.Columns[3].DefaultCellStyle.Format = "Rp #,###";
           // dgvPenjualan.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            foreach (DataGridViewColumn colm in dgvPenjualan.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            DataGridViewColumn column = dgvPenjualan.Columns[2];
            column.Width = 180;
            dgvPenjualan.BorderStyle = BorderStyle.None;
            dgvPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPenjualan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPenjualan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPenjualan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPenjualan.BackgroundColor = Color.White;

            dgvPenjualan.EnableHeadersVisualStyles = false;
            dgvPenjualan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPenjualan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPenjualan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // dgvPenjualan.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

        }
        private void Clear()
        {
            txtIdCus.Text = "";
            TxtCariBarang.Text = "";
            txtNamaCus.Text = "";
            txtJumlahBayar.Text = "";
            txtUangBayar.Text = "";
            txtUangKembali.Text = "";
           
        }
        private void CariId(string user)
        {
            
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
