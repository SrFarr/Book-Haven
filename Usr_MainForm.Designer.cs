namespace Penjualan_Buku
{
    partial class Usr_MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usr_MainForm));
            this.panelControl = new System.Windows.Forms.Panel();
            this.customPanel1 = new CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.panelCart = new System.Windows.Forms.Panel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.panelDaftarBuku = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panelTransaksi = new System.Windows.Forms.Panel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelDaftarBuku.SuspendLayout();
            this.panelTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(246, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(893, 716);
            this.panelControl.TabIndex = 5;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 3;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.bigLabel5);
            this.customPanel1.Controls.Add(this.pictureBox5);
            this.customPanel1.Controls.Add(this.panelDashboard);
            this.customPanel1.Controls.Add(this.panelCart);
            this.customPanel1.Controls.Add(this.panelDaftarBuku);
            this.customPanel1.Controls.Add(this.panelTransaksi);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customPanel1.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.customPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.ShadowDepth = 5;
            this.customPanel1.ShadowSpread = 3;
            this.customPanel1.Size = new System.Drawing.Size(246, 716);
            this.customPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 65);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logout";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.Black;
            this.bigLabel5.Location = new System.Drawing.Point(44, 24);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(173, 31);
            this.bigLabel5.TabIndex = 2;
            this.bigLabel5.Text = "Customer Panel";
            this.bigLabel5.Click += new System.EventHandler(this.bigLabel5_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.pictureBox3);
            this.panelDashboard.Controls.Add(this.bigLabel3);
            this.panelDashboard.Location = new System.Drawing.Point(3, 257);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(243, 46);
            this.panelDashboard.TabIndex = 0;
            this.panelDashboard.Click += new System.EventHandler(this.panelDashboard_Click);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.Black;
            this.bigLabel3.Location = new System.Drawing.Point(62, 12);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(97, 23);
            this.bigLabel3.TabIndex = 0;
            this.bigLabel3.Text = "Dashboard";
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.pictureBox2);
            this.panelCart.Controls.Add(this.bigLabel2);
            this.panelCart.Location = new System.Drawing.Point(3, 361);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(243, 46);
            this.panelCart.TabIndex = 0;
            this.panelCart.Click += new System.EventHandler(this.panelCart_Click);
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.Black;
            this.bigLabel2.Location = new System.Drawing.Point(62, 12);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(91, 23);
            this.bigLabel2.TabIndex = 0;
            this.bigLabel2.Text = "Keranjang";
            // 
            // panelDaftarBuku
            // 
            this.panelDaftarBuku.Controls.Add(this.pictureBox1);
            this.panelDaftarBuku.Controls.Add(this.bigLabel1);
            this.panelDaftarBuku.Location = new System.Drawing.Point(3, 309);
            this.panelDaftarBuku.Name = "panelDaftarBuku";
            this.panelDaftarBuku.Size = new System.Drawing.Size(243, 46);
            this.panelDaftarBuku.TabIndex = 0;
            this.panelDaftarBuku.Click += new System.EventHandler(this.panelDaftarBuku_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(62, 12);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(108, 23);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Daftar Buku";
            this.bigLabel1.Click += new System.EventHandler(this.bigLabel1_Click);
            // 
            // panelTransaksi
            // 
            this.panelTransaksi.Controls.Add(this.pictureBox4);
            this.panelTransaksi.Controls.Add(this.bigLabel4);
            this.panelTransaksi.Location = new System.Drawing.Point(2, 413);
            this.panelTransaksi.Name = "panelTransaksi";
            this.panelTransaksi.Size = new System.Drawing.Size(244, 46);
            this.panelTransaksi.TabIndex = 0;
            this.panelTransaksi.Click += new System.EventHandler(this.panelTransaksi_Click);
            this.panelTransaksi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTransaksi_Paint);
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.Black;
            this.bigLabel4.Location = new System.Drawing.Point(62, 12);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(153, 23);
            this.bigLabel4.TabIndex = 0;
            this.bigLabel4.Text = "Transaksi Terakhir";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Penjualan_Buku.Properties.Resources.Logout;
            this.pictureBox6.Location = new System.Drawing.Point(8, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Penjualan_Buku.Properties.Resources.Customer;
            this.pictureBox5.Location = new System.Drawing.Point(0, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Penjualan_Buku.Properties.Resources.Dashboard;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Penjualan_Buku.Properties.Resources.CartUser;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Penjualan_Buku.Properties.Resources.Book1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Penjualan_Buku.Properties.Resources.Transaction;
            this.pictureBox4.Location = new System.Drawing.Point(12, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // Usr_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 716);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usr_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Haven - Customer";
            this.Load += new System.EventHandler(this.Usr_MainForm_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            this.panelDaftarBuku.ResumeLayout(false);
            this.panelDaftarBuku.PerformLayout();
            this.panelTransaksi.ResumeLayout(false);
            this.panelTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.Panel panelDaftarBuku;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Panel panelTransaksi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private System.Windows.Forms.Panel panelControl;
    }
}