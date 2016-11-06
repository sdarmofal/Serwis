﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwis
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            User u = new User();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            new Login(this).Show();
        }
        private void Home_Activated(object sender, EventArgs e)
        {
            User u = new User();
            if (u.isSuperadmin())
            {
                this.addNewToolStripMenuItem.Visible = true;
                this.listUsersToolStripMenuItem.Visible = true;
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserAdd(this).Show();
        }
    }
}
