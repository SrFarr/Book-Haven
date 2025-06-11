using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Penjualan_Buku.Customer
{
    public partial class CartCard : UserControl
    {
        bool isInternalChange;
        int idbuku;
        public CartCard()
        {
            InitializeComponent();
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void carts(CartItem c)
        {
            idbuku = c.IdBuku;
            lblJudul.Text = c.judul;
            lblHargaAseli.Text = (c.harga ?? 0).ToString("C", new CultureInfo(""));
            lblHargaUpdate.Text = c.subtotal.ToString("C", new CultureInfo("id-ID"));
            isInternalChange = true;
            numericUpDown1.Value = c.qty;
            isInternalChange = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (isInternalChange) return;
            int newQty = (int)numericUpDown1.Value;
            int idBuku = idbuku;
            CartService.UpdateQuantity(idBuku, newQty);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Apakah anda yakin ingin menghapus buku ini? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msg == DialogResult.Yes)
            {
                CartService.RemoveFromCart(idbuku);

            }
        }
    }
}
