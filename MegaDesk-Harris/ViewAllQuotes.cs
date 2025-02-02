﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Harris
{
    public partial class ViewAllQuotes : Form
    {

        private Form _mainmenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainmenu = mainMenu;
        }

        private void ExitViewAllButton_Click(object sender, EventArgs e)
        {
           _mainmenu.Show();
            this.Close();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }
    }
}
