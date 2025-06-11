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
    public partial class TransaksiCard : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        int idPelanggan;
        public TransaksiCard(int idPelanggan)
        {
            InitializeComponent();
            this.idPelanggan = idPelanggan;
        }

        private void TransaksiCard_Load(object sender, EventArgs e)
        {
            InitTransaksiCombo();
            // Optional: Select first transaction if exists
            if (cmbxTransaksi.Items.Count > 0)
            {
                cmbxTransaksi.SelectedIndex = 0;
            }
        }

        public void LoadTransaksi(int selectedIdTransaksi)
        {
            // Ambil transaksi yang sesuai
            var transaksi = db.Transaksis
                .FirstOrDefault(x => x.IdPelanggan == idPelanggan && x.IdTransaksi == selectedIdTransaksi);

            if (transaksi == null)
            {
                datagridviewBuku.DataSource = null;
                lblIdTransaksi.Text = "-";
                lblTanggal.Text = "-";
                lblSubtotal.Text = "-";
                return;
            }

            // Ambil detail transaksi sesuai id transaksi yang dipilih
            var detailList = db.DetailTransaksis
                .Where(dt => dt.IdTransaksi == selectedIdTransaksi)
                .ToList();

            // Join ke buku untuk DataGridView
            var data = (from dt in detailList
                        join b in db.Bukus on dt.IdBuku equals b.IdBuku
                        select new
                        {
                            dt.IdTransaksi,
                            Tanggal = transaksi.Tanggal,
                            dt.Jumlah,
                            b.Judul,
                            dt.Subtotal
                        }).ToList();

            datagridviewBuku.DataSource = data;
            datagridviewBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridviewBuku.ReadOnly = true;

            // Label
            lblIdTransaksi.Text = transaksi.IdTransaksi.ToString();
            lblTanggal.Text = transaksi.Tanggal.HasValue ? transaksi.Tanggal.Value.ToString("dd/MM/yyyy") : "-";
            lblSubtotal.Text = "Rp" + detailList.Sum(dt => dt.Subtotal).ToString();
        }

        public void InitTransaksiCombo()
        {
            var transaksiList = db.Transaksis
                .Where(x => x.IdPelanggan == idPelanggan)
                .ToList();

            cmbxTransaksi.DataSource = null;
            cmbxTransaksi.DataSource = transaksiList;
            cmbxTransaksi.DisplayMember = "IdTransaksi"; // atau properti lain
            cmbxTransaksi.ValueMember = "IdTransaksi";
        }

        private void datagridviewBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Implement if you want to handle cell clicks
        }

        private void cmbxTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle only if combo box is properly bound and has a selected value
            if (cmbxTransaksi.SelectedItem is null)
                return;

            // SelectedValue might not be int if DataSource is a list of entities, so use SelectedItem
            if (cmbxTransaksi.SelectedItem is Transaksi selectedTransaksi)
            {
                LoadTransaksi(selectedTransaksi.IdTransaksi);
            }
            else if (cmbxTransaksi.SelectedValue is int id)
            {
                LoadTransaksi(id);
            }
        }
    }
}