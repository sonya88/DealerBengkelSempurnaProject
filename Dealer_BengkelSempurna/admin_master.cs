using Dealer_BengkelSempurna.Master.Posisi;
using Dealer_BengkelSempurna.Master.Services;
using Dealer_BengkelSempurna.Master.Member;
using Dealer_BengkelSempurna.Master;
using Dealer_BengkelSempurna.Master.Mobil;
using Dealer_BengkelSempurna.Master.Karyawan;
using Dealer_BengkelSempurna.Master.Supplier;
using Dealer_BengkelSempurna.Master.SukuCadang;
using Dealer_BengkelSempurna.Master.CRUD_MOTOR;
using Dealer_BengkelSempurna.Master.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CRUD_POSISI  posisi = new CRUD_POSISI();
            posisi.Show();
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
            Mobil mbl = new Mobil();
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
            SukuCadang su = new SukuCadang();
            su.Show();
            this.Hide();
        }

        private void BtnMotor_Click(object sender, EventArgs e)
        {
            Motor m = new Motor();
            m.Show();
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
    }
}
