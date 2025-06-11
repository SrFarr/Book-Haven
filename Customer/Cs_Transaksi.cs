using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku.Customer
{
    public partial class Cs_Transaksi : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        int idPelanggan;
        public Cs_Transaksi(int idPelanggan)
        {
            InitializeComponent();
            this.idPelanggan = idPelanggan;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadCardTransaksi()
        {
            var t = db.Transaksis.ToList();
            for(int i = flowLayoutPanel1.Controls.Count -1; i >= 0; i--)
            {
                if (flowLayoutPanel1.Controls[i] is TransaksiCard)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                }
            }
            var card = new TransaksiCard(idPelanggan);
            flowLayoutPanel1.Controls.Add(card);
        }

        private void Cs_Transaksi_Load(object sender, EventArgs e)
        {
            LoadCardTransaksi();
        }
    }
}
