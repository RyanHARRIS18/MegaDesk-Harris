using System;
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
   
    public partial class DisplayQuote : Form
    {
        private Form _mainmenu;

        public DisplayQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainmenu = mainMenu;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _mainmenu.Show();
            this.Close();

        }
    }
}
