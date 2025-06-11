using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku
{
    public partial class Adm_KelolaPengguna : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        int id_pelanggan;
        public Adm_KelolaPengguna()
        {
            InitializeComponent();
        }

        private void Adm_KelolaPengguna_Load(object sender, EventArgs e)
        {
            LoadDataPengguna();
        }
        void LoadDataPengguna()
        {
            var data = db.Pelanggans.Select(x => new
            {
                Id = x.IdPelanggan,
                x.Nama,
                x.Email,
                x.Telepon,
                x.Alamat,
                x.isAdmin
            }).ToList();

            datagridpengguna.Columns.Clear(); // <-- tambahkan ini biar kolom sebelumnya direset
            datagridpengguna.DataSource = data;

            datagridpengguna.ReadOnly = true;
            datagridpengguna.Columns["Id"].Visible = false;
            datagridpengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tambah tombol "Hapus"
            DataGridViewImageColumn imgDel = new DataGridViewImageColumn
            {
                Name = "Hapus",
                HeaderText = "Hapus",
                Image = Properties.Resources.trash,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            datagridpengguna.Columns.Add(imgDel);

            // Tambah tombol "Edit"
            DataGridViewImageColumn imgEdit = new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Image = Properties.Resources.pencil_color,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            datagridpengguna.Columns.Add(imgEdit);
        }


        private void datagridpengguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = datagridpengguna.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = datagridpengguna.Rows[e.RowIndex];

                int id = (int)row.Cells["Id"].Value;

                if (columnName == "Hapus")
                {
                    var del = db.Pelanggans.FirstOrDefault(x => x.IdPelanggan == id);
                    var msg = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes && del != null)
                    {
                        db.Pelanggans.Remove(del);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus");
                        LoadDataPengguna();
                    }
                }
                else if (columnName == "isAdmin")
                {
                    var user = db.Pelanggans.FirstOrDefault(x => x.IdPelanggan == id);
                    if (user != null)
                    {
                        user.isAdmin = !user.isAdmin;
                        db.SaveChanges();
                        LoadDataPengguna();
                    }
                }
                else if (columnName == "Edit")
                {
                    id_pelanggan = id;
                    txtNama.Text = row.Cells["Nama"].Value?.ToString();
                    txtEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtAlamat.Text = row.Cells["Alamat"].Value?.ToString();
                    txtTelpon.Text = row.Cells["Telepon"].Value?.ToString();

                    bool isAdmin = Convert.ToBoolean(row.Cells["isAdmin"].Value);
                    radioButton1.Checked = isAdmin;
                }
            }
        }
        void ClearField()
        {

            txtNama.Text = "";
            txtEmail.Text = "";
            txtTelpon.Text = "";
            txtAlamat.Text = "";

        }
        void Insert()
        {
            try
            {
                // Validasi input kosong
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(txtTelpon.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi nomor telepon (harus angka)
                if (!long.TryParse(txtTelpon.Text, out long noTelepon))
                {
                    MessageBox.Show("Nomor telepon harus berupa angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kalau semua valid, lanjut insert
                Pelanggan p = new Pelanggan
                {
                    Nama = txtNama.Text,
                    Password = "12345678",
                    Email = txtEmail.Text,
                    Alamat = txtAlamat.Text,
                    Telepon = txtTelpon.Text, // bisa noTelepon.ToString() kalau property-nya long
                    isAdmin = radioButton1.Checked ? true : false
                };

                db.Pelanggans.Add(p);
                db.SaveChanges();
                LoadDataPengguna();
                ClearField();
                MessageBox.Show("Data pelanggan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Update()
        {
            var user = db.Pelanggans.FirstOrDefault(x => x.IdPelanggan == id_pelanggan);
            if(user == null)
            {
                MessageBox.Show("Data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtAlamat.Text) ||
            string.IsNullOrWhiteSpace(txtTelpon.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtTelpon.Text, out _))
            {
                MessageBox.Show("Nomor telepon harus berupa angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.Nama = txtNama.Text;
            user.Email = txtEmail.Text;
            user.Alamat = txtAlamat.Text;
            user.Telepon = txtTelpon.Text;
            user.isAdmin = radioButton1.Checked;

            db.SaveChanges();
            LoadDataPengguna();
            ClearField();
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void datagridpengguna_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = datagridpengguna.Rows[e.RowIndex];
            var cellValue = row.Cells["isAdmin"].Value;

            if (cellValue != null && cellValue is bool IsAdmin)
            {
                if (!IsAdmin)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
