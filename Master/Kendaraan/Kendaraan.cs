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

namespace Dealer_BengkelSempurna.Master.Kendaraan
{
    public partial class Kendaraan : Form
    {
        //---Server Umum---
        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
        String id;

        Timer timer = new Timer();
        public Kendaraan()
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

        }

        private void Kendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.JenisKendaraan' table. You can move, or remove it, as needed.
            this.jenisKendaraanTableAdapter.Fill(this.pROJEK8.JenisKendaraan);
            // TODO: This line of code loads data into the 'pROJEK8.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter.Fill(this.pROJEK8.tSupplier);
            

            RefreshDg();
            cbSupplier.Text = " - PILIH SUPPLIER -";
            cbJen.Text = " - PILIH JENIS -";
            BtnHapus.Visible = true;
            lbledit.Visible = false;
        }
        private void Clear()
        {
            TxtMerek.Text = "";
            TxtWarna.Text = "";
            cbJen.Text = " - PILIH JENIS -";
            TxtHargaBeli.Text = "";
            TxtHargaJual.Text = "";
            TxtJumlah.Text = "";
            cbSupplier.Text = " - PILIH SUPPLIER -";

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

        private void BtnSimpan_Click(object sender, EventArgs e)
        {

            string query = "select top 1 id_kdr from tbKendaraan order by id_kdr desc";
            id = autogenerateID("KDR", query);
            //String id = Program.autogenerateID("MTR-", "sp_IdKendaraan");
            // IdOtomatis a = new IdOtomatis();
            // string sp = "sp_IdKendaraan";
            //a.setID("KDR-", sp);
            // string id = a.getID();

            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter param = new SqlParameter();

            SqlCommand insert = new SqlCommand("[sp_InputKendaraan]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_kdr", id);
            insert.Parameters.AddWithValue("merek_kdr", TxtMerek.Text);
            insert.Parameters.AddWithValue("warna", TxtWarna.Text);
            
            insert.Parameters.AddWithValue("harga_beli", TxtHargaBeli.Text);
            insert.Parameters.AddWithValue("harga_jual", TxtHargaJual.Text);
            insert.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
            insert.Parameters.AddWithValue("id_supplier", cbSupplier.SelectedValue);
            insert.Parameters.AddWithValue("status", "Tersedia");
            insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", cbJen.SelectedValue);
            

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
    
        


        public void RefreshDg()
        {
            Clear();
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_dgvKendaraan", connection);
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

            dgvkdr.DataSource = dt;
            dgvkdr.Columns[1].HeaderText = "ID";
            dgvkdr.Columns[2].HeaderText = "Merek";
            dgvkdr.Columns[3].HeaderText = "Warna";
            
            dgvkdr.Columns[4].HeaderText = "Harga Beli";
            dgvkdr.Columns[5].HeaderText = "Harga Jual";
            dgvkdr.Columns[6].HeaderText = "Jumlah";
            dgvkdr.Columns[7].HeaderText = "Supplier";
            dgvkdr.Columns[8].HeaderText = "Status";
            dgvkdr.Columns[9].HeaderText = "Jenis";

            this.dgvkdr.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvkdr.Columns["harga_beli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvkdr.Columns["harga_jual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvkdr.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvkdr.Columns[4].DefaultCellStyle.Format = "Rp #,###";
            dgvkdr.Columns[5].DefaultCellStyle.Format = "Rp #,###";
            connection.Close();

            dgvkdr.BorderStyle = BorderStyle.None;
            dgvkdr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvkdr.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvkdr.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvkdr.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvkdr.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvkdr.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvkdr.EnableHeadersVisualStyles = false;
            dgvkdr.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvkdr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvkdr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
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

                    SqlCommand delete = new SqlCommand("[sp_DeleteKendaraan]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_kdr", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus", "Information",
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

        private void BtnUbah_Click(object sender, EventArgs e)
        {
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvkdr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvkdr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CultureInfo culture = new CultureInfo("id-ID");

                cbJen.Enabled = true;
                TxtWarna.Enabled = true;
                TxtHargaBeli.Enabled = true;
                TxtHargaJual.Enabled = true;
                TxtJumlah.Enabled = true;
                cbSupplier.Enabled = true;
                cbStatus.Enabled = true;

                DataGridViewRow row = this.dgvkdr.Rows[e.RowIndex];
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
                cmbsu.Text = row.Cells[7].Value.ToString();
                cbStatus.Text = row.Cells[8].Value.ToString();
                cbJen.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void BtnUbah_Click_1(object sender, EventArgs e)
        {
          
                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("[sp_Updatekendaraan]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_kdr", id);
                insert.Parameters.AddWithValue("merek_kdr", TxtMerek.Text);
                insert.Parameters.AddWithValue("warna", TxtWarna.Text);
               
                string hargaBeli = Program.toAngka(TxtHargaBeli.Text).ToString();
               
                insert.Parameters.AddWithValue("harga_beli",TxtHargaBeli.Text);
                insert.Parameters.AddWithValue("harga_jual", TxtHargaJual.Text);
               insert.Parameters.AddWithValue("jumlah", TxtJumlah.Text);
                insert.Parameters.AddWithValue("id_supplier", cmbsu.SelectedValue);
                insert.Parameters.AddWithValue("status", cbStatus.Text);
            insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", cbJen.SelectedValue);

            try
                {
                    //transaction.Commit();
                    insert.ExecuteNonQuery();
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
