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

    public partial class GameForm : Form
    {

        private List<Button> btnCards; //stores the Buttons to be used in the grid, either 18 or 36 total
        private List<ImageList> cardImages; //stores the ImageLists to be used by the Buttons, either 9 or 18 total
        private int timeLeft;   //stores an int representing the amount of time left in a player's turn
        private int turn;   //stores an int representing the player whose turn it is, i.e. 1 or 2
        private Player player1; //stores the player 1 object
        private Player player2; //stores the player 2 object
        private List<Button> clicked;   //stores the Buttons that have been clicked during a player's turn
        private int pairsFound; //stores the number of pairs that have been found

        //GameForm constructor for 1 player mode
        public GameForm(int numOfPlayers, string mode, string username1)
        {
            InitializeComponent();
            //initializes the global variables for GameForm
            btnCards = new List<Button>();
            cardImages = new List<ImageList>();
            clicked = new List<Button>();
            timeLeft = 30;
            turn = 1;
            pairsFound = 0;

            //sets up the game's grid and players
            addImages(mode);
            makeGame(numOfPlayers, mode);
            setPlayer(username1);
        }

        //GameForm constructor for 2 player mode
        public GameForm(int numOfPlayers, string mode, string username1, string username2)
        {
            InitializeComponent();
            //initializes the global variables for GameForm
            btnCards = new List<Button>();
            cardImages = new List<ImageList>();
            clicked = new List<Button>();
            timeLeft = 30;
            turn = 1;
            pairsFound = 0;

            //sets up the game's grid and players
            addImages(mode);
            makeGame(numOfPlayers, mode);
            setPlayer(username1, username2);
        }

        //Common event handler for the grid of Buttons
        void btnEvent_Click(object sender, EventArgs e)
        {
            clicked.Add((Button)sender);    //adds the Button that was just clicked to the list
            clicked[clicked.Count() - 1].ImageIndex = 1;    //shows the hidden image of the Button that was just clicked

            if (clicked.Count() == 2)   //if a player has selected 2 Buttons
            {
                if(clicked[0].ImageKey == clicked[1].ImageKey)  //checks if its a pair by comparing the image keys
                {
                    //increases and updates the player's score
                    if(turn == 1)
                    {
                        player1.Score += 10;
                        lScore1.Text = player1.Score.ToString();
                    }
                    else
                    {
                        player2.Score += 10;
                        lScore2.Text = player2.Score.ToString();
                    }
                    MessageBox.Show("A pair was found!", "Pair Found");
                    pairsFound += 1;
                    if(pairsFound == cardImages.Count)  //if all pairs have been found
                    {
                        endOfGame();
                    }
                    else
                    {
                        if(turn == 2 && player2.Username == "CPU")
                        {
                            cpuTurn();
                        }
                    }

                }
                else    //if it isn't a pair
                {
                    //change player turn
                    if (turn == 1)
                    {
                        turn = 2;
                        MessageBox.Show(player2.Username + "'s turn", "Next Turn");
                        if (player2.Username == "CPU")
                        {
                            cpuTurn();
                        }
                    }
                    else
                    {
                        turn = 1;
                        MessageBox.Show(player1.Username + "'s turn", "Next Turn");
                    }
                    //hides the second images again
                    clicked[0].ImageIndex = 0;
                    clicked[1].ImageIndex = 0;
                }
                clicked.Clear();    //empties the list so it can be reused for the next turn
            }
            
        }

        //Simulates a second player to play against in 1 player mode
        private void cpuTurn()
        {
            //generates 2 unique random numbers to be used as indexes
            Random random = new Random();
            int index1 = random.Next(0, btnCards.Count);
            int index2;
            do
            {
                index2 = random.Next(0, btnCards.Count);
            }
            while (index1 == index2);
            
            //selects 2 random Buttons from the grid using the generated indexes
            btnCards[index1].ImageIndex = 1;
            btnCards[index2].ImageIndex = 1;
            if(btnCards[index1].ImageKey == btnCards[index2].ImageKey)  //checks if its a pair by comparing the image keys
            {
                //increases and updates the player's score
                player2.Score += 10;
                lScore2.Text = player2.Score.ToString();
                MessageBox.Show("A pair was found!", "Pair Found");
                pairsFound += 1;
                if (pairsFound == cardImages.Count) //if all pairs have been found
                {
                    endOfGame();
                }
                else
                {
                    cpuTurn();
                }
            }
            else    //if it isn't a pair
            {
                //hides the second images again
                btnCards[index1].ImageIndex = 0;
                btnCards[index2].ImageIndex = 0;

                //change player turn
                turn = 1;
                MessageBox.Show(player1.Username + "'s turn", "Next Turn");
            }
        }

        //Sets up the players for a 1 player game
        private void setPlayer(string username)
        {
            //Sets up the second player
            player2 = new Player("CPU");
            lUsername2.Text = "CPU";

            //Sets up player 1
            lUsername1.Text = username;
            List <Player> allPlayers = Player.ReadFromFile();
            bool found = false;
            foreach(Player player in allPlayers)
            {
                if(player.Username == username)
                {
                    found = true;
                    player1 = player;
                    break;
                }
            }
            if(!found)  //if the player doesn't already exist
            {
                player1 = new Player(username); //creates a new player object
                //Player.AppendNewPlayer(player1);
            }
        }

        //Sets up the players for a 2 player game
        private void setPlayer(string username1, string username2)
        {
            lUsername1.Text = username1;
            lUsername2.Text = username2;
            List <Player> allPlayers = Player.ReadFromFile();
            bool found1 = false;
            bool found2 = false;
            foreach (Player player in allPlayers)
            {
                if (player.Username == username1)
                {
                    found1 = true;
                    player1 = player;
                }
                else if(player.Username == username2)
                {
                    found2 = true;
                    player2 = player;
                }
                if (found1 && found2)   //if both players have been found break out of the loop
                    break;
            }
            if (!found1)    //if player 1 doesn't already exist
            {
                player1 = new Player(username1);    //creates a new player object
                //Player.AppendNewPlayer(player1);
            }
            if (!found2)    //if player 2 doesn't already exist
            {
                player2 = new Player(username2);    //creates a new player object
                //Player.AppendNewPlayer(player2);
            }
        }

        //Adds the relevant ImageLists into the list cardImages
        private void addImages(string mode)
        {
            cardImages.Add(iL1);
            cardImages.Add(iL2);
            cardImages.Add(iL3);
            cardImages.Add(iL4);
            cardImages.Add(iL5);
            cardImages.Add(iL6);
            cardImages.Add(iL7);
            cardImages.Add(iL8);
            cardImages.Add(iL9);

            if (mode == "hard")
            {
                //adds the remaining ImageLists
                cardImages.Add(iL10);
                cardImages.Add(iL11);
                cardImages.Add(iL12);
                cardImages.Add(iL13);
                cardImages.Add(iL14);
                cardImages.Add(iL15);
                cardImages.Add(iL16);
                cardImages.Add(iL17);
                cardImages.Add(iL18);
            } 
        }

        //Randomly assigns each ImageList in cardImages to 2 Buttons
        private void addImagesToBtns()  //wont work =(
        {
            /*Random random = new Random();
            List<int> indexsUsed = new List<int>();
            int num1, num2;
            foreach (ImageList i in cardImages)
            {
                do
                {
                    num1 = random.Next(1, btnCards.Count);
                    num2 = random.Next(1, btnCards.Count);
                }
                while (num1 == num2 || indexsUsed.Contains(num1) || indexsUsed.Contains(num2));

                btnCards[num1].ImageList = i;
                btnCards[num2].ImageList = i;
                indexsUsed.Add(num1);
                indexsUsed.Add(num2);
            }*/


        }

        //Sets up and populates the grid of Buttons for the game
        private void makeGame(int players, string mode)
        {
            if(mode == "easy")
            {
                for(int i = 0; i < 18; i++)
                {
                    btnCards.Add(new Button());
                    //btnCards[i]
                    //set size etc?
                    btnCards[i].Click += new EventHandler(this.btnEvent_Click);
                    fLPCards.Controls.Add(btnCards[i]);
                }
                
            }
            else
            {
                for (int i = 0; i < 36; i++)
                {
                    btnCards.Add(new Button());
                    //btnCards[i]
                    //set size etc?
                    btnCards[i].Click += new EventHandler(this.btnEvent_Click);
                    fLPCards.Controls.Add(btnCards[i]);
                }
            }
            addImagesToBtns();
        }

        //Manages the end of the game by updating players' scores and saving them to file
        private void endOfGame()
        {
            if(player1.Score == player2.Score)
            {
                MessageBox.Show("It's a draw!","All Pairs Found");
            }
            else if (player1.Score > player2.Score)
            {
                MessageBox.Show(player1.Username + " wins!", "All Pairs Found");
            }
            else
            {
                MessageBox.Show(player2.Username + " wins!", "All Pairs Found");
            }

            //Update the players' scores
            if(cardImages.Count() == 9) //i.e. if playing in easy mode
            {
                player1.ScoresEasy.Add(player1.Score);
                player1.Score = 0;
                if(player2.Username != "CPU")   //skips player 2 if in 1 player mode
                {
                    player2.ScoresEasy.Add(player2.Score);
                    player2.Score = 0;
                }
            }
            else    //i.e. if playing in hard mode
            {
                player1.ScoresHard.Add(player1.Score);
                player1.Score = 0;
                if (player2.Username != "CPU")  //skips player 2 if in 1 player mode
                {
                    player2.ScoresHard.Add(player2.Score);
                    player2.Score = 0;
                }
            }
            
            //saves the players' scores to file
            if(!Player.UpdatePlayer(player1))   //if player not found then append to file
            {
                Player.AppendNewPlayer(player1);
            }
            if(player2.Username != "CPU")   //skips player 2 if in 1 player mode
            {
                if (!Player.UpdatePlayer(player2))  //if player not found then append to file
                {
                    Player.AppendNewPlayer(player2);
                }
            }
            
            //Closes the GameForm and opens the HighscoreForm to show the top scores
            this.Close();
            HighscoreForm highscoreForm = new HighscoreForm();
            highscoreForm.Show();
        }

        //Allows the user to return to the MenuForm
        private void stripItemExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returning to game menu...", "Exiting Game");
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        //Displays a message explaining how to play Concentration
        private void stripItemRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to Play Concentration: \n The aim of the game is to find as many pairs of matching" +
                " cards as possible. In easy mode there are 18 cards, i.e. 9 pairs to find, while in hard mode there" +
                " are 36 cards, i.e. 18 pairs to find. \n Players take turns to select 2 cards which will be turned over" +
                " to reveal a hidden image. If the revealed images match the player will gain points and will get another" +
                " turn immediately. If the cards aren't a pair, the images will be hidden again and the turn will pass to the" +
                " next player. \n The game ends when all pairs have been found.", "Game Rules");
        }

        //Allows the player to pause their turn by stopping the timer
        private void stripItemPause_Click(object sender, EventArgs e)
        {
            timerTurn.Stop();
            MessageBox.Show("Game Paused", "Pause");
        }

        //Allows the player to resume their turn after pausing by starting the timer
        private void stripItemResume_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resuming Game...", "Resume");
            timerTurn.Start();
        }

        private void timerTurn_Tick(object sender, EventArgs e)
        {
            //check if below point then change colour
            //check if 0 then change turn
            //need some way to track turns etc
        }

        /*progressBar1.Value = timeLeft;
          timer1.Interval = 1000;
          timer1.Start();
          timer1.Tick += timer1_Tick;*/

        /*private void timer1_Tick(object sender, EventArgs e)
        {
           if (progressBar1.Value <= 40)
            {
                progressBar1.ForeColor = Color.Crimson;
            }
            if (progressBar1.Value <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You have ran out of time.", "Out of time!");
                
            }
            else
            {
                progressBar1.Value -= 2;
            }
        }*/


    }
}
