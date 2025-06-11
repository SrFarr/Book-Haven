namespace Penjualan_Buku.Customer
{
    partial class CartCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customPanel1 = new CustomPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblHargaUpdate = new System.Windows.Forms.Label();
            this.lblHargaAseli = new ReaLTaiizor.Controls.BigLabel();
            this.lblJudul = new ReaLTaiizor.Controls.BigLabel();
            this.btnHapus = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.numericUpDown1);
            this.customPanel1.Controls.Add(this.lblHargaUpdate);
            this.customPanel1.Controls.Add(this.lblHargaAseli);
            this.customPanel1.Controls.Add(this.lblJudul);
            this.customPanel1.Controls.Add(this.btnHapus);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.GradientColor1 = System.Drawing.Color.White;
            this.customPanel1.GradientColor2 = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(3, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.customPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.ShadowDepth = 5;
            this.customPanel1.ShadowSpread = 3;
            this.customPanel1.Size = new System.Drawing.Size(660, 118);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblHargaUpdate
            // 
            this.lblHargaUpdate.AutoSize = true;
            this.lblHargaUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHargaUpdate.Location = new System.Drawing.Point(80, 42);
            this.lblHargaUpdate.Name = "lblHargaUpdate";
            this.lblHargaUpdate.Size = new System.Drawing.Size(45, 16);
            this.lblHargaUpdate.TabIndex = 2;
            this.lblHargaUpdate.Text = "Harga";
            // 
            // lblHargaAseli
            // 
            this.lblHargaAseli.AutoSize = true;
            this.lblHargaAseli.BackColor = System.Drawing.Color.Transparent;
            this.lblHargaAseli.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaAseli.ForeColor = System.Drawing.Color.Black;
            this.lblHargaAseli.Location = new System.Drawing.Point(535, 11);
            this.lblHargaAseli.Name = "lblHargaAseli";
            this.lblHargaAseli.Size = new System.Drawing.Size(59, 23);
            this.lblHargaAseli.TabIndex = 1;
            this.lblHargaAseli.Text = "Harga";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(76, 11);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(69, 31);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul";
            // 
            // btnHapus
            // 
            this.btnHapus.Image = global::Penjualan_Buku.Properties.Resources.trash;
            this.btnHapus.Location = new System.Drawing.Point(623, 83);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(26, 31);
            this.btnHapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHapus.TabIndex = 0;
            this.btnHapus.TabStop = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Penjualan_Buku.Properties.Resources.Books;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel1);
            this.Name = "CartCard";
            this.Size = new System.Drawing.Size(659, 120);
            this.customPanel1.ResumeLayout(true);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(true);

        }

        #endregion

        private CustomPanel customPanel1;
        private ReaLTaiizor.Controls.BigLabel lblJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private ReaLTaiizor.Controls.BigLabel lblHargaAseli;
        private System.Windows.Forms.PictureBox btnHapus;
        public System.Windows.Forms.Label lblHargaUpdate;
    }
}
