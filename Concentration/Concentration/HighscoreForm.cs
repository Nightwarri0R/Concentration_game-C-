using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentration
{
    public partial class HighscoreForm : Form
    {
        public HighscoreForm()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            displayScores("easy");
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            displayScores("hard");
        }

        private void displayScores(string mode)
        {

        }
    }
}
