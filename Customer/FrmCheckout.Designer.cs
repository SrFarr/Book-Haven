namespace Penjualan_Buku.Customer
{
    partial class FrmCheckout
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
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.customPanel1 = new CustomPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtuang = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new ReaLTaiizor.Controls.BigTextBox();
            this.txtNm = new ReaLTaiizor.Controls.BigTextBox();
            this.airButton1 = new ReaLTaiizor.Controls.AirButton();
            this.lblTotal = new ReaLTaiizor.Controls.BigLabel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxSummary.ForeColor = System.Drawing.Color.White;
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.ItemHeight = 16;
            this.listBoxSummary.Location = new System.Drawing.Point(22, 95);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(266, 404);
            this.listBoxSummary.TabIndex = 0;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.linkLabel1);
            this.customPanel1.Controls.Add(this.txtuang);
            this.customPanel1.Controls.Add(this.txtAlamat);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.txtEmail);
            this.customPanel1.Controls.Add(this.txtNm);
            this.customPanel1.Controls.Add(this.airButton1);
            this.customPanel1.GradientColor1 = System.Drawing.Color.DodgerBlue;
            this.customPanel1.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(364, 85);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.customPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.ShadowDepth = 5;
            this.customPanel1.ShadowSpread = 3;
            this.customPanel1.Size = new System.Drawing.Size(409, 420);
            this.customPanel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 393);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kembali ke Transaksi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtuang
            // 
            this.txtuang.Location = new System.Drawing.Point(48, 332);
            this.txtuang.Name = "txtuang";
            this.txtuang.Size = new System.Drawing.Size(304, 22);
            this.txtuang.TabIndex = 4;
            this.txtuang.TextChanged += new System.EventHandler(this.txtuang_TextChanged);
            this.txtuang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuang_KeyPress);
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Location = new System.Drawing.Point(48, 209);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(313, 74);
            this.txtAlamat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Lengkap";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Image = null;
            this.txtEmail.Location = new System.Drawing.Point(48, 125);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(313, 46);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtNm
            // 
            this.txtNm.BackColor = System.Drawing.Color.Transparent;
            this.txtNm.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNm.ForeColor = System.Drawing.Color.DimGray;
            this.txtNm.Image = null;
            this.txtNm.Location = new System.Drawing.Point(48, 45);
            this.txtNm.MaxLength = 32767;
            this.txtNm.Multiline = false;
            this.txtNm.Name = "txtNm";
            this.txtNm.ReadOnly = false;
            this.txtNm.Size = new System.Drawing.Size(313, 46);
            this.txtNm.TabIndex = 1;
            this.txtNm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNm.UseSystemPasswordChar = false;
            // 
            // airButton1
            // 
            this.airButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airButton1.Image = null;
            this.airButton1.Location = new System.Drawing.Point(232, 381);
            this.airButton1.Name = "airButton1";
            this.airButton1.NoRounding = false;
            this.airButton1.Size = new System.Drawing.Size(129, 28);
            this.airButton1.TabIndex = 0;
            this.airButton1.Text = "Proses Checkout";
            this.airButton1.Transparent = false;
            this.airButton1.Click += new System.EventHandler(this.airButton1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(12, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 57);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.listBoxSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckout";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSummary;
        private CustomPanel customPanel1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigTextBox txtEmail;
        private ReaLTaiizor.Controls.BigTextBox txtNm;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.BigLabel lblTotal;
        private System.Windows.Forms.TextBox txtuang;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}