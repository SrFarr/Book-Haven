using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Buku
{
    public partial class Adm_KelolaBuku : UserControl
    {
        PenjualanBukuEntities db = new PenjualanBukuEntities();
        int idBuku;
        string selectedImgPath = "";
      
        public Adm_KelolaBuku()
        {
            InitializeComponent();
        }

        private void Adm_KelolaBuku_Load(object sender, EventArgs e)
        {
            LoadCmbx(cmbxGenre);
            LoadCmbx(cmbGenre);
            LoadField();
        }

        private void datagridbuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridbuku.Rows[e.RowIndex];
                if (row.Cells["Hapus"].Selected)
                {
                    var id = (int)row.Cells["Id"].Value;

                    var del = db.Bukus.FirstOrDefault(x => x.IdBuku == id);
                    var msg = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(msg == DialogResult.Yes)
                    {
                        db.Bukus.Remove(del);
                        db.SaveChanges();
                        MessageBox.Show("Data buku berhasil di hapus");
                        LoadData();
                    }
                    return;
                }
                
                idBuku = (int)row.Cells["Id"].Value;
                txtJudul.Text = row.Cells["Judul"].Value.ToString();
                txtHarga.Text = row.Cells["Harga"].Value.ToString();
                txtPenerbit.Text = row.Cells["Penerbit"].Value.ToString();
                txtPenulis.Text = row.Cells["Penulis"].Value.ToString();
                txtStok.Value = (int)row.Cells["Stok"].Value;
                cmbGenre.Text = row.Cells["Genre"].Value.ToString();

                string folderImages = Application.StartupPath + @"\Images\";
                string imgPath = Path.Combine(folderImages, idBuku + ".jpg");

                if (File.Exists(imgPath))
                {
                    picImage.Image = Image.FromFile(imgPath);
                }
                else
                {
                    picImage.Image = Properties.Resources.Book;
                }

            }
            else
            {
                MessageBox.Show("Index tidak valid");
            }
        }

        private void cmbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadField()
        {
            txtHarga.Text = "";
            txtJudul.Text = "";
            txtPenerbit.Text = "";
            txtPenulis.Text = "";
            txtStok.Value = 0;
            cmbxGenre.SelectedIndex = 0;
            picImage.Image = Properties.Resources.Book;
        }
        void LoadData()
        {
            
            var data = db.Bukus.Where(x => x.Genre == cmbxGenre.Text || cmbxGenre.Text == "Semua Genre").Select(y => new
            {
                Id = y.IdBuku,
                y.Judul,
                y.Genre,
                y.Penulis,
                y.Penerbit,
                y.Stok,
                y.Harga,
                y.Image
            }).ToList();

            var dataWithImages = data.Select(b =>
            {
                string folderImages = Application.StartupPath + @"\Images\";
                string imgPath = Path.Combine(folderImages, b.Id + ".jpg");

                Image img = File.Exists(imgPath) ? Image.FromFile(imgPath) : Properties.Resources.Book;

                return new
                {
                    b.Id,
                    b.Judul,
                    b.Genre,
                    b.Penulis,
                    b.Penerbit,
                    b.Stok,
                    b.Harga,
                    Image = img
                };
            }).ToList();

            datagridbuku.DataSource = dataWithImages;

            if (datagridbuku.Columns["Image"] == null)
            {
                var imgCol = new DataGridViewImageColumn
                {
                    Name = "Image",
                    HeaderText = "Cover",
                    DataPropertyName = "Image",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 45
                };
                datagridbuku.Columns.Add(imgCol);
            }

            if (datagridbuku.Columns["Hapus"] == null)
            {
                var imgDel = new DataGridViewImageColumn
                {
                    Name = "Hapus",
                    HeaderText = "Hapus",
                    Image = Properties.Resources.trash
                };
                datagridbuku.Columns.Add(imgDel);
            }
            datagridbuku.Columns["Id"].Visible = false;
            datagridbuku.ReadOnly = true;
            datagridbuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoadCmbx(ComboBox cmbxData)
        {
            var cmbx = db.Bukus.Select(x => x.Genre).Distinct().ToList();
            cmbx.Insert(0, "Semua Genre");
            cmbxData.DataSource = cmbx;
            cmbxData.DisplayMember = "Genre";
            cmbxData.ValueMember = null;
        }

        private void cmbxGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Cover Buku";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImgPath = ofd.FileName;
                    picImage.Image = Image.FromFile(selectedImgPath);
                }

            }
           
        }
        void AddBook()
        {
            Buku b = new Buku
            {
                Judul = txtJudul.Text,
                Genre = cmbGenre.Text,
                Penulis = txtPenulis.Text,
                Penerbit = txtPenerbit.Text,
                Harga = Convert.ToDecimal(txtHarga.Text),
                Stok = Convert.ToInt32(txtStok.Text)
            };

            db.Bukus.Add(b);
            db.SaveChanges();

            int newIdBuku = b.IdBuku;
            if (!string.IsNullOrEmpty(selectedImgPath))
            {
                string folderImages = Application.StartupPath + @"\Images\";
                if (!Directory.Exists(folderImages))
                {
                    Directory.CreateDirectory(folderImages);
                }
                string newImgPath = Path.Combine(folderImages, newIdBuku + ".jpg");
                File.Copy(selectedImgPath, newImgPath, true);

                b.Image = newIdBuku + ".jpg";
                db.SaveChanges();
            }
            MessageBox.Show("Buku Berhasil ditambahkan","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            LoadField();
        }

        void UpdateBook()
        {
            var buku = db.Bukus.FirstOrDefault(x => x.IdBuku == idBuku);
            if(buku != null)
            {
                buku.Judul = txtJudul.Text;
                buku.Genre = cmbGenre.Text;
                buku.Penulis = txtPenulis.Text;
                buku.Penerbit = txtPenerbit.Text;
                buku.Stok = Convert.ToInt32(txtStok.Text);
                buku.Harga = Convert.ToDecimal(txtHarga.Text);

                if (!string.IsNullOrEmpty(selectedImgPath))
                {
                    string folderImages = Application.StartupPath + @"\Images\";

                    if (!Directory.Exists(folderImages))
                    {
                        Directory.CreateDirectory(folderImages);
                    }
                    string newImagePath = Path.Combine(folderImages, idBuku + ".jpg");
                    File.Copy(selectedImgPath, newImagePath, true);
                    buku.Image = idBuku + ".jpg";
                }
                db.SaveChanges();
                MessageBox.Show("Data berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadField();
                LoadData();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadField();
        }
    }
}
