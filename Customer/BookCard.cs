    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Penjualan_Buku.Customer
    {
        public partial class BookCard : UserControl
        {
            public List<CartItem> cart = new List<CartItem>();
            Buku buku;
            public BookCard(Buku b)
            {
                InitializeComponent();
                buku = b;
            }

            private void customPanel2_Paint(object sender, PaintEventArgs e)
            {

            }
            public void SetData(Buku buku)
            {
                lblJudul.Text = buku.Judul;
                lblAuthor.Text = buku.Penulis;
                lblGenre.Text = buku.Genre;
                lblHarga.Text = "Rp" + buku.Harga;
                lblStok.Text = $"Stok({buku.Stok})";

                string folderImages = Application.StartupPath + @"\Images\";
                string imgPath = Path.Combine(folderImages, buku.Image ?? (buku.IdBuku + ".jpg"));

                pictureBoxCover.Image = File.Exists(imgPath) ? Image.FromFile(imgPath) : Properties.Resources.Books;
            }

            private void btnAddToCart_Click(object sender, EventArgs e)
            {
                CartItem item = new CartItem
                {
                    IdBuku = buku.IdBuku,
                    judul = buku.Judul,
                    harga = buku.Harga,
                    qty = 1
                };
                CartService.AddToCart(item);
              MessageBox.Show($"'{buku.Judul}' ditambahkan ke keranjang!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

            private void BookCard_Load(object sender, EventArgs e)
            {

            }
        }
    }
