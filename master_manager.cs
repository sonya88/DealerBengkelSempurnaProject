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
using System.Windows.Forms;
using Dealer_BengkelSempurna.laporan;

namespace Dealer_BengkelSempurna
{
    public partial class master_manager : Form
    {
        public master_manager()
        {
            InitializeComponent();
        }

        private void BtnLapPembelian_Click(object sender, EventArgs e)
        {
            LaporanPembelian lap = new LaporanPembelian();
            lap.Show();
            this.Hide();
        }

        private void BtnLapRetur_Click(object sender, EventArgs e)
        {
            LaporanReturn r = new LaporanReturn();
            r.Show();
            this.Hide();
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
                    //graphPenjualan.Series["Jual"].Points.AddXY(rdr.GetString(0), rdr.GetInt32(1));
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
                    //graphSukuCadang.Series["SukuCadang"].Points.AddXY(rdr.GetString(1), rdr.GetInt32(0));
                }
                rdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void master_manager_Load(object sender, EventArgs e)
        {

            lbUser.Text = lbUser.Text + Thread.CurrentPrincipal.Identity.Name;
            

           
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void BtnLapPenjualan_Click(object sender, EventArgs e)
        {
            Laporan_Penjualan l = new Laporan_Penjualan();
            l.Show();
            this.Hide();
        }
    }
}
