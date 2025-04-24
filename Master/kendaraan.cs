using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna.Master
{
    public partial class kendaraan : Form
    { 
        //---Server Umum---
        string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
        String id;

        Timer timer = new Timer();
        public kendaraan()
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
            lbWakt.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
        private void BtnTambah_Click(object sender, EventArgs e)
        {

        }

        private void kendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter.Fill(this.pROJEK8.tSupplier);
            // TODO: This line of code loads data into the 'pROJEK8.JenisKendaraan' table. You can move, or remove it, as needed.
            this.jenisKendaraanTableAdapter.Fill(this.pROJEK8.JenisKendaraan);

        }
    }
}
