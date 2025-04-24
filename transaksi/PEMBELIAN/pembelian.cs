using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Dealer_BengkelSempurna.transaksi.Retur;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Configuration;

namespace Dealer_BengkelSempurna.transaksi.PEMBELIAN
{
    public partial class pembelian : Form
    {
        string jenis, idTran, id, idKat;
        string sup, user, idKendaraan, hargaBeli;
        double total = 0;
        int y;
        string Hargabeli;

        private void cbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbJenisBarang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbJenisBarang.Text == "Kendaraan")
            {
                jenis = "tbKendaraan";
            }
          
            else if (cbJenisBarang.Text == "Sukucadang")
            {
                jenis = "tSukucadang";
            }

            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                sup = cbSupplier.SelectedValue.ToString();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM " + jenis , connection);
                DataTable dt = new DataTable();

                connection.Open();
                adapt.Fill(dt);

                //DataColumn col = dt.Columns.Add("Check", typeof(bool));
                //col.SetOrdinal(0);
                //foreach (DataRow r in dt.Rows)
                //{
                //    r["Check"] = 0;
                //}

                dgvStok.DataSource = dt;
                dgvStok.Columns[0].HeaderText = "ID";
                dgvStok.Columns[1].HeaderText = "Merek";
                dgvStok.Columns[2].HeaderText = "Tipe/Warna";
                dgvStok.Columns[3].HeaderText = "Harga Beli";
                dgvStok.Columns[4].HeaderText = "Harga Jual";
                dgvStok.Columns[5].HeaderText = "Jumlah";
                dgvStok.Columns[6].HeaderText = "Id Supplier";
                dgvStok.Columns[7].HeaderText = "Status";
                dgvStok.Columns[8].HeaderText = "ID Jenis";

                foreach (DataGridViewColumn col in dgvStok.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

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



                dgvStok.Columns[3].DefaultCellStyle.Format = "Rp #,###";
                dgvStok.Columns[4].DefaultCellStyle.Format = "Rp #,###";
                connection.Close();
            }
            catch (Exception ex)
            {

            }
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
                dgvKeranjang.Rows[i].Cells[3].Value = dgvStok.Rows[n].Cells[8].Value.ToString();
                Hargabeli = dgvStok.Rows[n].Cells[4].Value.ToString();
                Hargabeli = Convert.ToDecimal(Hargabeli).ToString("Rp #,###", culture);
                dgvKeranjang.Rows[i].Cells[4].Value = Hargabeli;
                dgvKeranjang.Rows[i].Cells[5].Value = j;
               // dgvKeranjang.Rows[i].Cells[6].Value = dgvStok.Rows[n].Cells[7].Value.ToString();
                dgvKeranjang.Columns[4].DefaultCellStyle.Format = "Rp #,###";
                //dgvStok.Columns[5].DefaultCellStyle.Format = "Rp #,###";
               
                cekBeli();
            }
            foreach (DataGridViewColumn col in dgvKeranjang.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }
          //  dgvKeranjang.CellBorderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKeranjang.BorderStyle = BorderStyle.None;
                dgvKeranjang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgvKeranjang.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
                dgvKeranjang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dgvKeranjang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvKeranjang.BackgroundColor = Color.White;

                dgvKeranjang.EnableHeadersVisualStyles = false;
                dgvKeranjang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvKeranjang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dgvKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void cekBeli()
        {
            total = 0;
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                dgvKeranjang.Rows[i].Cells[4].Value = dgvKeranjang.Rows[i].Cells[4].Value.ToString().Replace(".", "");
                dgvKeranjang.Rows[i].Cells[4].Value = dgvKeranjang.Rows[i].Cells[4].Value.ToString().Replace("Rp ", "");

                total = total + (double.Parse(dgvKeranjang.Rows[i].Cells[4].Value.ToString()) * double.Parse(dgvKeranjang.Rows[i].Cells[5].Value.ToString()));

                dgvKeranjang.Rows[i].Cells[4].Value = Convert.ToDecimal(dgvKeranjang.Rows[i].Cells[4].Value).ToString("Rp #,###", culture);
                dgvKeranjang.Rows[i].Cells[4].Value = dgvKeranjang.Rows[i].Cells[4].Value;
            }
            TxtJumlahBayar.Text = total.ToString("#,###");
        }
        private void isiJenisBarang()
        {
            int a = 0;
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                idKat = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
                idKendaraan = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
                string jum = dgvKeranjang.Rows[i].Cells[5].Value.ToString();

                string kategori = idKat.Substring(0, 3);

                try
                {
                    string cari = TxtCariBarang.Text;

                    string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlDataAdapter adapt = new SqlDataAdapter(
                        "SELECT * FROM tKategoriBarangPem WHERE id_jenisBarang='" + idKat + "'", connection);

                    DataSet ds = new DataSet();

                    connection.Open();
                    adapt.Fill(ds);
                    int hitung = ds.Tables[0].Rows.Count;
                    if (hitung == 1)
                    {
                        penambahanBarang(idKat, jum, i);
                        continue;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pemberitahuan!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (a == 1)
                {
                    continue;
                }

                if (kategori == "Kendaraan")
                {
                    string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand insert = new SqlCommand("[sp_InputKategoriBarang]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_jenisBarang", idKat);
                    insert.Parameters.AddWithValue("id_kdr", idKendaraan);
                    insert.Parameters.AddWithValue("id_sukucadang", SqlDbType.Text).Value = DBNull.Value;

                    try
                    {
                        //transaction.Commit();
                        insert.ExecuteNonQuery();
                        penambahanBarang(idKat, jum, i);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }
                    connection.Close();
                }
                else if (kategori == "SCD")
                {
                    string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand insert = new SqlCommand("[sp_InputKategoriBarang]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_jenisBarang", idKat);
                    insert.Parameters.AddWithValue("id_kdr", SqlDbType.Text).Value = DBNull.Value;
                    insert.Parameters.AddWithValue("id_sukucadang", idKendaraan);

                    try
                    {
                        //transaction.Commit();
                        insert.ExecuteNonQuery();
                        penambahanBarang(idKat, jum, i);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }
                    connection.Close();
                }
            }
        }
        private void penambahanBarang(string idKat, string jum, int i)
        {
            string kategori = idKat.Substring(0, 3);

            if (kategori == "KDR")
            {
                string query = "select * from tbKendaraan where id_kdr='" + idKat + "'";

                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand search = new SqlCommand(query, connection);

                connection.Open();
                search.Parameters.AddWithValue("@id_kdr", idKat.Trim());

                SqlDataReader reader = search.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string jumlah = Convert.ToString(reader["jumlah"]);
                    int hasil = int.Parse(jumlah) + int.Parse(jum);
                    updateBarangKendaraan(hasil, i);
                }
                else
                //    MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                  //      MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }
            else if (kategori == "SCD")
            {
                string query = "select * from tSukucadang where id_sukucadang='" + idKat + "'";

                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand search = new SqlCommand(query, connection);

                connection.Open();
                search.Parameters.AddWithValue("@id_sukucadang", idKat.Trim());

                SqlDataReader reader = search.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string jumlah = Convert.ToString(reader["jumlah"]);
                    int hasil = int.Parse(jumlah) + int.Parse(jum);
                    updateBarangSukuCadang(hasil, i);
                }
                else
                  //  MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }
        }
        private void updateBarangKendaraan(int hasil, int i)
        {
            string id_kdr = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
            string merek = dgvKeranjang.Rows[i].Cells[1].Value.ToString();
            string tipe = dgvKeranjang.Rows[i].Cells[2].Value.ToString();
            string jenis = dgvKeranjang.Rows[i].Cells[3].Value.ToString();
            string hargaJual = dgvKeranjang.Rows[i].Cells[4].Value.ToString();
            //hasil;
            string sup = dgvKeranjang.Rows[i].Cells[6].Value.ToString();
            
            CariKendaraan(id_kdr);
            hargaJual = hargaJual.Replace(".", "");
            hargaJual = hargaJual.Replace("Rp ", "");

            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter param = new SqlParameter();

            SqlCommand insert = new SqlCommand("[sp_Updatekdr]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_kdr", id_kdr);
            insert.Parameters.AddWithValue("merek_kdr", merek);
            insert.Parameters.AddWithValue("warna", tipe);
            insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", jenis);
            insert.Parameters.AddWithValue("harga_beli", int.Parse(hargaBeli));
            insert.Parameters.AddWithValue("harga_jual", int.Parse(hargaJual));
            insert.Parameters.AddWithValue("jumlah", hasil);
            insert.Parameters.AddWithValue("id_supplier", sup);
            insert.Parameters.AddWithValue("status", "Tersedia");

            try
            {
                //transaction.Commit();
                insert.ExecuteNonQuery();
                //MessageBox.Show(idMobil + " " + hasil, "Information",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message, "UpdateMobil");
            }
        }
        private void updateBarangSukuCadang(int hasil, int i)
        {
            string idSukuCadang = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
            string merk = dgvKeranjang.Rows[i].Cells[1].Value.ToString();
            string tipe = dgvKeranjang.Rows[i].Cells[2].Value.ToString();
            string jenis = dgvKeranjang.Rows[i].Cells[3].Value.ToString();
            string hargaJual = dgvKeranjang.Rows[i].Cells[4].Value.ToString();
            //hasil;
            string sup = dgvKeranjang.Rows[i].Cells[6].Value.ToString();
            CariSukuCadang(idSukuCadang);
            hargaJual = hargaJual.Replace(".", "");
            hargaJual = hargaJual.Replace("Rp ", "");
            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter param = new SqlParameter();

            SqlCommand insert = new SqlCommand("[sp_UpdateSukuCadang]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_sukucadang", idSukuCadang);
            insert.Parameters.AddWithValue("merk_sukucadang", merk);
            insert.Parameters.AddWithValue("tipe", tipe);
            insert.Parameters.AddWithValue("Kode_Jenis_SukuCadang", jenis);
            insert.Parameters.AddWithValue("harga_beli", Int64.Parse(total.ToString()));
            insert.Parameters.AddWithValue("harga_jual", Int64.Parse(total.ToString()));
            insert.Parameters.AddWithValue("jumlah", hasil);
            insert.Parameters.AddWithValue("id_supplier", sup);
            insert.Parameters.AddWithValue("status", "Tersedia");

            try
            {
                //transaction.Commit();
                insert.ExecuteNonQuery();
                //MessageBox.Show(idSpare + " " + hasil, "Information",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message, "UpdateSukuCadang");
            }
        }
        private void CariKendaraan(string id_kdr)
        {
            string query = "select * from tbKendaraan where id_kdr='" + id_kdr + "'";

            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand search = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                hargaBeli = Convert.ToString(reader["harga_beli"]);
            }
            else
               // MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                 //   MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }
        private void CariSukuCadang(string idSukuCadang)
        {
            string query = "select * from tSukucadang where id_sukucadang='" + idSukuCadang + "'";

            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand search = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                hargaBeli = Convert.ToString(reader["harga_beli"]);
            }
            else
               // MessageBox.Show("Data tidak ditemukan ", "Pemberitahuan",
                 //   MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (TxtJumlahBayar.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hasil = MessageBox.Show("Apakah anda yakin?", "Information",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    isiJenisBarang();
                    isiTPembelian();
                    isiDetailTPembelian();
                    MessageBox.Show("Pembelian berhasil dilakukan", "Pemberitahuan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.dgvKeranjang.Rows.Clear();
                    // this.dgvStok.DataSource = null;
                    RefreshPEN();
                }
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
       
        private void isiTPembelian()
        {
            //idTran = Program.autogenerateID("TBB-", "sp_IdPembelian");
           // idotomatis a = new idotomatis();
           // string sp = "sp_IdPembelian";
           // a.setID("TBB", sp);
            //idTran = a.getID();
            string query = "select top 1 id_pembelian from tPembelian order by id_pembelian desc";
            idTran = idotomatis("TBB", query);


            string waktu = DateTime.Now.ToString("yyyy-MM-dd");
         
           

            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand insert = new SqlCommand("[sp_InputTPembelian]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_pembelian", idTran);
            insert.Parameters.AddWithValue("tanggal", waktu);
            insert.Parameters.AddWithValue("total_harga", Int64.Parse(total.ToString()));
            insert.Parameters.AddWithValue("id_jenisBarang", idKat);

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

        private void isiDetailTPembelian()
        {
            for (int i = 0; i < dgvKeranjang.Rows.Count; i++)
            {
                string idKat = dgvKeranjang.Rows[i].Cells[0].Value.ToString();
                string harga = dgvKeranjang.Rows[i].Cells[4].Value.ToString();
                string jumlah = dgvKeranjang.Rows[i].Cells[5].Value.ToString();
                string sup = dgvStok.Rows[i].Cells[6].Value.ToString();

                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                harga = harga.Replace(".", "");
                harga = harga.Replace("Rp ", "");
                connection.Open();
               // string query = "select top 1 id_pembelian from tDetailTPembelian order by id_pembelian desc";
               // idTran = idotomatis("TBB", query);
                SqlCommand insert = new SqlCommand("[sp_InputDetailTPembelian]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_pembelian", idTran);
                insert.Parameters.AddWithValue("jumlah_pembelian", int.Parse(jumlah.ToString()));
                insert.Parameters.AddWithValue("harga_beli_satuan", double.Parse(harga.ToString()));
                insert.Parameters.AddWithValue("id_jenisBarang", idKat);
                insert.Parameters.AddWithValue("id_supplier", sup);

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
        }
        private void BtnCariBarang_Click(object sender, EventArgs e)
        {
            try
            {
                string cari = TxtCariBarang.Text;

                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapt = new SqlDataAdapter(
                    "SELECT id_kdr AS ID, merek_kdr AS Merek, warna AS Warna, Kode_Jenis_Kendaraan AS Jenis, harga_beli AS HargaBeli, harga_jual AS HargaJual, jumlah AS Jumlah, id_supplier AS Supplier FROM tbKendaraan "
                    + "WHERE merek_mobil='" + cari + "'"
                    + " UNION "
                    + "SELECT id_sukucadang AS ID, merek_sukucadang AS Merek, tipe AS Warna, jenis_sukucadang AS Jenis, harga_beli AS HargaBeli, harga_jual AS HargaJual, jumlah AS Jumlah, id_supplier AS Supplier FROM tSukucadang "
                    + "WHERE jenis_sukucadang='" + cari + "'", connection);
                DataTable dt = new DataTable();

                connection.Open();
                adapt.Fill(dt);
                dgvStok.DataSource = dt;
                dgvStok.Columns[4].DefaultCellStyle.Format = "Rp #,###";
                dgvStok.Columns[5].DefaultCellStyle.Format = "Rp #,###";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pemberitahuan!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        CultureInfo culture = new CultureInfo("id-ID");

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPembelian_Click(object sender, EventArgs e)
        {

        }

        private void BtnRetur_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi r = new Kasir_Transaksi();
            r.Show();
            this.Hide();
        }

        private void dgvStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbJudul_Click(object sender, EventArgs e)
        {

        }

        Timer timer = new Timer();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        public pembelian()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void RefreshPEN()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM tPembelian", connection);
            DataTable dt = new DataTable();

            connection.Open();
            adapt.Fill(dt);

            // DataColumn col = dt.Columns.Add("Check", typeof(bool));
            //  col.SetOrdinal(0);
            // foreach (DataRow r in dt.Rows)
            //{
            //  r["Check"] = 0;
            //}

            //            dgvPembelian.DataSource = dt;

            dgvPembelian.DataSource = dt;
            dgvPembelian.Columns[0].HeaderText = "ID Pembelian";
            dgvPembelian.Columns[1].HeaderText = "Tanggal Pembelian";
            dgvPembelian.Columns[2].HeaderText = "Total Harga";
            dgvPembelian.Columns[3].HeaderText = "ID Jenis Barang";

            //   this.dgvPembelian.Columns["Total_Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPembelian.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            // dgvPembelian.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            foreach (DataGridViewColumn colm in dgvPembelian.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            DataGridViewColumn column = dgvPembelian.Columns[2];
            column.Width = 180;
            dgvPembelian.BorderStyle = BorderStyle.None;
            dgvPembelian.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPembelian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPembelian.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPembelian.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPembelian.BackgroundColor = Color.White;

            dgvPembelian.EnableHeadersVisualStyles = false;
            dgvPembelian.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPembelian.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPembelian.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // dgvPembelian.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

        }
        private void pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter.Fill(this.pROJEK8.tSupplier);
           
            RefreshPEN();
           
            cbSupplier.Text = " -- PILIH SUPPLIER --";
            cbJenisBarang.Text = " -- PILIH JENIS BARANG --";

            

        }
        private void Clear()
        {
            cbSupplier.Text = " -- PILIH SUPPLIER --";
            cbJenisBarang.Text = " -- PILIH JENIS BARANG --";
            TxtJumlahBayar.Text = "";
            TxtCariBarang.Text = "";
        }
    }
}
