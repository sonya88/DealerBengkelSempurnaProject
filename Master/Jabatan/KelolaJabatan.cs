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
using Dealer_BengkelSempurna.Master.Kendaraan;
using Dealer_BengkelSempurna.Master.JenisSukuCadang;
using Dealer_BengkelSempurna.Master.JenisKendaraan;
using Dealer_BengkelSempurna.Master.Karyawan;
using Dealer_BengkelSempurna.Master.Supplier;
//using Dealer_BengkelSempurna.Master.SukuCadang;
using Dealer_BengkelSempurna.Master.Bus;
using Dealer_BengkelSempurna.Master.Kendaraan;
using System.Text.RegularExpressions;

namespace Dealer_BengkelSempurna.Master
{
    public partial class KelolaJabatan : Form
    {
        String id;
        Timer timer = new Timer();

        public KelolaJabatan()
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
            TxtGaji.Text = "";
            TxtDeskripsi.Text = "";


        }
        private void KelolaJabatan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.ViewKelolaJabatan' table. You can move, or remove it, as needed.
            this.viewKelolaJabatanTableAdapter.Fill(this.pROJEK8.ViewKelolaJabatan);
            // TODO: This line of code loads data into the 'pROJEK8.ViewKelolaJabatan' table. You can move, or remove it, as needed.
            this.viewKelolaJabatanTableAdapter.Fill(this.pROJEK8.ViewKelolaJabatan);
            RefreshDg();
            BtnHapus.Enabled = false;
            BtnUbah.Enabled = false;
            
        }
        public void RefreshDg()
        {

            this.viewKelolaJabatanTableAdapter.Fill(this.pROJEK8.ViewKelolaJabatan);
            dgvPosisi.Columns[2].DefaultCellStyle.Format = "Rp #,###";

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
        private void BtnSimpan_Click(object sender, EventArgs e)
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
                        string query = "select top 1 id_jabatan from Jabatan order by id_jabatan desc";
                      id = autogenerateID("JBT00", query);
                        //String id = Program.autogenerateID("ROLE-", "sp_IdPosisi");
                      // autogenerateID a = new autogenerateID();
                        //string sp = "sp_IdJabatan";
                         //a.setID("JBT", sp);
                        //id = a.getID();
                    
                    string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                        SqlConnection connection = new SqlConnection(connectionstring);

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlParameter param = new SqlParameter();

                        SqlCommand insert = new SqlCommand("[sp_InputJabatan]", connection);
                        insert.CommandType = CommandType.StoredProcedure;

                        insert.Parameters.AddWithValue("id_jabatan", id);
                        insert.Parameters.AddWithValue("nama", TxtDeskripsi.Text);
                        string GAJI = Program.toAngka(TxtGaji.Text).ToString();
                        insert.Parameters.AddWithValue("gaji", GAJI);

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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (TxtDeskripsi.Text == "" || TxtGaji.Text == "")
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

                    SqlCommand delete = new SqlCommand("[sp_Deletejabatan]", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("id_jabatan", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        MessageBox.Show("data berhasil dihapus", "Information",
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
            BtnUbah.Enabled = true;
            BtnHapus.Enabled = true;
            try
            {
                CultureInfo culture = new CultureInfo("id-ID");

                TxtGaji.Enabled = true;
               

                DataGridViewRow row = this.dgvPosisi.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                TxtDeskripsi.Text = row.Cells[1].Value.ToString();
                TxtGaji.Text = row.Cells[2].Value.ToString();
                String gaji = row.Cells[2].Value.ToString();
                gaji = Convert.ToDecimal(gaji).ToString("c", culture);
                TxtGaji.Text = gaji.Replace("Rp", "");
            }
            catch (Exception ex)
            {

            }
        }

        private void lbJudul_Click(object sender, EventArgs e)
        {

        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (TxtDeskripsi.Text == "" || TxtGaji.Text == "")
            {
                MessageBox.Show("Data ada yang kosong!!", "Warning!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                {
                string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand update = new SqlCommand("[sp_Updatejabatan]", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("id_jabatan", id);
                update.Parameters.AddWithValue("nama_jabatan", TxtDeskripsi.Text);
                string GAJI = Program.toAngka(TxtGaji.Text).ToString();
                update.Parameters.AddWithValue("gaji", GAJI);

                try
                {
                    //transaction.Commit();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //RefreshDg();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.Message);
                }
                RefreshDg();
                    
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtDeskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void TxtGaji_KeyPress(object sender, KeyPressEventArgs e )
        {
            
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshDg();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtGaji_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void TxtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void dgvPosisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbWakt_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaryawan_Click(object sender, EventArgs e)
        {
            karyawan karyawan = new karyawan();
            karyawan.Show();
            this.Hide();
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

        private void BtnMobil_Click(object sender, EventArgs e)
        {
            
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
          
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            admin_master adm = new admin_master();
            adm.Show();
            this.Hide();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            try
            {
                // string query = "select * from Pelanggan where id_pelanggan='" + txtCariMember.Text + "'";
                BindingSource bindingSource1 = new BindingSource();
            DataTable st = new DataTable();
            string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand search = new SqlCommand("sp_CariJabatan", connection);
                search.CommandType = CommandType.StoredProcedure;
            connection.Open();
            search.Parameters.AddWithValue("@cari", txtCari.Text.Trim());
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
            dgvPosisi.Columns[0].HeaderCell.Value = "ID Jabatan";
            dgvPosisi.Columns[1].HeaderCell.Value = "Nama";
            dgvPosisi.Columns[2].HeaderCell.Value = "Gaji";
            dgvPosisi.Columns[0].Width = 100;
            dgvPosisi.Columns[1].Width = 100;
            dgvPosisi.Columns[2].Width = 125;
            //dgvPosisi.Columns[3].Width = 150;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }
        private String ToRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }
        private int ToAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void TxtGaji_Leave(object sender, EventArgs e)
        {
            int uang = Int32.Parse(TxtGaji.Text);
            TxtGaji.Text = ToRupiah(uang);
        }
    }
    }

