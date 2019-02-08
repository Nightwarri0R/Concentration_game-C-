using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Concentration
{
    /*Team 6:
    * Nicole Orr   170010591
    * Aylin Ibryamov   170017397
    */

    [Serializable]
    public class Player
    {

        private string username;
        private int score;  //stores the player's current score
        private List<int> scoresEasy;   //stores the player's previous scores on easy mode
        private List<int> scoresHard;   //stores the player's previous scores on hard mode

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public List<int> ScoresEasy
        {
            get { return scoresEasy; }
            set { scoresEasy = value; }
        }
        public List<int> ScoresHard
        {
            get { return scoresHard; }
            set { scoresHard = value; }
        }

        //Player constructor
        public Player(string username)
        {
            this.username = username;
            score = 0;
            scoresEasy = new List<int>();
            scoresHard = new List<int>();
        }

        //Appends new players to the end of the PlayerDetails file
        //Method is public static to enable use within the forms
        public static void AppendNewPlayer(Player player)
        {
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sw = File.Open("PlayerDetails.bin", FileMode.Append);
                bf.Serialize(sw, player);
                sw.Close();
                sw.Dispose();
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("" + e.Message);
            }
        }

        //Reads in all players stored in the PlayerDetails file, stores them in a list of Players and returns the list
        //Method is public static to enable use within the forms
        public static List<Player> ReadFromFile()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            List<Player> players = new List<Player>();
            try
            {
                sr = File.OpenRead("PlayerDetails.bin");
                try
                {
                    while (sr.Position < sr.Length)
                    {
                        players.Add((Player)bf.Deserialize(sr));
                    }
                }
                catch (SerializationException e)
                {
                    System.Windows.Forms.MessageBox.Show("" + e.Message);
                }
                sr.Close();
                sr.Dispose();
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("" + e.Message);
            }
            return players;
        }

        //Updates the scores of existing Players stored in the PlayerDetails file
        //Method is public static to enable use within the forms
        public static bool UpdatePlayer(Player player)
        {
            long pos = -1;
            bool found = false;
            Player readPlayer;
            int comparison;
            Stream sr;
            try
            {
                sr = File.Open("PlayerDetails.bin", FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    while (sr.Position < sr.Length && found == false)
                    {
                        pos = sr.Position;
                        readPlayer = (Player)bf.Deserialize(sr);
                        if (readPlayer.Username == null) //removes null player objects
                        {
                            comparison = 1;
                        }
                        else
                        {
                            comparison = readPlayer.Username.CompareTo(player.Username);
                        }

                        if (comparison == 0)
                        {
                            found = true;
                            //updates player's scores
                            readPlayer.ScoresEasy = player.ScoresEasy;
                            readPlayer.ScoresHard = player.ScoresHard;
                            sr.Seek(pos, SeekOrigin.Begin);
                            bf.Serialize(sr, readPlayer);
                        }
                    }
                    sr.Close();
                    sr.Dispose();
                }
                catch (SerializationException e)
                {
                    System.Windows.Forms.MessageBox.Show("" + e.Message);
                }
                sr.Close();
                sr.Dispose();
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("" + e.Message);
            }
            return found;
        }
    }
}
