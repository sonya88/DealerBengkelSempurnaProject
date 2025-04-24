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

namespace Dealer_BengkelSempurna.laporan.RDLC
{
    public partial class KonfirmasiRetur2 : Form
    {
        Timer timer = new Timer();

        public KonfirmasiRetur2()
        {
            InitializeComponent();
           
        }

        public void RefreshDg()
        {
            this.viewReturTableAdapter.Fill(this.laporan1.viewRetur);


            foreach (DataGridViewColumn colm in dgvDataRetur.Columns)
            {
                colm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colm.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvDataRetur.BorderStyle = BorderStyle.None;
            dgvDataRetur.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDataRetur.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDataRetur.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDataRetur.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDataRetur.BackgroundColor = Color.White;

            dgvDataRetur.EnableHeadersVisualStyles = false;
            dgvDataRetur.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDataRetur.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDataRetur.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

         
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataRetur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdRetur, TanggalRetur, Keterangan, IdPelanggan, Status, KodePelanggan;
            int n = dgvDataRetur.CurrentCell.RowIndex;
            if (dgvDataRetur.Rows[n].Cells[5].Value.ToString() == "Disetujui" || dgvDataRetur.Rows[n].Cells[5].Value.ToString() == "Tidak Disetujui")
            {
                MessageBox.Show("Data telah dikonfirmasi", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgvDataRetur.Rows[n].Cells[5].Value.ToString() == "")
            {
                MessageBox.Show("Data kosong!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

               IdRetur = dgvDataRetur.Rows[n].Cells[0].Value.ToString();
                TanggalRetur = dgvDataRetur.Rows[n].Cells[1].Value.ToString();
                Keterangan = dgvDataRetur.Rows[n].Cells[2].Value.ToString();
                IdPelanggan = dgvDataRetur.Rows[n].Cells[3].Value.ToString();
                KodePelanggan = dgvDataRetur.Rows[n].Cells[4].Value.ToString();
                Status = dgvDataRetur.Rows[n].Cells[5].Value.ToString();
              

                KonfirmasiRetur retur = new KonfirmasiRetur(IdRetur, TanggalRetur, Keterangan, IdPelanggan, Status, KodePelanggan);
                retur.Show();
                this.Hide();
            }
        }

        private void KonfirmasiRetur2_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvDataRetur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KonfirmasiRetur2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laporan1.viewRetur' table. You can move, or remove it, as needed.
            this.viewReturTableAdapter.Fill(this.laporan1.viewRetur);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           KonfirmasiRetur lap = new KonfirmasiRetur();
            lap.Show();
            this.Hide();
        }
    }
}
