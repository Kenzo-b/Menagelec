﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menagelec.Forms
{
    public partial class fmMenu : Form
    {
        public fmMenu()
        {
            InitializeComponent();
        }

        private void FmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            fmOrders formOrders = new fmOrders();
            formOrders.Show();
            this.Hide();
        }
    }
}
