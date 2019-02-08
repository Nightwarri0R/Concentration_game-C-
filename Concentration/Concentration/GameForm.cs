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
    public partial class GameForm : Form
    {

        private List<Button> btnCards; //either 18 or 36
        //private ImageList allImages; //either 10 or 19
        private List<ImageList> cardImages; //either 9 or 18
        private int timeLeft;
        private int turn;
        private Player player1;
        private Player player2;
        private List<Button> clicked;
        private int pairsFound;

        public GameForm(int numOfPlayers, string mode, string username1)
        {
            InitializeComponent();
            btnCards = new List<Button>();
            //allImages = new ImageList();
            cardImages = new List<ImageList>();
            clicked = new List<Button>();
            timeLeft = 100;
            turn = 1;
            pairsFound = 0;
            addImages(mode);
            makeGame(numOfPlayers, mode);
            setPlayer(username1);
        }

        //need to update later so same as above
        public GameForm(int numOfPlayers, string mode, string username1, string username2)
        {
            InitializeComponent();
            btnCards = new List<Button>();
            allImages = new ImageList();
            cardImages = new List<ImageList>();
            clicked = new List<Button>();
            timeLeft = 100;
            turn = 1;
            pairsFound = 0;
            addImages(mode);
            makeGame(numOfPlayers, mode);
            setPlayer(username1, username2);
        }

        //need to change logic of when etc
        void btnEvent_Click(object sender, EventArgs e)
        {
            clicked.Add((Button)sender);
            clicked[clicked.Count() - 1].ImageIndex = 1;

            if (clicked.Count() == 2)
            {
                //check if a pair
                if(clicked[0].ImageKey == clicked[1].ImageKey) //need to test
                {
                    //increase score
                    if(turn == 1)
                    {
                        player1.Score += 10;
                    }
                    else
                    {
                        player2.Score += 10;
                    }
                    MessageBox.Show("A pair was found!", "Pair Found");
                    pairsFound += 1;
                    if(pairsFound == cardImages.Count)
                    {
                        endOfGame();
                    }

                }
                else
                {
                    //change turn, might need to mbox or otherwise indicate?
                    if (turn == 1)
                    {
                        turn = 2;
                    }
                    else
                    {
                        turn = 1;
                    }
                    //hide images again
                    clicked[0].ImageIndex = 0;
                    clicked[1].ImageIndex = 0;
                }
                clicked.Clear();
            }
            
        }

        private void setPlayer(string username)
        {
            List<Player> allPlayers = Player.ReadFromFile();
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
            if(!found)
            {
                player1 = new Player(username);
                //Player.AppendNewPlayer(player1);
            }
        }

        private void setPlayer(string username1, string username2)
        {
            List<Player> allPlayers = Player.ReadFromFile();
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
                if (found1 && found2)
                    break;
            }
            if (!found1)
            {
                player1 = new Player(username1);
                //Player.AppendNewPlayer(player1);
            }
            if (!found2)
            {
                player2 = new Player(username2);
                //Player.AppendNewPlayer(player2);
            }
        }

        private void addImages(string mode)
        {
            if (mode == "hard")
            {
               for (int i = 0; i < 18; i++)
                {
                    cardImages.Add(new ImageList());
                    cardImages[i].Images.Add(allImages.Images[0]);
                    cardImages[i].Images.Add(allImages.Images[i+1]);
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    cardImages.Add(new ImageList());
                    cardImages[i].Images.Add(allImages.Images[0]);
                    cardImages[i].Images.Add(allImages.Images[i+1]);
                }
            }

            
        }

        private void addImagesToBtns()
        {
            Random random = new Random();
            List<int> indexsUsed = new List<int>();
            int num1, num2;
            foreach (ImageList i in cardImages)
            {
                do
                {
                    num1 = random.Next(1, btnCards.Count);
                    num2 = random.Next(1, btnCards.Count);
                }
                while (num1 == num2 || indexsUsed.Contains(num1) || indexsUsed.Contains(num2)); //need to test won't infinite

                btnCards[num1].ImageList = i;
                btnCards[num2].ImageList = i;
                indexsUsed.Add(num1);
                indexsUsed.Add(num2);
            }
        }

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
                if(player2.Username != "CPU")
                {
                    player2.ScoresEasy.Add(player2.Score);
                    player2.Score = 0;
                }
            }
            else    //i.e. if playing in hard mode
            {
                player1.ScoresHard.Add(player1.Score);
                player1.Score = 0;
                if (player2.Username != "CPU")
                {
                    player2.ScoresHard.Add(player2.Score);
                    player2.Score = 0;
                }
            }
            if(!Player.UpdatePlayer(player1))   //if not found then add
            {
                Player.AppendNewPlayer(player1);
            }
            if(!Player.UpdatePlayer(player2))
            {
                Player.AppendNewPlayer(player2);
            }

            this.Close();
            HighscoreForm highscoreForm = new HighscoreForm();
            highscoreForm.Show();
        }

        private void stripItemExit_Click(object sender, EventArgs e)
        {
            //add a mbox to ask if sure then
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void stripItemRules_Click(object sender, EventArgs e)
        {
            //need to change
            MessageBox.Show("Rules");
        }

        private void stripItemPause_Click(object sender, EventArgs e)
        {
            timerTurn.Stop();
            MessageBox.Show("Game Paused");
        }

        private void stripItemResume_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resuming Game");
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
