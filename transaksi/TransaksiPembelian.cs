using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna.transaksi
{
    public partial class TransaksiPembelian : Form
    {
        String id;
        Timer timer = new Timer();
        public TransaksiPembelian()
        {
            InitializeComponent();
        }

        private void TransaksiPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJEK8.tSupplier' table. You can move, or remove it, as needed.
            this.tSupplierTableAdapter.Fill(this.pROJEK8.tSupplier);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
