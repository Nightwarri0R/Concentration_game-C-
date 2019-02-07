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
    public partial class MenuForm : Form
    {
        private int numOfPlayers;
        private string mode;

        public MenuForm()
        {
            InitializeComponent();
            panelPlayer.Hide();
            btnEasy.Hide();
            btnHard.Hide();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            this.Hide();
            HighscoreForm highscoreForm = new HighscoreForm();
            highscoreForm.Show();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            numOfPlayers = 1;
            btnEasy.Show();
            btnHard.Show();
            lPlayer2.Hide();
            txtName2.Hide();
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            numOfPlayers = 2;
            btnEasy.Show();
            btnHard.Show();
            lPlayer2.Show();
            txtName2.Show();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            mode = "easy";
            panelPlayer.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            mode = "hard";
            panelPlayer.Show();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //?
            //validate usernames & then call appropiate GameForm constructor
            this.Hide();
            GameForm gameForm = new GameForm(numOfPlayers, mode, "test");   //need to test else use static?
            gameForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
