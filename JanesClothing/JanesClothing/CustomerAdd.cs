using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothing
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainForm = new frmMainMenu();
            mainForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cbCategoryID.SelectedIndex = -1;
            txtAddress.Clear();
            txtSuburb.Clear();
            cbCategoryID.SelectedIndex = -1;
            txtPostcode.Clear();
            txtCustomerID.Clear();
            chkYes.Checked = false;
            chkNo.Checked = false;
        }
    }
}
