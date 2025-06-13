using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku.Admin
{
    public partial class Adm_Transaction : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        public Adm_Transaction()
        {
            InitializeComponent();
        }

        private void Adm_Transaction_Load(object sender, EventArgs e)
        {
            LoadTransaction();
        }
        void LoadTransaction()
        {
            var data = (from t in db.Transaksis
                        join dt in db.DetailTransaksis on t.IdTransaksi equals dt.IdTransaksi
                        join b in db.Bukus on dt.IdBuku equals b.IdBuku
                        join p in db.Pelanggans on t.IdPelanggan equals p.IdPelanggan
                        select new
                        {
                            Id = t.IdTransaksi,
                            Pelangan = p.Nama,
                            Alamat = p.Alamat,
                            Judul = b.Judul,
                            Jumlah = dt.Jumlah,
                            Subtotal = dt.Subtotal,
                            Tanggal = t.Tanggal
                        }).ToList();
            poisonDataGridView1.DataSource = data;
            poisonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poisonDataGridView1.ReadOnly = true;
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
