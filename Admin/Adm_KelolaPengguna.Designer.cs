namespace Penjualan_Buku
{
    partial class Adm_KelolaPengguna
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.datagridpengguna = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelpon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInsert = new ReaLTaiizor.Controls.Button();
            this.buttonUpd = new ReaLTaiizor.Controls.Button();
            this.button3 = new ReaLTaiizor.Controls.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpengguna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(78, 115);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(817, 24);
            this.cmbxGenre.TabIndex = 12;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(342, 57);
            this.bigLabel1.TabIndex = 11;
            this.bigLabel1.Text = "Kelola Pelanggan";
            // 
            // datagridpengguna
            // 
            this.datagridpengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridpengguna.Location = new System.Drawing.Point(10, 155);
            this.datagridpengguna.Name = "datagridpengguna";
            this.datagridpengguna.RowHeadersWidth = 51;
            this.datagridpengguna.RowTemplate.Height = 24;
            this.datagridpengguna.Size = new System.Drawing.Size(885, 316);
            this.datagridpengguna.TabIndex = 10;
            this.datagridpengguna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpengguna_CellContentClick);
            this.datagridpengguna.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridpengguna_CellFormatting);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(117, 496);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(225, 22);
            this.txtNama.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 533);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(117, 578);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(225, 22);
            this.txtAlamat.TabIndex = 14;
            // 
            // txtTelpon
            // 
            this.txtTelpon.Location = new System.Drawing.Point(117, 621);
            this.txtTelpon.Name = "txtTelpon";
            this.txtTelpon.Size = new System.Drawing.Size(225, 22);
            this.txtTelpon.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telpon";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonInsert.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonInsert.Image = null;
            this.buttonInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsert.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonInsert.Location = new System.Drawing.Point(456, 502);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonInsert.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonInsert.Size = new System.Drawing.Size(123, 36);
            this.buttonInsert.TabIndex = 17;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpd.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonUpd.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpd.Image = null;
            this.buttonUpd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpd.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonUpd.Location = new System.Drawing.Point(456, 544);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonUpd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonUpd.Size = new System.Drawing.Size(123, 36);
            this.buttonUpd.TabIndex = 17;
            this.buttonUpd.Text = "Update";
            this.buttonUpd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Image = null;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Location = new System.Drawing.Point(456, 586);
            this.button3.Name = "button3";
            this.button3.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.Size = new System.Drawing.Size(123, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear";
            this.button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(117, 649);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Is Admin";
            // 
            // Adm_KelolaPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelpon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.datagridpengguna);
            this.Name = "Adm_KelolaPengguna";
            this.Size = new System.Drawing.Size(926, 716);
            this.Load += new System.EventHandler(this.Adm_KelolaPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridpengguna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.DataGridView datagridpengguna;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTelpon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.Button buttonInsert;
        private ReaLTaiizor.Controls.Button buttonUpd;
        private ReaLTaiizor.Controls.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
    }
}
