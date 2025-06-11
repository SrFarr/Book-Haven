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
    public partial class Cs_Cart : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        bool subscribed = false;
        int idPelanggan;
        public Cs_Cart(int idPelanggan)
        {
            InitializeComponent();
            this.idPelanggan = idPelanggan;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadCart()
        {
            for (int i = flowLayoutPanel1.Controls.Count -1; i>= 0; i--)
            {
                if (flowLayoutPanel1.Controls[i] is CartCard)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                }
            }
            foreach(var cart in CartService.Items)
            {
                var cartCard = new CartCard();
                cartCard.carts(cart);
                flowLayoutPanel1.Controls.Add(cartCard);
            }
            
        }

        private void Cs_Cart_Load(object sender, EventArgs e)
        {
            if (!subscribed)
            {
                CartService.OnCartChanged += LoadCart;
                subscribed = true;
            }
            LoadCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (CartService.Items.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var checkoutForm = new FrmCheckout(idPelanggan); // kirim ID pelanggan ke form checkout
            checkoutForm.ShowDialog(); // buka sebagai dialog
        }
        
    }
}
