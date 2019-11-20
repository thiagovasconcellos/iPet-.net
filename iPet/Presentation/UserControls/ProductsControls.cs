using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPet.Presentation.UserControls
{
    public partial class ProductsControls : UserControl
    {
        public ProductsControls()
        {
            InitializeComponent();
            lowerPanel.Height = btnGeneral.Height;
            lowerPanel.Left = btnGeneral.Left;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            lowerPanel.Height = btnGeneral.Height;
            lowerPanel.Left = btnGeneral.Left;
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            lowerPanel.Height = btnStorage.Height;
            lowerPanel.Left = btnGeneral.Right;
        }

        private void btnPictures_Click(object sender, EventArgs e)
        {
            lowerPanel.Height = btnPictures.Height;
            lowerPanel.Left = btnStorage.Right;
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            lowerPanel.Height = btnGroups.Height;
            lowerPanel.Left = btnPictures.Right;
        }
    }
}
