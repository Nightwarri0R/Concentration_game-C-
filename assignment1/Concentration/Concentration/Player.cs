﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //dont know if needed
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Concentration
{
    [Serializable]
    public class Player
    {

        private string username;
        private string password;
        private List<int> scoresEasy;
        private List<int> scoresHard;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
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

        public Player(string username, string password)
        {
            this.username = username;
            this.password = password;
            scoresEasy = new List<int> { 0, 0 };
            scoresHard = new List<int> { 0, 0 };
        }

        //need to test/change code below
        //need to change for two score lists etc
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

        public static List<Player> ReadFromFile()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            List<Player> users = new List<Player>();
            try
            {
                sr = File.OpenRead("PlayerDetails.bin");
                try
                {
                    while (sr.Position < sr.Length)
                    {
                        users.Add((Player)bf.Deserialize(sr));
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
            return users;
        }

        public static bool UpdateUser(Player player)
        {
            long pos = -1;
            bool found = false;
            Player readPlayer;
            int comparison;
            Stream sr;
            try
            {
                sr = File.Open("UserDetails.bin", FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    while (sr.Position < sr.Length && found == false)
                    {
                        pos = sr.Position;
                        readPlayer = (Player)bf.Deserialize(sr);
                        if (readPlayer.Username == null) // catches nulls so an exception wont be thrown//
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
                            // updates scores below//
                            readPlayer.Scores = player.Scores;
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
