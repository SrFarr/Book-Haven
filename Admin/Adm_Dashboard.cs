using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku
{
    public partial class Adm_Dashboard : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        public Adm_Dashboard()
        {
            InitializeComponent();
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adm_Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            int jumlahBuku = db.Bukus.Count();
            lblTotalBook.Text = jumlahBuku.ToString();

            int jumlahUser = db.Pelanggans.Where(x => x.isAdmin == false).Count();
            lblTotalPelanggan.Text = jumlahUser.ToString();

            int jumlahTransaksi = db.Transaksis.Count();
            lblTotalTransaksi.Text = jumlahTransaksi.ToString();

            var transaksi = (from t in db.Transaksis
                             join u in db.Pelanggans on t.IdPelanggan equals u.IdPelanggan
                             join d in db.DetailTransaksis on t.IdTransaksi equals d.IdTransaksi
                             select new
                             {
                                 Id_Transaksi = t.IdTransaksi,
                                 Pelanggan = u.Nama,
                                 Tanggal = t.Tanggal,
                                 Total = d.Subtotal
                             }).ToList();

            if(transaksi.Count > 0)
            {
                panelTidakAdaTransaksi.Visible = false;
                datagridview.Visible = true;
                datagridview.DataSource = transaksi;
                datagridview.ReadOnly = true;
                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                panelTidakAdaTransaksi.Visible = true;
                datagridview.Visible = false;
            }
        }
    }
}
