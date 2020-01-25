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
    public partial class SearchQuotes : Form
    {
        private Form _mainmenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainmenu = mainMenu;
        }


        private void ExitSearchPageButton_Click_1(object sender, EventArgs e)
        {
            _mainmenu.Show();
            this.Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }
    }
}
