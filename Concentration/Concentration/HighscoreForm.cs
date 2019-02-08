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
            Label[,] lScoreboard = { { lName1, lScore1 }, { lName2, lScore2 }, { lName3, lScore3 }, { lName4, lScore4 }, { lName5, lScore5 } };
            List<Player> allPlayers = Player.ReadFromFile();

            if (mode == "easy")
            {
                List<Player> sortedEasy = allPlayers.OrderByDescending(player => player.ScoresEasy[0]).ToList();
                for (int i = 0; i < 5; i++)
                {
                    lScoreboard[i, 0].Text = sortedEasy[i].Username;
                    lScoreboard[i, 1].Text = sortedEasy[i].ScoresEasy[0].ToString();
                }
            }
            else
            {
                List<Player> sortedHard = allPlayers.OrderByDescending(player => player.ScoresHard[0]).ToList();
                for (int i = 0; i < 5; i++)
                {
                    lScoreboard[i, 0].Text = sortedHard[i].Username;
                    lScoreboard[i, 1].Text = sortedHard[i].ScoresHard[0].ToString();
                }
            }
        }
    }
}
