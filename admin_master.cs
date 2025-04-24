
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dealer_BengkelSempurna
{
    public partial class admin_master : Form
    {
        public admin_master()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnPosisi_Click(object sender, EventArgs e)
        {
          KelolaJabatan  jabatan = new KelolaJabatan();
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
            Kendaraan mbl = new Kendaraan();
            mbl.Show();
            this.Hide();
        }

        private void BtnKaryawan_Click(object sender, EventArgs e)
        {
            karyawan karyawan = new karyawan();
            karyawan.Show();
            this.Hide();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            supplier sup = new supplier();
            sup.Show();
            this.Hide();
        }

        private void BtnSukuCadang_Click(object sender, EventArgs e)
        {
          //  Master.SukuCadang.JenisSukuCadang su = new Master.SukuCadang.JenisSukuCadang();
          //  su.Show();
            this.Hide();
        }

        private void BtnKendaraan_Click(object sender, EventArgs e)
        {
            //Kendaraan m = new Kendaraan();
           // m.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();
            b.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            services s = new services();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            karyawan karyawan = new karyawan();
            karyawan.Show();
            this.Hide();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Jsc jns = new Jsc();
            jns.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KelolaJabatan jabatan = new KelolaJabatan();
            jabatan.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            member member = new member();
            member.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            JenisKendaraan jns = new JenisKendaraan();
            jns.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kendaraan kdr = new Kendaraan();
            kdr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            services srv = new services();
            srv.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            supplier sup = new supplier();
            sup.Show();
            this.Hide();
        
        }

        private void button15_Click(object sender, EventArgs e)
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

           
            login Form = new login();
            Form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
