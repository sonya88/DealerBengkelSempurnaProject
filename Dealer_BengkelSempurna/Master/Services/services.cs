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

namespace Dealer_BengkelSempurna.Master.Services
{
    public partial class services : Form
    {
        String id;

        Timer timer = new Timer();
        public services()
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
        private void services_Load(object sender, EventArgs e)
        {
            RefreshDg();
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
          
            SqlCommand view = new SqlCommand("sp_dgvService", connection);
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

            dgvJenisSer.DataSource = dt;
            dgvJenisSer.Columns[1].HeaderText = "ID";
            dgvJenisSer.Columns[2].HeaderText = "Jenis Servis";
            dgvJenisSer.Columns[3].HeaderText = "Harga";
            dgvJenisSer.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvJenisSer.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvJenisSer.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJenisSer.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvJenisSer.BorderStyle = BorderStyle.None;
            dgvJenisSer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvJenisSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvJenisSer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvJenisSer.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvJenisSer.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvJenisSer.EnableHeadersVisualStyles = false;
            dgvJenisSer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvJenisSer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvJenisSer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
            txtHarga.Enabled = true;
            cbStatus.Enabled = false;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            lbJudul.Text = "TAMBAH SERVICE";
            BtnHapus.Visible = false;
            lbStatus.Visible = false;
            cbStatus.Visible = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
            txtHarga.Enabled = false;
            cbStatus.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            lbJudul.Text = "UBAH SERVICE";
            BtnHapus.Visible = true;
            lbStatus.Visible = true;
            cbStatus.Visible = true;
            cbStatus.Text = " - PILIH STATUS -";
        }


        private void Clear()
        {
            txtJenisSer.Text = "";
            txtHarga.Text = "";
            cbStatus.Text = " - PILIH STATUS -";

            if (lbJudul.Text == "TAMBAH SERVICE")
            {

            }
            else
            {
                txtHarga.Enabled = false;
                cbStatus.Enabled = false;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (txtJenisSer.Text == "" || txtHarga.Text == "" || cbStatus.Text == " - Pilih Status -")
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

                    SqlCommand delete = new SqlCommand("[sp_DeleteService]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_service", id);

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
                        MessageBox.Show("Unable to delete: " + ex.Message);
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
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
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
            if (lbJudul.Text == "TAMBAH SERVICE")
            {
                if (txtJenisSer.Text == "" || txtHarga.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "select top 1 id_service from tService order by id_service desc";
                    id = autogenerateID("SRV-", query);

                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                    SqlConnection connection = new SqlConnection(connectionstring);
                 
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_InputService]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("id_service", id);
                    insert.Parameters.AddWithValue("jenis_service", txtJenisSer.Text);
                    string harga = Program.toAngka(txtHarga.Text).ToString();
                    insert.Parameters.AddWithValue("harga", harga);
                    insert.Parameters.AddWithValue("status", "Tersedia");

                    try
                    {
                        //transaction.Commit();
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan", "Information",
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
                if (txtJenisSer.Text == "" || txtHarga.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                    SqlConnection connection = new SqlConnection(connectionstring);
                    
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand update = new SqlCommand("[sp_UpdateService]", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("id_service", id);
                    update.Parameters.AddWithValue("jenis_service", txtJenisSer.Text);
                    string harga = Program.toAngka(txtHarga.Text).ToString();
                    update.Parameters.AddWithValue("harga", harga);
                    update.Parameters.AddWithValue("status", cbStatus.SelectedItem);

                    try
                    {
                        //transaction.Commit();
                        update.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diupdate", "Information",
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
        }

        private void dgvJenisSer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH SERVICE")
            {

            }
            else
            {
                try
                {
                    CultureInfo culture = new CultureInfo("id-ID");

                    txtJenisSer.Enabled = true;
                    txtHarga.Enabled = true;
                    cbStatus.Enabled = true;

                    DataGridViewRow row = this.dgvJenisSer.Rows[e.RowIndex];
                    id = row.Cells[1].Value.ToString();
                    txtJenisSer.Text = row.Cells[2].Value.ToString();
                    String harga = row.Cells[3].Value.ToString();
                    harga = Convert.ToDecimal(harga).ToString("c", culture);
                    txtHarga.Text = harga.Replace("Rp", "");
                    cbStatus.Text = row.Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_ServiceTersedia", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter(view);
            DataTable dt = new DataTable();

            adapt.Fill(dt);

            DataColumn col = dt.Columns.Add("No", typeof(System.Int32));
            col.SetOrdinal(0);
            int a = 1;
            foreach (DataRow r in dt.Rows)
            {
                r["No"] = a;
                a++;
            }

            dgvJenisSer.DataSource = dt;
            dgvJenisSer.Columns[1].HeaderText = "ID";
            dgvJenisSer.Columns[2].HeaderText = "Jenis Servis";
            dgvJenisSer.Columns[3].HeaderText = "Harga";
            dgvJenisSer.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvJenisSer.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvJenisSer.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJenisSer.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvJenisSer.BorderStyle = BorderStyle.None;
            dgvJenisSer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvJenisSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvJenisSer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvJenisSer.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvJenisSer.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvJenisSer.EnableHeadersVisualStyles = false;
            dgvJenisSer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvJenisSer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvJenisSer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbTidakAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand view = new SqlCommand("sp_ServiceTidakTersedia", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter(view);
            DataTable dt = new DataTable();

            adapt.Fill(dt);

            DataColumn col = dt.Columns.Add("No", typeof(System.Int32));
            col.SetOrdinal(0);
            int a = 1;
            foreach (DataRow r in dt.Rows)
            {
                r["No"] = a;
                a++;
            }

            dgvJenisSer.DataSource = dt;
            dgvJenisSer.Columns[1].HeaderText = "ID";
            dgvJenisSer.Columns[2].HeaderText = "Jenis Servis";
            dgvJenisSer.Columns[3].HeaderText = "Harga";
            dgvJenisSer.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvJenisSer.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvJenisSer.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJenisSer.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvJenisSer.BorderStyle = BorderStyle.None;
            dgvJenisSer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvJenisSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvJenisSer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvJenisSer.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvJenisSer.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvJenisSer.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvJenisSer.EnableHeadersVisualStyles = false;
            dgvJenisSer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvJenisSer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvJenisSer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }
    }
}
