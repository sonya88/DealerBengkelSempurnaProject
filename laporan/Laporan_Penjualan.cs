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
using Dealer_BengkelSempurna.laporan;

namespace Dealer_BengkelSempurna.laporan
{
    public partial class Laporan_Penjualan : Form
    {
        Timer timer = new Timer();

        public Laporan_Penjualan()
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login Form = new login();
            Form.Show();
        }

        private void Laporan_Penjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dealerBengkelSempurna.Penjualan' table. You can move, or remove it, as needed.
           // this.penjualan1TableAdapter.Fill(this.pROJEK8.Penjualan1);
            // TODO: This line of code loads data into the 'laporan.Penjualan' table. You can move, or remove it, as needed.
            // this.penjualanTableAdapter.Fill(this.laporan.Penjualan);
            // TODO: This line of code loads data into the 'dealerBengkelSempurnaDataSet2.TranPenjualan' table. You can move, or remove it, as needed.
            //this.tPenjualanTableAdapter1.Fill(this.dealerBengkelSempurnaDataSet.TransPenjualan, awal, akhir);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void dateAwal_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;

            this.penjualan1TableAdapter.Fill(this.pROJEK8.Penjualan1, awal, akhir);
            // this.penjualanTableAdapter.Fill(this.dealerBengkelSempurna.Penjualan, awal, akhir);
            this.reportViewer1.RefreshReport();
        }

        private void dateAkhir_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;
            this.penjualan1TableAdapter.Fill(this.pROJEK8.Penjualan1, awal, akhir);
            //this.penjualanTableAdapter.Fill(this.dealerBengkelSempurna.Penjualan);
            this.reportViewer1.RefreshReport();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnLapPembelian_Click(object sender, EventArgs e)
        {
            LaporanPembelian lap = new LaporanPembelian();
            lap.Show();
            this.Hide();
        }

        private void BtnLapPenjualan_Click(object sender, EventArgs e)
        {
            LaporanReturn r = new LaporanReturn();
            r.Show();
            this.Hide();
        }

        private void BtnLapRetur_Click(object sender, EventArgs e)
        {
            LaporanReturn r = new LaporanReturn();
            r.Show();
            this.Hide();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            master_manager r = new master_manager();
            r.Show();
            this.Hide();
        }
    }
    }

