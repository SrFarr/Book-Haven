using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku
{
    public partial class FormLogin : Form
    {  
        public FormLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await Login();
        }
        async Task Login()
        {
            using(var db = new PenjualanBukuEntities())
            {

                var dt = await db.Pelanggans.FirstOrDefaultAsync(x => x.Email == txtEmail.Text.Trim());

                if (dt != null && dt.isAdmin == true)
                {
                    MessageBox.Show("Welcome admin " + dt.Nama, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Adm_MainForm adm = new Adm_MainForm();
                    adm.Show();
                    this.Hide();
                }
                else if(dt != null && dt.isAdmin == false)
                {
                    MessageBox.Show("Welcome " + dt.Nama, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Usr_MainForm usr = new Usr_MainForm(dt.Nama, dt.IdPelanggan);
                    usr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Akun tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            txtEmail.Text = "       ";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Text = "       ";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
