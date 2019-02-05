namespace Concentration
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lConcentration = new System.Windows.Forms.Label();
            this.btnScores = new System.Windows.Forms.Button();
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.lEnterName = new System.Windows.Forms.Label();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lConcentration
            // 
            this.lConcentration.AutoSize = true;
            this.lConcentration.Location = new System.Drawing.Point(189, 32);
            this.lConcentration.Name = "lConcentration";
            this.lConcentration.Size = new System.Drawing.Size(73, 13);
            this.lConcentration.TabIndex = 0;
            this.lConcentration.Text = "Concentration";
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(178, 74);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(75, 23);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "View Highscores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(178, 122);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(75, 23);
            this.btn1Player.TabIndex = 2;
            this.btn1Player.Text = "1 Player";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2Player
            // 
            this.btn2Player.Location = new System.Drawing.Point(178, 167);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(75, 23);
            this.btn2Player.TabIndex = 3;
            this.btn2Player.Text = "2 Player";
            this.btn2Player.UseVisualStyleBackColor = true;
            this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(178, 210);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 4;
            this.btnEasy.Text = "Easy Mode";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(178, 255);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Hard Mode";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer.Controls.Add(this.btnStartGame);
            this.panelPlayer.Controls.Add(this.txtName2);
            this.panelPlayer.Controls.Add(this.txtName1);
            this.panelPlayer.Controls.Add(this.lPlayer2);
            this.panelPlayer.Controls.Add(this.lPlayer1);
            this.panelPlayer.Controls.Add(this.lEnterName);
            this.panelPlayer.Location = new System.Drawing.Point(259, 122);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(393, 248);
            this.panelPlayer.TabIndex = 6;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(299, 208);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(117, 116);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 20);
            this.txtName2.TabIndex = 4;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(117, 66);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 20);
            this.txtName1.TabIndex = 3;
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Location = new System.Drawing.Point(35, 119);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(48, 13);
            this.lPlayer2.TabIndex = 2;
            this.lPlayer2.Text = "Player 2:";
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Location = new System.Drawing.Point(35, 64);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(48, 13);
            this.lPlayer1.TabIndex = 1;
            this.lPlayer1.Text = "Player 1:";
            // 
            // lEnterName
            // 
            this.lEnterName.AutoSize = true;
            this.lEnterName.Location = new System.Drawing.Point(35, 25);
            this.lEnterName.Name = "lEnterName";
            this.lEnterName.Size = new System.Drawing.Size(121, 13);
            this.lEnterName.TabIndex = 0;
            this.lEnterName.Text = "Please enter your name:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 453);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btn2Player);
            this.Controls.Add(this.btn1Player);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lConcentration);
            this.Name = "MenuForm";
            this.Text = "Concentration";
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConcentration;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.Label lEnterName;
    }
}

