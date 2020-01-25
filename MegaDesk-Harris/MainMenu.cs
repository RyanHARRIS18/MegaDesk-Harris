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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        /*New Quote Button*/
        private void AddNewQuote_MouseClick(object sender, MouseEventArgs e)
        {
            var addNewSearchFrom = new AddQuote();
            addNewSearchFrom.Tag = this;
            addNewSearchFrom.Show();
            Hide();
        }


        /*Exit Button*/
        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /*Seach Button*/
        private void SearchQuotesButton_MouseClick(object sender, MouseEventArgs e)
        {
            var addNewSearchFrom = new SearchQuotes();
            addNewSearchFrom.Tag = this;
            addNewSearchFrom.Show();
            Hide();
        }

        private void ViewQuotesButton_MouseClick(object sender, MouseEventArgs e)
        {
            var addNewSearchFrom = new ViewAllQuotes(this);
            addNewSearchFrom.Tag = this;
            addNewSearchFrom.Show();
            Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
