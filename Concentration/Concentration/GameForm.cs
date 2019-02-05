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

        private List<Button> btnCards = new List<Button>();
        private int timeLeft = 100;
        Player player1;
        Player player2;

        public GameForm()
        {
            InitializeComponent();
        }

        private void makeGame(int players, string mode)
        {
            if(mode == "easy")
            {

            }
            else
            {

            }
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
