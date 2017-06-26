﻿using System;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            frmCustomerEdit editForm = new frmCustomerEdit();
            editForm.Show();
            this.Hide();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerAdd addForm = new frmCustomerAdd();
            addForm.Show();
            this.Hide();
        }
    }
}
