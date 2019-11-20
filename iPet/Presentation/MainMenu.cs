using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPet.Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            sidePanel.Height = btnOrders.Height;
            sidePanel.Top = btnOrders.Top;
            lblSelectedMenu.Text = "Pedidos";
            ordersControls1.BringToFront();
        }

        private void btnOrders_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnOrders_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnOrders_MouseClick(object sender, MouseEventArgs e)
        {
            sidePanel.Height = btnOrders.Height;
            sidePanel.Top = btnOrders.Top;
            lblSelectedMenu.Text = "Pedidos";
            ordersControls1.BringToFront();
        }

        private void btnProducts_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnProducts_MouseClick(object sender, MouseEventArgs e)
        {
            sidePanel.Height = btnProducts.Height;
            sidePanel.Top = btnProducts.Top;
            lblSelectedMenu.Text = "Produtos";
            productsControls1.BringToFront();
            
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnReports_MouseClick(object sender, MouseEventArgs e)
        {
            sidePanel.Height = btnReports.Height;
            sidePanel.Top = btnReports.Top;
            lblSelectedMenu.Text = "Relatórios";
        }

        private void btnNotifications_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnNotifications_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnNotifications_MouseClick(object sender, MouseEventArgs e)
        {
            sidePanel.Height = btnNotifications.Height;
            sidePanel.Top = btnNotifications.Top;
            lblSelectedMenu.Text = "Notificações";
        }

        private void btnConfigs_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnConfigs_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnConfigs_MouseClick(object sender, MouseEventArgs e)
        {
            sidePanel.Height = btnConfigs.Height;
            sidePanel.Top = btnConfigs.Top;
            lblSelectedMenu.Text = "Configurações";
        }

        private void btnControlNotification_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnControlNotification_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnFacebook_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnFacebook_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void btnControlNotification_Click(object sender, EventArgs e)
        {
            btnNotifications_MouseClick(sender, new MouseEventArgs(MouseButtons.Right, 0, 0, 0, 0));
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            btnConfigs_MouseClick(sender, new MouseEventArgs(MouseButtons.Right, 0, 0, 0, 0));
        }
    }
}
