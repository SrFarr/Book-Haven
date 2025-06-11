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
    public partial class Cs_DaftarBuku : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();

        public Cs_DaftarBuku()
        {
            InitializeComponent();
        }

        private void Cs_DaftarBuku_Load(object sender, EventArgs e)
        {
            LoadBuku();
            LoadGenre();
        }
        void LoadBuku()
        {
            string keyword = (txtbSearch.Text == "Cari buku...") ? "" : txtbSearch.Text.ToLower();
            string selectedGenre = cmbxGenre.Text;
            var bukuList = db.Bukus
                                .Where(x =>
                                    (string.IsNullOrEmpty(keyword) ||
                                     x.Judul.ToLower().Contains(keyword) ||
                                     x.Penulis.ToLower().Contains(keyword)) &&
                                    (selectedGenre == "-- Semua Genre --" || x.Genre == selectedGenre)
                                )
                                .Take(15)
                                .ToList();

            for (int i = flowLayoutPanel1.Controls.Count -1; i >= 0; i--)
            {
                if (flowLayoutPanel1.Controls[i] is BookCard)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                }
            }
            foreach(var buku in bukuList)
            {
                var card = new BookCard(buku);
                card.SetData(buku);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void SetPlaceholder()
        {
            txtbSearch.Text = "Cari buku...";
            txtbSearch.ForeColor = Color.Gray;
        }
        void LoadGenre()
        {
            var genre = db.Bukus.Select(x => x.Genre).Distinct().OrderBy(g => g).ToList();
            genre.Insert(0, "-- Semua Genre --");
            cmbxGenre.DataSource = genre;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBuku();
        }

        private void txtbSearch_Click(object sender, EventArgs e)
        {
            txtbSearch.Text = "";
        }

        private void cmbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBuku();
        }

        private void txtbSearch_Enter(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void txtbSearch_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }
    }
}
