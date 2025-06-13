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
    public partial class FrmCheckout : Form
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        int id_Pelanggan;
        public FrmCheckout(int id)
        {
            InitializeComponent();
            this.id_Pelanggan = id;
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }
        private void LoadSummary()
        {
            var data = db.Pelanggans.FirstOrDefault(x => x.IdPelanggan == id_Pelanggan);
            txtNm.Text = data.Nama;
            txtAlamat.Text = data.Alamat;
            txtEmail.Text = data.Email;
            foreach (var item in CartService.Items)
            {
                listBoxSummary.Items.Add($"{item.judul} x {item.qty} = Rp{item.subtotal}");
            }
            lblTotal.Text = $"Total: Rp{CartService.Total}";   
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            decimal uang = Convert.ToInt32(txtuang.Text);
            decimal total = CartService.Total;

            if (uang >= total)
            {
                decimal kembali = uang - total;

                var transaksi = new Transaksi
                {
                    Tanggal = DateTime.Now,
                    IdPelanggan = id_Pelanggan
                };
                db.Transaksis.Add(transaksi);
                db.SaveChanges();

                foreach (var item in CartService.Items)
                {
                    var buku = db.Bukus.FirstOrDefault(x => x.IdBuku == item.IdBuku);
                    buku.Stok -= item.qty;
                    var detail = new DetailTransaksi
                    {
                        IdBuku = item.IdBuku,
                        IdTransaksi = transaksi.IdTransaksi,
                        Jumlah = item.qty,
                        HargaSaatTransaksi = item.harga ?? 0,
                        Subtotal = item.subtotal
                    };
                    db.DetailTransaksis.Add(detail);
                }

                db.SaveChanges(); // simpan semua detail
              
                MessageBox.Show($"Pembayaran berhasil!\nKembalian: Rp{kembali}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CartService.Items.Clear();
                CartService.OnCartChanged?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Uang tidak cukup!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtuang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
