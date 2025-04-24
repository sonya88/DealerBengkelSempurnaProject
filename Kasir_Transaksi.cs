using Dealer_BengkelSempurna.transaksi.PEMBELIAN;
using Dealer_BengkelSempurna.transaksi.Transaksi_Penjualan;
using Dealer_BengkelSempurna.transaksi.Retur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Dealer_BengkelSempurna
{
    public partial class Kasir_Transaksi : Form
    {
        Timer timerJam = new Timer();
        public Kasir_Transaksi()
        {
            InitializeComponent();

            timerJam.Tick += new EventHandler(timer_Tick);
            //1000 = 1 detik
            timerJam.Interval = (1000) * (1);
            timerJam.Enabled = true;
            timerJam.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbWaktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void BtnPembelian_Click(object sender, EventArgs e)
        {
            pembelian p = new pembelian();
            p.Show();
            this.Hide();
        }

        private void BtnPenjualan_Click(object sender, EventArgs e)
        {
            TransaksiPenjualan p = new TransaksiPenjualan();
            p.Show();
            this.Hide();
        }

        private void BtnRetur_Click(object sender, EventArgs e)
        {
            Retur r = new Retur();
            r.Show();
            this.Hide();
        }

        private void lblKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //Graph Penjualan Motor
        private void fillJualKendaraan()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Program.koneksi());
                DataSet ds = new DataSet();

                SqlCommand query = new SqlCommand("SELECT TOP 3 COUNT(id_jenisBarang) AS Total, m.merek_kdr FROM Penjualan P " +
                    "INNER JOIN tbKendaraan M ON P.id_jenisBarang = M.id_kdr GROUP BY merek_kdr ORDER BY Total DESC", connection);
                connection.Open();
                SqlDataReader rdr = query.ExecuteReader();
                while (rdr.Read())
                {
                    //graphKendraaan.Series["tbKendaraan"].Points.AddXY(rdr.GetString(1), rdr.GetInt32(0));
                }
                rdr.Close();
                connection.Close();

            }
            catch (Exception ex)
            {

            }
        }
        public void tampilService()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM tService", connection);
                //lblServices.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void isiPendapatan()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT SUM(total_harga) AS PENDAPATAN FROM Penjualan", connection);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
               

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void tampilKaryawan()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM tKaryawan", connection);
                //lblKaryawan.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void tampilPelanggan()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM Pelanggan", connection);
                //lblMember.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void tampilKdr()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM tbKendaraan", connection);
                //lblkdr.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void tampilSuku()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM tSukucadang", connection);
                //lblSukuCadang.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void tampilSupplier()
        {
            SqlConnection connection = new SqlConnection(Program.koneksi());

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM tSupplier", connection);
                //lblSupplier.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Graph Keseluruhan Penjualan
        private void fillGraph()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Program.koneksi());
                DataSet ds = new DataSet();

                SqlCommand query = new SqlCommand("SELECT id_jenisBarang AS tKategoriBarangPem, Total FROM (SELECT TOP 3 COUNT(id_jenisBarang)" +
                    " AS Total, id_jenisBarang FROM Penjualan GROUP BY id_jenisBarang ORDER BY Total DESC) AS A", connection);
                connection.Open();
                SqlDataReader rdr = query.ExecuteReader();
                while (rdr.Read())
                {
                    ////graphPenjualan.Series["Jual"].Points.AddXY(rdr.GetString(0), rdr.GetInt32(1));
                }
                rdr.Close();
                connection.Close();

            }
            catch (Exception ex)
            {

            }
        }

        //Graph Penjualan SukuCadang
        private void fillJualSukuCadang()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Program.koneksi());
                DataSet ds = new DataSet();

                SqlCommand query = new SqlCommand("SELECT TOP 3 COUNT(id_jenisBarang) AS Total, T.merek_sukucadang FROM Penjualan P INNER JOIN tSukucadang T ON P.id_jenisBarang = T.id_sukucadang GROUP BY merek_sukucadang ORDER BY Total DESC", connection);
                connection.Open();
                SqlDataReader rdr = query.ExecuteReader();
                while (rdr.Read())
                {
                    ////graphSukuCadang.Series["SukuCadang"].Points.AddXY(rdr.GetString(1), rdr.GetInt32(0));
                }
                rdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Kasir_Transaksi_Load(object sender, EventArgs e)
        {
            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            login Form = new login();
            Form.Show();
            this.Hide();
        }
    }
}
