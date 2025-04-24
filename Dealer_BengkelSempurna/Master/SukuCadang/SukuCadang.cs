using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;

namespace Dealer_BengkelSempurna.Master.SukuCadang
{
    public partial class SukuCadang : Form
    {
        String id;

        Timer timer = new Timer();

        public SukuCadang()
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
        private void SukuCadang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dealerBengkelSempurna.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter.Fill(this.dealerBengkelSempurna.tSupplier);
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;

            RefreshDg();
            cmbSup.Text = " - PILIH SUPPLIER -";
            cbStatus.Text = " - PILIH STATUS -";
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtMerk.Enabled = true;
            TxtJenis.Enabled = true;
            TxtTipe.Enabled = true;
            TxtHargaBeli.Enabled = true;
            TxtHargaJual.Enabled = true;
            TxtJumlah.Enabled = true;
            cmbSup.Enabled = true;
            cbStatus.Enabled = false;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            lbJudul.Text = "TAMBAH SUKUCADANG";
            BtnHapus.Visible = false;
            lbStatus.Visible = false;
            cbStatus.Visible = false;
            cbStatus.Text = " - PILIH STATUS -";
            cmbSup.Text = " - PILIH SUPPLIER -";
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
            TxtJenis.Enabled = false;
            TxtTipe.Enabled = false;
            TxtHargaBeli.Enabled = false;
            TxtHargaJual.Enabled = false;
            TxtJumlah.Enabled = false;
            cmbSup.Enabled = false;
            cbStatus.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            lbJudul.Text = "UBAH SUKUCADANG";
            BtnHapus.Visible = true;
            lbStatus.Visible = true;
            cbStatus.Visible = true;
            cbStatus.Text = " - PILIH STATUS -";
            cmbSup.Text = " - PILIH SUPPLIER -";
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }
        private void Clear()
        {
            TxtMerk.Text = "";
            TxtTipe.Text = "";
            TxtJenis.Text = "";
            TxtHargaBeli.Text = "";
            TxtHargaJual.Text = "";
            TxtJumlah.Text = "";
            cmbSup.Text = " - PILIH SUPPLIER -";
            cbStatus.Text = " - PILIH STATUS -";

            if (lbJudul.Text == "TAMBAH SUKUCADANG")
            {

            }
            else
            {
                TxtTipe.Enabled = false;
                TxtJenis.Enabled = false;
                TxtHargaBeli.Enabled = false;
                TxtHargaJual.Enabled = false;
                TxtJumlah.Enabled = false;
                cmbSup.Enabled = false;
                cbStatus.Enabled = false;
            }
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_dgvSuku", connection);
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

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Merek SukuCadang";
            dataGridView1.Columns[3].HeaderText = "Tipe";
            dataGridView1.Columns[4].HeaderText = "Jenis";
            dataGridView1.Columns[5].HeaderText = "Harga Beli";
            dataGridView1.Columns[6].HeaderText = "Harga Jual";
            dataGridView1.Columns[7].HeaderText = "Jumlah";
            dataGridView1.Columns[8].HeaderText = "Supplier";
            dataGridView1.Columns[9].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp #,###.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtMerk.Text == "" || TxtTipe.Text == "" || TxtJenis.Text == "" ||
                  TxtHargaBeli.Text == "" || TxtJumlah.Text == "" || cmbSup.Text == " - PILIH SUPPLIER -")
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
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                    SqlConnection connection = new SqlConnection(connectionstring);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand delete = new SqlCommand("[sp_DeleteSukuCadang]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_sukucadang", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Information",
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
            if (lbJudul.Text == "TAMBAH SUKUCADANG")
            {
                if (TxtMerk.Text == "" || TxtTipe.Text == "" || TxtJenis.Text == "" ||
                TxtHargaBeli.Text == "" || TxtJumlah.Text == "" || cmbSup.Text == " - PILIH SUPPLIER -")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Information!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "select top 1 id_sukucadang from tSukucadang order by id_sukucadang desc";
                    id = autogenerateID("SCD-", query);

                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                    SqlConnection connection = new SqlConnection(connectionstring);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_InputSukuCadang]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_sukucadang", id);
                    insert.Parameters.AddWithValue("merk_sukucadang", TxtMerk.Text);
                    insert.Parameters.AddWithValue("tipe", TxtTipe.Text);
                    insert.Parameters.AddWithValue("jenis_sukucadang", TxtJenis.Text);
                    string hargaBeli = Program.toAngka(TxtHargaBeli.Text).ToString();
                    insert.Parameters.AddWithValue("harga_beli", hargaBeli);
                    string hargaJual = Program.toAngka(TxtHargaJual.Text).ToString();
                    insert.Parameters.AddWithValue("harga_jual", hargaJual);
                    insert.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
                    insert.Parameters.AddWithValue("id_supplier", cmbSup.SelectedValue);
                    insert.Parameters.AddWithValue("status", "Tersedia");

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
                }
            }
            else
            {
                if (TxtMerk.Text == "" || TxtTipe.Text == "" || TxtJenis.Text == "" ||
                   TxtHargaBeli.Text == "" || TxtJumlah.Text == "" || cmbSup.Text == " - PILIH SUPPLIER -")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Information!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                    SqlConnection connection = new SqlConnection(connectionstring);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_UpdateSukuCadang]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_sukucadang", id);
                    insert.Parameters.AddWithValue("merk_sukucadang", TxtMerk.Text);
                    insert.Parameters.AddWithValue("tipe", TxtTipe.Text);
                    insert.Parameters.AddWithValue("jenis_sukucadang", TxtJenis.Text);
                    string hargaBeli = Program.toAngka(TxtHargaBeli.Text).ToString();
                    insert.Parameters.AddWithValue("harga_beli", hargaBeli);
                    string hargaJual = Program.toAngka(TxtHargaJual.Text).ToString();
                    insert.Parameters.AddWithValue("harga_jual", hargaJual);
                    insert.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
                    insert.Parameters.AddWithValue("id_supplier", cmbSup.SelectedValue);
                    insert.Parameters.AddWithValue("status", cbStatus.Text);

                    try
                    {
                        //transaction.Commit();
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diperbarui", "Information",
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH SUKUCADANG")
            {

            }
            else
            {
                try
                {
                    CultureInfo culture = new CultureInfo("id-ID");

                    TxtMerk.Enabled = true;
                    TxtJenis.Enabled = true;
                    TxtTipe.Enabled = true;
                    TxtHargaBeli.Enabled = true;
                    TxtHargaJual.Enabled = true;
                    TxtJumlah.Enabled = true;
                    cmbSup.Enabled = true;
                    cbStatus.Enabled = true;

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells[1].Value.ToString();
                    TxtMerk.Text = row.Cells[2].Value.ToString();
                    TxtTipe.Text = row.Cells[3].Value.ToString();
                    TxtJenis.Text = row.Cells[4].Value.ToString();
                    String hargabeli = row.Cells[5].Value.ToString();
                    hargabeli = Convert.ToDecimal(hargabeli).ToString("c", culture);
                    String hargajual = row.Cells[6].Value.ToString();
                    hargajual = Convert.ToDecimal(hargajual).ToString("c", culture);
                    TxtHargaBeli.Text = hargabeli.Replace("Rp", "");
                    TxtHargaJual.Text = hargajual.Replace("Rp", "");
                    TxtJumlah.Text = row.Cells[7].Value.ToString();
                    cmbSup.Text = row.Cells[8].Value.ToString();
                    cbStatus.Text = row.Cells[9].Value.ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void rbTersedia_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_SukuTersedia", connection);
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

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Merek SukuCadang";
            dataGridView1.Columns[3].HeaderText = "Tipe";
            dataGridView1.Columns[4].HeaderText = "Jenis";
            dataGridView1.Columns[5].HeaderText = "Harga Beli";
            dataGridView1.Columns[6].HeaderText = "Harga Jual";
            dataGridView1.Columns[7].HeaderText = "Jumlah";
            dataGridView1.Columns[8].HeaderText = "Supplier";
            dataGridView1.Columns[9].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp #,###.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbTidakTersedia_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_SukuTidakTersedia", connection);
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

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Merek SukuCadang";
            dataGridView1.Columns[3].HeaderText = "Tipe";
            dataGridView1.Columns[4].HeaderText = "Jenis";
            dataGridView1.Columns[5].HeaderText = "Harga Beli";
            dataGridView1.Columns[6].HeaderText = "Harga Jual";
            dataGridView1.Columns[7].HeaderText = "Jumlah";
            dataGridView1.Columns[8].HeaderText = "Supplier";
            dataGridView1.Columns[9].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp #,###.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dataGridView1.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void TxtHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtHargaJual_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
