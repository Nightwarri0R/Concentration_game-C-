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

    public partial class MenuForm : Form
    {
        private int numOfPlayers;   //stores the number of players, i.e. if 1 or 2 player mode is selected
        private string mode;    //stores the mode selected, i.e. "easy" or "hard" mode

        public MenuForm()
        {
            InitializeComponent();
            //Hides the controls until they are needed
            panelPlayer.Hide();
            btnEasy.Hide();
            btnHard.Hide();
        }

        //Allows the user to view the HighscoreForm
        private void btnScores_Click(object sender, EventArgs e)
        {
            this.Hide();    //Hides the MenuForm as it is the MainForm for the application
            HighscoreForm highscoreForm = new HighscoreForm();
            highscoreForm.Show();
        }

        //Sets the number of players to 1
        private void btn1Player_Click(object sender, EventArgs e)
        {
            numOfPlayers = 1;
            btnEasy.Show();
            btnHard.Show();
            lPlayer2.Hide();
            txtName2.Hide();
        }

        //Sets the number of players to 2
        private void btn2Player_Click(object sender, EventArgs e)
        {
            numOfPlayers = 2;
            btnEasy.Show();
            btnHard.Show();
            lPlayer2.Show();
            txtName2.Show();
        }

        //Sets the mode to easy
        private void btnEasy_Click(object sender, EventArgs e)
        {
            mode = "easy";
            panelPlayer.Show();
            btnEasy.Hide();
            btnHard.Hide();
        }

        //Sets the mode to hard
        private void btnHard_Click(object sender, EventArgs e)
        {
            mode = "hard";
            panelPlayer.Show();
            btnEasy.Hide();
            btnHard.Hide();
        }

        //Allows the user to start the game by calling the relevant GameForm constructor and opening the GameForm
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(validUsernames())
            {
                this.Hide();
                if (numOfPlayers == 1)
                {
                    GameForm gameForm = new GameForm(numOfPlayers, mode, txtName1.Text);
                    gameForm.Show();
                }
                else
                {
                    GameForm gameForm = new GameForm(numOfPlayers, mode, txtName1.Text, txtName2.Text);
                    gameForm.Show();
                }
            }   
        }

        //Allows the user to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Checks if valid usernames have been entered into the textbox controls by returning true if they are valid
        private bool validUsernames()
        {
            bool valid = true;
            if(txtName1.Text == "") //if the textbox is empty
            {
                valid = false;
            }
            if(numOfPlayers == 2)
            {
                if(txtName2.Text == "") //if the textbox is empty
                {
                    valid = false;
                }
                if(txtName1.Text == txtName2.Text)  //if the same username has been entered in both textboxes
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
