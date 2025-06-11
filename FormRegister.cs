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
    public partial class FormRegister : Form
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        public FormRegister()
        {
            InitializeComponent();
        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            await Register();
        }

        async Task Register()
        {

            if (string.IsNullOrEmpty(txtbNama.Text.Trim()) ||  string.IsNullOrEmpty(txtbAlamat.Text.Trim()) || string.IsNullOrEmpty(txtbEmail.Text.Trim()) || string.IsNullOrEmpty(txtbPassword.Text.Trim()))
            {
                MessageBox.Show("Semua data harus di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Pelanggan p = new Pelanggan();
            p.Nama = txtbNama.Text.Trim();
            p.Email = txtbEmail.Text.Trim();
            p.Password = txtbPassword.Text.Trim();
            p.Alamat = txtbAlamat.Text.Trim();
            p.Telepon = txtbNotelp.Text.Trim();

            db.Pelanggans.Add(p);
            await db.SaveChangesAsync();

            MessageBox.Show("Berhasil register", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
