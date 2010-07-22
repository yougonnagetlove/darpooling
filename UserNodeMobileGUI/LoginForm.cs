﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserNodeMobileGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void resetMenuItem_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            serviceNodeAddressTextBox.Text = "";
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            // Login procedure;
            UserNodeCore.UserNodeCore core = new UserNodeCore.UserNodeCore(new Communication.UserNode("username"));
            Form searchForm = new SearchTripForm(core);
            searchForm.Show();
        }

    }
}