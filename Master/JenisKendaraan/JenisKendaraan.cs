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
using Dealer_BengkelSempurna.Master.Services;
using Dealer_BengkelSempurna.Master.Member;
using Dealer_BengkelSempurna.Master;
using Dealer_BengkelSempurna.Master.JenisSukuCadang;
using Dealer_BengkelSempurna.Master.JenisKendaraan;
using Dealer_BengkelSempurna.Master.Karyawan;
using Dealer_BengkelSempurna.Master.Supplier;
//using Dealer_BengkelSempurna.Master.SukuCadang;
using Dealer_BengkelSempurna.Master.Bus;
using Dealer_BengkelSempurna.Master.Kendaraan;

namespace Dealer_BengkelSempurna.Master.JenisKendaraan
{
    public partial class JenisKendaraan : Form
    {
        String id;
        Universal_Class uv = new Universal_Class();
        Timer timer = new Timer();

        public JenisKendaraan()
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
            lbWakt.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void Clear()
        {
            TxtNamaJenis.Text = "";
            txtDeskripsi.Text = "";


        }

        private void JenisKendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.ViewJenisKendaraan' table. You can move, or remove it, as needed.
            this.viewJenisKendaraanTableAdapter.Fill(this.pROJEK8.ViewJenisKendaraan);
            // TODO: This line of code loads data into the 'pROJEK8.JenisKendaraan' table. You can move, or remove it, as needed.
           // this.jenisKendaraanTableAdapter.Fill(this.pROJEK8.JenisKendaraan);
          
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            BtnHapus.Visible = true;
            lbledit.Visible = false;
        }
        public void RefreshDg()
        {
            this.viewJenisKendaraanTableAdapter.Fill(this.pROJEK8.ViewJenisKendaraan);
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
        class IdOtomatis
        {
            string result;
            public void setID(string firstText, string sp)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection sqlCon = new SqlConnection(connectionstring);
                sqlCon.Open();
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

            result = firstText + num.ToString().PadLeft(4, '0');
            return result;
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
                        string query = "select top 1 Kode_Jenis_Kendaraan from JenisKendaraan order by Kode_Jenis_Kendaraan desc";
                        id = idotomatis("JKD", query);
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

                        SqlCommand insert = new SqlCommand("[sp_InputJenisKendaraan]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", id);
                        insert.Parameters.AddWithValue("Nama_Jenis_Kendaraan", TxtNamaJenis.Text);
                        insert.Parameters.AddWithValue("Detail_Jenis_Kendaraan", txtDeskripsi.Text);


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
    
          

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Clear();
          
            TxtNamaJenis.Enabled = true;
            txtDeskripsi.Enabled = true;
            lbledit.Visible = false;

            BtnSimpan.Text = "SIMPAN";
            BtnHapus.Visible = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
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

                    SqlCommand insert = new SqlCommand("[sp_UpdateJenisKendaraan]", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("Kode_Jenis_Kendaraan", id);
                    insert.Parameters.AddWithValue("Nama_Jenis_Kendaraan", TxtNamaJenis.Text);
                    insert.Parameters.AddWithValue("Detail_Jenis_Kendaraan", txtDeskripsi.Text);


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

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Clear();
           
            TxtNamaJenis.Enabled = false;
            txtDeskripsi.Enabled = false;
            lbledit.Visible = true;

            BtnSimpan.Text = "UBAH";
            BtnHapus.Visible = true;

        }

        private void TxtNamaJenis_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNamaJenis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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

                    SqlCommand delete = new SqlCommand("[sp_DeleteJenisKendaraan]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("Kode_Jenis_Kendaraan", id);

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
                try
                {
                    CultureInfo culture = new CultureInfo("id-ID");

                    TxtNamaJenis.Enabled = true;
                    txtDeskripsi.Enabled = true;

                    DataGridViewRow row = this.dgvPosisi
                        .Rows[e.RowIndex];
                    id = row.Cells[0].Value.ToString();
                    TxtNamaJenis.Text = row.Cells[2].Value.ToString();
                    txtDeskripsi.Text = row.Cells[1].Value.ToString();
                }
                catch (Exception ex)
                {
                }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_master adm = new admin_master();
            adm.Show();
            this.Hide();
        }

        private void BtnKaryawan_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPosisi_Click(object sender, EventArgs e)
        {
            KelolaJabatan jabatan = new KelolaJabatan();
            jabatan.Show();
            this.Hide();
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            services services = new services();
            services.Show();
            this.Hide();
        }

        private void BtnMember_Click(object sender, EventArgs e)
        {
            member member = new member();
            member.Show();
            this.Hide();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            supplier sup = new supplier();
            sup.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Jsc jns = new Jsc();
            jns.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            JenisKendaraan jns = new JenisKendaraan();
            jns.Show();
            this.Hide();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin_master adm = new admin_master();
            adm.Show();
            this.Hide();
        }
    

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // string query = "select * from Pelanggan where id_pelanggan='" + txtCariMember.Text + "'";
                BindingSource bindingSource1 = new BindingSource();
                DataTable st = new DataTable();
                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand search = new SqlCommand("sp_CariJenisKendaraan", connection);
                search.CommandType = CommandType.StoredProcedure;
                connection.Open();
                search.Parameters.AddWithValue("@cari", txtCariID.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dgvPosisi.DataSource = bindingSource1;



                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            dgvPosisi.Columns[0].HeaderCell.Value = "Kode_Jenis_Kendaraan";
            dgvPosisi.Columns[1].HeaderCell.Value = "Nama_Jenis_Kendaraan";
            dgvPosisi.Columns[2].HeaderCell.Value = "Detail_Jenis_Kendaraan";
            dgvPosisi.Columns[0].Width = 100;
            dgvPosisi.Columns[1].Width = 100;
            dgvPosisi.Columns[2].Width = 125;
            //dgvPosisi.Columns[3].Width = 150;
        }

        private void dgvPosisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
