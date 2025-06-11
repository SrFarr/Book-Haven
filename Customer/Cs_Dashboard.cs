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
    public partial class Cs_Dashboard : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        string nama;
        public Cs_Dashboard(string nama)
        {
            InitializeComponent();
            this.nama = nama;
        }

        private void Cs_Dashboard_Load(object sender, EventArgs e)
        {
            lblNama.Text = "Selamat datang " + nama + "!";
            BukuTerbaru();
        }
        void BukuTerbaru()
        {
            var books = db.Bukus.OrderByDescending(x => x.IdBuku).Take(10).ToList();
            poisonDataGridView1.DataSource = books;
            poisonDataGridView1.ReadOnly = true;
            poisonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poisonDataGridView1.Columns["IdBuku"].Visible = false;
            poisonDataGridView1.Columns["DetailTransaksis"].Visible = false;
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
