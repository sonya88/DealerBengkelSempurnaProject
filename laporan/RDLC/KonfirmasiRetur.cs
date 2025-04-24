using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna.laporan.RDLC
{
    public partial class KonfirmasiRetur : Form
    {

        public string IdRetur;
        public string TanggalRetur;
        public string Keterangan;
        public string IdPelanggan;
        public string KodePelanggan;
        public string Status;
        int i;

        public KonfirmasiRetur(string IdRetur, string TanggalRetur, string Keterangan, string IdPelanggan, string Status, string KodePelanggan )
        {
            InitializeComponent();
            this.IdRetur = IdRetur;
            this.TanggalRetur = TanggalRetur;
            this.Keterangan = Keterangan;
            this.IdPelanggan = IdPelanggan;
            this.Status = Status;
            this.KodePelanggan = KodePelanggan;
            tampilData();
        }

        public KonfirmasiRetur()
        {
            InitializeComponent();
            
        }

        

        public void tampilData()
        {
            txtIDRetur.Enabled = false;
            txtTanggal.Enabled = false;
            txtKet.Enabled = false;
            txtKar.Enabled = false;
            txtMbr.Enabled = false;
            txtStatus.Enabled = false;

            txtIDRetur.Text = IdRetur;
            txtTanggal.Text = TanggalRetur;
            txtKet.Text = Keterangan;
            txtKar.Text = IdPelanggan;
            txtMbr.Text = KodePelanggan;
            txtStatus.Text = Status;
        }

        private void KonfirmasiRetur_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Apakah anda yakin?", "Information",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("[sp_UpdateRetur]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                string setuju = "Disetujui";
                insert.Parameters.AddWithValue("status", setuju);
                insert.Parameters.AddWithValue("id_retur", txtIDRetur.Text);

                try
                {
                    //transaction.Commit();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    i = 1;
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.Message);
                }
            }
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Apakah anda yakin?", "Information",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                string connectionstring = "integrated security = true; data source =LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param = new SqlParameter();

                SqlCommand insert = new SqlCommand("[sp_UpdateRetur]", connection);
                insert.CommandType = CommandType.StoredProcedure;

                string ditolak = "Ditolak";
                insert.Parameters.AddWithValue("Status", ditolak);
                insert.Parameters.AddWithValue("id_retur", txtIDRetur.Text);

                try
                {
                    //transaction.Commit();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    i = 2;

                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

