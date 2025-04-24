using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna.laporan
{
    public partial class LaporanReturn : Form
    {
        public LaporanReturn()
        {
            InitializeComponent();
        }

        private void dateAwal_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;


            this.returPembelianTableAdapter.Fill(this.laporan.ReturPembelian, awal, akhir);
            this.reportViewer1.RefreshReport();
        }

        private void dateAkhir_ValueChanged(object sender, EventArgs e)
        {
            string awal = dateAwal.Text;
            string akhir = dateAkhir.Text;


            this.returPembelianTableAdapter.Fill(this.laporan.ReturPembelian, awal, akhir);
            this.reportViewer1.RefreshReport();
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

        private void button2_Click(object sender, EventArgs e)
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

        private void BtnKonfirRetur_Click(object sender, EventArgs e)
        {
            laporan.RDLC.KonfirmasiRetur2 r = new RDLC.KonfirmasiRetur2();
            r.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
            login Form = new login();
            Form.Show();
        }
    }
}
