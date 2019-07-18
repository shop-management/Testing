using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerView
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void managerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerView mv = new ManagerView();
            mv.TopLevel = false;
            mv.AutoScroll = true;
            mv.FormBorderStyle = FormBorderStyle.None;
            mv.Dock = DockStyle.Fill;

            this.panel2.Controls.Clear();

            this.panel2.Controls.Add(mv); //Add Manager View Form into Panel2
            mv.Show();
        }

        private void customerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            cv.TopLevel = false;
            cv.AutoScroll = true;
            cv.FormBorderStyle = FormBorderStyle.None;
            cv.Dock = DockStyle.Fill;

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(cv);
            cv.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerView mv = new ManagerView();
            mv.TopLevel = false;
            mv.AutoScroll = true;
            mv.FormBorderStyle = FormBorderStyle.None;
            mv.Dock = DockStyle.Fill;

            this.panel2.Controls.Clear();

            this.panel2.Controls.Add(mv); //Add Manager View Form into Panel2
            mv.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            cv.TopLevel = false;
            cv.AutoScroll = true;
            cv.FormBorderStyle = FormBorderStyle.None;
            cv.Dock = DockStyle.Fill;

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(cv);
            cv.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully LogOut", "Notification ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }
    }
}
