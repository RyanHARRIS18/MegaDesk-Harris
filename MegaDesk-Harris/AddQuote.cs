using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MegaDesk_Harris
{
    public partial class AddQuote : Form
    {
        private Form _mainmenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainmenu = mainMenu;

        //populate drop down menu materials combobox
        List<DesktopMaterial> materials =
                Enum.GetValues(typeof(DesktopMaterial))
                                .Cast<DesktopMaterial>()
                                .ToList();

            MaterialTypeMenu.DataSource = materials;

            MaterialTypeMenu.SelectedIndex = -1;

            //populate drop down Rush Order combobox
            List<RushOrderSpecs> rushDays =
                Enum.GetValues(typeof(RushOrderSpecs))
                                .Cast<RushOrderSpecs>()
                                .ToList();

            RushOrderMenu.DataSource = rushDays;

            RushOrderMenu.SelectedIndex = -1;


            DateTime currentDate = DateTime.Today;
            string thisDate = String.Format("{0: dd MMMM yyyy}", currentDate);
            myDate.Text = thisDate;
            /*lalal */

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var addNewDisplayQuote = new DisplayQuote(_mainmenu);
            addNewDisplayQuote.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)this.Tag).Show();
            this.Close();
        }

        private void exitButton_MouseClick(object sender, MouseEventArgs e)
        {
            ((Form)this.Tag).Show();
            this.Close();

        }

        private void AddQuoteFormClose(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PriceOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RushOrderMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialTypeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfDrawersLabel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void myDate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void width_txt_label_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_MouseClick(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      

        /* public void getDateNow()
         {

         } */


    }
}
