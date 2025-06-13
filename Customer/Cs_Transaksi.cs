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

        private void Cs_Transaksi_Load(object sender, EventArgs e)
        {
            LoadData();   
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadData()
        {
            var data = (from t in db.Transaksis
                        join d in db.DetailTransaksis on t.IdTransaksi equals d.IdTransaksi
                        join b in db.Bukus on d.IdBuku equals b.IdBuku
                        where t.IdPelanggan == idPelanggan
                        select new
                        {
                            t.Tanggal,
                            b.Judul,
                            d.Jumlah,
                            d.HargaSaatTransaksi,
                            d.Subtotal
                        }).ToList();

            // Tambahkan nomor urut (index)
            var dta = data.Select((x, i) => new
            {
                No = i + 1, // index mulai dari 1
                x.Tanggal,
                x.Judul,
                x.Jumlah,
                x.HargaSaatTransaksi,
                x.Subtotal
            }).ToList();

            dataGridView1.DataSource = dta;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }


    }
}
