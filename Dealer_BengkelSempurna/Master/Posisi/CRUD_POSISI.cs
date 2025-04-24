using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;

namespace Dealer_BengkelSempurna.Master.Posisi
{
    public partial class CRUD_POSISI : Form
    {
        String id;
        Timer timer = new Timer();
        public CRUD_POSISI()
        {

            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            //1000 = 1 detik;
            timer.Interval = (1000) * (1);
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbWaktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void Clear()
        {
            TxtDeskripsi.Text = "";
            TxtGaji.Text = "";
            CbStatus.Text = "-- Pilih Status --";

            if (lbJudul.Text == "TAMBAH POSISI")
            {

            }
            else
            {
                TxtGaji.Enabled = false;
                CbStatus.Enabled = false;
            }
        }


        private void CRUD_POSISI_Load(object sender, EventArgs e)
        {
            RefreshDg();
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            BtnHapus.Visible = false;
            lbledit.Visible = false;
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand view = new SqlCommand("sp_dgvPosisi", connection);
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

            dgvPosisi.DataSource = dt;
            dgvPosisi.Columns[1].HeaderText = "ID";
            dgvPosisi.Columns[2].HeaderText = "Jabatan";
            dgvPosisi.Columns[3].HeaderText = "Gaji";
            dgvPosisi.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvPosisi.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPosisi.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPosisi.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvPosisi.BorderStyle = BorderStyle.None;
            dgvPosisi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPosisi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPosisi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPosisi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPosisi.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvPosisi.EnableHeadersVisualStyles = false;
            dgvPosisi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPosisi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPosisi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =DealerBengkelSempurna";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand sqlCmd;
                int num = 0;
                try
                {
                    sqlCmd = new SqlCommand(sp, connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
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
                    connection.Close();
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
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (lbJudul.Text == "TAMBAH POSISI")
            {
                if (TxtDeskripsi.Text == "" || TxtGaji.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var hasil = MessageBox.Show("Data akan diinput?", "Information",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                       string query = "select top 1 id_posisi from tPosisi order by id_posisi desc";
                        id = autogenerateID("ROLE-", query);
                        //String id = Program.autogenerateID("ROLE-", "sp_IdPosisi");
                        //IdOtomatis a = new IdOtomatis();
                        //string sp = "sp_IdPosisi";
                        //a.setID("ROLE-", sp);
                        //string id = a.getID();
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);
                        
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("[sp_InputPosisi]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("id_posisi", id);
                        insert.Parameters.AddWithValue("deskripsi", TxtDeskripsi.Text);
                        string harga = Program.toAngka(TxtGaji.Text).ToString();
                        insert.Parameters.AddWithValue("gaji", harga);
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
                    else
                    {

                    }
                }
            }
            else
            {
                if (TxtDeskripsi.Text == "" || TxtGaji.Text == "" || CbStatus.Text == "-- Pilih Status --")
                {
                    MessageBox.Show("Data ada yang kosong!!", "Information!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var hasil = MessageBox.Show("Data akan diupdate?", "Information",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
                        SqlConnection connection = new SqlConnection(connectionstring);
                       
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("[sp_UpdatePosisi]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("id_posisi", id);
                        insert.Parameters.AddWithValue("deskripsi", TxtDeskripsi.Text);
                        string harga = Program.toAngka(TxtGaji.Text).ToString();
                        insert.Parameters.AddWithValue("gaji", harga);
                        insert.Parameters.AddWithValue("status", CbStatus.Text);

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
                    else
                    {

                    }
                }
            }
        }

        
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
            lbJudul.Text = "TAMBAH POSISI";
            TxtGaji.Enabled = true;
            CbStatus.Enabled = true;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            BtnHapus.Visible = false;
            lbStatus.Visible = false;
            CbStatus.Visible = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
            lbJudul.Text = "UBAH POSISI";
            TxtGaji.Enabled = false;
            CbStatus.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            BtnHapus.Visible = true;
            lbStatus.Visible = true;
            CbStatus.Visible = true;
            CbStatus.Text = "-- Pilih Status --";
        }

        private void TxtDeskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
            if (TxtDeskripsi.Text == "" || TxtGaji.Text == "" || CbStatus.Text == "-- Pilih Status --")
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

                    SqlCommand delete = new SqlCommand("[sp_DeletePosisi]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_posisi", id);

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
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }
                }
                else
                {

                }
            }
        }
       

        private void dgvPosisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPosisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbJudul.Text == "TAMBAH POSISI")
            {

            }
            else
            {
                try
                {
                    CultureInfo culture = new CultureInfo("id-ID");

                    TxtGaji.Enabled = true;
                    CbStatus.Enabled = true;

                    DataGridViewRow row = this.dgvPosisi.Rows[e.RowIndex];
                    id = row.Cells[1].Value.ToString();
                    TxtDeskripsi.Text = row.Cells[2].Value.ToString();
                    String harga = row.Cells[3].Value.ToString();
                    CbStatus.Text = row.Cells[4].Value.ToString();
                    harga = Convert.ToDecimal(harga).ToString("c", culture);
                    TxtGaji.Text = harga.Replace("Rp", "");
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand view = new SqlCommand("sp_PosisiAktif", connection);
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

            dgvPosisi.DataSource = dt;
            dgvPosisi.Columns[1].HeaderText = "ID";
            dgvPosisi.Columns[2].HeaderText = "Jabatan";
            dgvPosisi.Columns[3].HeaderText = "Gaji";
            dgvPosisi.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvPosisi.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPosisi.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPosisi.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvPosisi.BorderStyle = BorderStyle.None;
            dgvPosisi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPosisi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPosisi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPosisi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPosisi.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvPosisi.EnableHeadersVisualStyles = false;
            dgvPosisi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPosisi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPosisi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void rbTidakAktif_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand view = new SqlCommand("sp_PosisiTidakAktif", connection);
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

            dgvPosisi.DataSource = dt;
            dgvPosisi.Columns[1].HeaderText = "ID";
            dgvPosisi.Columns[2].HeaderText = "Jabatan";
            dgvPosisi.Columns[3].HeaderText = "Gaji";
            dgvPosisi.Columns[4].HeaderText = "Status";

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dgvPosisi.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPosisi.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPosisi.Columns[3].DefaultCellStyle.Format = "Rp #,###.00";
            connection.Close();

            dgvPosisi.BorderStyle = BorderStyle.None;
            dgvPosisi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPosisi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPosisi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPosisi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPosisi.BackgroundColor = Color.White;

            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvPosisi.EnableHeadersVisualStyles = false;
            dgvPosisi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPosisi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPosisi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void TxtGaji_TextChanged(object sender, EventArgs e)
        {
            if (TxtGaji.Text == "")
            {
                return;
            }
            else
            {
                TxtGaji.Text = string.Format("{0:n0}", double.Parse(TxtGaji.Text));
                TxtGaji.SelectionStart = TxtGaji.Text.Length;
            }
        }

        private void TxtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbWaktu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_master Adm_M = new admin_master();
            Adm_M.Show();
            this.Hide();
        }

        private void TxtGaji_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
