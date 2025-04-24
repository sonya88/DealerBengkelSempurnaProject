using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Dealer_BengkelSempurna.Master.Bus
{
    public partial class Bus : Form
    {
        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
        String id;

        Timer timer = new Timer();
        public Bus()
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
        private void Bus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.JenisKendaraan' table. You can move, or remove it, as needed.
            this.jenisKendaraanTableAdapter.Fill(this.pROJEK8.JenisKendaraan);
            // TODO: This line of code loads data into the 'pROJEK8.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter1.Fill(this.pROJEK8.tSupplier);
            // TODO: This line of code loads data into the 'dealerBengkelSempurna.tSupplier' table. You can move, or remove it, as needed.
            //this.tSupplierTableAdapter.Fill(this.dealerBengkelSempurna.tSupplier);
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;

            RefreshDg();
            cmbSup.Text = " - PILIH SUPPLIER -";
            cbJenis.Text = " - PILIH JENIS -";
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }
        private void Clear()
        {
            TxtMerek.Text = "";
            TxtWarna.Text = "";
            cbJenis.Text = " - PILIH JENIS -";
            TxtHargaBeli.Text = "";
            TxtHargaJual.Text = "";
            TxtJumlah.Text = "";
            cmbSup.Text = " - PILIH SUPPLIER -";

                TxtWarna.Enabled = false;
                cbJenis.Enabled = false;
                TxtHargaBeli.Enabled = false;
                TxtHargaJual.Enabled = false;
                TxtJumlah.Enabled = false;
                cmbSup.Enabled = false;
                cbStatus.Enabled = false;
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_dgvkendaraan", connection);
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

            dgvKdr.DataSource = dt;
            dgvKdr.Columns[1].HeaderText = "ID";
            dgvKdr.Columns[2].HeaderText = "Merek";
            dgvKdr.Columns[3].HeaderText = "Warna";
            dgvKdr.Columns[4].HeaderText = "Harga Beli";
            dgvKdr.Columns[5].HeaderText = "Harga Jual";
            dgvKdr.Columns[6].HeaderText = "Jumlah";
            dgvKdr.Columns[7].HeaderText = "Supplier";
            dgvKdr.Columns[8].HeaderText = "Jenis Kendaraan";
            dgvKdr.Columns[9].HeaderText = "Status";
            

            foreach (DataGridViewColumn colm in dgvKdr.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvKdr.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKdr.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvKdr.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvKdr.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKdr.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            dgvKdr.Columns[5].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

            dgvKdr.BorderStyle = BorderStyle.None;
            dgvKdr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKdr.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKdr.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKdr.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKdr.BackgroundColor = Color.White;

            dgvKdr.EnableHeadersVisualStyles = false;
            dgvKdr.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKdr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKdr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }

        private void TxtJumlah_TextChanged(object sender, EventArgs e)
        {
           // if (TxtHargaJual.Text == "")
           // {
             //   return;
           // }
           // else
           // {
            //    TxtHargaJual.Text = string.Format("{0:n0}", double.Parse(TxtHargaJual.Text));
             //   TxtHargaJual.SelectionStart = TxtHargaJual.Text.Length;
           // }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtMerek.Text == "" || TxtWarna.Text == "" || cbJenis.Text == " - PILIH JENIS -" ||
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
                    string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionstring);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_Deletekendaraan]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_kdr", id);

                    try
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus", "Information",
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
        }
        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
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
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 2;

                    sqlCon.Close();
                }
                else
                {
                    num = 2;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(3, '0');
            return result;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (lbJudul.Text == "TAMBAH KENDARAAN")
            {
                if (TxtMerek.Text == "" || TxtWarna.Text == "" || cbJenis.Text == " - PILIH JENIS -" ||
                    TxtHargaBeli.Text == "" || TxtJumlah.Text == "" || cmbSup.Text == " - PILIH SUPPLIER -")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Information!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   // String id = Program.autogenerateID("MBL-", "sp_IdBus");
                   // IdOtomatis a = new IdOtomatis();
                    //string sp = "sp_IdKendaraan";
                    //a.setID("KDR", sp);
                    //string id = a.getID();
                  string query = "select top 1 id_kdr from tbKendaraan order by id_kdr desc";
                  id = autogenerateID("KDR", query);

                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionstring);
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_InputKendaraan]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_kdr", id);
                    insert.Parameters.AddWithValue("merek_kdr", TxtMerek.Text);
                    insert.Parameters.AddWithValue("warna", TxtWarna.Text);
                    string hargaBeli = Program.toAngka(TxtHargaBeli.Text).ToString();
                    insert.Parameters.AddWithValue("harga_beli", hargaBeli);
                    string hargaJual = Program.toAngka(TxtHargaJual.Text).ToString();
                    insert.Parameters.AddWithValue("harga_jual", hargaJual);
                    insert.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
                    insert.Parameters.AddWithValue("id_supplier", cmbSup.SelectedValue);
                    insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", cbJenis.Text);
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
                        MessageBox.Show("Unable to Input: " + ex.Message);
                    }
                }
            }
            else
            {
                if (TxtMerek.Text == "" || TxtWarna.Text == "" || cbJenis.Text == " - PILIH JENIS -" ||
                    TxtHargaBeli.Text == "" || TxtJumlah.Text == "" || cmbSup.Text == " - PILIH SUPPLIER -")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionstring);
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand update = new SqlCommand("[sp_Updatekdr]", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("id_kdr", id);
                    update.Parameters.AddWithValue("merek_kdr", TxtMerek.Text);
                    update.Parameters.AddWithValue("warna", TxtWarna.Text);
                    string hargaBeli = Program.toAngka(TxtHargaBeli.Text).ToString();
                    update.Parameters.AddWithValue("harga_beli", hargaBeli);
                    string hargaJual = Program.toAngka(TxtHargaJual.Text).ToString();
                    update.Parameters.AddWithValue("harga_jual", hargaJual);
                    update.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
                    update.Parameters.AddWithValue("id_supplier", cmbSup.SelectedValue);
                    update.Parameters.AddWithValue("Kode_Jenis_Kendaraan", cbJenis.Text);
                    update.Parameters.AddWithValue("status", cbStatus.Text);

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
        }

        private void dgvBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH Bus")
            {

            }
            else
            {
            }
        }

       

       

        private void TxtHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void dgvBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbJudul_Click(object sender, EventArgs e)
        {

        }

        private void dgvKdr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CultureInfo culture = new CultureInfo("id-ID");

                cbJenis.Enabled = true;
                TxtWarna.Enabled = true;
                TxtHargaBeli.Enabled = true;
                TxtHargaJual.Enabled = true;
                TxtJumlah.Enabled = true;
                cmbSup.Enabled = true;
                cbStatus.Enabled = true;

                DataGridViewRow row = this.dgvKdr.Rows[e.RowIndex];
                id = row.Cells[1].Value.ToString();
                TxtMerek.Text = row.Cells[2].Value.ToString();
                TxtWarna.Text = row.Cells[3].Value.ToString();
                String hargabeli = row.Cells[4].Value.ToString();
                hargabeli = Convert.ToDecimal(hargabeli).ToString("c", culture);
                String hargajual = row.Cells[5].Value.ToString();
                hargajual = Convert.ToDecimal(hargajual).ToString("c", culture);
                TxtHargaBeli.Text = hargabeli.Replace("Rp", "");
                TxtHargaJual.Text = hargajual.Replace("Rp", "");
                TxtJumlah.Text = row.Cells[6].Value.ToString();
                cmbSup.Text = row.Cells[7].Value.ToString();
                cbJenis.Text = row.Cells[8].Value.ToString();
                cbStatus.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvKdr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

