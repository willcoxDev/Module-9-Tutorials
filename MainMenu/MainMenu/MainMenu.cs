using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void vanillaCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Vanilla Cake, Price: $25";
        }

        private void macaroonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "Toppings: Macaroons";
        }

        private void pickUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDeliveryOption.Text = "Delivery Option: Pick-Up";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAbout();
            frm1.ShowDialog(this);
        }
    }
}
