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
    public partial class Adm_MainForm : Form
    {
        List<Panel> menuPanels;
        public Adm_MainForm()
        {
            InitializeComponent();
        }

        private void Adm_MainForm_Load(object sender, EventArgs e)
        {
            RegPanelEventHandler(panelKelolaBuku, panelKelolaBuku_Click);
            RegPanelEventHandler(panelKelolaPengguna, panelKelolaPengguna_Click);
            RegPanelEventHandler(panelDashboard, panelDashboard_Click);
            menuPanels = new List<Panel>
            {
                panelKelolaBuku, panelKelolaPengguna, panelDashboard
            };
        }
        void SetActivePanel(Panel activePanel)
        {
            foreach(Panel p in menuPanels)
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
            foreach(Control child in parent.Controls)
            {
                RegPanelEventHandler(child, eventHandler);
            }
        }

        private void panelKelolaBuku_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panelKelolaPengguna_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelKelolaBuku_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelKelolaBuku);
            LoadUserControl(new Adm_KelolaBuku());
        }

        private void panelKelolaPengguna_Click(object sender, EventArgs e)
        {

            SetActivePanel(panelKelolaPengguna);
            LoadUserControl(new Adm_KelolaPengguna());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            this.Hide();
            log.Show();
        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            SetActivePanel(panelDashboard);
            LoadUserControl(new Adm_Dashboard());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msg == DialogResult.Yes)
            {
                this.Hide();
                FormLogin log = new FormLogin();
                log.Show();
            }
        }

        private void bigLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
