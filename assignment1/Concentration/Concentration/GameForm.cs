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
            MenuForm menuform = new MenuForm();
            Form.ActiveForm.Close();
            menuform.Show();
        }

        private void stripItemRules_Click(object sender, EventArgs e)
        {

        }

        private void stripItemPause_Click(object sender, EventArgs e)
        {
            //
            timerTurn.Stop();
        }

        /*progressBar1.Value = 100;
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
                MessageBox.Show("You have ran out of time on this question.", "Out of time!");
                checkAnswer();
                this.Close();
                Program.nextQuestion();
            }
            else
            {
                progressBar1.Value -= 10;
            }
        }*/


    }
}
