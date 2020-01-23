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
            var addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Show();
            /* ((Control)sender).Hide(); */
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
            addNewSearchFrom.Show();
           /* ((Control)sender).Hide(); */
        }

        private void ViewQuotesButton_MouseClick(object sender, MouseEventArgs e)
        {
            var addNewViewAllForm = new ViewAllQuotes();
            addNewViewAllForm.Show();
           /* ((Control)sender).Hide(); */
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

    }
}
