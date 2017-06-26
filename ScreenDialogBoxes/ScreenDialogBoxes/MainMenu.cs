using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenDialogBoxes
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really wish to exit", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            frmHelp formHelp = new ScreenDialogBoxes.frmHelp();
            formHelp.Show();
        }
        private void btnWarning_Click(object sender, EventArgs e)
        {

            SystemSounds.Beep.Play();
            frmAlert formAlert = new frmAlert();
            formAlert.ShowDialog();
            
        }
    }
}
