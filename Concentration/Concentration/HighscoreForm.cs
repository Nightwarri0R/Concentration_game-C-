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
    /*Team 6:
     * Nicole Orr   170010591
     * Aylin Ibryamov   170017397
     */

    public partial class HighscoreForm : Form
    {
        public HighscoreForm()
        {
            InitializeComponent();
        }

        //Allows the user to return to the MenuForm
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        //Displays the top 5 scores by players on easy mode
        private void btnEasy_Click(object sender, EventArgs e)
        {
            displayScores("easy");
        }

        //Displays the top 5 scores by players on hard mode
        private void btnHard_Click(object sender, EventArgs e)
        {
            displayScores("hard");
        }

        //Displays the top 5 scores per mode by sorting the lists of scores and populating the label controls contained in the tLPScores
        private void displayScores(string mode)
        {
            //stores the top 5 players' usernames and scores
            Label[,] lScoreboard = { { lName1, lScore1 }, { lName2, lScore2 }, { lName3, lScore3 }, { lName4, lScore4 }, { lName5, lScore5 } };
            List<Player> allPlayers = Player.ReadFromFile();
            List<Player> scorePlayers = new List<Player>();

            for(int i = 0; i < allPlayers.Count; i++)
            {
                if(allPlayers[i].Username != null && allPlayers[i].ScoresEasy != null && allPlayers[i].ScoresHard != null)
                {
                    scorePlayers.Add(allPlayers[i]);
                }
            }

            if (mode == "easy")
            {
                //sorts list from highest score to lowest
                List<Player> sortedEasy = scorePlayers.OrderByDescending(player => player.ScoresEasy[0]).ToList();
                
                //populates the label controls
                for (int i = 0; i < 5; i++)
                {
                    lScoreboard[i, 0].Text = sortedEasy[i].Username;
                    lScoreboard[i, 1].Text = sortedEasy[i].ScoresEasy[0].ToString();
                }
            }
            else
            {
                //sorts list from highest score to lowest
                List<Player> sortedHard = scorePlayers.OrderByDescending(player => player.ScoresHard[0]).ToList();
                
                //populates the label controls
                for (int i = 0; i < 5; i++)
                {
                    lScoreboard[i, 0].Text = sortedHard[i].Username;
                    lScoreboard[i, 1].Text = sortedHard[i].ScoresHard[0].ToString();
                }
            }
        }
    }
}
