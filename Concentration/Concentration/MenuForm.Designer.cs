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
            this.lConcentration.BackColor = System.Drawing.Color.Transparent;
            this.lConcentration.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConcentration.ForeColor = System.Drawing.Color.GreenYellow;
            this.lConcentration.Location = new System.Drawing.Point(342, 37);
            this.lConcentration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConcentration.Name = "lConcentration";
            this.lConcentration.Size = new System.Drawing.Size(249, 34);
            this.lConcentration.TabIndex = 0;
            this.lConcentration.Text = "Concentration";
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Transparent;
            this.btnScores.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.Color.Black;
            this.btnScores.Location = new System.Drawing.Point(237, 91);
            this.btnScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(100, 28);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "View Highscores";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btn1Player
            // 
            this.btn1Player.BackColor = System.Drawing.Color.Transparent;
            this.btn1Player.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Player.Location = new System.Drawing.Point(237, 150);
            this.btn1Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(100, 28);
            this.btn1Player.TabIndex = 2;
            this.btn1Player.Text = "1 Player";
            this.btn1Player.UseVisualStyleBackColor = false;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2Player
            // 
            this.btn2Player.BackColor = System.Drawing.Color.Transparent;
            this.btn2Player.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player.Location = new System.Drawing.Point(237, 206);
            this.btn2Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(100, 28);
            this.btn2Player.TabIndex = 3;
            this.btn2Player.Text = "2 Player";
            this.btn2Player.UseVisualStyleBackColor = false;
            this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(237, 258);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(100, 28);
            this.btnEasy.TabIndex = 4;
            this.btnEasy.Text = "Easy Mode";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(237, 314);
            this.btnHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(100, 28);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Hard Mode";
            this.btnHard.UseVisualStyleBackColor = false;
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
            this.panelPlayer.Location = new System.Drawing.Point(345, 150);
            this.panelPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(524, 305);
            this.panelPlayer.TabIndex = 6;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(399, 256);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(100, 28);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(156, 143);
            this.txtName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(132, 22);
            this.txtName2.TabIndex = 4;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(156, 81);
            this.txtName1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(132, 22);
            this.txtName1.TabIndex = 3;
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer2.ForeColor = System.Drawing.Color.YellowGreen;
            this.lPlayer2.Location = new System.Drawing.Point(47, 146);
            this.lPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(79, 14);
            this.lPlayer2.TabIndex = 2;
            this.lPlayer2.Text = "Player 2:";
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer1.ForeColor = System.Drawing.Color.YellowGreen;
            this.lPlayer1.Location = new System.Drawing.Point(47, 79);
            this.lPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(79, 14);
            this.lPlayer1.TabIndex = 1;
            this.lPlayer1.Text = "Player 1:";
            // 
            // lEnterName
            // 
            this.lEnterName.AutoSize = true;
            this.lEnterName.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnterName.ForeColor = System.Drawing.Color.YellowGreen;
            this.lEnterName.Location = new System.Drawing.Point(47, 31);
            this.lEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEnterName.Name = "lEnterName";
            this.lEnterName.Size = new System.Drawing.Size(238, 17);
            this.lEnterName.TabIndex = 0;
            this.lEnterName.Text = "Please enter your name:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 569);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btn2Player);
            this.Controls.Add(this.btn1Player);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lConcentration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

