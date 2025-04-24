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

namespace Dealer_BengkelSempurna.JenisSukuCadang
{
    public partial class JenisSukuCadang : Form
    {
        String id;
        Timer timer = new Timer();

        public JenisSukuCadang()
        {
            InitializeComponent();
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
            TxtNamaJenis.Text = "";
            txtDeskripsi.Text = "";


            if (lbJudul.Text == "TAMBAH JENIS SUKUCADANG")
            {

            }
            else
            {
                txtDeskripsi.Enabled = false;

            }
        }

        private void JenisSukuCadang_Load(object sender, EventArgs e)
        {
            RefreshDg();
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            BtnHapus.Visible = true;
            lbledit.Visible = false;
        }
        public void RefreshDg()
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand view = new SqlCommand("sp_dgvJenisSukuCadang", connection);
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
            dgvPosisi.Columns[1].HeaderText = "Kode_Jenis_SukuCadang";
            dgvPosisi.Columns[2].HeaderText = "Nama_Jenis_SukuCadang";
            dgvPosisi.Columns[3].HeaderText = "Detail_Jenis_SukuCadang";


            foreach (DataGridViewColumn colm in dgvPosisi.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }



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

            result = firstText + num.ToString().PadLeft(4, '0');
            return result;
        }
        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog =PROJEK08";
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
            if (lbJudul.Text == "TAMBAH JENIS SUKUCADANG")
            {
                if (txtDeskripsi.Text == "" || TxtNamaJenis.Text == "")
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
                        string query = "select top 1 Kode_Jenis_SukuCadang from JenisSukuCadang order by Kode_Jenis_SukuCadang desc";
                        id = idotomatis("JNB", query);
                        //String id = Program.autogenerateID("ROLE-", "sp_IdPosisi");
                        //IdOtomatis a = new IdOtomatis();
                        //string sp = "sp_IdPosisi";
                        //a.setID("ROLE-", sp);
                        //string id = a.getID();
                        string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                        SqlConnection connection = new SqlConnection(connectionstring);

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("[sp_InputJenisSukuCadang]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("Kode_Jenis_SukuCadang", id);
                        insert.Parameters.AddWithValue("Nama_Jenis_SukuCadang", TxtNamaJenis.Text);
                        insert.Parameters.AddWithValue("Detail_Jenis_SukuCadang", txtDeskripsi.Text);


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
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeskripsi.Text == "" || TxtNamaJenis.Text == "")
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
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionstring);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand insert = new SqlCommand("[sp_UpdateJenisSukuCadang]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("Kode_Jenis_SukuCadang", id);
                    insert.Parameters.AddWithValue("Nama_Jenis_SukuCadang", TxtNamaJenis.Text);
                    insert.Parameters.AddWithValue("Detail_Jenis_SukuCadang", txtDeskripsi.Text);


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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (txtDeskripsi.Text == "" || TxtNamaJenis.Text == "")
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
                    string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                    SqlConnection connection = new SqlConnection(connectionstring);
                    connection.Open();


                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlParameter param = new SqlParameter();

                    SqlCommand delete = new SqlCommand("[sp_DeleteJenisSukuCadang]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("Kode_Jenis_SukuCadang", id);

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

                        TxtNamaJenis.Enabled = true;
                        txtDeskripsi.Enabled = true;

                        DataGridViewRow row = this.dgvPosisi
                            .Rows[e.RowIndex];
                        id = row.Cells[1].Value.ToString();
                        TxtNamaJenis.Text = row.Cells[2].Value.ToString();
                        txtDeskripsi.Text = row.Cells[3].Value.ToString();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }

