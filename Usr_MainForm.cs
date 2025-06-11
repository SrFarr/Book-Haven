using Penjualan_Buku.Customer;
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
    public partial class Usr_MainForm : Form
    {
        string nama;
        int id;
        List<Panel> menuPanels;
        public Usr_MainForm(string nama, int id)
        {
            InitializeComponent();
            this.nama = nama;
            this.id = id;
        }

        private void bigLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Usr_MainForm_Load(object sender, EventArgs e)
        {
            RegPanelEventHandler(panelDashboard, panelDashboard_Click);
            RegPanelEventHandler(panelDaftarBuku, panelDaftarBuku_Click);
            RegPanelEventHandler(panelCart, panelCart_Click);
            RegPanelEventHandler(panelTransaksi, panelTransaksi_Click);
            menuPanels = new List<Panel>
            {
                panelDashboard, panelDaftarBuku, panelCart, panelTransaksi
            };
        }
        void SetActivePanel(Panel activePanel)
        {
            foreach (Panel p in menuPanels)
            {
                p.BackColor = Color.Transparent;
            }
            activePanel.BackColor = Color.White;
        }
        void LoadUserControl(UserControl uc)
        {
            panelControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }
        void RegPanelEventHandler(Control parent, EventHandler eventHandler)
        {
            parent.Click -= eventHandler;
            parent.Click += eventHandler;
            foreach (Control child in parent.Controls)
            {
                RegPanelEventHandler(child, eventHandler);
            }
        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cs_Dashboard(nama));
            SetActivePanel(panelDashboard);
        }

        private void panelDaftarBuku_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cs_DaftarBuku());
            SetActivePanel(panelDaftarBuku);
        }

        private void panelCart_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cs_Cart(id));
            SetActivePanel(panelCart);
        }

        private void panelTransaksi_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Cs_Transaksi(id));
            SetActivePanel(panelTransaksi);
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            this.Hide();
            log.Show();
        }

        private void panelTransaksi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
