using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Dealer_BengkelSempurna.laporan
{
    public partial class LaporanPembelian : Form
    {
        Timer timer = new Timer();
        public LaporanPembelian()
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

        private void LaporanPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laporan.Pembelian' table. You can move, or remove it, as needed.
           
           
            this.reportViewer1.RefreshReport();
        }

        private void dateAwal_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;


            this.pembelianTableAdapter.Fill(this.laporan.Pembelian, awal, akhir);
            this.reportViewer1.RefreshReport();
        }

        private void dateAkhir_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;


            this.pembelianTableAdapter.Fill(this.laporan.Pembelian, awal, akhir);
            this.reportViewer1.RefreshReport();
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

        private void BtnLapPenjualan_Click(object sender, EventArgs e)
        {
            Laporan_Penjualan r = new Laporan_Penjualan();
            r.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void BtnKonfirRetur_Click(object sender, EventArgs e)
        {
            laporan.RDLC.KonfirmasiRetur r = new RDLC.KonfirmasiRetur();
            r.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            master_manager r = new master_manager();
            r.Show();
            this.Hide();
        }
    }
}
